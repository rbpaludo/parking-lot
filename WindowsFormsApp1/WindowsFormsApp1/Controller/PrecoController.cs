using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using Dapper;
using Estacionamento.Model;

namespace Estacionamento.Controller
{
    public class PrecoController
    {

        /// <summary>
        /// Recupera todas tabelas de precos contidas no banco de dados.
        /// </summary>
        /// <returns>Lista de tabelas de preços.</returns>
        public List<Preco> BuscarPrecos()
        {
            using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
            {
                var output = cnn.Query<Preco>("select * from preco", new DynamicParameters());
                return output.ToList();
            }
        }

        /// <summary>
        /// Salva uma nova tabela de preços no banco
        /// </summary>
        /// <param name="preco">Tabela a ser salva. Contém valor de primeira hora, hora adicional e 
        ///     datas de início e fim de vigência</param>
        public void RegistrarTabelaPrecos(Preco preco)
        {
            if (preco.InicioVigencia != null &&
                preco.FimVigencia != null &&
                preco.HoraInicial > 0 &&
                preco.HoraAdicional > 0)
            {
                using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
                {
                    cnn.Execute("insert into preco (horaInicial, horaAdicional, inicioVigencia, fimVigencia) " +
                        "values (@horaInicial, @horaAdicional, @inicioVigencia, @fimVigencia)", preco);
                }
            }
            else
            {
                throw new System.Exception("Um dos dados inseridos é inválido ou não foi informado.");
            }
        }

        /// <summary>
        /// Altera uma tabela de precos do banco, alterando o inicio ou o fim da vigência para evitar 
        /// sobreposição de vigências.
        /// </summary>
        /// <param name="preco">Tabela de preços a ser alterada.</param>
        public void AtualizarVigenciaPreco(Preco preco)
        {
            if (preco.FimVigencia != null &&
                preco.InicioVigencia != null &&
                preco.HoraInicial > 0 &&
                preco.HoraAdicional > 0)
            {
                using (IDbConnection cnn = new SQLiteConnection(SqlAccess.LoadConnectionString()))
                {
                    cnn.Execute("update preco set inicioVigencia=@inicioVigencia, fimVigencia=@fimVigencia " +
                        "where id=@id", preco);
                }
            }
            else
            {
                throw new System.Exception("Um dos dados inseridos é inválido ou não foi informado.");
            }
        }
    }
}
