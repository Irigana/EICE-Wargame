namespace EICE_WARGAME
{
    partial class Form_Principal
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageConnexion1 = new EICE_WARGAME.PageConnexion();
            this.inscription1 = new EICE_WARGAME.Inscription();
            this.SuspendLayout();
            // 
            // pageConnexion1
            // 
            this.pageConnexion1.BackColor = System.Drawing.SystemColors.Control;
            this.pageConnexion1.Location = new System.Drawing.Point(98, 10);
            this.pageConnexion1.Margin = new System.Windows.Forms.Padding(2);
            this.pageConnexion1.Name = "pageConnexion1";
            this.pageConnexion1.Size = new System.Drawing.Size(415, 397);
            this.pageConnexion1.TabIndex = 1;
            // 
            // inscription1
            // 
            this.inscription1.Location = new System.Drawing.Point(60, 10);
            this.inscription1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inscription1.Name = "inscription1";
            this.inscription1.Size = new System.Drawing.Size(526, 396);
            this.inscription1.TabIndex = 2;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 417);
            this.Controls.Add(this.pageConnexion1);
            this.Controls.Add(this.inscription1);
            this.Name = "Form_Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private PageConnexion pageConnexion1;
        private Inscription pageInscription;
        private Inscription inscription1;
    }
}

