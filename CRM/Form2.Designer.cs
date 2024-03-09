namespace CRM
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pais_relleno = new System.Windows.Forms.Panel();
            this.mapa_pais = new System.Windows.Forms.PictureBox();
            this.pais_relleno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapa_pais)).BeginInit();
            this.SuspendLayout();
            // 
            // pais_relleno
            // 
            this.pais_relleno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pais_relleno.Controls.Add(this.mapa_pais);
            this.pais_relleno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pais_relleno.Location = new System.Drawing.Point(0, 0);
            this.pais_relleno.Name = "pais_relleno";
            this.pais_relleno.Size = new System.Drawing.Size(800, 450);
            this.pais_relleno.TabIndex = 2;
            // 
            // mapa_pais
            // 
            this.mapa_pais.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapa_pais.BackgroundImage")));
            this.mapa_pais.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mapa_pais.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapa_pais.Location = new System.Drawing.Point(0, 0);
            this.mapa_pais.Name = "mapa_pais";
            this.mapa_pais.Size = new System.Drawing.Size(800, 450);
            this.mapa_pais.TabIndex = 8;
            this.mapa_pais.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pais_relleno);
            this.Name = "Form2";
            this.Text = "Form2";
            this.pais_relleno.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapa_pais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox mapa_pais;
        public System.Windows.Forms.Panel pais_relleno;
    }
}