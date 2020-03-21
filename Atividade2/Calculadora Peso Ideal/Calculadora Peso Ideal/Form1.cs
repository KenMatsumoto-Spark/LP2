using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Peso_Ideal
{
    public partial class Form1 : Form
    {
        bool verificacaoOk = true;
        private void verificacao(TextBox actual)
        {
            double verify1;

            if ((actual.Text == string.Empty) || (!double.TryParse(actual.Text, out verify1)))
            {
                MessageBox.Show("Valor Invalido ou campo vazio!");
                actual.Clear();
                verificacaoOk = false;
            }

        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double pAtual, alt, pIdeal;
            verificacaoOk = true;
            verificacao(textBoxPesoAtual);
            verificacao(textBoxAltura);
            double.TryParse(textBoxPesoAtual.Text, out pAtual);
            double.TryParse(textBoxAltura.Text, out alt);
            pIdeal = 0;

            if (verificacaoOk == true)
            {
                if (radioBtnMale.Checked)
                {
                    pIdeal = ((72.2 * alt) - 58);
                    maskedTextBoxPesoIdeal.Text = pIdeal.ToString("N2");
                }
                if (radioBtnFem.Checked)
                {
                    pIdeal = ((62.1 * alt) - 44.7);
                    maskedTextBoxPesoIdeal.Text = pIdeal.ToString("N2");
                }

                if (Math.Abs(pAtual - pIdeal) < 1)
                {
                    textBoxRecomendacao.Text = "Você está com o peso ideal";
                }

                else if (pAtual > pIdeal)
                {
                    textBoxRecomendacao.Text = "Regime Obrigatório Já";
                }

                else if (pAtual < pIdeal)
                {
                    textBoxRecomendacao.Text = "Coma bastante massas e doces";
                }
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
    }
}
