using Estacionamento.Controller;
using Estacionamento.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estacionamento.View
{
    public partial class NovaTabelaPrecos : Form
    {
        PrecoController precoController;
        DateTime dataInicioVigencia;
        DateTime dataFimVigencia;
        double primeiraHora;
        double horaAdicional;

        public NovaTabelaPrecos()
        {
            InitializeComponent();
            precoController = new PrecoController();
        }

        private void calendarFimVigencia_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataInicioVigencia = e.Start;
        }

        private void calendarIniVigencia_DateSelected(object sender, DateRangeEventArgs e)
        {
            dataFimVigencia = e.Start;
        }

        private void buttonSalvarPrecos_Click(object sender, EventArgs e)
        {
            try
            {
                // se ambas as datas forem posteriores ao dia atual, prossiga...
                if (DateTime.Compare(DateTime.Now, dataInicioVigencia) < 0 || 
                    DateTime.Compare(DateTime.Now, dataFimVigencia) < 0)
                {
                    var vigenciaSobrepoeFinal = false;
                    var vigenciaSobrepoeInicio = false;
                    int diaSobreposto = 0, mesSobreposto = 0, anoSobreposto = 0;
                    Preco precoSobreposto = new Preco(-1, 0, 0, "", "");
                    List<Preco> precos = precoController.BuscarPrecos();

                    foreach (Preco precoLocal in precos)
                    {
                        if (DateTime.Compare(dataInicioVigencia, precoLocal.InicioVigencia) > 0 &&
                            DateTime.Compare(dataInicioVigencia, precoLocal.FimVigencia) < 0)
                        {
                            // vigência selecionada inicia antes de uma anterior terminar
                            precoSobreposto = precoLocal;
                            diaSobreposto = precoLocal.FimVigencia.Day;
                            mesSobreposto = precoLocal.FimVigencia.Month;
                            anoSobreposto = precoLocal.FimVigencia.Year;
                            vigenciaSobrepoeFinal = true;
                            break;
                        }
                        else if (DateTime.Compare(dataFimVigencia, precoLocal.InicioVigencia) > 0 &&
                            DateTime.Compare(dataFimVigencia, precoLocal.FimVigencia) < 0)
                        {
                            // vigência selecionada termina depois de uma posterior começar
                            precoSobreposto = precoLocal;
                            diaSobreposto = precoLocal.InicioVigencia.Day;
                            mesSobreposto = precoLocal.InicioVigencia.Month;
                            anoSobreposto = precoLocal.InicioVigencia.Year;
                            vigenciaSobrepoeInicio = true;
                            break;
                        }
                    }

                    if (vigenciaSobrepoeFinal)
                    {
                        DialogResult dialogResult = MessageBox.Show("O período de vigência selecionado " +
                            "começa antes da vigência de uma tabela anterior terminar. Deseja alterar o " +
                            "final da vigência anterior? Senão, clique em \"Não\" e altere o início da " +
                            "vigência selecionada para algum dia depois de " +
                            "" + diaSobreposto + "/" + mesSobreposto + "/" + anoSobreposto + ".", 
                            "Sobreposição de Vigências", 
                            MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            precoSobreposto.FimVigencia = dataInicioVigencia.AddDays(1);
                            precoController.AtualizarVigenciaPreco(precoSobreposto);

                            Double.TryParse(textBoxPrimeiraHora.Text, out primeiraHora);
                            Double.TryParse(textBoxHoraAdicional.Text, out horaAdicional);
                            precoController.RegistrarTabelaPrecos(new Preco(-1,
                                primeiraHora,
                                horaAdicional,
                                dataInicioVigencia.ToString(),
                                dataFimVigencia.ToString()));
                            MessageBox.Show("Tabela de preços registrada com sucesso!");
                            Close();
                        }
                    }
                    else if (vigenciaSobrepoeInicio)
                    {
                        DialogResult dialogResult = MessageBox.Show("O período de vigência selecionado " +
                            "termina depois da vigência de uma tabela posterior começar. Deseja alterar o " +
                            "início da vigência anterior? Senão, clique em \"Não\" e altere o fim da " +
                            "vigência selecionada para algum dia antes de " +
                            "" + diaSobreposto + "/" + mesSobreposto + "/" + anoSobreposto + ".",
                            "Sobreposição de Vigências",
                            MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            precoSobreposto.InicioVigencia = dataFimVigencia.AddDays(1);
                            precoController.AtualizarVigenciaPreco(precoSobreposto);

                            Double.TryParse(textBoxPrimeiraHora.Text, out primeiraHora);
                            Double.TryParse(textBoxHoraAdicional.Text, out horaAdicional);
                            precoController.RegistrarTabelaPrecos(new Preco(-1,
                                primeiraHora,
                                horaAdicional,
                                dataInicioVigencia.ToString(),
                                dataFimVigencia.ToString()));
                            MessageBox.Show("Tabela de preços registrada com sucesso!");
                            Close();
                        }
                    }
                    else
                    {
                        Double.TryParse(textBoxPrimeiraHora.Text, out primeiraHora);
                        Double.TryParse(textBoxHoraAdicional.Text, out horaAdicional);
                        precoController.RegistrarTabelaPrecos(new Preco(-1,
                            primeiraHora,
                            horaAdicional,
                            dataInicioVigencia.ToString(),
                            dataFimVigencia.ToString()));
                        MessageBox.Show("Tabela de preços registrada com sucesso!");
                        Close();
                    }
                }
                else
                {
                    MessageBox.Show("Uma das datas selecionadas ou ambas são anteriores ao dia de hoje, " +
                        "favor selecionar o dia de hoje ou um dia posterior.");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
