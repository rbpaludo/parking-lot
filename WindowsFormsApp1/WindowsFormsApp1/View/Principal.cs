using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Dapper;
using Estacionamento.Controller;
using Estacionamento.Model;
using Estacionamento.View;

namespace Estacionamento
{
    public partial class Principal : Form
    {
        RegistroController registroController;
        List<Registro> registros;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, System.EventArgs e)
        {
            registroController = new RegistroController();
            registros = registroController.BuscarRegistros();
            dataGridRegistros.DataSource = registroController.BuscarRegistros();
            labelHoraInicial.Text = "R$ " + registroController.Preco.HoraInicial;
            labelHoraAdicional.Text = "R$ " + registroController.Preco.HoraAdicional;
        }

        private void botaoEntrada_Click(object sender, System.EventArgs e)
        {
            try
            {
                registroController.RegistrarEntrada(new Registro(textBoxPlacaEntrada.Text, DateTime.Now));
                textBoxPlacaEntrada.Text = "";
                dataGridRegistros.DataSource = registroController.BuscarRegistros();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void botaoSaida_Click(object sender, System.EventArgs e)
        {
            try
            {
                Registro registroSaida = registroController.BuscarRegistroPlaca(textBoxPlacaSaida.Text);
                registroSaida.HoraSaida = DateTime.Now;
                registroController.RegistrarSaida(registroSaida);
                textBoxPlacaSaida.Text = "";
                dataGridRegistros.DataSource = registroController.BuscarRegistros();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void dataGridRegistros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxPlacaSaida.Text = registros.ToArray()[e.RowIndex].Placa;
        }

        private void textBoxPesquisaPlaca_TextChanged(object sender, EventArgs e)
        {
            registros = registroController.BuscarListaRegistrosPlaca(textBoxPesquisaPlaca.Text);
            dataGridRegistros.DataSource = registros;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NovaTabelaPrecos novaTabelaPrecos = new NovaTabelaPrecos();
            novaTabelaPrecos.Show();
            this.SendToBack();
        }
    }
}
