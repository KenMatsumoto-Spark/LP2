using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus_e_Metodos
{
    public partial class FrmExercicio4 : Form
    {
        public FrmExercicio4()
        {
            InitializeComponent();
        }

        private void btnCarNum_Click(object sender, EventArgs e)
        {
            int contador = 0;

            for( var x=0; x <= richText4.Text.Length-1; x++)
            {
                if (Char.IsNumber(richText4.Text[x]))
                    contador++;
            }
            MessageBox.Show("Caracteres numericos: " + contador);
        }

        private void btnBranco_Click(object sender, EventArgs e)
        {
            int x = 0;
            while (x < richText4.Text.Length)
            {
                if (Char.IsWhiteSpace(richText4.Text[x]))
                {
                    MessageBox.Show("Primeiro caractere branco: " + (x + 1));
                    break;
                }
                x++;
            }
        }

        private void btnCarAlpha_Click(object sender, EventArgs e)
        {
            int contador = 0;

            foreach( char c in richText4.Text)
            {
                if (Char.IsLetter(c))
                    contador++;
            }

            MessageBox.Show("Caracteres Alfabeticos: " + contador);
        }
    }
}
