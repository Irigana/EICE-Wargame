namespace EICE_WARGAME
{
    partial class PageCaractere
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
            this.labelCaractere = new System.Windows.Forms.Label();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelRechercheCaract = new System.Windows.Forms.Label();
            this.textBoxCaractere = new System.Windows.Forms.TextBox();
            this.buttonAnnulerCaract = new System.Windows.Forms.Button();
            this.buttonSupprimerCaract = new System.Windows.Forms.Button();
            this.buttonModifierCaract = new System.Windows.Forms.Button();
            this.buttonAjouterCaract = new System.Windows.Forms.Button();
            this.labelNouveauCaract = new System.Windows.Forms.Label();
            this.errorProviderErreurCaractere = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ficheCaractere1 = new EICE_WARGAME.FicheCaractere();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreurCaractere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCaractere
            // 
            this.labelCaractere.AutoSize = true;
            this.labelCaractere.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelCaractere.ForeColor = System.Drawing.Color.SlateGray;
            this.labelCaractere.Location = new System.Drawing.Point(233, 20);
            this.labelCaractere.Name = "labelCaractere";
            this.labelCaractere.Size = new System.Drawing.Size(215, 46);
            this.labelCaractere.TabIndex = 2;
            this.labelCaractere.Text = "Caractères";
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.ForeColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 32;
            // 
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFaction.Location = new System.Drawing.Point(600, 132);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(65, 18);
            this.labelFaction.TabIndex = 35;
            this.labelFaction.Text = "Faction :";
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSF.Location = new System.Drawing.Point(600, 187);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(99, 18);
            this.labelSF.TabIndex = 36;
            this.labelSF.Text = "Sous faction :";
            // 
            // labelRechercheCaract
            // 
            this.labelRechercheCaract.AutoSize = true;
            this.labelRechercheCaract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRechercheCaract.Location = new System.Drawing.Point(923, 132);
            this.labelRechercheCaract.Name = "labelRechercheCaract";
            this.labelRechercheCaract.Size = new System.Drawing.Size(179, 18);
            this.labelRechercheCaract.TabIndex = 37;
            this.labelRechercheCaract.Text = "Rechercher un caractère :";
            // 
            // textBoxCaractere
            // 
            this.textBoxCaractere.Location = new System.Drawing.Point(603, 274);
            this.textBoxCaractere.Name = "textBoxCaractere";
            this.textBoxCaractere.Size = new System.Drawing.Size(286, 22);
            this.textBoxCaractere.TabIndex = 39;
            this.textBoxCaractere.Enter += new System.EventHandler(this.textBoxCaractere_Enter);
            this.textBoxCaractere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCaractere_KeyPress);
            // 
            // buttonAnnulerCaract
            // 
            this.buttonAnnulerCaract.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnulerCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerCaract.Location = new System.Drawing.Point(894, 484);
            this.buttonAnnulerCaract.Name = "buttonAnnulerCaract";
            this.buttonAnnulerCaract.Size = new System.Drawing.Size(121, 39);
            this.buttonAnnulerCaract.TabIndex = 43;
            this.buttonAnnulerCaract.Text = "Annuler";
            this.buttonAnnulerCaract.UseVisualStyleBackColor = false;
            this.buttonAnnulerCaract.Click += new System.EventHandler(this.buttonAnnulerCaract_Click);
            // 
            // buttonSupprimerCaract
            // 
            this.buttonSupprimerCaract.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerCaract.Location = new System.Drawing.Point(1021, 484);
            this.buttonSupprimerCaract.Name = "buttonSupprimerCaract";
            this.buttonSupprimerCaract.Size = new System.Drawing.Size(121, 39);
            this.buttonSupprimerCaract.TabIndex = 42;
            this.buttonSupprimerCaract.Text = "Supprimer";
            this.buttonSupprimerCaract.UseVisualStyleBackColor = false;
            this.buttonSupprimerCaract.Click += new System.EventHandler(this.buttonSupprimerCaract_Click);
            // 
            // buttonModifierCaract
            // 
            this.buttonModifierCaract.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifierCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierCaract.Location = new System.Drawing.Point(767, 484);
            this.buttonModifierCaract.Name = "buttonModifierCaract";
            this.buttonModifierCaract.Size = new System.Drawing.Size(121, 39);
            this.buttonModifierCaract.TabIndex = 41;
            this.buttonModifierCaract.Text = "Modifier";
            this.buttonModifierCaract.UseVisualStyleBackColor = false;
            this.buttonModifierCaract.Click += new System.EventHandler(this.buttonModifierCaract_Click);
            // 
            // buttonAjouterCaract
            // 
            this.buttonAjouterCaract.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterCaract.Location = new System.Drawing.Point(640, 484);
            this.buttonAjouterCaract.Name = "buttonAjouterCaract";
            this.buttonAjouterCaract.Size = new System.Drawing.Size(121, 39);
            this.buttonAjouterCaract.TabIndex = 40;
            this.buttonAjouterCaract.Text = "Ajouter";
            this.buttonAjouterCaract.UseVisualStyleBackColor = false;
            this.buttonAjouterCaract.Click += new System.EventHandler(this.buttonAjouterCaract_Click);
            // 
            // labelNouveauCaract
            // 
            this.labelNouveauCaract.AutoSize = true;
            this.labelNouveauCaract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNouveauCaract.Location = new System.Drawing.Point(600, 253);
            this.labelNouveauCaract.Name = "labelNouveauCaract";
            this.labelNouveauCaract.Size = new System.Drawing.Size(141, 18);
            this.labelNouveauCaract.TabIndex = 44;
            this.labelNouveauCaract.Text = "Nouveau caractère :";
            // 
            // errorProviderErreurCaractere
            // 
            this.errorProviderErreurCaractere.BlinkRate = 0;
            this.errorProviderErreurCaractere.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderErreurCaractere.ContainerControl = this;
            // 
            // ValidationProvider
            // 
            this.ValidationProvider.BlinkRate = 0;
            this.ValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ValidationProvider.ContainerControl = this;
            // 
            // ficheCaractere1
            // 
            this.ficheCaractere1.CaractereSelectionne = null;
            this.ficheCaractere1.Location = new System.Drawing.Point(926, 153);
            this.ficheCaractere1.Name = "ficheCaractere1";
            this.ficheCaractere1.Size = new System.Drawing.Size(298, 287);
            this.ficheCaractere1.TabIndex = 38;
            this.ficheCaractere1.TexteDuFiltre = "";
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Enabled = false;
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(603, 208);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(286, 25);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 34;
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(603, 153);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(286, 25);
            this.listeDeroulanteFaction1.TabIndex = 33;
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
            this.menuAdmin1.TabIndex = 45;
            this.menuAdmin1.Utilisateur = null;
            // 
            // PageCaractere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.labelNouveauCaract);
            this.Controls.Add(this.buttonAnnulerCaract);
            this.Controls.Add(this.buttonSupprimerCaract);
            this.Controls.Add(this.buttonModifierCaract);
            this.Controls.Add(this.buttonAjouterCaract);
            this.Controls.Add(this.textBoxCaractere);
            this.Controls.Add(this.ficheCaractere1);
            this.Controls.Add(this.labelRechercheCaract);
            this.Controls.Add(this.labelSF);
            this.Controls.Add(this.labelFaction);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelCaractere);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Name = "PageCaractere";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageCaractere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreurCaractere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Label labelCaractere;
        private System.Windows.Forms.Panel panelLigne;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelRechercheCaract;
        private FicheCaractere ficheCaractere1;
        private System.Windows.Forms.TextBox textBoxCaractere;
        private System.Windows.Forms.Button buttonAnnulerCaract;
        private System.Windows.Forms.Button buttonSupprimerCaract;
        private System.Windows.Forms.Button buttonModifierCaract;
        private System.Windows.Forms.Button buttonAjouterCaract;
        private System.Windows.Forms.Label labelNouveauCaract;
        private System.Windows.Forms.ErrorProvider errorProviderErreurCaractere;
        private System.Windows.Forms.ErrorProvider ValidationProvider;
        private MenuAdmin menuAdmin1;
    }
}
