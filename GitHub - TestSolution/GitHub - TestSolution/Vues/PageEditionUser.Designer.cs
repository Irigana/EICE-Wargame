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
            this.textBoxAvecTextInvisibleLogin = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleMdpInitial = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleNouveauMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleConfNewMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.buttonValiderModif = new System.Windows.Forms.Button();
            this.buttonRetourMenu = new System.Windows.Forms.Button();
            this.errorProviderEdition = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEdition)).BeginInit();
            this.SuspendLayout();
            // 
            // labelEditionUser
            // 
            this.labelEditionUser.AutoSize = true;
            this.labelEditionUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.labelEditionUser.Location = new System.Drawing.Point(693, 194);
            this.labelEditionUser.Name = "labelEditionUser";
            this.labelEditionUser.Size = new System.Drawing.Size(323, 52);
            this.labelEditionUser.TabIndex = 0;
            this.labelEditionUser.Text = "Edition du profil";
            // 
            // textBoxAvecTextInvisibleLogin
            // 
            this.textBoxAvecTextInvisibleLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleLogin.Location = new System.Drawing.Point(702, 298);
            this.textBoxAvecTextInvisibleLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleLogin.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleLogin.Name = "textBoxAvecTextInvisibleLogin";
            this.textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            this.textBoxAvecTextInvisibleLogin.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleLogin.TabIndex = 1;
            // 
            // textBoxAvecTextInvisibleMdpInitial
            // 
            this.textBoxAvecTextInvisibleMdpInitial.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdpInitial.Location = new System.Drawing.Point(702, 345);
            this.textBoxAvecTextInvisibleMdpInitial.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdpInitial.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleMdpInitial.Name = "textBoxAvecTextInvisibleMdpInitial";
            this.textBoxAvecTextInvisibleMdpInitial.PlaceHolder = "Mot de passe actuel";
            this.textBoxAvecTextInvisibleMdpInitial.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleMdpInitial.TabIndex = 2;
            // 
            // textBoxAvecTextInvisibleNouveauMdp
            // 
            this.textBoxAvecTextInvisibleNouveauMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleNouveauMdp.Location = new System.Drawing.Point(702, 390);
            this.textBoxAvecTextInvisibleNouveauMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleNouveauMdp.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleNouveauMdp.Name = "textBoxAvecTextInvisibleNouveauMdp";
            this.textBoxAvecTextInvisibleNouveauMdp.PlaceHolder = "Nouveau mot de passe";
            this.textBoxAvecTextInvisibleNouveauMdp.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleNouveauMdp.TabIndex = 3;
            // 
            // textBoxAvecTextInvisibleConfNewMdp
            // 
            this.textBoxAvecTextInvisibleConfNewMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleConfNewMdp.Location = new System.Drawing.Point(702, 439);
            this.textBoxAvecTextInvisibleConfNewMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleConfNewMdp.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleConfNewMdp.Name = "textBoxAvecTextInvisibleConfNewMdp";
            this.textBoxAvecTextInvisibleConfNewMdp.PlaceHolder = "Confirmation nouveau mot de passe";
            this.textBoxAvecTextInvisibleConfNewMdp.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleConfNewMdp.TabIndex = 4;
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 5;
            // 
            // buttonValiderModif
            // 
            this.buttonValiderModif.BackColor = System.Drawing.SystemColors.Window;
            this.buttonValiderModif.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonValiderModif.FlatAppearance.BorderSize = 2;
            this.buttonValiderModif.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonValiderModif.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonValiderModif.Location = new System.Drawing.Point(702, 490);
            this.buttonValiderModif.Name = "buttonValiderModif";
            this.buttonValiderModif.Size = new System.Drawing.Size(314, 36);
            this.buttonValiderModif.TabIndex = 6;
            this.buttonValiderModif.Text = "Valider les modifications";
            this.buttonValiderModif.UseVisualStyleBackColor = false;
            // 
            // buttonRetourMenu
            // 
            this.buttonRetourMenu.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRetourMenu.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRetourMenu.FlatAppearance.BorderSize = 2;
            this.buttonRetourMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetourMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonRetourMenu.Location = new System.Drawing.Point(702, 542);
            this.buttonRetourMenu.Name = "buttonRetourMenu";
            this.buttonRetourMenu.Size = new System.Drawing.Size(314, 36);
            this.buttonRetourMenu.TabIndex = 7;
            this.buttonRetourMenu.Text = "Menu principal";
            this.buttonRetourMenu.UseVisualStyleBackColor = false;
            // 
            // errorProviderEdition
            // 
            this.errorProviderEdition.ContainerControl = this;
            // 
            // PageEditionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
    }
}
