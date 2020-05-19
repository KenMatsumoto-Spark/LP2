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
    public partial class FrmExercicio5 : Form
    {
        public FrmExercicio5()
        {
            InitializeComponent();
        }

        private void btnRand_Click(object sender, EventArgs e)
        {
            Random objRandom = new Random();
            int numero = objRandom.Next(Convert.ToInt32(textNum1.Text),
                                        Convert.ToInt32(textNum2.Text));

            MessageBox.Show("O numero sorteado é " + numero);
        }
    }
}
