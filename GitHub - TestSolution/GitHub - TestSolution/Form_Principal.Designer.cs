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
            this.pageMenuPrincipal1 = new EICE_WARGAME.PageMenuPrincipal();
            this.pageInscription1 = new EICE_WARGAME.PageInscription();
            this.pageEditionUser1 = new EICE_WARGAME.PageEditionUser();
            this.SuspendLayout();
            // 
            // pageConnexion1
            // 
            this.pageConnexion1.BackColor = System.Drawing.SystemColors.Control;
            this.pageConnexion1.Location = new System.Drawing.Point(0, 1);
            this.pageConnexion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pageConnexion1.Name = "pageConnexion1";
            this.pageConnexion1.Size = new System.Drawing.Size(1500, 750);
            this.pageConnexion1.TabIndex = 0;
            this.pageConnexion1.Leave += new System.EventHandler(this.pageConnexion1_Leave);
            // 
            // pageMenuPrincipal1
            // 
            this.pageMenuPrincipal1.Location = new System.Drawing.Point(0, 1);
            this.pageMenuPrincipal1.Name = "pageMenuPrincipal1";
            this.pageMenuPrincipal1.Size = new System.Drawing.Size(1500, 750);
            this.pageMenuPrincipal1.TabIndex = 2;
            this.pageMenuPrincipal1.Leave += new System.EventHandler(this.pageMenuPrincipal1_Leave);
            // 
            // pageInscription1
            // 
            this.pageInscription1.Location = new System.Drawing.Point(0, 1);
            this.pageInscription1.Name = "pageInscription1";
            this.pageInscription1.Size = new System.Drawing.Size(1500, 750);
            this.pageInscription1.TabIndex = 1;
            this.pageInscription1.Leave += new System.EventHandler(this.PageInscription_Leave);
            // 
            // pageEditionUser1
            // 
            this.pageEditionUser1.Location = new System.Drawing.Point(0, 1);
            this.pageEditionUser1.Name = "pageEditionUser1";
            this.pageEditionUser1.Size = new System.Drawing.Size(1500, 750);
            this.pageEditionUser1.TabIndex = 3;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1482, 703);
            this.Controls.Add(this.pageConnexion1);
            this.Controls.Add(this.pageMenuPrincipal1);
            this.Controls.Add(this.pageInscription1);
            this.Controls.Add(this.pageEditionUser1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private PageConnexion pageConnexion1;
        private PageInscription pageInscription1;
        private PageMenuPrincipal pageMenuPrincipal1;
        private PageEditionUser pageEditionUser1;
    }
}

