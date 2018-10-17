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
            this.pageInscription1 = new EICE_WARGAME.PageInscription();
            this.SuspendLayout();
            // 
            // pageConnexion1
            // 
            this.pageConnexion1.BackColor = System.Drawing.SystemColors.Control;
            this.pageConnexion1.Location = new System.Drawing.Point(193, 44);
            this.pageConnexion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageConnexion1.Name = "pageConnexion1";
            this.pageConnexion1.Size = new System.Drawing.Size(553, 489);
            this.pageConnexion1.TabIndex = 0;
            // 
            // pageInscription1
            // 
            this.pageInscription1.Location = new System.Drawing.Point(153, 25);
            this.pageInscription1.Name = "pageInscription1";
            this.pageInscription1.Size = new System.Drawing.Size(651, 549);
            this.pageInscription1.TabIndex = 1;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(921, 624);
            this.Controls.Add(this.pageConnexion1);
            this.Controls.Add(this.pageInscription1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PageConnexion pageConnexion1;
        private PageInscription pageInscription1;
    }
}

