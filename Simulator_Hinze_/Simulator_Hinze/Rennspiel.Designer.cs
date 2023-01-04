namespace Simulator_Hinze
{
    partial class Rennspiel
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.flaeche = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.flaeche)).BeginInit();
            this.SuspendLayout();
            // 
            // flaeche
            // 
            this.flaeche.Location = new System.Drawing.Point(12, 12);
            this.flaeche.Name = "flaeche";
            this.flaeche.Size = new System.Drawing.Size(776, 426);
            this.flaeche.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flaeche.TabIndex = 0;
            this.flaeche.TabStop = false;
            // 
            // Rennspiel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flaeche);
            this.Name = "Rennspiel";
            this.Text = "Rennspiel";
            this.Load += new System.EventHandler(this.load);
            ((System.ComponentModel.ISupportInitialize)(this.flaeche)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox flaeche;
    }
}

