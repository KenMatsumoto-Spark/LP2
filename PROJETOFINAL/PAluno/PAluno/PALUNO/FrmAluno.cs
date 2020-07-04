using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PALUNO
{
    public partial class FrmAluno : Form
    {
        private BindingSource bnAluno = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsAluno = new DataSet();
        private DataSet dsCidade = new DataSet();

        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmAluno_Load(object sender, EventArgs e)
        {
            try
            {
                Aluno Alu = new Aluno();
                dsAluno.Tables.Add(Alu.Listar());
                bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                dgvAluno.DataSource = bnAluno;
                bnvAluno.BindingSource = bnAluno;

                txtRA.DataBindings.Add("TEXT", bnAluno, "RA_ALUNO");
                txtNome.DataBindings.Add("TEXT", bnAluno, "NOME_ALUNO");

                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                cbAlunoCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                cbAlunoCidade.DisplayMember = "NOME_CIDADE";
                cbAlunoCidade.ValueMember = "ID_CIDADE";
                cbAlunoCidade.DataBindings.Add("SelectedValue",bnAluno,"CIDADE_ID_CIDADE");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tbAluno.SelectedIndex == 0)
            {
                tbAluno.SelectTab(1);
            }

            bnAluno.AddNew();
            txtNome.Enabled = true;
            cbAlunoCidade.Enabled = true;
            cbAlunoCidade.SelectedIndex = 0;
            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtRA.Text=="")
            {
                MessageBox.Show("Dados inválidos!");
            }
            else
            {
                Aluno RegAluno = new Aluno();
                RegAluno.RaAluno = Convert.ToInt32(txtRA.Text);
                RegAluno.NomeAluno = txtNome.Text;
                RegAluno.CidadeIdcidade = Convert.ToInt16(cbAlunoCidade.SelectedValue);
                if (bInclusao)
                {
                    if (RegAluno.Salvar() > 0)
                    {
                        MessageBox.Show("Aluno adicionado com sucesso!");

                        btnSalvar.Enabled = false;
                        txtRA.Enabled = false;
                        txtNome.Enabled = false;
                        cbAlunoCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAluno.Listar());
                        bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar aluno!");
                    }
                }
                else
                {
                    if (RegAluno.Alterar() > 0)
                    {
                        MessageBox.Show("Aluno alterada com sucesso!");
                        dsAluno.Tables.Clear();
                        dsAluno.Tables.Add(RegAluno.Listar());
                        btnSalvar.Enabled = false;
                        txtRA.Enabled = false;
                        txtNome.Enabled = false;
                        cbAlunoCidade.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;
                    }
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (tbAluno.SelectedIndex == 0)
            {
                tbAluno.SelectTab(1);
            }

            txtNome.Enabled = true;
            cbAlunoCidade.Enabled = true;
            txtNome.Focus();
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tbAluno.SelectedIndex == 0)
            {
                tbAluno.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yes or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Aluno RegAluno = new Aluno();
                RegAluno.RaAluno = Convert.ToInt32(txtRA.Text);
                RegAluno.NomeAluno = txtNome.Text;
                RegAluno.CidadeIdcidade = Convert.ToInt16(cbAlunoCidade.SelectedValue);
                if (RegAluno.Excluir() > 0)
                {
                    MessageBox.Show("Aluno excluído com sucesso!");
                    Aluno R = new Aluno();
                    dsAluno.Tables.Clear();
                    dsAluno.Tables.Add(R.Listar());
                    bnAluno.DataSource = dsAluno.Tables["TBALUNO"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir aluno!");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnAluno.CancelEdit();
            btnSalvar.Enabled = false;
            txtNome.Enabled = false;
            cbAlunoCidade.Enabled = false;
            btnEditar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtRA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar)&& e.KeyChar!=(char)8)
            {
                e.Handled = true;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
