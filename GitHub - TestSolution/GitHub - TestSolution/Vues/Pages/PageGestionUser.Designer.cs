namespace EICE_WARGAME
{
    partial class PageGestionUser
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
            this.labelTitreGestionUser = new System.Windows.Forms.Label();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.ficheUtilisateur1 = new EICE_WARGAME.FicheUtilisateur();
            this.buttonPromouvoir = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonDestitution = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitreGestionUser
            // 
            this.labelTitreGestionUser.AutoSize = true;
            this.labelTitreGestionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelTitreGestionUser.Location = new System.Drawing.Point(233, 20);
            this.labelTitreGestionUser.Name = "labelTitreGestionUser";
            this.labelTitreGestionUser.Size = new System.Drawing.Size(434, 46);
            this.labelTitreGestionUser.TabIndex = 2;
            this.labelTitreGestionUser.Text = "Gestion des utilisateurs";
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 32;
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 1;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // menuAdmin1
            // 
            this.menuAdmin1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuAdmin1.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin1.Name = "menuAdmin1";
            this.menuAdmin1.Size = new System.Drawing.Size(190, 750);
            this.menuAdmin1.TabIndex = 0;
            this.menuAdmin1.Utilisateur = null;
            // 
            // ficheUtilisateur1
            // 
            this.ficheUtilisateur1.Location = new System.Drawing.Point(514, 96);
            this.ficheUtilisateur1.Name = "ficheUtilisateur1";
            this.ficheUtilisateur1.Size = new System.Drawing.Size(414, 464);
            this.ficheUtilisateur1.TabIndex = 33;
            this.ficheUtilisateur1.TexteRechercheUser = "";
            this.ficheUtilisateur1.UtilisateurSelectionne = null;
            // 
            // buttonPromouvoir
            // 
            this.buttonPromouvoir.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPromouvoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPromouvoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPromouvoir.Location = new System.Drawing.Point(517, 566);
            this.buttonPromouvoir.Name = "buttonPromouvoir";
            this.buttonPromouvoir.Size = new System.Drawing.Size(133, 45);
            this.buttonPromouvoir.TabIndex = 35;
            this.buttonPromouvoir.Text = "Promouvoir";
            this.buttonPromouvoir.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSupprimer.Location = new System.Drawing.Point(795, 566);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(133, 45);
            this.buttonSupprimer.TabIndex = 36;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // buttonDestitution
            // 
            this.buttonDestitution.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDestitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDestitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonDestitution.Location = new System.Drawing.Point(656, 566);
            this.buttonDestitution.Name = "buttonDestitution";
            this.buttonDestitution.Size = new System.Drawing.Size(133, 45);
            this.buttonDestitution.TabIndex = 37;
            this.buttonDestitution.Text = "Destituer";
            this.buttonDestitution.UseVisualStyleBackColor = false;
            // 
            // PageGestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDestitution);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonPromouvoir);
            this.Controls.Add(this.ficheUtilisateur1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelTitreGestionUser);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.menuAdmin1);
            this.Name = "PageGestionUser";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageGestionUser_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuAdmin menuAdmin1;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Label labelTitreGestionUser;
        private System.Windows.Forms.Panel panelLigne;
        private FicheUtilisateur ficheUtilisateur1;
        private System.Windows.Forms.Button buttonPromouvoir;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonDestitution;
    }
}
