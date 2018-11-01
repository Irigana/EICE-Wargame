namespace EICE_WARGAME
{
    partial class PageEditionUser
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
            this.labelEditionUser = new System.Windows.Forms.Label();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.buttonRetourMenu = new System.Windows.Forms.Button();
            this.errorProviderEdition = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.textBoxAvecTextInvisibleConfNewMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleNouveauMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleMdpInitial = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleLogin = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.labelNouveauLogin = new System.Windows.Forms.Label();
            this.labelNouveauMdp = new System.Windows.Forms.Label();
            this.panelLigneSeparatrice = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEdition)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditionUser
            // 
            this.labelEditionUser.AutoSize = true;
            this.labelEditionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.labelEditionUser.Location = new System.Drawing.Point(599, 86);
            this.labelEditionUser.Name = "labelEditionUser";
            this.labelEditionUser.Size = new System.Drawing.Size(323, 52);
            this.labelEditionUser.TabIndex = 0;
            this.labelEditionUser.Text = "Edition du profil";
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.BackColor = System.Drawing.SystemColors.Window;
            this.buttonValiderModif.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonValiderModif.FlatAppearance.BorderSize = 2;
            this.buttonValiderModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValiderModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonValiderModif.Location = new System.Drawing.Point(608, 486);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(314, 36);
            this.buttonValiderModif.TabIndex = 6;
            this.buttonValiderModif.Text = "Valider les modifications";
            this.buttonValiderModif.UseVisualStyleBackColor = false;
            this.buttonValiderModif.Click += new System.EventHandler(this.buttonValiderModif_Click);
            // 
            // buttonRetourMenu
            // 
            this.buttonRetourMenu.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRetourMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRetourMenu.FlatAppearance.BorderSize = 2;
            this.buttonRetourMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRetourMenu.Location = new System.Drawing.Point(608, 538);
            this.buttonRetourMenu.Name = "buttonRetourMenu";
            this.buttonRetourMenu.Size = new System.Drawing.Size(314, 36);
            this.buttonRetourMenu.TabIndex = 7;
            this.buttonRetourMenu.Text = "Menu principal";
            this.buttonRetourMenu.UseVisualStyleBackColor = false;
            this.buttonRetourMenu.Click += new System.EventHandler(this.buttonRetourMenu_Click);
            // 
            // errorProviderEdition
            // 
            this.errorProviderEdition.ContainerControl = this;
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 5;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // textBoxAvecTextInvisibleConfNewMdp
            // 
            this.textBoxAvecTextInvisibleConfNewMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleConfNewMdp.Location = new System.Drawing.Point(897, 359);
            this.textBoxAvecTextInvisibleConfNewMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleConfNewMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleConfNewMdp.Name = "textBoxAvecTextInvisibleConfNewMdp";
            this.textBoxAvecTextInvisibleConfNewMdp.PlaceHolder = "Confirmation nouveau mot de passe";
            this.textBoxAvecTextInvisibleConfNewMdp.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleConfNewMdp.TabIndex = 4;
            // 
            // textBoxAvecTextInvisibleNouveauMdp
            // 
            this.textBoxAvecTextInvisibleNouveauMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleNouveauMdp.Location = new System.Drawing.Point(897, 310);
            this.textBoxAvecTextInvisibleNouveauMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleNouveauMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleNouveauMdp.Name = "textBoxAvecTextInvisibleNouveauMdp";
            this.textBoxAvecTextInvisibleNouveauMdp.PlaceHolder = "Nouveau mot de passe";
            this.textBoxAvecTextInvisibleNouveauMdp.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleNouveauMdp.TabIndex = 3;
            // 
            // textBoxAvecTextInvisibleMdpInitial
            // 
            this.textBoxAvecTextInvisibleMdpInitial.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdpInitial.Location = new System.Drawing.Point(297, 357);
            this.textBoxAvecTextInvisibleMdpInitial.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdpInitial.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleMdpInitial.Name = "textBoxAvecTextInvisibleMdpInitial";
            this.textBoxAvecTextInvisibleMdpInitial.PlaceHolder = "Mot de passe actuel";
            this.textBoxAvecTextInvisibleMdpInitial.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleMdpInitial.TabIndex = 2;
            // 
            // textBoxAvecTextInvisibleLogin
            // 
            this.textBoxAvecTextInvisibleLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleLogin.Location = new System.Drawing.Point(297, 310);
            this.textBoxAvecTextInvisibleLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleLogin.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleLogin.Name = "textBoxAvecTextInvisibleLogin";
            this.textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            this.textBoxAvecTextInvisibleLogin.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleLogin.TabIndex = 1;
            // 
            // labelNouveauLogin
            // 
            this.labelNouveauLogin.AutoSize = true;
            this.labelNouveauLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNouveauLogin.Location = new System.Drawing.Point(291, 227);
            this.labelNouveauLogin.Name = "labelNouveauLogin";
            this.labelNouveauLogin.Size = new System.Drawing.Size(187, 31);
            this.labelNouveauLogin.TabIndex = 8;
            this.labelNouveauLogin.Text = "Nouveau login";
            // 
            // labelNouveauMdp
            // 
            this.labelNouveauMdp.AutoSize = true;
            this.labelNouveauMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.labelNouveauMdp.Location = new System.Drawing.Point(891, 227);
            this.labelNouveauMdp.Name = "labelNouveauMdp";
            this.labelNouveauMdp.Size = new System.Drawing.Size(292, 31);
            this.labelNouveauMdp.TabIndex = 9;
            this.labelNouveauMdp.Text = "Nouveau mot de passe";
            // 
            // panelLigneSeparatrice
            // 
            this.panelLigneSeparatrice.BackColor = System.Drawing.SystemColors.WindowText;
            this.panelLigneSeparatrice.Location = new System.Drawing.Point(751, 160);
            this.panelLigneSeparatrice.Name = "panelLigneSeparatrice";
            this.panelLigneSeparatrice.Size = new System.Drawing.Size(5, 300);
            this.panelLigneSeparatrice.TabIndex = 10;
            // 
            // PageEditionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelLigneSeparatrice);
            this.Controls.Add(this.labelNouveauMdp);
            this.Controls.Add(this.labelNouveauLogin);
            this.Controls.Add(this.buttonRetourMenu);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.textBoxAvecTextInvisibleConfNewMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleNouveauMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdpInitial);
            this.Controls.Add(this.textBoxAvecTextInvisibleLogin);
            this.Controls.Add(this.labelEditionUser);
            this.Name = "PageEditionUser";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageEditionUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEdition)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEditionUser;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleLogin;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdpInitial;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleNouveauMdp;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleConfNewMdp;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.Button buttonRetourMenu;
        private System.Windows.Forms.ErrorProvider errorProviderEdition;
        private System.Windows.Forms.Panel panelLigneSeparatrice;
        private System.Windows.Forms.Label labelNouveauMdp;
        private System.Windows.Forms.Label labelNouveauLogin;
    }
}
