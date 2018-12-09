namespace EICE_WARGAME
{
    partial class PageEquipements
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
            this.labelCRUDArmes = new System.Windows.Forms.Label();
            this.panelLigneSeparatriceAjout = new System.Windows.Forms.Panel();
            this.labelNomEquipement = new System.Windows.Forms.Label();
            this.labelTypeArme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.checkBoxVisibility = new System.Windows.Forms.CheckBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxNomEquipement = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxValeur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAjouterCaract = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewCaracteristiques = new System.Windows.Forms.ListView();
            this.ficheEquipement1 = new EICE_WARGAME.FicheEquipement();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.listeDeroulanteStuff1 = new EICE_WARGAME.ListeDeroulanteStuff();
            this.listeDeroulanteFeature1 = new EICE_WARGAME.ListeDeroulanteFeature();
            this.listeDeroulanteType = new EICE_WARGAME.ListeDeroulanteType();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.listBoxCharacter1 = new EICE_WARGAME.ListBoxCharacter();
            this.listBoxEquipablePar = new System.Windows.Forms.ListBox();
            this.buttonAjouterEquipable = new System.Windows.Forms.Button();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.fichePersonnageEquipement1 = new EICE_WARGAME.FichePersonnageEquipement();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCRUDArmes
            // 
            this.labelCRUDArmes.AutoSize = true;
            this.labelCRUDArmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelCRUDArmes.ForeColor = System.Drawing.Color.SlateGray;
            this.labelCRUDArmes.Location = new System.Drawing.Point(242, 26);
            this.labelCRUDArmes.Name = "labelCRUDArmes";
            this.labelCRUDArmes.Size = new System.Drawing.Size(188, 36);
            this.labelCRUDArmes.TabIndex = 1;
            this.labelCRUDArmes.Text = "Equipements";
            // 
            // panelLigneSeparatriceAjout
            // 
            this.panelLigneSeparatriceAjout.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigneSeparatriceAjout.Location = new System.Drawing.Point(219, 75);
            this.panelLigneSeparatriceAjout.Name = "panelLigneSeparatriceAjout";
            this.panelLigneSeparatriceAjout.Size = new System.Drawing.Size(1250, 3);
            this.panelLigneSeparatriceAjout.TabIndex = 2;
            // 
            // labelNomEquipement
            // 
            this.labelNomEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNomEquipement.Location = new System.Drawing.Point(244, 171);
            this.labelNomEquipement.Name = "labelNomEquipement";
            this.labelNomEquipement.Size = new System.Drawing.Size(150, 20);
            this.labelNomEquipement.TabIndex = 3;
            this.labelNomEquipement.Text = "Nom";
            this.labelNomEquipement.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // labelTypeArme
            // 
            this.labelTypeArme.AutoSize = true;
            this.labelTypeArme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTypeArme.Location = new System.Drawing.Point(344, 125);
            this.labelTypeArme.Name = "labelTypeArme";
            this.labelTypeArme.Size = new System.Drawing.Size(45, 20);
            this.labelTypeArme.TabIndex = 5;
            this.labelTypeArme.Text = "Type";
            this.labelTypeArme.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(219, 426);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 3);
            this.panel1.TabIndex = 7;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouter.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAjouter.Location = new System.Drawing.Point(248, 367);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(84, 40);
            this.buttonAjouter.TabIndex = 18;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifier.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonModifier.Location = new System.Drawing.Point(338, 367);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(92, 40);
            this.buttonModifier.TabIndex = 22;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSupprimer.Location = new System.Drawing.Point(536, 367);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(95, 40);
            this.buttonSupprimer.TabIndex = 23;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // checkBoxVisibility
            // 
            this.checkBoxVisibility.AutoSize = true;
            this.checkBoxVisibility.Location = new System.Drawing.Point(400, 210);
            this.checkBoxVisibility.Name = "checkBoxVisibility";
            this.checkBoxVisibility.Size = new System.Drawing.Size(71, 21);
            this.checkBoxVisibility.TabIndex = 24;
            this.checkBoxVisibility.Text = "Visible";
            this.checkBoxVisibility.UseVisualStyleBackColor = true;
            this.checkBoxVisibility.CheckedChanged += new System.EventHandler(this.checkBoxVisibility_CheckedChanged);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAnnuler.Location = new System.Drawing.Point(436, 367);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(94, 40);
            this.buttonAnnuler.TabIndex = 25;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // textBoxNomEquipement
            // 
            this.textBoxNomEquipement.Location = new System.Drawing.Point(400, 169);
            this.textBoxNomEquipement.Name = "textBoxNomEquipement";
            this.textBoxNomEquipement.Size = new System.Drawing.Size(197, 22);
            this.textBoxNomEquipement.TabIndex = 26;
            this.textBoxNomEquipement.Enter += new System.EventHandler(this.textBoxNomEquipement_Enter);
            this.textBoxNomEquipement.Leave += new System.EventHandler(this.textBoxNomEquipement_Leave);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(949, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Caractéristique";
            // 
            // textBoxValeur
            // 
            this.textBoxValeur.Location = new System.Drawing.Point(1072, 208);
            this.textBoxValeur.Name = "textBoxValeur";
            this.textBoxValeur.Size = new System.Drawing.Size(206, 22);
            this.textBoxValeur.TabIndex = 29;
            this.textBoxValeur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1003, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Valeur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(949, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Equipement";
            // 
            // buttonAjouterCaract
            // 
            this.buttonAjouterCaract.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterCaract.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAjouterCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterCaract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonAjouterCaract.Location = new System.Drawing.Point(1308, 181);
            this.buttonAjouterCaract.Name = "buttonAjouterCaract";
            this.buttonAjouterCaract.Size = new System.Drawing.Size(148, 49);
            this.buttonAjouterCaract.TabIndex = 33;
            this.buttonAjouterCaract.Text = "Ajouter Caracteristique";
            this.buttonAjouterCaract.UseVisualStyleBackColor = false;
            this.buttonAjouterCaract.Click += new System.EventHandler(this.buttonAjouterCaract_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(243, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Nouvel équipement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.SlateGray;
            this.label5.Location = new System.Drawing.Point(936, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 25);
            this.label5.TabIndex = 35;
            this.label5.Text = "Caractéristiques";
            // 
            // listViewCaracteristiques
            // 
            this.listViewCaracteristiques.Location = new System.Drawing.Point(1072, 247);
            this.listViewCaracteristiques.Name = "listViewCaracteristiques";
            this.listViewCaracteristiques.Size = new System.Drawing.Size(370, 151);
            this.listViewCaracteristiques.TabIndex = 36;
            this.listViewCaracteristiques.UseCompatibleStateImageBehavior = false;
            // 
            // ficheEquipement1
            // 
            this.ficheEquipement1.EquipementSelectionne = null;
            this.ficheEquipement1.Location = new System.Drawing.Point(645, 125);
            this.ficheEquipement1.Name = "ficheEquipement1";
            this.ficheEquipement1.Size = new System.Drawing.Size(290, 295);
            this.ficheEquipement1.TabIndex = 39;
            this.ficheEquipement1.TexteFiltreEquipement = "";
            // 
            // buttonRetourDashBoard1
            // 
            this.buttonRetourDashBoard1.Location = new System.Drawing.Point(196, 3);
            this.buttonRetourDashBoard1.Name = "buttonRetourDashBoard1";
            this.buttonRetourDashBoard1.Size = new System.Drawing.Size(44, 34);
            this.buttonRetourDashBoard1.TabIndex = 38;
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
            this.menuAdmin1.TabIndex = 37;
            this.menuAdmin1.Utilisateur = null;
            // 
            // listeDeroulanteStuff1
            // 
            this.listeDeroulanteStuff1.Location = new System.Drawing.Point(1072, 129);
            this.listeDeroulanteStuff1.Name = "listeDeroulanteStuff1";
            this.listeDeroulanteStuff1.Size = new System.Drawing.Size(206, 26);
            this.listeDeroulanteStuff1.StuffSelectionnee = null;
            this.listeDeroulanteStuff1.TabIndex = 32;
            // 
            // listeDeroulanteFeature1
            // 
            this.listeDeroulanteFeature1.FeatureSelectionnee = null;
            this.listeDeroulanteFeature1.Location = new System.Drawing.Point(1072, 171);
            this.listeDeroulanteFeature1.Name = "listeDeroulanteFeature1";
            this.listeDeroulanteFeature1.Size = new System.Drawing.Size(206, 25);
            this.listeDeroulanteFeature1.TabIndex = 28;
            // 
            // listeDeroulanteType
            // 
            this.listeDeroulanteType.Location = new System.Drawing.Point(400, 125);
            this.listeDeroulanteType.Name = "listeDeroulanteType";
            this.listeDeroulanteType.Size = new System.Drawing.Size(197, 25);
            this.listeDeroulanteType.TabIndex = 17;
            this.listeDeroulanteType.TypeSelectionne = null;
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 16;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // listBoxCharacter1
            // 
            this.listBoxCharacter1.CharactSelectionnee = null;
            this.listBoxCharacter1.Location = new System.Drawing.Point(603, 476);
            this.listBoxCharacter1.Name = "listBoxCharacter1";
            this.listBoxCharacter1.Size = new System.Drawing.Size(320, 260);
            this.listBoxCharacter1.TabIndex = 40;
            // 
            // listBoxEquipablePar
            // 
            this.listBoxEquipablePar.FormattingEnabled = true;
            this.listBoxEquipablePar.ItemHeight = 16;
            this.listBoxEquipablePar.Location = new System.Drawing.Point(307, 567);
            this.listBoxEquipablePar.Name = "listBoxEquipablePar";
            this.listBoxEquipablePar.Size = new System.Drawing.Size(290, 132);
            this.listBoxEquipablePar.TabIndex = 41;
            // 
            // buttonAjouterEquipable
            // 
            this.buttonAjouterEquipable.Location = new System.Drawing.Point(957, 481);
            this.buttonAjouterEquipable.Name = "buttonAjouterEquipable";
            this.buttonAjouterEquipable.Size = new System.Drawing.Size(75, 23);
            this.buttonAjouterEquipable.TabIndex = 42;
            this.buttonAjouterEquipable.Text = "Lier";
            this.buttonAjouterEquipable.UseVisualStyleBackColor = true;
            this.buttonAjouterEquipable.Click += new System.EventHandler(this.buttonAjouterEquipable_Click);
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(399, 476);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(198, 22);
            this.listeDeroulanteFaction1.TabIndex = 43;
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(399, 513);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(198, 25);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.SlateGray;
            this.label6.Location = new System.Drawing.Point(244, 442);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 25);
            this.label6.TabIndex = 45;
            this.label6.Text = "Equipable par";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(322, 481);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 46;
            this.label7.Text = "Faction";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(285, 521);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Sous-Faction";
            // 
            // fichePersonnageEquipement1
            // 
            this.fichePersonnageEquipement1.CaractereSelectionne = null;
            this.fichePersonnageEquipement1.Location = new System.Drawing.Point(1072, 476);
            this.fichePersonnageEquipement1.Name = "fichePersonnageEquipement1";
            this.fichePersonnageEquipement1.Size = new System.Drawing.Size(400, 260);
            this.fichePersonnageEquipement1.TabIndex = 48;
            // 
            // PageEquipements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.fichePersonnageEquipement1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.buttonAjouterEquipable);
            this.Controls.Add(this.listBoxEquipablePar);
            this.Controls.Add(this.listBoxCharacter1);
            this.Controls.Add(this.ficheEquipement1);
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.listViewCaracteristiques);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAjouterCaract);
            this.Controls.Add(this.listeDeroulanteStuff1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxValeur);
            this.Controls.Add(this.listeDeroulanteFeature1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomEquipement);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.checkBoxVisibility);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listeDeroulanteType);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTypeArme);
            this.Controls.Add(this.labelNomEquipement);
            this.Controls.Add(this.panelLigneSeparatriceAjout);
            this.Controls.Add(this.labelCRUDArmes);
            this.Name = "PageEquipements";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageAjouterEquipements_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelCRUDArmes;
        private System.Windows.Forms.Panel panelLigneSeparatriceAjout;
        private System.Windows.Forms.Label labelNomEquipement;
        private System.Windows.Forms.Label labelTypeArme;
        private System.Windows.Forms.Panel panel1;
        private ButtonOptionsUser buttonOptionsUser1;
        private ListeDeroulanteType listeDeroulanteType;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.CheckBox checkBoxVisibility;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxNomEquipement;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValeur;
        private ListeDeroulanteFeature listeDeroulanteFeature1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ListeDeroulanteStuff listeDeroulanteStuff1;
        private System.Windows.Forms.Button buttonAjouterCaract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewCaracteristiques;
        private MenuAdmin menuAdmin1;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
        private FicheEquipement ficheEquipement1;
        private ListBoxCharacter listBoxCharacter1;
        private System.Windows.Forms.ListBox listBoxEquipablePar;
        private System.Windows.Forms.Button buttonAjouterEquipable;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private FichePersonnageEquipement fichePersonnageEquipement1;
    }
}
