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
    public partial class FrmExercicio2 : Form
    {
        public FrmExercicio2()
        {
            InitializeComponent();
        }

        private void btnCompara_Click(object sender, EventArgs e)
        {
            if (String.Compare(textPalavra1.Text, textPalavra2.Text, true) == 0)
            {
                MessageBox.Show("Os textos são iguais!");
            }
            else
            {
                MessageBox.Show("Os textos são diferentes");
            }
        }

        private void btnInserir1_Click(object sender, EventArgs e)
        {
            int meio = textPalavra2.Text.Length / 2;
            textPalavra2.Text = textPalavra2.Text.Substring(0, meio) +
                                textPalavra1.Text + 
                                textPalavra2.Text.Substring(meio, textPalavra2.Text.Length - meio);
        }

        private void btnInserir2_Click(object sender, EventArgs e)
        {
            int meio = textPalavra1.Text.Length / 2;
            textPalavra1.Text = textPalavra1.Text.Insert(meio, "**");
        }
    }
}
