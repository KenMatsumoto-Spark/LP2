﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace PAluno
{
    public partial class frmCidade : Form
    {
        private BindingSource bnCidade = new BindingSource();
        private bool bInclusao = false;
        private DataSet dsCidade = new DataSet();
        public frmCidade()
        {
            InitializeComponent();
        }

        private void FrmCidade_Load(object sender, EventArgs e)
        {

            try
            {
                Cidade Cid = new Cidade();
                dsCidade.Tables.Add(Cid.Listar());
                bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                dgvCidade.DataSource = bnCidade;
                bnvCidade.BindingSource = bnCidade;

                txtId.DataBindings.Add("TEXT", bnCidade, "ID_CIDADE");
                txtNomeCidade.DataBindings.Add("TEXT", bnCidade, "NOME_CIDADE");
                cbxEstado.DataBindings.Add("SelectedItem", bnCidade, "UF_CIDADE");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNovoRegistro_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            bnCidade.AddNew();
            txtNomeCidade.Enabled = true;
            cbxEstado.Enabled = true;
            cbxEstado.SelectedIndex = 0;
            txtNomeCidade.Focus();
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;
            bInclusao = true;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (txtNomeCidade.Text == "")
            {
                MessageBox.Show("Cidade inválida");
            }
            else
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtId.Text);
                RegCid.Nomecidade = txtNomeCidade.Text;
                RegCid.Ufcidade = cbxEstado.SelectedItem.ToString();
                if (bInclusao)
                {
                    if (RegCid.Salvar() > 0)
                    {
                        MessageBox.Show("Cidade adicionada com sucesso");

                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNomeCidade.Enabled = false;
                        cbxEstado.Enabled = false;
                        btnSalvar.Enabled = false;
                        btnEditar.Enabled = true;
                        btnNovoRegistro.Enabled = true;
                        btnExcluir.Enabled = true;
                        btnCancelar.Enabled = false;

                        bInclusao = false;

                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                    }
                    else
                    {
                        MessageBox.Show("Erro ao gravar cidade");
                    }
                }
                else
                {
                    if (RegCid.Alterar() > 0)
                    {
                        MessageBox.Show("Cidade alterada com sucesso");
                        dsCidade.Tables.Clear();
                        dsCidade.Tables.Add(RegCid.Listar());
                        btnSalvar.Enabled = false;
                        txtId.Enabled = false;
                        txtNomeCidade.Enabled = false;
                        cbxEstado.Enabled = false;
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
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }

            txtNomeCidade.Enabled = true;
            cbxEstado.Enabled = true;
            txtNomeCidade.Focus();
            btnSalvar.Enabled = true;
            btnEditar.Enabled = false;
            btnNovoRegistro.Enabled = false;
            btnExcluir.Enabled = false;
            btnCancelar.Enabled = true;

            bInclusao = false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {
                tabControl1.SelectTab(1);
            }
            if (MessageBox.Show("Confirma exclusão?", "Yeas or No", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Cidade RegCid = new Cidade();
                RegCid.Idcidade = Convert.ToInt16(txtId.Text);
                RegCid.Nomecidade = txtNomeCidade.Text;
                RegCid.Ufcidade = cbxEstado.SelectedItem.ToString();
                if (RegCid.Excluir() > 0)
                {
                    MessageBox.Show("Cidade excluída com sucesso");
                    Cidade R = new Cidade();
                    dsCidade.Tables.Clear();
                    dsCidade.Tables.Add(R.Listar());
                    bnCidade.DataSource = dsCidade.Tables["TBCIDADE"];
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cidade");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            bnCidade.CancelEdit();
            btnSalvar.Enabled = false;
            txtNomeCidade.Enabled = false;
            cbxEstado.Enabled = false;
            btnEditar.Enabled = true;
            btnNovoRegistro.Enabled = true;
            btnExcluir.Enabled = true;

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

