using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVolume
{
    public partial class PVolume : Form
    {
        private void verificacao(TextBox actual)
        {
            double verify1;
                
            if ((actual.Text != string.Empty) && (!double.TryParse(actual.Text, out verify1)))
            {
                MessageBox.Show("Valor Invalido!");
                actual.Clear();
            }
            
        }

        private void CalculoAltura(TextBox raio, TextBox altura)
        {
            double raioNum, alturaNum;
            double.TryParse(raio.Text, out raioNum);
            double.TryParse(altura.Text, out alturaNum);
            double Volume = Math.PI * Math.Pow(raioNum, 2) * alturaNum;
            txtBoxVolume.Text = Volume.ToString("N2");
        }

        
    public PVolume()
        {
            InitializeComponent();
        }

        private void txtBoxRaio_TextChanged(object sender, EventArgs e)
        {
            verificacao(txtBoxRaio);
            CalculoAltura(txtBoxRaio, txtBoxAltura);

        }

        private void txtBoxRaio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (Char)13)
            {
                SendKeys.Send("{TAB}");
                e.Handled = true; //desabilitar o beep
            }
        }

        private void txtBoxAltura_TextChanged(object sender, EventArgs e)
        {
            verificacao(txtBoxAltura);
            CalculoAltura(txtBoxRaio, txtBoxAltura);
        }

        
    }
}
