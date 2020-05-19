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
    public partial class FrmEx2 : Form
    {
        
        public FrmEx2()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            int verify1;

            if ((txtBoxN.Text == string.Empty) || (!int.TryParse(txtBoxN.Text, out verify1)))
            {
                MessageBox.Show("Valor Invalido!");
                txtBoxN.Clear(); 
                txtBoxH.Clear();
            }
            else
            {
                int i, n;
                n = int.Parse(txtBoxN.Text);
                double nDec = 0;
                for(i=1; i<=n; i++)
                {
                    nDec += 1 / (double)i;
                }
                txtBoxH.Text = nDec.ToString("N4");
            }
            
        }
    }
}
