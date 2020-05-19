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
    public partial class FrmExercicio3 : Form
    {
        public FrmExercicio3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textPalavra2_Click(object sender, EventArgs e)
        {

        }

        private void FrmExercicio3_Load(object sender, EventArgs e)
        {

        }

        private void btnRemove1_Click(object sender, EventArgs e)
        {
            int posicao = 0;

            textPalavra1.Text = textPalavra1.Text.ToUpper();
            textPalavra2.Text = textPalavra2.Text.ToUpper();

            posicao = textPalavra2.Text.IndexOf(textPalavra1.Text);

            while(posicao >= 0)
            {
                textPalavra2.Text = textPalavra2.Text.Substring(0, posicao) +
                                    textPalavra2.Text.Substring(posicao + textPalavra1.Text.Length, textPalavra2.Text.Length - posicao - textPalavra1.Text.Length);

                posicao = textPalavra2.Text.IndexOf(textPalavra1.Text);
            }
        }

        private void btnRemove2_Click(object sender, EventArgs e)
        {
            textPalavra2.Text = textPalavra2.Text.Replace(textPalavra1.Text, "");
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string s = textPalavra1.Text;
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = "";
            foreach (char c in arr)
                s = s + c.ToString();
            MessageBox.Show(s);
        }
    }
}
