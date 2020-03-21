namespace Calculo_de_rendas_e_impostos
{
    partial class Calculadora
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSalBruto = new System.Windows.Forms.Label();
            this.lblNumFilhos = new System.Windows.Forms.Label();
            this.lblInss = new System.Windows.Forms.Label();
            this.lvlIrpf = new System.Windows.Forms.Label();
            this.lblSalFamilia = new System.Windows.Forms.Label();
            this.lblSalLiq = new System.Windows.Forms.Label();
            this.lblDescInss = new System.Windows.Forms.Label();
            this.lblDescIrpf = new System.Windows.Forms.Label();
            this.txtBoxdescricao = new System.Windows.Forms.TextBox();
            this.groupBoxSexo = new System.Windows.Forms.GroupBox();
            this.radBtnFem = new System.Windows.Forms.RadioButton();
            this.radBtnMasc = new System.Windows.Forms.RadioButton();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.checkBoxCasado = new System.Windows.Forms.CheckBox();
            this.mTxtBoxSalBruto = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxNumFilhos = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxNomeFunc = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxAInss = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxAIrpf = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxSalFam = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxSalLiq = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxDescInss = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxDescIrpf = new System.Windows.Forms.MaskedTextBox();
            this.groupBoxSexo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(26, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(90, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome funcionario";
            // 
            // lblSalBruto
            // 
            this.lblSalBruto.AutoSize = true;
            this.lblSalBruto.Location = new System.Drawing.Point(26, 81);
            this.lblSalBruto.Name = "lblSalBruto";
            this.lblSalBruto.Size = new System.Drawing.Size(66, 13);
            this.lblSalBruto.TabIndex = 1;
            this.lblSalBruto.Text = "Salario bruto";
            // 
            // lblNumFilhos
            // 
            this.lblNumFilhos.AutoSize = true;
            this.lblNumFilhos.Location = new System.Drawing.Point(26, 120);
            this.lblNumFilhos.Name = "lblNumFilhos";
            this.lblNumFilhos.Size = new System.Drawing.Size(86, 13);
            this.lblNumFilhos.TabIndex = 2;
            this.lblNumFilhos.Text = "Numero de filhos";
            // 
            // lblInss
            // 
            this.lblInss.AutoSize = true;
            this.lblInss.Location = new System.Drawing.Point(26, 259);
            this.lblInss.Name = "lblInss";
            this.lblInss.Size = new System.Drawing.Size(73, 13);
            this.lblInss.TabIndex = 3;
            this.lblInss.Text = "Aliquota INSS";
            // 
            // lvlIrpf
            // 
            this.lvlIrpf.AutoSize = true;
            this.lvlIrpf.Location = new System.Drawing.Point(26, 298);
            this.lvlIrpf.Name = "lvlIrpf";
            this.lvlIrpf.Size = new System.Drawing.Size(72, 13);
            this.lvlIrpf.TabIndex = 4;
            this.lvlIrpf.Text = "Aliquota IRPF";
            // 
            // lblSalFamilia
            // 
            this.lblSalFamilia.AutoSize = true;
            this.lblSalFamilia.Location = new System.Drawing.Point(26, 337);
            this.lblSalFamilia.Name = "lblSalFamilia";
            this.lblSalFamilia.Size = new System.Drawing.Size(74, 13);
            this.lblSalFamilia.TabIndex = 5;
            this.lblSalFamilia.Text = "Salario Familia";
            // 
            // lblSalLiq
            // 
            this.lblSalLiq.AutoSize = true;
            this.lblSalLiq.Location = new System.Drawing.Point(26, 376);
            this.lblSalLiq.Name = "lblSalLiq";
            this.lblSalLiq.Size = new System.Drawing.Size(76, 13);
            this.lblSalLiq.TabIndex = 6;
            this.lblSalLiq.Text = "Salario Liquido";
            // 
            // lblDescInss
            // 
            this.lblDescInss.AutoSize = true;
            this.lblDescInss.Location = new System.Drawing.Point(235, 259);
            this.lblDescInss.Name = "lblDescInss";
            this.lblDescInss.Size = new System.Drawing.Size(81, 13);
            this.lblDescInss.TabIndex = 7;
            this.lblDescInss.Text = "Desconto INSS";
            // 
            // lblDescIrpf
            // 
            this.lblDescIrpf.AutoSize = true;
            this.lblDescIrpf.Location = new System.Drawing.Point(235, 298);
            this.lblDescIrpf.Name = "lblDescIrpf";
            this.lblDescIrpf.Size = new System.Drawing.Size(80, 13);
            this.lblDescIrpf.TabIndex = 8;
            this.lblDescIrpf.Text = "Desconto IRPF";
            // 
            // txtBoxdescricao
            // 
            this.txtBoxdescricao.Enabled = false;
            this.txtBoxdescricao.Location = new System.Drawing.Point(29, 186);
            this.txtBoxdescricao.Multiline = true;
            this.txtBoxdescricao.Name = "txtBoxdescricao";
            this.txtBoxdescricao.Size = new System.Drawing.Size(193, 64);
            this.txtBoxdescricao.TabIndex = 18;
            // 
            // groupBoxSexo
            // 
            this.groupBoxSexo.Controls.Add(this.radBtnFem);
            this.groupBoxSexo.Controls.Add(this.radBtnMasc);
            this.groupBoxSexo.Location = new System.Drawing.Point(287, 39);
            this.groupBoxSexo.Name = "groupBoxSexo";
            this.groupBoxSexo.Size = new System.Drawing.Size(135, 98);
            this.groupBoxSexo.TabIndex = 19;
            this.groupBoxSexo.TabStop = false;
            this.groupBoxSexo.Text = "Sexo";
            // 
            // radBtnFem
            // 
            this.radBtnFem.AutoSize = true;
            this.radBtnFem.Location = new System.Drawing.Point(6, 63);
            this.radBtnFem.Name = "radBtnFem";
            this.radBtnFem.Size = new System.Drawing.Size(67, 17);
            this.radBtnFem.TabIndex = 6;
            this.radBtnFem.TabStop = true;
            this.radBtnFem.Text = "Feminino";
            this.radBtnFem.UseVisualStyleBackColor = true;
            // 
            // radBtnMasc
            // 
            this.radBtnMasc.AutoSize = true;
            this.radBtnMasc.Checked = true;
            this.radBtnMasc.Location = new System.Drawing.Point(6, 30);
            this.radBtnMasc.Name = "radBtnMasc";
            this.radBtnMasc.Size = new System.Drawing.Size(73, 17);
            this.radBtnMasc.TabIndex = 5;
            this.radBtnMasc.TabStop = true;
            this.radBtnMasc.Text = "Masculino";
            this.radBtnMasc.UseVisualStyleBackColor = true;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(105, 143);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(117, 37);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "Verificar Desconto";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // checkBoxCasado
            // 
            this.checkBoxCasado.AutoSize = true;
            this.checkBoxCasado.Location = new System.Drawing.Point(287, 163);
            this.checkBoxCasado.Name = "checkBoxCasado";
            this.checkBoxCasado.Size = new System.Drawing.Size(74, 17);
            this.checkBoxCasado.TabIndex = 7;
            this.checkBoxCasado.Text = "Casado(a)";
            this.checkBoxCasado.UseVisualStyleBackColor = true;
            // 
            // mTxtBoxSalBruto
            // 
            this.mTxtBoxSalBruto.Location = new System.Drawing.Point(122, 78);
            this.mTxtBoxSalBruto.Mask = "99999.99";
            this.mTxtBoxSalBruto.Name = "mTxtBoxSalBruto";
            this.mTxtBoxSalBruto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mTxtBoxSalBruto.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxSalBruto.TabIndex = 2;
            // 
            // mTxtBoxNumFilhos
            // 
            this.mTxtBoxNumFilhos.Location = new System.Drawing.Point(122, 117);
            this.mTxtBoxNumFilhos.Mask = "99";
            this.mTxtBoxNumFilhos.Name = "mTxtBoxNumFilhos";
            this.mTxtBoxNumFilhos.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxNumFilhos.TabIndex = 3;
            // 
            // mTxtBoxNomeFunc
            // 
            this.mTxtBoxNomeFunc.Location = new System.Drawing.Point(122, 39);
            this.mTxtBoxNomeFunc.Mask = "??????????????????????????????????????????????????????????";
            this.mTxtBoxNomeFunc.Name = "mTxtBoxNomeFunc";
            this.mTxtBoxNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxNomeFunc.TabIndex = 1;
            // 
            // mTxtBoxAInss
            // 
            this.mTxtBoxAInss.Enabled = false;
            this.mTxtBoxAInss.Location = new System.Drawing.Point(105, 256);
            this.mTxtBoxAInss.Name = "mTxtBoxAInss";
            this.mTxtBoxAInss.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxAInss.TabIndex = 25;
            // 
            // mTxtBoxAIrpf
            // 
            this.mTxtBoxAIrpf.Enabled = false;
            this.mTxtBoxAIrpf.Location = new System.Drawing.Point(104, 295);
            this.mTxtBoxAIrpf.Name = "mTxtBoxAIrpf";
            this.mTxtBoxAIrpf.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxAIrpf.TabIndex = 26;
            // 
            // mTxtBoxSalFam
            // 
            this.mTxtBoxSalFam.Enabled = false;
            this.mTxtBoxSalFam.Location = new System.Drawing.Point(104, 334);
            this.mTxtBoxSalFam.Name = "mTxtBoxSalFam";
            this.mTxtBoxSalFam.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxSalFam.TabIndex = 27;
            // 
            // mTxtBoxSalLiq
            // 
            this.mTxtBoxSalLiq.Enabled = false;
            this.mTxtBoxSalLiq.Location = new System.Drawing.Point(104, 373);
            this.mTxtBoxSalLiq.Name = "mTxtBoxSalLiq";
            this.mTxtBoxSalLiq.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxSalLiq.TabIndex = 28;
            // 
            // mTxtBoxDescInss
            // 
            this.mTxtBoxDescInss.Enabled = false;
            this.mTxtBoxDescInss.Location = new System.Drawing.Point(322, 256);
            this.mTxtBoxDescInss.Name = "mTxtBoxDescInss";
            this.mTxtBoxDescInss.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxDescInss.TabIndex = 29;
            // 
            // mTxtBoxDescIrpf
            // 
            this.mTxtBoxDescIrpf.Enabled = false;
            this.mTxtBoxDescIrpf.Location = new System.Drawing.Point(322, 295);
            this.mTxtBoxDescIrpf.Name = "mTxtBoxDescIrpf";
            this.mTxtBoxDescIrpf.Size = new System.Drawing.Size(100, 20);
            this.mTxtBoxDescIrpf.TabIndex = 30;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 424);
            this.Controls.Add(this.mTxtBoxDescIrpf);
            this.Controls.Add(this.mTxtBoxDescInss);
            this.Controls.Add(this.mTxtBoxSalLiq);
            this.Controls.Add(this.mTxtBoxSalFam);
            this.Controls.Add(this.mTxtBoxAIrpf);
            this.Controls.Add(this.mTxtBoxAInss);
            this.Controls.Add(this.mTxtBoxNomeFunc);
            this.Controls.Add(this.mTxtBoxNumFilhos);
            this.Controls.Add(this.mTxtBoxSalBruto);
            this.Controls.Add(this.checkBoxCasado);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.groupBoxSexo);
            this.Controls.Add(this.txtBoxdescricao);
            this.Controls.Add(this.lblDescIrpf);
            this.Controls.Add(this.lblDescInss);
            this.Controls.Add(this.lblSalLiq);
            this.Controls.Add(this.lblSalFamilia);
            this.Controls.Add(this.lvlIrpf);
            this.Controls.Add(this.lblInss);
            this.Controls.Add(this.lblNumFilhos);
            this.Controls.Add(this.lblSalBruto);
            this.Controls.Add(this.lblNome);
            this.KeyPreview = true;
            this.Name = "Calculadora";
            this.Text = "Calculadora de Informações do salario do funcionario";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Calculadora_KeyPress);
            this.groupBoxSexo.ResumeLayout(false);
            this.groupBoxSexo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSalBruto;
        private System.Windows.Forms.Label lblNumFilhos;
        private System.Windows.Forms.Label lblInss;
        private System.Windows.Forms.Label lvlIrpf;
        private System.Windows.Forms.Label lblSalFamilia;
        private System.Windows.Forms.Label lblSalLiq;
        private System.Windows.Forms.Label lblDescInss;
        private System.Windows.Forms.Label lblDescIrpf;
        private System.Windows.Forms.TextBox txtBoxdescricao;
        private System.Windows.Forms.GroupBox groupBoxSexo;
        private System.Windows.Forms.RadioButton radBtnFem;
        private System.Windows.Forms.RadioButton radBtnMasc;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.CheckBox checkBoxCasado;
        private System.Windows.Forms.MaskedTextBox mTxtBoxSalBruto;
        private System.Windows.Forms.MaskedTextBox mTxtBoxNumFilhos;
        private System.Windows.Forms.MaskedTextBox mTxtBoxNomeFunc;
        private System.Windows.Forms.MaskedTextBox mTxtBoxAInss;
        private System.Windows.Forms.MaskedTextBox mTxtBoxAIrpf;
        private System.Windows.Forms.MaskedTextBox mTxtBoxSalFam;
        private System.Windows.Forms.MaskedTextBox mTxtBoxSalLiq;
        private System.Windows.Forms.MaskedTextBox mTxtBoxDescInss;
        private System.Windows.Forms.MaskedTextBox mTxtBoxDescIrpf;
    }
}

