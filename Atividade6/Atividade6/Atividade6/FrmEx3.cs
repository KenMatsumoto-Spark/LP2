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
    public partial class FrmEx3 : Form
    {
        public FrmEx3()
        {
            InitializeComponent();
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            txtEx3.Text = txtEx3.Text.ToUpper();

            txtEx3.Text = txtEx3.Text.Replace(" ", "");

            string s = txtEx3.Text;
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            s = "";
            foreach (char c in arr)
                s = s + c.ToString();
            txtEx3Reverse.Text = (s);

            if(String.Compare(txtEx3.Text, txtEx3Reverse.Text) == 0)
            {
                txtBoxEhPalindromo.Text = ("As palavras são Palindromos!");
            }
            else
            {
                txtBoxEhPalindromo.Text = ("As palavras não são Palindromos!");
            }
        }
    }
}
