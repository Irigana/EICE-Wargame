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
            this.components = new System.ComponentModel.Container();
            this.labelTitreGestionUser = new System.Windows.Forms.Label();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.buttonPromouvoir = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonDestitution = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ficheUtilisateur1 = new EICE_WARGAME.FicheUtilisateur();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.labelNouveauMotDePasse = new System.Windows.Forms.Label();
            this.textBoxAvecTextInvisibleMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleConfMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.buttonValider = new System.Windows.Forms.Button();
            this.errorProviderValidation = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitreGestionUser
            // 
            this.labelTitreGestionUser.AutoSize = true;
            this.labelTitreGestionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelTitreGestionUser.ForeColor = System.Drawing.Color.SlateGray;
            this.labelTitreGestionUser.Location = new System.Drawing.Point(233, 20);
            this.labelTitreGestionUser.Name = "labelTitreGestionUser";
            this.labelTitreGestionUser.Size = new System.Drawing.Size(434, 46);
            this.labelTitreGestionUser.TabIndex = 2;
            this.labelTitreGestionUser.Text = "Gestion des utilisateurs";
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 32;
            // 
            // buttonPromouvoir
            // 
            this.buttonPromouvoir.BackColor = System.Drawing.SystemColors.Window;
            this.buttonPromouvoir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPromouvoir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonPromouvoir.Location = new System.Drawing.Point(375, 591);
            this.buttonPromouvoir.Name = "buttonPromouvoir";
            this.buttonPromouvoir.Size = new System.Drawing.Size(133, 45);
            this.buttonPromouvoir.TabIndex = 35;
            this.buttonPromouvoir.Text = "Promouvoir";
            this.buttonPromouvoir.UseVisualStyleBackColor = false;
            this.buttonPromouvoir.Click += new System.EventHandler(this.buttonPromouvoir_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSupprimer.Location = new System.Drawing.Point(653, 591);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(133, 45);
            this.buttonSupprimer.TabIndex = 36;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // buttonDestitution
            // 
            this.buttonDestitution.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDestitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDestitution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonDestitution.Location = new System.Drawing.Point(514, 591);
            this.buttonDestitution.Name = "buttonDestitution";
            this.buttonDestitution.Size = new System.Drawing.Size(133, 45);
            this.buttonDestitution.TabIndex = 37;
            this.buttonDestitution.Text = "Destituer";
            this.buttonDestitution.UseVisualStyleBackColor = false;
            this.buttonDestitution.Click += new System.EventHandler(this.buttonDestitution_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(372, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Rechercher un utilisateur";
            // 
            // ficheUtilisateur1
            // 
            this.ficheUtilisateur1.Location = new System.Drawing.Point(372, 121);
            this.ficheUtilisateur1.Name = "ficheUtilisateur1";
            this.ficheUtilisateur1.Size = new System.Drawing.Size(414, 464);
            this.ficheUtilisateur1.TabIndex = 33;
            this.ficheUtilisateur1.TexteRechercheUser = "";
            this.ficheUtilisateur1.UtilisateurSelectionne = null;
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
            this.menuAdmin1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuAdmin1.EstAdmin = false;
            this.menuAdmin1.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin1.MaPageActive = 0;
            this.menuAdmin1.Name = "menuAdmin1";
            this.menuAdmin1.Size = new System.Drawing.Size(190, 750);
            this.menuAdmin1.TabIndex = 39;
            this.menuAdmin1.Utilisateur = null;
            // 
            // buttonRetourDashBoard1
            // 
            this.buttonRetourDashBoard1.Location = new System.Drawing.Point(197, 4);
            this.buttonRetourDashBoard1.Name = "buttonRetourDashBoard1";
            this.buttonRetourDashBoard1.Size = new System.Drawing.Size(44, 34);
            this.buttonRetourDashBoard1.TabIndex = 40;
            this.buttonRetourDashBoard1.Utilisateur = null;
            // 
            // labelNouveauMotDePasse
            // 
            this.labelNouveauMotDePasse.AutoSize = true;
            this.labelNouveauMotDePasse.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelNouveauMotDePasse.ForeColor = System.Drawing.Color.SlateGray;
            this.labelNouveauMotDePasse.Location = new System.Drawing.Point(916, 227);
            this.labelNouveauMotDePasse.Name = "labelNouveauMotDePasse";
            this.labelNouveauMotDePasse.Size = new System.Drawing.Size(429, 46);
            this.labelNouveauMotDePasse.TabIndex = 41;
            this.labelNouveauMotDePasse.Text = "Nouveau mot de passe";
            // 
            // textBoxAvecTextInvisibleMdp
            // 
            this.textBoxAvecTextInvisibleMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdp.Location = new System.Drawing.Point(1008, 318);
            this.textBoxAvecTextInvisibleMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleMdp.Name = "textBoxAvecTextInvisibleMdp";
            this.textBoxAvecTextInvisibleMdp.PlaceHolder = "Nouveau mot de passe";
            this.textBoxAvecTextInvisibleMdp.Size = new System.Drawing.Size(288, 22);
            this.textBoxAvecTextInvisibleMdp.TabIndex = 42;
            this.textBoxAvecTextInvisibleMdp.Enter += new System.EventHandler(this.textBoxAvecTextInvisibleMdp_Enter);
            // 
            // textBoxAvecTextInvisibleConfMdp
            // 
            this.textBoxAvecTextInvisibleConfMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleConfMdp.Location = new System.Drawing.Point(1008, 369);
            this.textBoxAvecTextInvisibleConfMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleConfMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleConfMdp.Name = "textBoxAvecTextInvisibleConfMdp";
            this.textBoxAvecTextInvisibleConfMdp.PlaceHolder = "Confirmation mot de passe";
            this.textBoxAvecTextInvisibleConfMdp.Size = new System.Drawing.Size(288, 22);
            this.textBoxAvecTextInvisibleConfMdp.TabIndex = 43;
            this.textBoxAvecTextInvisibleConfMdp.Enter += new System.EventHandler(this.textBoxAvecTextInvisibleConfMdp_Enter);
            // 
            // buttonValider
            // 
            this.buttonValider.BackColor = System.Drawing.SystemColors.Window;
            this.buttonValider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonValider.Location = new System.Drawing.Point(1008, 423);
            this.buttonValider.Name = "buttonValider";
            this.buttonValider.Size = new System.Drawing.Size(288, 31);
            this.buttonValider.TabIndex = 44;
            this.buttonValider.Text = "Valider";
            this.buttonValider.UseVisualStyleBackColor = false;
            this.buttonValider.Click += new System.EventHandler(this.buttonValider_Click);
            // 
            // errorProviderValidation
            // 
            this.errorProviderValidation.ContainerControl = this;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // PageGestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonValider);
            this.Controls.Add(this.textBoxAvecTextInvisibleConfMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdp);
            this.Controls.Add(this.labelNouveauMotDePasse);
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDestitution);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonPromouvoir);
            this.Controls.Add(this.ficheUtilisateur1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelTitreGestionUser);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Name = "PageGestionUser";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageGestionUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Label labelTitreGestionUser;
        private System.Windows.Forms.Panel panelLigne;
        private FicheUtilisateur ficheUtilisateur1;
        private System.Windows.Forms.Button buttonPromouvoir;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonDestitution;
        private System.Windows.Forms.Label label1;
        private MenuAdmin menuAdmin1;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
        private System.Windows.Forms.Label labelNouveauMotDePasse;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdp;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleConfMdp;
        private System.Windows.Forms.Button buttonValider;
        private System.Windows.Forms.ErrorProvider errorProviderValidation;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}
