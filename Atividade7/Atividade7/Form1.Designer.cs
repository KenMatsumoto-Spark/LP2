namespace Atividade7
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
            this.btnLer20 = new System.Windows.Forms.Button();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnMerc = new System.Windows.Forms.Button();
            this.btnArrayList = new System.Windows.Forms.Button();
            this.btnContChars = new System.Windows.Forms.Button();
            this.btnMedia20em3 = new System.Windows.Forms.Button();
            this.BtnVariavelTotal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLer20
            // 
            this.btnLer20.Location = new System.Drawing.Point(68, 50);
            this.btnLer20.Name = "btnLer20";
            this.btnLer20.Size = new System.Drawing.Size(157, 155);
            this.btnLer20.TabIndex = 0;
            this.btnLer20.Text = "Ler 20 Numeros(Ex1)";
            this.btnLer20.UseVisualStyleBackColor = true;
            this.btnLer20.Click += new System.EventHandler(this.btnLer20_Click);
            // 
            // btnReverse
            // 
            this.btnReverse.Location = new System.Drawing.Point(231, 50);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(157, 155);
            this.btnReverse.TabIndex = 1;
            this.btnReverse.Text = "Reverse(Ex1)";
            this.btnReverse.UseVisualStyleBackColor = true;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnMerc
            // 
            this.btnMerc.Location = new System.Drawing.Point(394, 50);
            this.btnMerc.Name = "btnMerc";
            this.btnMerc.Size = new System.Drawing.Size(157, 155);
            this.btnMerc.TabIndex = 2;
            this.btnMerc.Text = "Mercadorias(Ex3)";
            this.btnMerc.UseVisualStyleBackColor = true;
            this.btnMerc.Click += new System.EventHandler(this.btnMerc_Click);
            // 
            // btnArrayList
            // 
            this.btnArrayList.Location = new System.Drawing.Point(68, 211);
            this.btnArrayList.Name = "btnArrayList";
            this.btnArrayList.Size = new System.Drawing.Size(157, 155);
            this.btnArrayList.TabIndex = 3;
            this.btnArrayList.Text = "Uso ArrayList(Ex5)";
            this.btnArrayList.UseVisualStyleBackColor = true;
            this.btnArrayList.Click += new System.EventHandler(this.btnArrayList_Click);
            // 
            // btnContChars
            // 
            this.btnContChars.Location = new System.Drawing.Point(394, 211);
            this.btnContChars.Name = "btnContChars";
            this.btnContChars.Size = new System.Drawing.Size(157, 155);
            this.btnContChars.TabIndex = 5;
            this.btnContChars.Text = "Contador de Caracteres em Nomes(Ex7)";
            this.btnContChars.UseVisualStyleBackColor = true;
            this.btnContChars.Click += new System.EventHandler(this.btnContChars_Click);
            // 
            // btnMedia20em3
            // 
            this.btnMedia20em3.Location = new System.Drawing.Point(231, 211);
            this.btnMedia20em3.Name = "btnMedia20em3";
            this.btnMedia20em3.Size = new System.Drawing.Size(157, 155);
            this.btnMedia20em3.TabIndex = 6;
            this.btnMedia20em3.Text = "Media de 20 Alunos em 3 disciplinoas(Ex6)";
            this.btnMedia20em3.UseVisualStyleBackColor = true;
            this.btnMedia20em3.Click += new System.EventHandler(this.btnMedia20em3_Click);
            // 
            // BtnVariavelTotal
            // 
            this.BtnVariavelTotal.Location = new System.Drawing.Point(557, 50);
            this.BtnVariavelTotal.Name = "BtnVariavelTotal";
            this.BtnVariavelTotal.Size = new System.Drawing.Size(157, 155);
            this.BtnVariavelTotal.TabIndex = 7;
            this.BtnVariavelTotal.Text = "Variavel Total(Ex4)";
            this.BtnVariavelTotal.UseVisualStyleBackColor = true;
            this.BtnVariavelTotal.Click += new System.EventHandler(this.BtnVariavelTotal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnVariavelTotal);
            this.Controls.Add(this.btnMedia20em3);
            this.Controls.Add(this.btnContChars);
            this.Controls.Add(this.btnArrayList);
            this.Controls.Add(this.btnMerc);
            this.Controls.Add(this.btnReverse);
            this.Controls.Add(this.btnLer20);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLer20;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Button btnMerc;
        private System.Windows.Forms.Button btnArrayList;
        private System.Windows.Forms.Button btnContChars;
        private System.Windows.Forms.Button btnMedia20em3;
        private System.Windows.Forms.Button BtnVariavelTotal;
    }
}

