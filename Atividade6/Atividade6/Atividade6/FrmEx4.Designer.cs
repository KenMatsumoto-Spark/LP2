namespace Atividade6
{
    partial class FrmEx4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSalario = new System.Windows.Forms.Label();
            this.txtBoxSalario = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtBoxSalarioBruto = new System.Windows.Forms.TextBox();
            this.lblSalarioBruto = new System.Windows.Forms.Label();
            this.lblGrat = new System.Windows.Forms.Label();
            this.lblProd = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtBoxGrat = new System.Windows.Forms.TextBox();
            this.txtBoxProd = new System.Windows.Forms.TextBox();
            this.txtBoxID = new System.Windows.Forms.TextBox();
            this.txtBoxCargo = new System.Windows.Forms.TextBox();
            this.txtBoxNome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblSalario.Location = new System.Drawing.Point(12, 149);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(95, 24);
            this.lblSalario.TabIndex = 29;
            this.lblSalario.Text = "SALARIO:";
            // 
            // txtBoxSalario
            // 
            this.txtBoxSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalario.Location = new System.Drawing.Point(277, 146);
            this.txtBoxSalario.Name = "txtBoxSalario";
            this.txtBoxSalario.Size = new System.Drawing.Size(295, 29);
            this.txtBoxSalario.TabIndex = 28;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(16, 284);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(201, 86);
            this.btnCalc.TabIndex = 27;
            this.btnCalc.Text = "Calcular Salario Bruto";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtBoxSalarioBruto
            // 
            this.txtBoxSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxSalarioBruto.Location = new System.Drawing.Point(277, 396);
            this.txtBoxSalarioBruto.Name = "txtBoxSalarioBruto";
            this.txtBoxSalarioBruto.Size = new System.Drawing.Size(295, 29);
            this.txtBoxSalarioBruto.TabIndex = 26;
            // 
            // lblSalarioBruto
            // 
            this.lblSalarioBruto.AutoSize = true;
            this.lblSalarioBruto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioBruto.Location = new System.Drawing.Point(12, 399);
            this.lblSalarioBruto.Name = "lblSalarioBruto";
            this.lblSalarioBruto.Size = new System.Drawing.Size(165, 24);
            this.lblSalarioBruto.TabIndex = 25;
            this.lblSalarioBruto.Text = "SALARIO BRUTO:";
            // 
            // lblGrat
            // 
            this.lblGrat.AutoSize = true;
            this.lblGrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblGrat.Location = new System.Drawing.Point(12, 236);
            this.lblGrat.Name = "lblGrat";
            this.lblGrat.Size = new System.Drawing.Size(154, 24);
            this.lblGrat.TabIndex = 24;
            this.lblGrat.Text = "GRATIFICAÇÃO:";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblProd.Location = new System.Drawing.Point(12, 192);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(122, 24);
            this.lblProd.TabIndex = 23;
            this.lblProd.Text = "PRODUÇÃO:";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblID.Location = new System.Drawing.Point(12, 106);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(236, 24);
            this.lblID.TabIndex = 22;
            this.lblID.Text = "NUMERO DE INSCRIÇÃO:";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblCargo.Location = new System.Drawing.Point(12, 65);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(83, 24);
            this.lblCargo.TabIndex = 21;
            this.lblCargo.Text = "CARGO:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lblNome.Location = new System.Drawing.Point(12, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(73, 24);
            this.lblNome.TabIndex = 20;
            this.lblNome.Text = "NOME:";
            // 
            // txtBoxGrat
            // 
            this.txtBoxGrat.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGrat.Location = new System.Drawing.Point(277, 233);
            this.txtBoxGrat.Name = "txtBoxGrat";
            this.txtBoxGrat.Size = new System.Drawing.Size(295, 29);
            this.txtBoxGrat.TabIndex = 19;
            // 
            // txtBoxProd
            // 
            this.txtBoxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxProd.Location = new System.Drawing.Point(277, 189);
            this.txtBoxProd.Name = "txtBoxProd";
            this.txtBoxProd.Size = new System.Drawing.Size(295, 29);
            this.txtBoxProd.TabIndex = 18;
            // 
            // txtBoxID
            // 
            this.txtBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxID.Location = new System.Drawing.Point(277, 103);
            this.txtBoxID.Name = "txtBoxID";
            this.txtBoxID.Size = new System.Drawing.Size(295, 29);
            this.txtBoxID.TabIndex = 17;
            // 
            // txtBoxCargo
            // 
            this.txtBoxCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxCargo.Location = new System.Drawing.Point(277, 62);
            this.txtBoxCargo.Name = "txtBoxCargo";
            this.txtBoxCargo.Size = new System.Drawing.Size(295, 29);
            this.txtBoxCargo.TabIndex = 16;
            // 
            // txtBoxNome
            // 
            this.txtBoxNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNome.Location = new System.Drawing.Point(277, 23);
            this.txtBoxNome.Name = "txtBoxNome";
            this.txtBoxNome.Size = new System.Drawing.Size(295, 29);
            this.txtBoxNome.TabIndex = 15;
            // 
            // FrmEx4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.txtBoxSalario);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtBoxSalarioBruto);
            this.Controls.Add(this.lblSalarioBruto);
            this.Controls.Add(this.lblGrat);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblCargo);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.txtBoxGrat);
            this.Controls.Add(this.txtBoxProd);
            this.Controls.Add(this.txtBoxID);
            this.Controls.Add(this.txtBoxCargo);
            this.Controls.Add(this.txtBoxNome);
            this.Name = "FrmEx4";
            this.Text = "FrmEx4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.TextBox txtBoxSalario;
        private System.Windows.Forms.Button btnCalc;
        private System.Windows.Forms.TextBox txtBoxSalarioBruto;
        private System.Windows.Forms.Label lblSalarioBruto;
        private System.Windows.Forms.Label lblGrat;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtBoxGrat;
        private System.Windows.Forms.TextBox txtBoxProd;
        private System.Windows.Forms.TextBox txtBoxID;
        private System.Windows.Forms.TextBox txtBoxCargo;
        private System.Windows.Forms.TextBox txtBoxNome;
    }
}