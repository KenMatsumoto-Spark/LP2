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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnEx1_Click(object sender, EventArgs e)
        {
            FrmEx1 frm = new FrmEx1();
            frm.Show();
        }

        private void btnEx2_Click(object sender, EventArgs e)
        {
            FrmEx2 frm = new FrmEx2();
            frm.Show();
        }

        private void btnEx3_Click(object sender, EventArgs e)
        {
            FrmEx3 frm = new FrmEx3();
            frm.Show();
        }

        private void btnEx4_Click(object sender, EventArgs e)
        {
            FrmEx4 frm = new FrmEx4();
            frm.Show();
        }
    }
}
