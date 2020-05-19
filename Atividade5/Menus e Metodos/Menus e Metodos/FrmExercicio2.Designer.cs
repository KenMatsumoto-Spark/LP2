namespace Menus_e_Metodos
{
    partial class FrmExercicio2
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
            this.lblPalavra1 = new System.Windows.Forms.Label();
            this.lblPalavra2 = new System.Windows.Forms.Label();
            this.textPalavra1 = new System.Windows.Forms.TextBox();
            this.textPalavra2 = new System.Windows.Forms.TextBox();
            this.btnCompara = new System.Windows.Forms.Button();
            this.btnInserir1 = new System.Windows.Forms.Button();
            this.btnInserir2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(76, 68);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(76, 125);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            // 
            // textPalavra1
            // 
            this.textPalavra1.Location = new System.Drawing.Point(134, 65);
            this.textPalavra1.Name = "textPalavra1";
            this.textPalavra1.Size = new System.Drawing.Size(407, 20);
            this.textPalavra1.TabIndex = 2;
            // 
            // textPalavra2
            // 
            this.textPalavra2.Location = new System.Drawing.Point(134, 122);
            this.textPalavra2.Name = "textPalavra2";
            this.textPalavra2.Size = new System.Drawing.Size(407, 20);
            this.textPalavra2.TabIndex = 3;
            // 
            // btnCompara
            // 
            this.btnCompara.Location = new System.Drawing.Point(53, 202);
            this.btnCompara.Name = "btnCompara";
            this.btnCompara.Size = new System.Drawing.Size(101, 97);
            this.btnCompara.TabIndex = 4;
            this.btnCompara.Text = "Comparar";
            this.btnCompara.UseVisualStyleBackColor = true;
            this.btnCompara.Click += new System.EventHandler(this.btnCompara_Click);
            // 
            // btnInserir1
            // 
            this.btnInserir1.Location = new System.Drawing.Point(180, 202);
            this.btnInserir1.Name = "btnInserir1";
            this.btnInserir1.Size = new System.Drawing.Size(207, 97);
            this.btnInserir1.TabIndex = 5;
            this.btnInserir1.Text = "Insere Palavra 1 no meio da Palavra 2";
            this.btnInserir1.UseVisualStyleBackColor = true;
            this.btnInserir1.Click += new System.EventHandler(this.btnInserir1_Click);
            // 
            // btnInserir2
            // 
            this.btnInserir2.Location = new System.Drawing.Point(415, 202);
            this.btnInserir2.Name = "btnInserir2";
            this.btnInserir2.Size = new System.Drawing.Size(126, 97);
            this.btnInserir2.TabIndex = 6;
            this.btnInserir2.Text = "Insere ** na Palavra1";
            this.btnInserir2.UseVisualStyleBackColor = true;
            this.btnInserir2.Click += new System.EventHandler(this.btnInserir2_Click);
            // 
            // FrmExercicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 444);
            this.Controls.Add(this.btnInserir2);
            this.Controls.Add(this.btnInserir1);
            this.Controls.Add(this.btnCompara);
            this.Controls.Add(this.textPalavra2);
            this.Controls.Add(this.textPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "FrmExercicio2";
            this.Text = "FrmExercicio2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox textPalavra1;
        private System.Windows.Forms.TextBox textPalavra2;
        private System.Windows.Forms.Button btnCompara;
        private System.Windows.Forms.Button btnInserir1;
        private System.Windows.Forms.Button btnInserir2;
    }
}