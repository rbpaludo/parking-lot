using Estacionamento.Model;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System;
using Dapper;

namespace Estacionamento.Controller
{
    public class RegistroController
    {
        private Preco preco;

        public Preco Preco { get => preco; set => preco = value; }

        /// <summary>
        /// Construtor. Inicializa a tabela de preços que será usada para o cálculo dos preços do dia atual 
        /// de acordo com a tabela de preços em vigência.
        /// </summary>
        public RegistroController()
        {
            var dataAtual = DateTime.Now;

            using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
            {
                var output = cnn.Query<Preco>("select * from preco", new DynamicParameters());
                if (output.Count() == 0)
                {
                    throw new Exception("Não existe nenhuma tabela de preços vigente atualmente.");
                }

                foreach (Preco precoLocal in output)
                {
                    /* Se a data atual é posterior ao início e anterior ao fim da vigência da tabela de 
                     * preços sendo analisada...*/
                    if (DateTime.Compare(dataAtual, precoLocal.InicioVigencia) >= 0 &&
                        DateTime.Compare(dataAtual, precoLocal.FimVigencia) <= 0)
                    {
                        Preco = precoLocal;
                    }
                }

            }
        }

        /// <summary>
        /// Recupera todos os registros de entradas de carros contidas no banco de dados.
        /// </summary>
        /// <returns>Lista de registros contidos no banco de dados.</returns>
        public List<Registro> BuscarRegistros()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
            {
                var output = cnn.Query<Registro>("select * from registro", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Salva um registro de entrada de um carro, preenchendo apenas a placa do carro e o horário de 
        /// entrada, já que é impossível que o horário de entrada e saída sejam iguais.
        /// </summary>
        /// <param name="registro">Registro de entrada a ser inserido no banco de dados.</param>
        public void RegistrarEntrada(Registro registro)
        {
            if (registro.HoraEntrada != null &&
                registro.Placa.Length != 0)
            {
                using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
                {
                    registro.PrimeiraHora = Preco.HoraInicial;
                    registro.HoraAdicional = Preco.HoraAdicional;
                    cnn.Execute("insert into registro (placa, horaEntrada, primeiraHora, horaAdicional) " +
                        "values (@placa, @horaEntrada, @primeiraHora, @horaAdicional)", registro);
                }
            }
            else
            {
                throw new System.Exception("Um dos dados inseridos é inválido ou não foi informado.");
            }
        }

        /// <summary>
        /// Registra a saída de um carro, completando o seu registro com o horário de saída e o preço total da estadia.
        /// </summary>
        /// <param name="registro">Registro de saída e entrada do carro</param>
        public void RegistrarSaida(Registro registro)
        {
            if (registro.HoraEntrada != null &&
                registro.HoraSaida != null &&
                registro.Placa.Length != 0)
            {
                registro.ValorTotal = CalculaPrecoTotal(registro);
                using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
                {
                    cnn.Execute("update registro set horaSaida=@horaSaida, valorTotal=@valorTotal where placa=@placa", registro);
                }
            }
            else
            {
                throw new System.Exception("Um dos dados inseridos é inválido ou não foi informado.");
            }
        }

        /// <summary>
        /// Recupera o registro com a placa informada e sem hora de saída registrada.
        /// </summary>
        /// <param name="placa">Placa do veículo saindo.</param>
        /// <returns>Registro no banco de dados do veículo encontrado.</returns>
        public Registro BuscarRegistroPlaca(string placa)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
            {
                Registro registroPlaca = new Registro(placa, DateTime.Now);

                var output = cnn.Query<Registro>("select * from registro where placa=@placa", registroPlaca);
                return output.ToList().ElementAt(output.ToList().Count - 1);
            }
        }

        /// <summary>
        /// Recupera a lista de registros cujos veículos contém na placa o padrão informado.
        /// </summary>
        /// <param name="placa">Placa ou parte de placa a ser pesquisada.</param>
        /// <returns>Lista de registros encontrados.</returns>
        public List<Registro> BuscarListaRegistrosPlaca(string placa)
        {
            using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
            {
                Registro registroPlaca = new Registro(placa, DateTime.Now);
                registroPlaca.Placa = "%" + registroPlaca.Placa + "%";
                var output = cnn.Query<Registro>("select * from registro where placa like @placa", registroPlaca);
                return output.ToList();
            }
        }

        /// <summary>
        /// Calcula o preço total da estadia de um carro.
        /// </summary>
        /// <param name="registro">Registro de saída e entrada do veículo</param>
        /// <returns>O preço total calculado.</returns>
        public double CalculaPrecoTotal(Registro registro)
        {
            TimeSpan diffEntradaSaida = registro.HoraSaida - registro.HoraEntrada;
            if (diffEntradaSaida.Hours < 1 && diffEntradaSaida.Minutes <= 30)
            {
                registro.ValorTotal = registro.PrimeiraHora / 2;
            }
            else if (diffEntradaSaida.Hours < 2 && diffEntradaSaida.Minutes <= 10)
            {
                registro.ValorTotal = registro.PrimeiraHora;
            }
            else
            {
                registro.ValorTotal = registro.PrimeiraHora + (registro.HoraAdicional * (diffEntradaSaida.Hours - 1));
                if (diffEntradaSaida.Minutes > 10)
                {
                    registro.ValorTotal += registro.HoraAdicional;
                }
            }
            return registro.ValorTotal;
        }
    }
}
