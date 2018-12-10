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
            this.q_buttonAjouter = new System.Windows.Forms.Button();
            this.q_buttonModifier = new System.Windows.Forms.Button();
            this.q_buttonSupprimer = new System.Windows.Forms.Button();
            this.z_checkBoxVisibility = new System.Windows.Forms.CheckBox();
            this.q_buttonAnnuler = new System.Windows.Forms.Button();
            this.z_textBoxNomEquipement = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.z_textBoxValeur = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.q_buttonAjouterCaract = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listViewCaracteristiques = new System.Windows.Forms.ListView();
            this.z_ficheEquipement = new EICE_WARGAME.FicheEquipement();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.z_listeDeroulanteStuff = new EICE_WARGAME.ListeDeroulanteStuff();
            this.z_listeDeroulanteFeature = new EICE_WARGAME.ListeDeroulanteFeature();
            this.z_listeDeroulanteType = new EICE_WARGAME.ListeDeroulanteType();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.q_buttonAjouterEquipable = new System.Windows.Forms.Button();
            this.z_listeDeroulanteFaction = new EICE_WARGAME.ListeDeroulanteFaction();
            this.z_listeDeroulanteSousFaction = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.z_fichePersonnageEquipement1 = new EICE_WARGAME.FichePersonnageEquipement();
            this.label9 = new System.Windows.Forms.Label();
            this.z_listeDeroulanteCharRank = new EICE_WARGAME.ListeDeroulanteCharRank();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.z_numericUpDownCout = new System.Windows.Forms.NumericUpDown();
            this.z_numericUpDownMinimum = new System.Windows.Forms.NumericUpDown();
            this.z_numericUpDownMaximum = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.z_listeDeroulanteUnity = new EICE_WARGAME.ListeDeroulanteUnity();
            this.z_listeDeroulanteSubUnity = new EICE_WARGAME.ListeDeroulanteSubUnity();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_numericUpDownCout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_numericUpDownMinimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_numericUpDownMaximum)).BeginInit();
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
            // q_buttonAjouter
            // 
            this.q_buttonAjouter.BackColor = System.Drawing.SystemColors.Window;
            this.q_buttonAjouter.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.q_buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q_buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.q_buttonAjouter.Location = new System.Drawing.Point(248, 367);
            this.q_buttonAjouter.Name = "q_buttonAjouter";
            this.q_buttonAjouter.Size = new System.Drawing.Size(84, 40);
            this.q_buttonAjouter.TabIndex = 18;
            this.q_buttonAjouter.Text = "Ajouter";
            this.q_buttonAjouter.UseVisualStyleBackColor = false;
            this.q_buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // q_buttonModifier
            // 
            this.q_buttonModifier.BackColor = System.Drawing.SystemColors.Window;
            this.q_buttonModifier.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.q_buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q_buttonModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.q_buttonModifier.Location = new System.Drawing.Point(338, 367);
            this.q_buttonModifier.Name = "q_buttonModifier";
            this.q_buttonModifier.Size = new System.Drawing.Size(92, 40);
            this.q_buttonModifier.TabIndex = 22;
            this.q_buttonModifier.Text = "Modifier";
            this.q_buttonModifier.UseVisualStyleBackColor = false;
            // 
            // q_buttonSupprimer
            // 
            this.q_buttonSupprimer.BackColor = System.Drawing.SystemColors.Window;
            this.q_buttonSupprimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.q_buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q_buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.q_buttonSupprimer.Location = new System.Drawing.Point(536, 367);
            this.q_buttonSupprimer.Name = "q_buttonSupprimer";
            this.q_buttonSupprimer.Size = new System.Drawing.Size(95, 40);
            this.q_buttonSupprimer.TabIndex = 23;
            this.q_buttonSupprimer.Text = "Supprimer";
            this.q_buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // z_checkBoxVisibility
            // 
            this.z_checkBoxVisibility.AutoSize = true;
            this.z_checkBoxVisibility.Location = new System.Drawing.Point(400, 210);
            this.z_checkBoxVisibility.Name = "z_checkBoxVisibility";
            this.z_checkBoxVisibility.Size = new System.Drawing.Size(71, 21);
            this.z_checkBoxVisibility.TabIndex = 24;
            this.z_checkBoxVisibility.Text = "Visible";
            this.z_checkBoxVisibility.UseVisualStyleBackColor = true;
            this.z_checkBoxVisibility.CheckedChanged += new System.EventHandler(this.checkBoxVisibility_CheckedChanged);
            // 
            // q_buttonAnnuler
            // 
            this.q_buttonAnnuler.BackColor = System.Drawing.SystemColors.Window;
            this.q_buttonAnnuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.q_buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q_buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.q_buttonAnnuler.Location = new System.Drawing.Point(436, 367);
            this.q_buttonAnnuler.Name = "q_buttonAnnuler";
            this.q_buttonAnnuler.Size = new System.Drawing.Size(94, 40);
            this.q_buttonAnnuler.TabIndex = 25;
            this.q_buttonAnnuler.Text = "Annuler";
            this.q_buttonAnnuler.UseVisualStyleBackColor = false;
            this.q_buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // z_textBoxNomEquipement
            // 
            this.z_textBoxNomEquipement.Location = new System.Drawing.Point(400, 169);
            this.z_textBoxNomEquipement.Name = "z_textBoxNomEquipement";
            this.z_textBoxNomEquipement.Size = new System.Drawing.Size(197, 22);
            this.z_textBoxNomEquipement.TabIndex = 26;
            this.z_textBoxNomEquipement.Enter += new System.EventHandler(this.textBoxNomEquipement_Enter);
            this.z_textBoxNomEquipement.Leave += new System.EventHandler(this.textBoxNomEquipement_Leave);
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
            // z_textBoxValeur
            // 
            this.z_textBoxValeur.Location = new System.Drawing.Point(1072, 208);
            this.z_textBoxValeur.Name = "z_textBoxValeur";
            this.z_textBoxValeur.Size = new System.Drawing.Size(206, 22);
            this.z_textBoxValeur.TabIndex = 29;
            this.z_textBoxValeur.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            // q_buttonAjouterCaract
            // 
            this.q_buttonAjouterCaract.BackColor = System.Drawing.SystemColors.Window;
            this.q_buttonAjouterCaract.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.q_buttonAjouterCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.q_buttonAjouterCaract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.q_buttonAjouterCaract.Location = new System.Drawing.Point(1308, 181);
            this.q_buttonAjouterCaract.Name = "q_buttonAjouterCaract";
            this.q_buttonAjouterCaract.Size = new System.Drawing.Size(148, 49);
            this.q_buttonAjouterCaract.TabIndex = 33;
            this.q_buttonAjouterCaract.Text = "Ajouter Caracteristique";
            this.q_buttonAjouterCaract.UseVisualStyleBackColor = false;
            this.q_buttonAjouterCaract.Click += new System.EventHandler(this.buttonAjouterCaract_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.SlateGray;
            this.label4.Location = new System.Drawing.Point(243, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Ajouter";
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
            // z_ficheEquipement
            // 
            this.z_ficheEquipement.EquipementSelectionne = null;
            this.z_ficheEquipement.Location = new System.Drawing.Point(645, 125);
            this.z_ficheEquipement.Name = "z_ficheEquipement";
            this.z_ficheEquipement.Size = new System.Drawing.Size(290, 295);
            this.z_ficheEquipement.TabIndex = 39;
            this.z_ficheEquipement.TexteFiltreEquipement = "";
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
            // z_listeDeroulanteStuff
            // 
            this.z_listeDeroulanteStuff.Location = new System.Drawing.Point(1072, 129);
            this.z_listeDeroulanteStuff.Name = "z_listeDeroulanteStuff";
            this.z_listeDeroulanteStuff.Size = new System.Drawing.Size(206, 26);
            this.z_listeDeroulanteStuff.StuffSelectionnee = null;
            this.z_listeDeroulanteStuff.TabIndex = 32;
            // 
            // z_listeDeroulanteFeature
            // 
            this.z_listeDeroulanteFeature.FeatureSelectionnee = null;
            this.z_listeDeroulanteFeature.Location = new System.Drawing.Point(1072, 171);
            this.z_listeDeroulanteFeature.Name = "z_listeDeroulanteFeature";
            this.z_listeDeroulanteFeature.Size = new System.Drawing.Size(206, 25);
            this.z_listeDeroulanteFeature.TabIndex = 28;
            // 
            // z_listeDeroulanteType
            // 
            this.z_listeDeroulanteType.Location = new System.Drawing.Point(400, 125);
            this.z_listeDeroulanteType.Name = "z_listeDeroulanteType";
            this.z_listeDeroulanteType.Size = new System.Drawing.Size(197, 25);
            this.z_listeDeroulanteType.TabIndex = 17;
            this.z_listeDeroulanteType.TypeSelectionne = null;
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
            // q_buttonAjouterEquipable
            // 
            this.q_buttonAjouterEquipable.Location = new System.Drawing.Point(815, 651);
            this.q_buttonAjouterEquipable.Name = "q_buttonAjouterEquipable";
            this.q_buttonAjouterEquipable.Size = new System.Drawing.Size(75, 23);
            this.q_buttonAjouterEquipable.TabIndex = 42;
            this.q_buttonAjouterEquipable.Text = "Lier";
            this.q_buttonAjouterEquipable.UseVisualStyleBackColor = true;
            this.q_buttonAjouterEquipable.Click += new System.EventHandler(this.buttonAjouterEquipable_Click);
            // 
            // z_listeDeroulanteFaction
            // 
            this.z_listeDeroulanteFaction.FactionSelectionnee = null;
            this.z_listeDeroulanteFaction.Location = new System.Drawing.Point(399, 476);
            this.z_listeDeroulanteFaction.Name = "z_listeDeroulanteFaction";
            this.z_listeDeroulanteFaction.Size = new System.Drawing.Size(198, 22);
            this.z_listeDeroulanteFaction.TabIndex = 43;
            // 
            // z_listeDeroulanteSousFaction
            // 
            this.z_listeDeroulanteSousFaction.Location = new System.Drawing.Point(399, 513);
            this.z_listeDeroulanteSousFaction.Name = "z_listeDeroulanteSousFaction";
            this.z_listeDeroulanteSousFaction.Size = new System.Drawing.Size(198, 25);
            this.z_listeDeroulanteSousFaction.SousFactionSelectionnee = null;
            this.z_listeDeroulanteSousFaction.TabIndex = 44;
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
            this.label8.Location = new System.Drawing.Point(285, 513);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 17);
            this.label8.TabIndex = 47;
            this.label8.Text = "Sous-Faction";
            // 
            // z_fichePersonnageEquipement1
            // 
            this.z_fichePersonnageEquipement1.CaractereSelectionne = null;
            this.z_fichePersonnageEquipement1.Location = new System.Drawing.Point(1056, 447);
            this.z_fichePersonnageEquipement1.Name = "z_fichePersonnageEquipement1";
            this.z_fichePersonnageEquipement1.Size = new System.Drawing.Size(400, 260);
            this.z_fichePersonnageEquipement1.TabIndex = 48;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.SlateGray;
            this.label9.Location = new System.Drawing.Point(640, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 25);
            this.label9.TabIndex = 49;
            this.label9.Text = "Rechercher";
            // 
            // z_listeDeroulanteCharRank
            // 
            this.z_listeDeroulanteCharRank.CharactSelectionnee = null;
            this.z_listeDeroulanteCharRank.Location = new System.Drawing.Point(399, 638);
            this.z_listeDeroulanteCharRank.Name = "z_listeDeroulanteCharRank";
            this.z_listeDeroulanteCharRank.Size = new System.Drawing.Size(260, 30);
            this.z_listeDeroulanteCharRank.TabIndex = 50;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(291, 638);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 17);
            this.label10.TabIndex = 51;
            this.label10.Text = "Personnage";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(744, 499);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 17);
            this.label11.TabIndex = 52;
            this.label11.Text = "Coût";
            // 
            // z_numericUpDownCout
            // 
            this.z_numericUpDownCout.Location = new System.Drawing.Point(815, 497);
            this.z_numericUpDownCout.Name = "z_numericUpDownCout";
            this.z_numericUpDownCout.Size = new System.Drawing.Size(120, 22);
            this.z_numericUpDownCout.TabIndex = 53;
            // 
            // z_numericUpDownMinimum
            // 
            this.z_numericUpDownMinimum.Location = new System.Drawing.Point(815, 555);
            this.z_numericUpDownMinimum.Name = "z_numericUpDownMinimum";
            this.z_numericUpDownMinimum.Size = new System.Drawing.Size(120, 22);
            this.z_numericUpDownMinimum.TabIndex = 54;
            // 
            // z_numericUpDownMaximum
            // 
            this.z_numericUpDownMaximum.Location = new System.Drawing.Point(815, 599);
            this.z_numericUpDownMaximum.Name = "z_numericUpDownMaximum";
            this.z_numericUpDownMaximum.Size = new System.Drawing.Size(120, 22);
            this.z_numericUpDownMaximum.TabIndex = 55;
            this.z_numericUpDownMaximum.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(729, 560);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Minimum";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(729, 599);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 57;
            this.label13.Text = "Maximum";
            // 
            // z_listeDeroulanteUnity
            // 
            this.z_listeDeroulanteUnity.Location = new System.Drawing.Point(400, 550);
            this.z_listeDeroulanteUnity.Name = "z_listeDeroulanteUnity";
            this.z_listeDeroulanteUnity.Size = new System.Drawing.Size(213, 27);
            this.z_listeDeroulanteUnity.TabIndex = 58;
            this.z_listeDeroulanteUnity.UnitySelectionnee = null;
            // 
            // z_listeDeroulanteSubUnity
            // 
            this.z_listeDeroulanteSubUnity.Location = new System.Drawing.Point(400, 590);
            this.z_listeDeroulanteSubUnity.Name = "z_listeDeroulanteSubUnity";
            this.z_listeDeroulanteSubUnity.Size = new System.Drawing.Size(220, 26);
            this.z_listeDeroulanteSubUnity.SubUnitySelectionnee = null;
            this.z_listeDeroulanteSubUnity.TabIndex = 59;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(335, 550);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 17);
            this.label14.TabIndex = 60;
            this.label14.Text = "Unité";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(298, 590);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 17);
            this.label15.TabIndex = 61;
            this.label15.Text = "Sous-Unité";
            // 
            // PageEquipements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.z_listeDeroulanteSubUnity);
            this.Controls.Add(this.z_listeDeroulanteUnity);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.z_numericUpDownMaximum);
            this.Controls.Add(this.z_numericUpDownMinimum);
            this.Controls.Add(this.z_numericUpDownCout);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.z_listeDeroulanteCharRank);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.z_fichePersonnageEquipement1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.z_listeDeroulanteSousFaction);
            this.Controls.Add(this.z_listeDeroulanteFaction);
            this.Controls.Add(this.q_buttonAjouterEquipable);
            this.Controls.Add(this.z_ficheEquipement);
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.listViewCaracteristiques);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.q_buttonAjouterCaract);
            this.Controls.Add(this.z_listeDeroulanteStuff);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.z_textBoxValeur);
            this.Controls.Add(this.z_listeDeroulanteFeature);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.z_textBoxNomEquipement);
            this.Controls.Add(this.q_buttonAnnuler);
            this.Controls.Add(this.z_checkBoxVisibility);
            this.Controls.Add(this.q_buttonSupprimer);
            this.Controls.Add(this.q_buttonModifier);
            this.Controls.Add(this.q_buttonAjouter);
            this.Controls.Add(this.z_listeDeroulanteType);
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
            ((System.ComponentModel.ISupportInitialize)(this.z_numericUpDownCout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_numericUpDownMinimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.z_numericUpDownMaximum)).EndInit();
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
        private ListeDeroulanteType z_listeDeroulanteType;
        private System.Windows.Forms.Button q_buttonAjouter;
        private System.Windows.Forms.Button q_buttonModifier;
        private System.Windows.Forms.Button q_buttonSupprimer;
        private System.Windows.Forms.CheckBox z_checkBoxVisibility;
        private System.Windows.Forms.Button q_buttonAnnuler;
        private System.Windows.Forms.TextBox z_textBoxNomEquipement;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox z_textBoxValeur;
        private ListeDeroulanteFeature z_listeDeroulanteFeature;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ListeDeroulanteStuff z_listeDeroulanteStuff;
        private System.Windows.Forms.Button q_buttonAjouterCaract;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listViewCaracteristiques;
        private MenuAdmin menuAdmin1;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
        private FicheEquipement z_ficheEquipement;
        private System.Windows.Forms.Button q_buttonAjouterEquipable;
        private ListeDeroulanteSousFaction z_listeDeroulanteSousFaction;
        private ListeDeroulanteFaction z_listeDeroulanteFaction;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private FichePersonnageEquipement z_fichePersonnageEquipement1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private ListeDeroulanteCharRank z_listeDeroulanteCharRank;
        private System.Windows.Forms.NumericUpDown z_numericUpDownCout;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown z_numericUpDownMaximum;
        private System.Windows.Forms.NumericUpDown z_numericUpDownMinimum;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private ListeDeroulanteSubUnity z_listeDeroulanteSubUnity;
        private ListeDeroulanteUnity z_listeDeroulanteUnity;
    }
}
