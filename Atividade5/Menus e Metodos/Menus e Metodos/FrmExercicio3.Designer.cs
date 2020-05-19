namespace Menus_e_Metodos
{
    partial class FrmExercicio3
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
            this.btnRemove1 = new System.Windows.Forms.Button();
            this.btnRemove2 = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPalavra1
            // 
            this.lblPalavra1.AutoSize = true;
            this.lblPalavra1.Location = new System.Drawing.Point(49, 45);
            this.lblPalavra1.Name = "lblPalavra1";
            this.lblPalavra1.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra1.TabIndex = 0;
            this.lblPalavra1.Text = "Palavra 1";
            this.lblPalavra1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPalavra2
            // 
            this.lblPalavra2.AutoSize = true;
            this.lblPalavra2.Location = new System.Drawing.Point(49, 104);
            this.lblPalavra2.Name = "lblPalavra2";
            this.lblPalavra2.Size = new System.Drawing.Size(52, 13);
            this.lblPalavra2.TabIndex = 1;
            this.lblPalavra2.Text = "Palavra 2";
            this.lblPalavra2.Click += new System.EventHandler(this.textPalavra2_Click);
            // 
            // textPalavra1
            // 
            this.textPalavra1.Location = new System.Drawing.Point(107, 42);
            this.textPalavra1.Name = "textPalavra1";
            this.textPalavra1.Size = new System.Drawing.Size(325, 20);
            this.textPalavra1.TabIndex = 2;
            // 
            // textPalavra2
            // 
            this.textPalavra2.Location = new System.Drawing.Point(107, 101);
            this.textPalavra2.Name = "textPalavra2";
            this.textPalavra2.Size = new System.Drawing.Size(325, 20);
            this.textPalavra2.TabIndex = 3;
            // 
            // btnRemove1
            // 
            this.btnRemove1.Location = new System.Drawing.Point(64, 165);
            this.btnRemove1.Name = "btnRemove1";
            this.btnRemove1.Size = new System.Drawing.Size(93, 94);
            this.btnRemove1.TabIndex = 4;
            this.btnRemove1.Text = "Remove ocorrencias da  Palavra 1 na Palavra 2";
            this.btnRemove1.UseVisualStyleBackColor = true;
            this.btnRemove1.Click += new System.EventHandler(this.btnRemove1_Click);
            // 
            // btnRemove2
            // 
            this.btnRemove2.Location = new System.Drawing.Point(200, 165);
            this.btnRemove2.Name = "btnRemove2";
            this.btnRemove2.Size = new System.Drawing.Size(93, 94);
            this.btnRemove2.TabIndex = 5;
            this.btnRemove2.Text = "Remove usando replace";
            this.btnRemove2.UseVisualStyleBackColor = true;
            this.btnRemove2.Click += new System.EventHandler(this.btnRemove2_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(340, 165);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(92, 94);
            this.btnReverse.TabIndex = 6;
            this.btnReverse.Text = "Inverte Palavra 1";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // FrmExercicio3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnRemove2);
            this.Controls.Add(this.btnRemove1);
            this.Controls.Add(this.textPalavra2);
            this.Controls.Add(this.textPalavra1);
            this.Controls.Add(this.lblPalavra2);
            this.Controls.Add(this.lblPalavra1);
            this.Name = "FrmExercicio3";
            this.Text = "FrmExercicio3";
            this.Load += new System.EventHandler(this.FrmExercicio3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPalavra1;
        private System.Windows.Forms.Label lblPalavra2;
        private System.Windows.Forms.TextBox textPalavra1;
        private System.Windows.Forms.TextBox textPalavra2;
        private System.Windows.Forms.Button btnRemove1;
        private System.Windows.Forms.Button btnRemove2;
        private System.Windows.Forms.Button btnReverse;
    }
}