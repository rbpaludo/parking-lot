using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estacionamento.Model
{
    public class Registro
    {

        private string placa;
        private DateTime horaEntrada;
        private DateTime horaSaida;
        private double primeiraHora;
        private double horaAdicional;
        private double valorTotal;

        public Registro(string placa, String horaEntrada, String horaSaida, double primeiraHora, double horaAdicional, double valorTotal)
        {
            this.placa = placa;
            this.horaEntrada = DateTime.Parse(horaEntrada);
            this.horaSaida = DateTime.Parse(horaSaida);
            this.PrimeiraHora = primeiraHora;
            this.HoraAdicional = horaAdicional;
            this.ValorTotal = valorTotal;
        }

        public Registro(string placa, DateTime horaEntrada)
        {
            this.Placa = placa;
            this.HoraEntrada = horaEntrada;
        }

        public string Placa { get => placa; set => placa = value; }
        public DateTime HoraEntrada { get => horaEntrada; set => horaEntrada = value; }
        public DateTime HoraSaida { get => horaSaida; set => horaSaida = value; }
        public double PrimeiraHora { get => primeiraHora; set => primeiraHora = value; }
        public double HoraAdicional { get => horaAdicional; set => horaAdicional = value; }
        public double ValorTotal { get => valorTotal; set => valorTotal = value; }
    }
}
