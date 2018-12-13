namespace EICE_WARGAME
{
    partial class PageImpressionCarteUnite
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.SuspendLayout();
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(844, 2);
            this.buttonOptionsUser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(164, 37);
            this.buttonOptionsUser1.TabIndex = 12;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // PageImpressionCarteUnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOptionsUser1);
            this.Name = "PageImpressionCarteUnite";
            this.Size = new System.Drawing.Size(1010, 519);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonOptionsUser buttonOptionsUser1;
    }
}
