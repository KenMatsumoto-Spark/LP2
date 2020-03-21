namespace Reconhecedor_de_Triangulos
{
    partial class ReconhecedordeTriangulos
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
            this.lbldescricao = new System.Windows.Forms.Label();
            this.lblLadoA = new System.Windows.Forms.Label();
            this.lblLadoB = new System.Windows.Forms.Label();
            this.lblLadoC = new System.Windows.Forms.Label();
            this.txtboxA = new System.Windows.Forms.TextBox();
            this.txtboxB = new System.Windows.Forms.TextBox();
            this.txtboxC = new System.Windows.Forms.TextBox();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldescricao
            // 
            this.lbldescricao.AutoSize = true;
            this.lbldescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.lbldescricao.Location = new System.Drawing.Point(12, 9);
            this.lbldescricao.Name = "lbldescricao";
            this.lbldescricao.Size = new System.Drawing.Size(235, 48);
            this.lbldescricao.TabIndex = 0;
            this.lbldescricao.Text = "Informe as três dimensões \r\npara a verificação:";
            // 
            // lblLadoA
            // 
            this.lblLadoA.AutoSize = true;
            this.lblLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoA.Location = new System.Drawing.Point(11, 76);
            this.lblLadoA.Name = "lblLadoA";
            this.lblLadoA.Size = new System.Drawing.Size(44, 24);
            this.lblLadoA.TabIndex = 1;
            this.lblLadoA.Text = "A = ";
            // 
            // lblLadoB
            // 
            this.lblLadoB.AutoSize = true;
            this.lblLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoB.Location = new System.Drawing.Point(11, 126);
            this.lblLadoB.Name = "lblLadoB";
            this.lblLadoB.Size = new System.Drawing.Size(43, 24);
            this.lblLadoB.TabIndex = 2;
            this.lblLadoB.Text = "B = ";
            // 
            // lblLadoC
            // 
            this.lblLadoC.AutoSize = true;
            this.lblLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLadoC.Location = new System.Drawing.Point(10, 176);
            this.lblLadoC.Name = "lblLadoC";
            this.lblLadoC.Size = new System.Drawing.Size(44, 24);
            this.lblLadoC.TabIndex = 3;
            this.lblLadoC.Text = "C = ";
            // 
            // txtboxA
            // 
            this.txtboxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtboxA.Location = new System.Drawing.Point(49, 73);
            this.txtboxA.Name = "txtboxA";
            this.txtboxA.Size = new System.Drawing.Size(100, 29);
            this.txtboxA.TabIndex = 1;
            // 
            // txtboxB
            // 
            this.txtboxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtboxB.Location = new System.Drawing.Point(49, 123);
            this.txtboxB.Name = "txtboxB";
            this.txtboxB.Size = new System.Drawing.Size(100, 29);
            this.txtboxB.TabIndex = 2;
            // 
            // txtboxC
            // 
            this.txtboxC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txtboxC.Location = new System.Drawing.Point(49, 173);
            this.txtboxC.Name = "txtboxC";
            this.txtboxC.Size = new System.Drawing.Size(100, 29);
            this.txtboxC.TabIndex = 3;
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(172, 73);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(75, 129);
            this.btnVerificar.TabIndex = 4;
            this.btnVerificar.Text = "VERIFICAR";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // ReconhecedordeTriangulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 212);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.txtboxC);
            this.Controls.Add(this.txtboxB);
            this.Controls.Add(this.txtboxA);
            this.Controls.Add(this.lblLadoC);
            this.Controls.Add(this.lblLadoB);
            this.Controls.Add(this.lblLadoA);
            this.Controls.Add(this.lbldescricao);
            this.KeyPreview = true;
            this.Name = "ReconhecedordeTriangulos";
            this.Text = "Reconhecedor de Triangulos";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ReconhecedordeTriangulos_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldescricao;
        private System.Windows.Forms.Label lblLadoA;
        private System.Windows.Forms.Label lblLadoB;
        private System.Windows.Forms.Label lblLadoC;
        private System.Windows.Forms.TextBox txtboxA;
        private System.Windows.Forms.TextBox txtboxB;
        private System.Windows.Forms.TextBox txtboxC;
        private System.Windows.Forms.Button btnVerificar;
    }
}

