namespace Atividade6
{
    partial class FrmEx3
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
            this.txtEx3 = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtEx3Reverse = new System.Windows.Forms.TextBox();
            this.btnReverse = new System.Windows.Forms.Button();
            this.txtBoxEhPalindromo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtEx3
            // 
            this.txtEx3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEx3.Location = new System.Drawing.Point(35, 120);
            this.txtEx3.MaxLength = 50;
            this.txtEx3.Name = "txtEx3";
            this.txtEx3.Size = new System.Drawing.Size(711, 38);
            this.txtEx3.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.lbl1.Location = new System.Drawing.Point(29, 63);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(573, 31);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Escreva a frase para verificar se é palíndromo:";
            // 
            // txtEx3Reverse
            // 
            this.txtEx3Reverse.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEx3Reverse.Location = new System.Drawing.Point(35, 299);
            this.txtEx3Reverse.MaxLength = 50;
            this.txtEx3Reverse.Name = "txtEx3Reverse";
            this.txtEx3Reverse.ReadOnly = true;
            this.txtEx3Reverse.Size = new System.Drawing.Size(711, 38);
            this.txtEx3Reverse.TabIndex = 2;
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(35, 187);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(207, 87);
            this.btnReverse.TabIndex = 3;
            this.btnReverse.Text = "Inverter Frase";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // txtBoxEhPalindromo
            // 
            this.txtBoxEhPalindromo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEhPalindromo.Location = new System.Drawing.Point(288, 206);
            this.txtBoxEhPalindromo.MaxLength = 50;
            this.txtBoxEhPalindromo.Name = "txtBoxEhPalindromo";
            this.txtBoxEhPalindromo.ReadOnly = true;
            this.txtBoxEhPalindromo.Size = new System.Drawing.Size(458, 38);
            this.txtBoxEhPalindromo.TabIndex = 4;
            // 
            // FrmEx3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 402);
            this.Controls.Add(this.txtBoxEhPalindromo);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.txtEx3Reverse);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtEx3);
            this.Name = "FrmEx3";
            this.Text = "FrmEx3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEx3;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtEx3Reverse;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.TextBox txtBoxEhPalindromo;
    }
}