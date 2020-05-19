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
    public partial class FrmEx1 : Form
    {
        public FrmEx1()
        {
            InitializeComponent();
        }

        private void richTxt_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int contador = 0;
            int x = 0;
            while (x < richTxt.Text.Length)
            {
                if (Char.IsWhiteSpace(richTxt.Text[x]))
                {
                    contador++;
                }
                x++;
            }
            MessageBox.Show("Aparecem " + contador + " espaços em branco nesta frase.");
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach (char c in richTxt.Text)
            {
                if (c == 'R' || c == 'r')
                    contador++;
            }
            MessageBox.Show("Aparecem " + contador + " 'r' ou 'R' nesta frase.");

        }

        private void btnLetIguais_Click(object sender, EventArgs e)
        {
            int i, contador = 0;

            for(i=1; i<richTxt.Text.Length; i++)
            {
                if (richTxt.Text[i-1] == richTxt.Text[i])
                    contador++;
            }
            MessageBox.Show("existem " + contador + " letras que tem como antecessor ela mesma(espaços seguidos tambem contam).");
        }

        private void richTxt_TextChanged_1(object sender, EventArgs e)
        {
            int n;

            n = richTxt.Text.Length;
            txtContador.Text = n.ToString();
        }
    }
}