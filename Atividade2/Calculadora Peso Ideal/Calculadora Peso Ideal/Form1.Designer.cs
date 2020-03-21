namespace Calculadora_Peso_Ideal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBoxDados = new System.Windows.Forms.GroupBox();
            this.textBoxAltura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.textBoxPesoAtual = new System.Windows.Forms.TextBox();
            this.lblPesoAtual = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.radioBtnFem = new System.Windows.Forms.RadioButton();
            this.radioBtnMale = new System.Windows.Forms.RadioButton();
            this.pictureBoxSexo = new System.Windows.Forms.PictureBox();
            this.maskedTextBoxPesoIdeal = new System.Windows.Forms.MaskedTextBox();
            this.lblPesoIdeal = new System.Windows.Forms.Label();
            this.groupBoxRecomendacao = new System.Windows.Forms.GroupBox();
            this.textBoxRecomendacao = new System.Windows.Forms.TextBox();
            this.groupBoxDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSexo)).BeginInit();
            this.groupBoxRecomendacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxDados
            // 
            this.groupBoxDados.Controls.Add(this.textBoxAltura);
            this.groupBoxDados.Controls.Add(this.btnCalcular);
            this.groupBoxDados.Controls.Add(this.textBoxPesoAtual);
            this.groupBoxDados.Controls.Add(this.lblPesoAtual);
            this.groupBoxDados.Controls.Add(this.lblAltura);
            this.groupBoxDados.Controls.Add(this.radioBtnFem);
            this.groupBoxDados.Controls.Add(this.radioBtnMale);
            this.groupBoxDados.Controls.Add(this.pictureBoxSexo);
            this.groupBoxDados.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDados.Name = "groupBoxDados";
            this.groupBoxDados.Size = new System.Drawing.Size(345, 269);
            this.groupBoxDados.TabIndex = 0;
            this.groupBoxDados.TabStop = false;
            this.groupBoxDados.Text = "Dados:";
            // 
            // textBoxAltura
            // 
            this.textBoxAltura.Location = new System.Drawing.Point(63, 189);
            this.textBoxAltura.Name = "textBoxAltura";
            this.textBoxAltura.Size = new System.Drawing.Size(100, 20);
            this.textBoxAltura.TabIndex = 1;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(183, 183);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(145, 66);
            this.btnCalcular.TabIndex = 3;
            this.btnCalcular.Text = "CALCULAR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // textBoxPesoAtual
            // 
            this.textBoxPesoAtual.Location = new System.Drawing.Point(84, 221);
            this.textBoxPesoAtual.Name = "textBoxPesoAtual";
            this.textBoxPesoAtual.Size = new System.Drawing.Size(79, 20);
            this.textBoxPesoAtual.TabIndex = 2;
            // 
            // lblPesoAtual
            // 
            this.lblPesoAtual.AutoSize = true;
            this.lblPesoAtual.Location = new System.Drawing.Point(17, 224);
            this.lblPesoAtual.Name = "lblPesoAtual";
            this.lblPesoAtual.Size = new System.Drawing.Size(61, 13);
            this.lblPesoAtual.TabIndex = 5;
            this.lblPesoAtual.Text = "Peso Atual:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(17, 192);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 4;
            this.lblAltura.Text = "Altura:";
            // 
            // radioBtnFem
            // 
            this.radioBtnFem.AutoSize = true;
            this.radioBtnFem.Location = new System.Drawing.Point(211, 160);
            this.radioBtnFem.Name = "radioBtnFem";
            this.radioBtnFem.Size = new System.Drawing.Size(67, 17);
            this.radioBtnFem.TabIndex = 12;
            this.radioBtnFem.TabStop = true;
            this.radioBtnFem.Text = "Feminino";
            this.radioBtnFem.UseVisualStyleBackColor = true;
            // 
            // radioBtnMale
            // 
            this.radioBtnMale.AutoSize = true;
            this.radioBtnMale.Checked = true;
            this.radioBtnMale.Location = new System.Drawing.Point(68, 160);
            this.radioBtnMale.Name = "radioBtnMale";
            this.radioBtnMale.Size = new System.Drawing.Size(73, 17);
            this.radioBtnMale.TabIndex = 12;
            this.radioBtnMale.TabStop = true;
            this.radioBtnMale.Text = "Masculino";
            this.radioBtnMale.UseVisualStyleBackColor = true;
            // 
            // pictureBoxSexo
            // 
            this.pictureBoxSexo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxSexo.Image")));
            this.pictureBoxSexo.Location = new System.Drawing.Point(20, 19);
            this.pictureBoxSexo.Name = "pictureBoxSexo";
            this.pictureBoxSexo.Size = new System.Drawing.Size(308, 135);
            this.pictureBoxSexo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSexo.TabIndex = 1;
            this.pictureBoxSexo.TabStop = false;
            // 
            // maskedTextBoxPesoIdeal
            // 
            this.maskedTextBoxPesoIdeal.Location = new System.Drawing.Point(182, 291);
            this.maskedTextBoxPesoIdeal.Mask = "99.99 Kg";
            this.maskedTextBoxPesoIdeal.Name = "maskedTextBoxPesoIdeal";
            this.maskedTextBoxPesoIdeal.ReadOnly = true;
            this.maskedTextBoxPesoIdeal.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBoxPesoIdeal.Size = new System.Drawing.Size(60, 20);
            this.maskedTextBoxPesoIdeal.TabIndex = 6;
            // 
            // lblPesoIdeal
            // 
            this.lblPesoIdeal.AutoSize = true;
            this.lblPesoIdeal.Location = new System.Drawing.Point(115, 294);
            this.lblPesoIdeal.Name = "lblPesoIdeal";
            this.lblPesoIdeal.Size = new System.Drawing.Size(60, 13);
            this.lblPesoIdeal.TabIndex = 7;
            this.lblPesoIdeal.Text = "Peso Ideal:";
            // 
            // groupBoxRecomendacao
            // 
            this.groupBoxRecomendacao.Controls.Add(this.textBoxRecomendacao);
            this.groupBoxRecomendacao.Location = new System.Drawing.Point(12, 319);
            this.groupBoxRecomendacao.Name = "groupBoxRecomendacao";
            this.groupBoxRecomendacao.Size = new System.Drawing.Size(345, 100);
            this.groupBoxRecomendacao.TabIndex = 8;
            this.groupBoxRecomendacao.TabStop = false;
            this.groupBoxRecomendacao.Text = "Recomendação";
            // 
            // textBoxRecomendacao
            // 
            this.textBoxRecomendacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.textBoxRecomendacao.Location = new System.Drawing.Point(20, 19);
            this.textBoxRecomendacao.Multiline = true;
            this.textBoxRecomendacao.Name = "textBoxRecomendacao";
            this.textBoxRecomendacao.ReadOnly = true;
            this.textBoxRecomendacao.Size = new System.Drawing.Size(308, 75);
            this.textBoxRecomendacao.TabIndex = 9;
            this.textBoxRecomendacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 429);
            this.Controls.Add(this.groupBoxRecomendacao);
            this.Controls.Add(this.lblPesoIdeal);
            this.Controls.Add(this.maskedTextBoxPesoIdeal);
            this.Controls.Add(this.groupBoxDados);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.groupBoxDados.ResumeLayout(false);
            this.groupBoxDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSexo)).EndInit();
            this.groupBoxRecomendacao.ResumeLayout(false);
            this.groupBoxRecomendacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxDados;
        private System.Windows.Forms.PictureBox pictureBoxSexo;
        private System.Windows.Forms.RadioButton radioBtnMale;
        private System.Windows.Forms.RadioButton radioBtnFem;
        private System.Windows.Forms.Label lblPesoAtual;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox textBoxPesoAtual;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPesoIdeal;
        private System.Windows.Forms.Label lblPesoIdeal;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.TextBox textBoxAltura;
        private System.Windows.Forms.GroupBox groupBoxRecomendacao;
        private System.Windows.Forms.TextBox textBoxRecomendacao;
    }
}

