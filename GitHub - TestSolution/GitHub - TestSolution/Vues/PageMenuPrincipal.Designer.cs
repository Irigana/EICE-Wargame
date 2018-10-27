namespace EICE_WARGAME
{
    partial class PageMenuPrincipal
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
            this.labelMenuPrincipal = new System.Windows.Forms.Label();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.SuspendLayout();
            // 
            // labelMenuPrincipal
            // 
            this.labelMenuPrincipal.AutoSize = true;
            this.labelMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuPrincipal.Location = new System.Drawing.Point(690, 200);
            this.labelMenuPrincipal.Name = "labelMenuPrincipal";
            this.labelMenuPrincipal.Size = new System.Drawing.Size(303, 51);
            this.labelMenuPrincipal.TabIndex = 0;
            this.labelMenuPrincipal.Text = "Menu principal";
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1276, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(221, 45);
            this.buttonOptionsUser1.TabIndex = 1;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // PageMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.labelMenuPrincipal);
            this.Name = "PageMenuPrincipal";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuPrincipal;
        private EICE_WARGAME.ButtonOptionsUser buttonOptionsUser1;
    }
}
