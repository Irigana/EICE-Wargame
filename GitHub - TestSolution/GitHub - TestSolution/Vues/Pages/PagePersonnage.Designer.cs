namespace EICE_WARGAME
{
    partial class PagePersonnage
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
            this.labelPersonnage = new System.Windows.Forms.Label();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSF = new System.Windows.Forms.Label();
            this.labelRechercheCaract = new System.Windows.Forms.Label();
            this.textBoxCaractere = new System.Windows.Forms.TextBox();
            this.buttonAnnulerPersonnage = new System.Windows.Forms.Button();
            this.buttonSupprimerPersonnage = new System.Windows.Forms.Button();
            this.buttonModifierPersonnage = new System.Windows.Forms.Button();
            this.buttonAjouterPersonnage = new System.Windows.Forms.Button();
            this.labelNouveauCaract = new System.Windows.Forms.Label();
            this.errorProviderErreurCaractere = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCaracteristiques = new System.Windows.Forms.Label();
            this.textBoxPersonnageSelectionne = new System.Windows.Forms.TextBox();
            this.labelPersonnageSelectionne = new System.Windows.Forms.Label();
            this.buttonAjouterCaracteristique = new System.Windows.Forms.Button();
            this.labelValeur = new System.Windows.Forms.Label();
            this.textBoxValeur = new System.Windows.Forms.TextBox();
            this.labelCaracteristique = new System.Windows.Forms.Label();
            this.labelCout = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.buttonModifCaracteristique = new System.Windows.Forms.Button();
            this.buttonSupprimerCaracteristique = new System.Windows.Forms.Button();
            this.labelRank = new System.Windows.Forms.Label();
            this.listeDeroulanteRank1 = new EICE_WARGAME.ListeDeroulanteRank();
            this.ficheCaracteristique1 = new EICE_WARGAME.FicheCaracteristique();
            this.listeDeroulanteFeature1 = new EICE_WARGAME.ListeDeroulanteFeature();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.ficheCaractere1 = new EICE_WARGAME.FicheCaractere();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreurCaractere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPersonnage
            // 
            this.labelPersonnage.AutoSize = true;
            this.labelPersonnage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelPersonnage.ForeColor = System.Drawing.Color.SlateGray;
            this.labelPersonnage.Location = new System.Drawing.Point(233, 20);
            this.labelPersonnage.Name = "labelPersonnage";
            this.labelPersonnage.Size = new System.Drawing.Size(235, 46);
            this.labelPersonnage.TabIndex = 2;
            this.labelPersonnage.Text = "Personnage";
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
            this.labelFaction.Location = new System.Drawing.Point(463, 105);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(65, 18);
            this.labelFaction.TabIndex = 35;
            this.labelFaction.Text = "Faction :";
            // 
            // labelSF
            // 
            this.labelSF.AutoSize = true;
            this.labelSF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSF.Location = new System.Drawing.Point(463, 169);
            this.labelSF.Name = "labelSF";
            this.labelSF.Size = new System.Drawing.Size(99, 18);
            this.labelSF.TabIndex = 36;
            this.labelSF.Text = "Sous faction :";
            // 
            // labelRechercheCaract
            // 
            this.labelRechercheCaract.AutoSize = true;
            this.labelRechercheCaract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRechercheCaract.Location = new System.Drawing.Point(876, 86);
            this.labelRechercheCaract.Name = "labelRechercheCaract";
            this.labelRechercheCaract.Size = new System.Drawing.Size(195, 18);
            this.labelRechercheCaract.TabIndex = 37;
            this.labelRechercheCaract.Text = "Rechercher un personnage :";
            // 
            // textBoxCaractere
            // 
            this.textBoxCaractere.Location = new System.Drawing.Point(466, 260);
            this.textBoxCaractere.Name = "textBoxCaractere";
            this.textBoxCaractere.Size = new System.Drawing.Size(248, 22);
            this.textBoxCaractere.TabIndex = 39;
            this.textBoxCaractere.Enter += new System.EventHandler(this.textBoxCaractere_Enter);
            this.textBoxCaractere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCaractere_KeyPress);
            // 
            // buttonAnnulerPersonnage
            // 
            this.buttonAnnulerPersonnage.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnulerPersonnage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerPersonnage.Location = new System.Drawing.Point(590, 355);
            this.buttonAnnulerPersonnage.Name = "buttonAnnulerPersonnage";
            this.buttonAnnulerPersonnage.Size = new System.Drawing.Size(121, 39);
            this.buttonAnnulerPersonnage.TabIndex = 43;
            this.buttonAnnulerPersonnage.Text = "Annuler";
            this.buttonAnnulerPersonnage.UseVisualStyleBackColor = false;
            this.buttonAnnulerPersonnage.Click += new System.EventHandler(this.buttonAnnulerCaract_Click);
            // 
            // buttonSupprimerPersonnage
            // 
            this.buttonSupprimerPersonnage.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerPersonnage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerPersonnage.Location = new System.Drawing.Point(717, 355);
            this.buttonSupprimerPersonnage.Name = "buttonSupprimerPersonnage";
            this.buttonSupprimerPersonnage.Size = new System.Drawing.Size(121, 39);
            this.buttonSupprimerPersonnage.TabIndex = 42;
            this.buttonSupprimerPersonnage.Text = "Supprimer";
            this.buttonSupprimerPersonnage.UseVisualStyleBackColor = false;
            this.buttonSupprimerPersonnage.Click += new System.EventHandler(this.buttonSupprimerCaract_Click);
            // 
            // buttonModifierPersonnage
            // 
            this.buttonModifierPersonnage.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifierPersonnage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierPersonnage.Location = new System.Drawing.Point(463, 355);
            this.buttonModifierPersonnage.Name = "buttonModifierPersonnage";
            this.buttonModifierPersonnage.Size = new System.Drawing.Size(121, 39);
            this.buttonModifierPersonnage.TabIndex = 41;
            this.buttonModifierPersonnage.Text = "Modifier";
            this.buttonModifierPersonnage.UseVisualStyleBackColor = false;
            this.buttonModifierPersonnage.Click += new System.EventHandler(this.buttonModifierCaract_Click);
            // 
            // buttonAjouterPersonnage
            // 
            this.buttonAjouterPersonnage.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterPersonnage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterPersonnage.Location = new System.Drawing.Point(336, 355);
            this.buttonAjouterPersonnage.Name = "buttonAjouterPersonnage";
            this.buttonAjouterPersonnage.Size = new System.Drawing.Size(121, 39);
            this.buttonAjouterPersonnage.TabIndex = 40;
            this.buttonAjouterPersonnage.Text = "Ajouter";
            this.buttonAjouterPersonnage.UseVisualStyleBackColor = false;
            this.buttonAjouterPersonnage.Click += new System.EventHandler(this.buttonAjouterCaract_Click);
            // 
            // labelNouveauCaract
            // 
            this.labelNouveauCaract.AutoSize = true;
            this.labelNouveauCaract.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNouveauCaract.Location = new System.Drawing.Point(463, 239);
            this.labelNouveauCaract.Name = "labelNouveauCaract";
            this.labelNouveauCaract.Size = new System.Drawing.Size(96, 18);
            this.labelNouveauCaract.TabIndex = 44;
            this.labelNouveauCaract.Text = "Personnage :";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(241, 411);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 3);
            this.panel1.TabIndex = 34;
            // 
            // labelCaracteristiques
            // 
            this.labelCaracteristiques.AutoSize = true;
            this.labelCaracteristiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelCaracteristiques.ForeColor = System.Drawing.Color.SlateGray;
            this.labelCaracteristiques.Location = new System.Drawing.Point(233, 417);
            this.labelCaracteristiques.Name = "labelCaracteristiques";
            this.labelCaracteristiques.Size = new System.Drawing.Size(308, 46);
            this.labelCaracteristiques.TabIndex = 33;
            this.labelCaracteristiques.Text = "Caracteristiques";
            // 
            // textBoxPersonnageSelectionne
            // 
            this.textBoxPersonnageSelectionne.Location = new System.Drawing.Point(336, 498);
            this.textBoxPersonnageSelectionne.Name = "textBoxPersonnageSelectionne";
            this.textBoxPersonnageSelectionne.ReadOnly = true;
            this.textBoxPersonnageSelectionne.Size = new System.Drawing.Size(246, 22);
            this.textBoxPersonnageSelectionne.TabIndex = 47;
            // 
            // labelPersonnageSelectionne
            // 
            this.labelPersonnageSelectionne.AutoSize = true;
            this.labelPersonnageSelectionne.Location = new System.Drawing.Point(333, 478);
            this.labelPersonnageSelectionne.Name = "labelPersonnageSelectionne";
            this.labelPersonnageSelectionne.Size = new System.Drawing.Size(169, 17);
            this.labelPersonnageSelectionne.TabIndex = 48;
            this.labelPersonnageSelectionne.Text = "Personnage sélectionné :";
            // 
            // buttonAjouterCaracteristique
            // 
            this.buttonAjouterCaracteristique.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterCaracteristique.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAjouterCaracteristique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterCaracteristique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonAjouterCaracteristique.Location = new System.Drawing.Point(336, 669);
            this.buttonAjouterCaracteristique.Name = "buttonAjouterCaracteristique";
            this.buttonAjouterCaracteristique.Size = new System.Drawing.Size(148, 49);
            this.buttonAjouterCaracteristique.TabIndex = 53;
            this.buttonAjouterCaracteristique.Text = "Ajouter Caracteristique";
            this.buttonAjouterCaracteristique.UseVisualStyleBackColor = false;
            // 
            // labelValeur
            // 
            this.labelValeur.AutoSize = true;
            this.labelValeur.Location = new System.Drawing.Point(622, 539);
            this.labelValeur.Name = "labelValeur";
            this.labelValeur.Size = new System.Drawing.Size(57, 17);
            this.labelValeur.TabIndex = 52;
            this.labelValeur.Text = "Valeur :";
            // 
            // textBoxValeur
            // 
            this.textBoxValeur.Enabled = false;
            this.textBoxValeur.Location = new System.Drawing.Point(625, 559);
            this.textBoxValeur.Name = "textBoxValeur";
            this.textBoxValeur.Size = new System.Drawing.Size(230, 22);
            this.textBoxValeur.TabIndex = 51;
            // 
            // labelCaracteristique
            // 
            this.labelCaracteristique.AutoSize = true;
            this.labelCaracteristique.Location = new System.Drawing.Point(622, 475);
            this.labelCaracteristique.Name = "labelCaracteristique";
            this.labelCaracteristique.Size = new System.Drawing.Size(111, 17);
            this.labelCaracteristique.TabIndex = 49;
            this.labelCaracteristique.Text = "Caractéristique :";
            // 
            // labelCout
            // 
            this.labelCout.AutoSize = true;
            this.labelCout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelCout.Location = new System.Drawing.Point(333, 597);
            this.labelCout.Name = "labelCout";
            this.labelCout.Size = new System.Drawing.Size(48, 18);
            this.labelCout.TabIndex = 56;
            this.labelCout.Text = "Coût :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(336, 618);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(246, 22);
            this.numericUpDown1.TabIndex = 57;
            // 
            // buttonModifCaracteristique
            // 
            this.buttonModifCaracteristique.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifCaracteristique.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonModifCaracteristique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifCaracteristique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonModifCaracteristique.Location = new System.Drawing.Point(510, 669);
            this.buttonModifCaracteristique.Name = "buttonModifCaracteristique";
            this.buttonModifCaracteristique.Size = new System.Drawing.Size(148, 49);
            this.buttonModifCaracteristique.TabIndex = 58;
            this.buttonModifCaracteristique.Text = "Modifier Caracteristique";
            this.buttonModifCaracteristique.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimerCaracteristique
            // 
            this.buttonSupprimerCaracteristique.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerCaracteristique.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonSupprimerCaracteristique.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerCaracteristique.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSupprimerCaracteristique.Location = new System.Drawing.Point(684, 669);
            this.buttonSupprimerCaracteristique.Name = "buttonSupprimerCaracteristique";
            this.buttonSupprimerCaracteristique.Size = new System.Drawing.Size(148, 49);
            this.buttonSupprimerCaracteristique.TabIndex = 59;
            this.buttonSupprimerCaracteristique.Text = "Supprimer Caracteristique";
            this.buttonSupprimerCaracteristique.UseVisualStyleBackColor = false;
            // 
            // labelRank
            // 
            this.labelRank.AutoSize = true;
            this.labelRank.Location = new System.Drawing.Point(333, 539);
            this.labelRank.Name = "labelRank";
            this.labelRank.Size = new System.Drawing.Size(49, 17);
            this.labelRank.TabIndex = 61;
            this.labelRank.Text = "Rank :";
            // 
            // listeDeroulanteRank1
            // 
            this.listeDeroulanteRank1.Location = new System.Drawing.Point(336, 559);
            this.listeDeroulanteRank1.Name = "listeDeroulanteRank1";
            this.listeDeroulanteRank1.RankSelectionnee = null;
            this.listeDeroulanteRank1.Size = new System.Drawing.Size(246, 26);
            this.listeDeroulanteRank1.TabIndex = 62;
            // 
            // ficheCaracteristique1
            // 
            this.ficheCaracteristique1.CaracteristiqueSelectionne = null;
            this.ficheCaracteristique1.Location = new System.Drawing.Point(879, 456);
            this.ficheCaracteristique1.Name = "ficheCaracteristique1";
            this.ficheCaracteristique1.Size = new System.Drawing.Size(284, 262);
            this.ficheCaracteristique1.TabIndex = 60;
            // 
            // listeDeroulanteFeature1
            // 
            this.listeDeroulanteFeature1.FeatureSelectionnee = null;
            this.listeDeroulanteFeature1.Location = new System.Drawing.Point(625, 495);
            this.listeDeroulanteFeature1.Name = "listeDeroulanteFeature1";
            this.listeDeroulanteFeature1.Size = new System.Drawing.Size(230, 25);
            this.listeDeroulanteFeature1.TabIndex = 50;
            // 
            // buttonRetourDashBoard1
            // 
            this.buttonRetourDashBoard1.Location = new System.Drawing.Point(196, 3);
            this.buttonRetourDashBoard1.Name = "buttonRetourDashBoard1";
            this.buttonRetourDashBoard1.Size = new System.Drawing.Size(44, 34);
            this.buttonRetourDashBoard1.TabIndex = 46;
            this.buttonRetourDashBoard1.Utilisateur = null;
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
            // ficheCaractere1
            // 
            this.ficheCaractere1.CaractereSelectionne = null;
            this.ficheCaractere1.Location = new System.Drawing.Point(879, 107);
            this.ficheCaractere1.Name = "ficheCaractere1";
            this.ficheCaractere1.Size = new System.Drawing.Size(298, 287);
            this.ficheCaractere1.TabIndex = 38;
            this.ficheCaractere1.TexteDuFiltre = "";
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Enabled = false;
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(466, 190);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(248, 25);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 34;
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(466, 126);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(248, 25);
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
            // PagePersonnage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listeDeroulanteRank1);
            this.Controls.Add(this.labelRank);
            this.Controls.Add(this.ficheCaracteristique1);
            this.Controls.Add(this.buttonSupprimerCaracteristique);
            this.Controls.Add(this.buttonModifCaracteristique);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.labelCout);
            this.Controls.Add(this.buttonAjouterCaracteristique);
            this.Controls.Add(this.labelValeur);
            this.Controls.Add(this.textBoxValeur);
            this.Controls.Add(this.listeDeroulanteFeature1);
            this.Controls.Add(this.labelCaracteristique);
            this.Controls.Add(this.labelPersonnageSelectionne);
            this.Controls.Add(this.textBoxPersonnageSelectionne);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelCaracteristiques);
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.labelNouveauCaract);
            this.Controls.Add(this.buttonAnnulerPersonnage);
            this.Controls.Add(this.buttonSupprimerPersonnage);
            this.Controls.Add(this.buttonModifierPersonnage);
            this.Controls.Add(this.buttonAjouterPersonnage);
            this.Controls.Add(this.textBoxCaractere);
            this.Controls.Add(this.ficheCaractere1);
            this.Controls.Add(this.labelRechercheCaract);
            this.Controls.Add(this.labelSF);
            this.Controls.Add(this.labelFaction);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelPersonnage);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Name = "PagePersonnage";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageCaractere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreurCaractere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Label labelPersonnage;
        private System.Windows.Forms.Panel panelLigne;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Label labelSF;
        private System.Windows.Forms.Label labelRechercheCaract;
        private FicheCaractere ficheCaractere1;
        private System.Windows.Forms.TextBox textBoxCaractere;
        private System.Windows.Forms.Button buttonAnnulerPersonnage;
        private System.Windows.Forms.Button buttonSupprimerPersonnage;
        private System.Windows.Forms.Button buttonModifierPersonnage;
        private System.Windows.Forms.Button buttonAjouterPersonnage;
        private System.Windows.Forms.Label labelNouveauCaract;
        private System.Windows.Forms.ErrorProvider errorProviderErreurCaractere;
        private System.Windows.Forms.ErrorProvider ValidationProvider;
        private MenuAdmin menuAdmin1;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCaracteristiques;
        private System.Windows.Forms.TextBox textBoxPersonnageSelectionne;
        private System.Windows.Forms.Label labelPersonnageSelectionne;
        private System.Windows.Forms.Button buttonAjouterCaracteristique;
        private System.Windows.Forms.Label labelValeur;
        private System.Windows.Forms.TextBox textBoxValeur;
        private ListeDeroulanteFeature listeDeroulanteFeature1;
        private System.Windows.Forms.Label labelCaracteristique;
        private System.Windows.Forms.Button buttonSupprimerCaracteristique;
        private System.Windows.Forms.Button buttonModifCaracteristique;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelCout;
        private FicheCaracteristique ficheCaracteristique1;
        private System.Windows.Forms.Label labelRank;
        private ListeDeroulanteRank listeDeroulanteRank1;
    }
}
