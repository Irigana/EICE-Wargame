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
            this.labelNouveauMdp = new System.Windows.Forms.Label();
            this.textBoxAvecTextInvisibleAncienMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
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
            this.textBoxAvecTextInvisibleConfNewMdp.Location = new System.Drawing.Point(608, 341);
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
            this.textBoxAvecTextInvisibleNouveauMdp.Location = new System.Drawing.Point(608, 292);
            this.textBoxAvecTextInvisibleNouveauMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleNouveauMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleNouveauMdp.Name = "textBoxAvecTextInvisibleNouveauMdp";
            this.textBoxAvecTextInvisibleNouveauMdp.PlaceHolder = "Nouveau mot de passe";
            this.textBoxAvecTextInvisibleNouveauMdp.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleNouveauMdp.TabIndex = 3;
            // 
            // labelNouveauMdp
            // 
            this.labelNouveauMdp.AutoSize = true;
            this.labelNouveauMdp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelNouveauMdp.Location = new System.Drawing.Point(603, 236);
            this.labelNouveauMdp.Name = "labelNouveauMdp";
            this.labelNouveauMdp.Size = new System.Drawing.Size(260, 29);
            this.labelNouveauMdp.TabIndex = 9;
            this.labelNouveauMdp.Text = "Nouveau mot de passe";
            // 
            // textBoxAvecTextInvisibleAncienMdp
            // 
            this.textBoxAvecTextInvisibleAncienMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleAncienMdp.Location = new System.Drawing.Point(608, 389);
            this.textBoxAvecTextInvisibleAncienMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleAncienMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleAncienMdp.Name = "textBoxAvecTextInvisibleAncienMdp";
            this.textBoxAvecTextInvisibleAncienMdp.PlaceHolder = "Ancien mot de passe";
            this.textBoxAvecTextInvisibleAncienMdp.Size = new System.Drawing.Size(314, 22);
            this.textBoxAvecTextInvisibleAncienMdp.TabIndex = 10;
            // 
            // PageEditionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxAvecTextInvisibleAncienMdp);
            this.Controls.Add(this.labelNouveauMdp);
            this.Controls.Add(this.buttonRetourMenu);
            this.Controls.Add(this.buttonValiderModif);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.textBoxAvecTextInvisibleConfNewMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleNouveauMdp);
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
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleNouveauMdp;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleConfNewMdp;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonValiderModif;
        private System.Windows.Forms.Button buttonRetourMenu;
        private System.Windows.Forms.ErrorProvider errorProviderEdition;
        private System.Windows.Forms.Label labelNouveauMdp;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleAncienMdp;
    }
}
