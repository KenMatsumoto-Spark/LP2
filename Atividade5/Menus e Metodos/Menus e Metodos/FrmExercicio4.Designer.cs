namespace Menus_e_Metodos
{
    partial class FrmExercicio4
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
            this.richText4 = new System.Windows.Forms.RichTextBox();
            this.btnCarNum = new System.Windows.Forms.Button();
            this.btnCarAlpha = new System.Windows.Forms.Button();
            this.btnBranco = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richText4
            // 
            this.richText4.Location = new System.Drawing.Point(49, 12);
            this.richText4.Name = "richText4";
            this.richText4.Size = new System.Drawing.Size(498, 252);
            this.richText4.TabIndex = 0;
            this.richText4.Text = "";
            // 
            // btnCarNum
            // 
            this.btnCarNum.Location = new System.Drawing.Point(49, 290);
            this.btnCarNum.Name = "btnCarNum";
            this.btnCarNum.Size = new System.Drawing.Size(98, 94);
            this.btnCarNum.TabIndex = 1;
            this.btnCarNum.Text = "Caracteres Numericos";
            this.btnCarNum.UseVisualStyleBackColor = true;
            this.btnCarNum.Click += new System.EventHandler(this.btnCarNum_Click);
            // 
            // btnCarAlpha
            // 
            this.btnCarAlpha.Location = new System.Drawing.Point(449, 290);
            this.btnCarAlpha.Name = "btnCarAlpha";
            this.btnCarAlpha.Size = new System.Drawing.Size(98, 94);
            this.btnCarAlpha.TabIndex = 2;
            this.btnCarAlpha.Text = "Caractere Alfabeticos";
            this.btnCarAlpha.UseVisualStyleBackColor = true;
            this.btnCarAlpha.Click += new System.EventHandler(this.btnCarAlpha_Click);
            // 
            // btnBranco
            // 
            this.btnBranco.Location = new System.Drawing.Point(250, 290);
            this.btnBranco.Name = "btnBranco";
            this.btnBranco.Size = new System.Drawing.Size(96, 94);
            this.btnBranco.TabIndex = 3;
            this.btnBranco.Text = "Primeiro Branco";
            this.btnBranco.UseVisualStyleBackColor = true;
            this.btnBranco.Click += new System.EventHandler(this.btnBranco_Click);
            // 
            // FrmExercicio4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 450);
            this.Controls.Add(this.btnBranco);
            this.Controls.Add(this.btnCarAlpha);
            this.Controls.Add(this.btnCarNum);
            this.Controls.Add(this.richText4);
            this.Name = "FrmExercicio4";
            this.Text = "Primeiro Branco";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richText4;
        private System.Windows.Forms.Button btnCarNum;
        private System.Windows.Forms.Button btnCarAlpha;
        private System.Windows.Forms.Button btnBranco;
    }
}