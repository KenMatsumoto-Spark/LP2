using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Atividade6
{
    public partial class FrmEx4 : Form
    {
        public FrmEx4()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            double verify1;

            if ((txtBoxSalario.Text == string.Empty) || (!double.TryParse(txtBoxSalario.Text, out verify1)))
            {
                MessageBox.Show("Valor Invalido no Salario!");
                txtBoxSalario.Clear();
            }
            else if ((txtBoxProd.Text == string.Empty) || (!double.TryParse(txtBoxProd.Text, out verify1)))
            {
                MessageBox.Show("Valor Invalido na produção!");
                txtBoxProd.Clear();
            }
            else if ((txtBoxGrat.Text == string.Empty) || (!double.TryParse(txtBoxGrat.Text, out verify1)))
            {
                MessageBox.Show("Valor Invalido na gratificação!");
                txtBoxGrat.Clear();
            }
            else
            {
                double Sal, Prod, Grat, SalBruto;

                Sal = double.Parse(txtBoxSalario.Text);
                Prod = double.Parse(txtBoxProd.Text);
                Grat = double.Parse(txtBoxGrat.Text);

                int bonusA = 0, bonusB = 0, bonusC = 0;
                if (Prod >= 100) bonusA = 1;
                if (Prod >= 120) bonusB = 1;
                if (Prod >= 150) bonusC = 1;

                SalBruto = Sal + Sal * (0.05 * bonusA + 0.1 * bonusB + 0.1 * bonusC) + Grat;

                if(SalBruto >= 7000)
                {
                    if(Prod >= 150 && Grat > 0)
                    {
                        txtBoxSalarioBruto.Text = SalBruto.ToString("N2");
                    }
                    else
                    {
                        txtBoxSalarioBruto.Text = ("7.000,00");
                    }
                }
                else
                {
                    txtBoxSalarioBruto.Text = SalBruto.ToString("N2");
                }

            }
        }
    }
}
