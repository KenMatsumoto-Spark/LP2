namespace PVolume
{
    partial class PVolume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PVolume));
            this.txtBoxRaio = new System.Windows.Forms.TextBox();
            this.lblRaio = new System.Windows.Forms.Label();
            this.lblAltura = new System.Windows.Forms.Label();
            this.txtBoxAltura = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtBoxVolume = new System.Windows.Forms.TextBox();
            this.picDiferenca = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picDiferenca)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxRaio
            // 
            this.txtBoxRaio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxRaio.Location = new System.Drawing.Point(69, 284);
            this.txtBoxRaio.Name = "txtBoxRaio";
            this.txtBoxRaio.Size = new System.Drawing.Size(255, 29);
            this.txtBoxRaio.TabIndex = 1;
            this.txtBoxRaio.TextChanged += new System.EventHandler(this.txtBoxRaio_TextChanged);
            this.txtBoxRaio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBoxRaio_KeyPress);
            // 
            // lblRaio
            // 
            this.lblRaio.AutoSize = true;
            this.lblRaio.Location = new System.Drawing.Point(18, 287);
            this.lblRaio.Name = "lblRaio";
            this.lblRaio.Size = new System.Drawing.Size(32, 13);
            this.lblRaio.TabIndex = 3;
            this.lblRaio.Text = "Raio:";
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Location = new System.Drawing.Point(18, 340);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(37, 13);
            this.lblAltura.TabIndex = 5;
            this.lblAltura.Text = "Altura:";
            // 
            // txtBoxAltura
            // 
            this.txtBoxAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxAltura.Location = new System.Drawing.Point(69, 337);
            this.txtBoxAltura.Name = "txtBoxAltura";
            this.txtBoxAltura.Size = new System.Drawing.Size(255, 29);
            this.txtBoxAltura.TabIndex = 4;
            this.txtBoxAltura.TextChanged += new System.EventHandler(this.txtBoxAltura_TextChanged);
            // 
            // lblVolume
            // 
            this.lblVolume.AutoSize = true;
            this.lblVolume.Location = new System.Drawing.Point(18, 403);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(45, 13);
            this.lblVolume.TabIndex = 7;
            this.lblVolume.Text = "Volume:";
            // 
            // txtBoxVolume
            // 
            this.txtBoxVolume.Enabled = false;
            this.txtBoxVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.txtBoxVolume.Location = new System.Drawing.Point(69, 400);
            this.txtBoxVolume.Name = "txtBoxVolume";
            this.txtBoxVolume.Size = new System.Drawing.Size(255, 29);
            this.txtBoxVolume.TabIndex = 6;
            // 
            // picDiferenca
            // 
            this.picDiferenca.Image = ((System.Drawing.Image)(resources.GetObject("picDiferenca.Image")));
            this.picDiferenca.Location = new System.Drawing.Point(12, 99);
            this.picDiferenca.Name = "picDiferenca";
            this.picDiferenca.Size = new System.Drawing.Size(314, 160);
            this.picDiferenca.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picDiferenca.TabIndex = 8;
            this.picDiferenca.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.lblInfo.Location = new System.Drawing.Point(18, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(306, 75);
            this.lblInfo.TabIndex = 9;
            this.lblInfo.Text = resources.GetString("lblInfo.Text");
            // 
            // PVolume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 450);
            this.Controls.Add(this.txtBoxRaio);
            this.Controls.Add(this.lblRaio);
            this.Controls.Add(this.txtBoxAltura);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.picDiferenca);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.txtBoxVolume);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PVolume";
            this.Text = "Calculadora de Volume de Cilindro";
            ((System.ComponentModel.ISupportInitialize)(this.picDiferenca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxRaio;
        private System.Windows.Forms.Label lblRaio;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.TextBox txtBoxAltura;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtBoxVolume;
        private System.Windows.Forms.PictureBox picDiferenca;
        private System.Windows.Forms.Label lblInfo;
    }
}

