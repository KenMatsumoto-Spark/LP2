using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace PAluno
{
    public partial class FrmPrincipal : Form
    {
        public static SqlConnection conexao;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                conexao = new SqlConnection("Data Source=LAPTOP-CVMUQH1A\\SQLEXPRESS;Initial Catalog=LP2;Integrated Security=True");
                conexao.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("ERRO SQL" + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO GERAL" + ex.Message);
            }
                
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCidade frmCid = new frmCidade();
            frmCid.MdiParent = this;
            frmCid.WindowState = FormWindowState.Maximized;
            frmCid.Show();
        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAluno frmAlu = new frmAluno();
            frmAlu.MdiParent = this;
            frmAlu.WindowState = FormWindowState.Maximized;
            frmAlu.Show();
        }
    }
}

