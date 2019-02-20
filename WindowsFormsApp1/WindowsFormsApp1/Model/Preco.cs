using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Model
{
    public class Preco
    {
        private long id;
        private DateTime inicioVigencia;
        private DateTime fimVigencia;
        private double horaInicial;
        private double horaAdicional;

        /// <summary>
        /// Construtor. Foi julgado desnecessário codificar um teste para este construtor porque ele possui 
        /// apenas um uso explícito, na classe NovaTabelaPrecos.cs, onde ele é usado apenas para evitar erro 
        /// de compilação (e precisa do TryParse para atribuir um valor padrão às datas sem lançar exceções), 
        /// sendo usado apenas se entrar no bloco de comandos no qual ele é apropriadamente usado para 
        /// recuperação de dados do banco. No momento descrito os dados recebidos sempre serão válidos, 
        /// porque são gerados automaticamente.
        /// </summary>
        public Preco(Int64 id, Double horaInicial, Double horaAdicional, String inicioVigencia, String fimVigencia)
        {
            if (id >= 0)
            {
                this.Id = id;
            }
            DateTime.TryParse(inicioVigencia, out this.inicioVigencia);
            DateTime.TryParse(fimVigencia, out this.fimVigencia);
            this.horaInicial = horaInicial;
            this.horaAdicional = horaAdicional;
        }

        public DateTime InicioVigencia { get => inicioVigencia; set => inicioVigencia = value; }
        public DateTime FimVigencia { get => fimVigencia; set => fimVigencia = value; }
        public double HoraInicial { get => horaInicial; set => horaInicial = value; }
        public double HoraAdicional { get => horaAdicional; set => horaAdicional = value; }
        public long Id { get => id; set => id = value; }
    }
}
