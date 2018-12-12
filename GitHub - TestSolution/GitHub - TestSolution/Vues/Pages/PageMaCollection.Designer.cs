namespace EICE_WARGAME
{
    partial class PageMaCollection
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
            this.labelMaCollection = new System.Windows.Forms.Label();
            this.panelLigneSeparatrice = new System.Windows.Forms.Panel();
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.labelUnity = new System.Windows.Forms.Label();
            this.labelFigurine = new System.Windows.Forms.Label();
            this.labelEquipement = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelMesFigurines = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSubunity = new System.Windows.Forms.Label();
            this.buttonAjoutEquipementSurPersonnage = new System.Windows.Forms.Button();
            this.buttonEnleverEquipementSurPersonnage = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonValiderFigurineStuff = new System.Windows.Forms.Button();
            this.ficheEquipementSansRecherche1 = new EICE_WARGAME.FicheEquipementSansRecherche();
            this.ficheEquipementSurFigurine1 = new EICE_WARGAME.FicheEquipementSurFigurine();
            this.listeDeroulanteChar1 = new EICE_WARGAME.ListeDeroulanteChar();
            this.listeDeroulanteSubUnity1 = new EICE_WARGAME.ListeDeroulanteSubUnity();
            this.listeDeroulanteUnity1 = new EICE_WARGAME.ListeDeroulanteUnity();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.ficheFigurineStuff1 = new EICE_WARGAME.FicheFigurineStuff();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelMaCollection
            // 
            this.labelMaCollection.AutoSize = true;
            this.labelMaCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.labelMaCollection.Location = new System.Drawing.Point(17, 41);
            this.labelMaCollection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaCollection.Name = "labelMaCollection";
            this.labelMaCollection.Size = new System.Drawing.Size(190, 36);
            this.labelMaCollection.TabIndex = 0;
            this.labelMaCollection.Text = "Ma collection";
            // 
            // panelLigneSeparatrice
            // 
            this.panelLigneSeparatrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLigneSeparatrice.Location = new System.Drawing.Point(22, 78);
            this.panelLigneSeparatrice.Margin = new System.Windows.Forms.Padding(2);
            this.panelLigneSeparatrice.Name = "panelLigneSeparatrice";
            this.panelLigneSeparatrice.Size = new System.Drawing.Size(1050, 2);
            this.panelLigneSeparatrice.TabIndex = 2;
            // 
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFaction.Location = new System.Drawing.Point(46, 91);
            this.labelFaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(62, 17);
            this.labelFaction.TabIndex = 3;
            this.labelFaction.Text = "Faction :";
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSousFaction.Location = new System.Drawing.Point(45, 127);
            this.labelSousFaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(94, 17);
            this.labelSousFaction.TabIndex = 4;
            this.labelSousFaction.Text = "Sous faction :";
            // 
            // labelUnity
            // 
            this.labelUnity.AutoSize = true;
            this.labelUnity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUnity.Location = new System.Drawing.Point(46, 161);
            this.labelUnity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnity.Name = "labelUnity";
            this.labelUnity.Size = new System.Drawing.Size(49, 17);
            this.labelUnity.TabIndex = 5;
            this.labelUnity.Text = "Unité :";
            // 
            // labelFigurine
            // 
            this.labelFigurine.AutoSize = true;
            this.labelFigurine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFigurine.Location = new System.Drawing.Point(46, 229);
            this.labelFigurine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFigurine.Name = "labelFigurine";
            this.labelFigurine.Size = new System.Drawing.Size(93, 17);
            this.labelFigurine.TabIndex = 6;
            this.labelFigurine.Text = "Personnage :";
            // 
            // labelEquipement
            // 
            this.labelEquipement.AutoSize = true;
            this.labelEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEquipement.Location = new System.Drawing.Point(45, 321);
            this.labelEquipement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipement.Name = "labelEquipement";
            this.labelEquipement.Size = new System.Drawing.Size(91, 17);
            this.labelEquipement.TabIndex = 8;
            this.labelEquipement.Text = "Equipement :";
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelQuantite.Location = new System.Drawing.Point(46, 260);
            this.labelQuantite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(70, 17);
            this.labelQuantite.TabIndex = 9;
            this.labelQuantite.Text = "Quantité :";
            // 
            // labelMesFigurines
            // 
            this.labelMesFigurines.AutoSize = true;
            this.labelMesFigurines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMesFigurines.Location = new System.Drawing.Point(541, 91);
            this.labelMesFigurines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMesFigurines.Name = "labelMesFigurines";
            this.labelMesFigurines.Size = new System.Drawing.Size(92, 17);
            this.labelMesFigurines.TabIndex = 10;
            this.labelMesFigurines.Text = "Mes figurines";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(158, 263);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(218, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelSubunity
            // 
            this.labelSubunity.AutoSize = true;
            this.labelSubunity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubunity.Location = new System.Drawing.Point(45, 195);
            this.labelSubunity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubunity.Name = "labelSubunity";
            this.labelSubunity.Size = new System.Drawing.Size(85, 17);
            this.labelSubunity.TabIndex = 22;
            this.labelSubunity.Text = "Sous Unité :";
            // 
            // buttonAjoutEquipementSurPersonnage
            // 
            this.buttonAjoutEquipementSurPersonnage.Location = new System.Drawing.Point(274, 384);
            this.buttonAjoutEquipementSurPersonnage.Name = "buttonAjoutEquipementSurPersonnage";
            this.buttonAjoutEquipementSurPersonnage.Size = new System.Drawing.Size(29, 23);
            this.buttonAjoutEquipementSurPersonnage.TabIndex = 27;
            this.buttonAjoutEquipementSurPersonnage.Text = ">";
            this.buttonAjoutEquipementSurPersonnage.UseVisualStyleBackColor = true;
            this.buttonAjoutEquipementSurPersonnage.Click += new System.EventHandler(this.AjoutEquipementSurFigurine);
            // 
            // buttonEnleverEquipementSurPersonnage
            // 
            this.buttonEnleverEquipementSurPersonnage.Location = new System.Drawing.Point(274, 413);
            this.buttonEnleverEquipementSurPersonnage.Name = "buttonEnleverEquipementSurPersonnage";
            this.buttonEnleverEquipementSurPersonnage.Size = new System.Drawing.Size(29, 23);
            this.buttonEnleverEquipementSurPersonnage.TabIndex = 28;
            this.buttonEnleverEquipementSurPersonnage.Text = "<";
            this.buttonEnleverEquipementSurPersonnage.UseVisualStyleBackColor = true;
            this.buttonEnleverEquipementSurPersonnage.Click += new System.EventHandler(this.EnleverEquipementSurFigurine);
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Image = global::EICE_WARGAME.Properties.Resources.ReturnLogo35px;
            this.buttonReturn.Location = new System.Drawing.Point(2, 2);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(33, 32);
            this.buttonReturn.TabIndex = 1;
            this.buttonReturn.UseVisualStyleBackColor = true;
            this.buttonReturn.Click += new System.EventHandler(this.buttonReturn_Click);
            // 
            // buttonValiderFigurineStuff
            // 
            this.buttonValiderFigurineStuff.Location = new System.Drawing.Point(158, 289);
            this.buttonValiderFigurineStuff.Name = "buttonValiderFigurineStuff";
            this.buttonValiderFigurineStuff.Size = new System.Drawing.Size(218, 23);
            this.buttonValiderFigurineStuff.TabIndex = 31;
            this.buttonValiderFigurineStuff.Text = "Créer figurine";
            this.buttonValiderFigurineStuff.UseVisualStyleBackColor = true;
            this.buttonValiderFigurineStuff.Click += new System.EventHandler(this.buttonCréerFigurine_Click);
            // 
            // ficheEquipementSansRecherche1
            // 
            this.ficheEquipementSansRecherche1.EquipementSelectionne = null;
            this.ficheEquipementSansRecherche1.Location = new System.Drawing.Point(48, 351);
            this.ficheEquipementSansRecherche1.Margin = new System.Windows.Forms.Padding(2);
            this.ficheEquipementSansRecherche1.Name = "ficheEquipementSansRecherche1";
            this.ficheEquipementSansRecherche1.Size = new System.Drawing.Size(220, 240);
            this.ficheEquipementSansRecherche1.TabIndex = 32;
            // 
            // ficheEquipementSurFigurine1
            // 
            this.ficheEquipementSurFigurine1.EquipementSelectionne = null;
            this.ficheEquipementSurFigurine1.Location = new System.Drawing.Point(308, 351);
            this.ficheEquipementSurFigurine1.Margin = new System.Windows.Forms.Padding(2);
            this.ficheEquipementSurFigurine1.Name = "ficheEquipementSurFigurine1";
            this.ficheEquipementSurFigurine1.Size = new System.Drawing.Size(220, 240);
            this.ficheEquipementSurFigurine1.TabIndex = 30;
            // 
            // listeDeroulanteChar1
            // 
            this.listeDeroulanteChar1.CharactSelectionnee = null;
            this.listeDeroulanteChar1.Location = new System.Drawing.Point(158, 229);
            this.listeDeroulanteChar1.Margin = new System.Windows.Forms.Padding(2);
            this.listeDeroulanteChar1.Name = "listeDeroulanteChar1";
            this.listeDeroulanteChar1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteChar1.TabIndex = 24;
            // 
            // listeDeroulanteSubUnity1
            // 
            this.listeDeroulanteSubUnity1.Location = new System.Drawing.Point(158, 195);
            this.listeDeroulanteSubUnity1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteSubUnity1.Name = "listeDeroulanteSubUnity1";
            this.listeDeroulanteSubUnity1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteSubUnity1.SubUnitySelectionnee = null;
            this.listeDeroulanteSubUnity1.TabIndex = 18;
            this.listeDeroulanteSubUnity1.Load += new System.EventHandler(this.listeDeroulanteSubUnity1_Load);
            // 
            // listeDeroulanteUnity1
            // 
            this.listeDeroulanteUnity1.Location = new System.Drawing.Point(158, 161);
            this.listeDeroulanteUnity1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteUnity1.Name = "listeDeroulanteUnity1";
            this.listeDeroulanteUnity1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteUnity1.TabIndex = 14;
            this.listeDeroulanteUnity1.UnitySelectionnee = null;
            this.listeDeroulanteUnity1.Load += new System.EventHandler(this.listeDeroulanteUnity1_Load);
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(158, 127);
            this.listeDeroulanteSousFaction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 13;
            this.listeDeroulanteSousFaction1.Load += new System.EventHandler(this.listeDeroulanteSousFaction1_Load);
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(158, 93);
            this.listeDeroulanteFaction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteFaction1.TabIndex = 12;
            this.listeDeroulanteFaction1.Load += new System.EventHandler(this.listeDeroulanteFaction1_Load);
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(958, 3);
            this.buttonOptionsUser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(164, 37);
            this.buttonOptionsUser1.TabIndex = 11;
            this.buttonOptionsUser1.Utilisateur = null;
            this.buttonOptionsUser1.Load += new System.EventHandler(this.buttonOptionsUser1_Load);
            // 
            // ficheFigurineStuff1
            // 
            this.ficheFigurineStuff1.FactionSelectionne = null;
            this.ficheFigurineStuff1.Location = new System.Drawing.Point(615, 110);
            this.ficheFigurineStuff1.Margin = new System.Windows.Forms.Padding(2);
            this.ficheFigurineStuff1.Name = "ficheFigurineStuff1";
            this.ficheFigurineStuff1.Size = new System.Drawing.Size(457, 481);
            this.ficheFigurineStuff1.TabIndex = 33;
            this.ficheFigurineStuff1.TexteFiltreFaction = "";
            // 
            // PageMaCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ficheFigurineStuff1);
            this.Controls.Add(this.ficheEquipementSansRecherche1);
            this.Controls.Add(this.buttonValiderFigurineStuff);
            this.Controls.Add(this.ficheEquipementSurFigurine1);
            this.Controls.Add(this.buttonEnleverEquipementSurPersonnage);
            this.Controls.Add(this.buttonAjoutEquipementSurPersonnage);
            this.Controls.Add(this.listeDeroulanteChar1);
            this.Controls.Add(this.labelSubunity);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listeDeroulanteSubUnity1);
            this.Controls.Add(this.listeDeroulanteUnity1);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.labelMesFigurines);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelEquipement);
            this.Controls.Add(this.labelFigurine);
            this.Controls.Add(this.labelUnity);
            this.Controls.Add(this.labelSousFaction);
            this.Controls.Add(this.labelFaction);
            this.Controls.Add(this.panelLigneSeparatrice);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.labelMaCollection);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PageMaCollection";
            this.Size = new System.Drawing.Size(1125, 609);
            this.Load += new System.EventHandler(this.MaCollectionONLoad);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMaCollection;
        private System.Windows.Forms.Button buttonReturn;
        private System.Windows.Forms.Panel panelLigneSeparatrice;
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Label labelSousFaction;
        private System.Windows.Forms.Label labelUnity;
        private System.Windows.Forms.Label labelFigurine;
        private System.Windows.Forms.Label labelEquipement;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelMesFigurines;
        private ButtonOptionsUser buttonOptionsUser1;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private ListeDeroulanteUnity listeDeroulanteUnity1;
        private ListeDeroulanteSubUnity listeDeroulanteSubUnity1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label labelSubunity;
        private ListeDeroulanteChar listeDeroulanteChar1;
        private System.Windows.Forms.Button buttonAjoutEquipementSurPersonnage;
        private System.Windows.Forms.Button buttonEnleverEquipementSurPersonnage;
        private FicheEquipementSurFigurine ficheEquipementSurFigurine1;
        private System.Windows.Forms.Button buttonValiderFigurineStuff;
        private FicheEquipementSansRecherche ficheEquipementSansRecherche1;
        private FicheFigurineStuff ficheFigurineStuff1;
    }
}
