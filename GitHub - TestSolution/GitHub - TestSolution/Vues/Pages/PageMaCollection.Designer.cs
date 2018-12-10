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
            this.buttonReturn = new System.Windows.Forms.Button();
            this.panelLigneSeparatrice = new System.Windows.Forms.Panel();
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.labelUnity = new System.Windows.Forms.Label();
            this.labelFigurine = new System.Windows.Forms.Label();
            this.labelRang = new System.Windows.Forms.Label();
            this.labelEquipement = new System.Windows.Forms.Label();
            this.labelQuantite = new System.Windows.Forms.Label();
            this.labelMesFigurines = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.labelSubunity = new System.Windows.Forms.Label();
            this.ficheEquipement1 = new EICE_WARGAME.FicheEquipement();
            this.listeDeroulanteCharRank1 = new EICE_WARGAME.ListeDeroulanteCharRank();
            this.listeDeroulanteSubUnity1 = new EICE_WARGAME.ListeDeroulanteSubUnity();
            this.listeDeroulanteRank1 = new EICE_WARGAME.ListeDeroulanteRank();
            this.listeDeroulanteUnity1 = new EICE_WARGAME.ListeDeroulanteUnity();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
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
            this.labelMaCollection.Click += new System.EventHandler(this.labelMaCollection_Click);
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
            // panelLigneSeparatrice
            // 
            this.panelLigneSeparatrice.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLigneSeparatrice.Location = new System.Drawing.Point(22, 78);
            this.panelLigneSeparatrice.Margin = new System.Windows.Forms.Padding(2);
            this.panelLigneSeparatrice.Name = "panelLigneSeparatrice";
            this.panelLigneSeparatrice.Size = new System.Drawing.Size(1050, 2);
            this.panelLigneSeparatrice.TabIndex = 2;
            this.panelLigneSeparatrice.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLigneSeparatrice_Paint);
            // 
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFaction.Location = new System.Drawing.Point(46, 120);
            this.labelFaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(54, 17);
            this.labelFaction.TabIndex = 3;
            this.labelFaction.Text = "Faction";
            this.labelFaction.Click += new System.EventHandler(this.labelFaction_Click);
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSousFaction.Location = new System.Drawing.Point(46, 154);
            this.labelSousFaction.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(86, 17);
            this.labelSousFaction.TabIndex = 4;
            this.labelSousFaction.Text = "Sous faction";
            this.labelSousFaction.Click += new System.EventHandler(this.labelSousFaction_Click);
            // 
            // labelUnity
            // 
            this.labelUnity.AutoSize = true;
            this.labelUnity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelUnity.Location = new System.Drawing.Point(46, 187);
            this.labelUnity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUnity.Name = "labelUnity";
            this.labelUnity.Size = new System.Drawing.Size(41, 17);
            this.labelUnity.TabIndex = 5;
            this.labelUnity.Text = "Unité";
            this.labelUnity.Click += new System.EventHandler(this.labelUnity_Click);
            // 
            // labelFigurine
            // 
            this.labelFigurine.AutoSize = true;
            this.labelFigurine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFigurine.Location = new System.Drawing.Point(46, 259);
            this.labelFigurine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFigurine.Name = "labelFigurine";
            this.labelFigurine.Size = new System.Drawing.Size(85, 17);
            this.labelFigurine.TabIndex = 6;
            this.labelFigurine.Text = "Personnage";
            this.labelFigurine.Click += new System.EventHandler(this.labelFigurine_Click);
            // 
            // labelRang
            // 
            this.labelRang.AutoSize = true;
            this.labelRang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelRang.Location = new System.Drawing.Point(46, 294);
            this.labelRang.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRang.Name = "labelRang";
            this.labelRang.Size = new System.Drawing.Size(42, 17);
            this.labelRang.TabIndex = 7;
            this.labelRang.Text = "Rang";
            this.labelRang.Click += new System.EventHandler(this.labelRang_Click);
            // 
            // labelEquipement
            // 
            this.labelEquipement.AutoSize = true;
            this.labelEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelEquipement.Location = new System.Drawing.Point(49, 337);
            this.labelEquipement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipement.Name = "labelEquipement";
            this.labelEquipement.Size = new System.Drawing.Size(83, 17);
            this.labelEquipement.TabIndex = 8;
            this.labelEquipement.Text = "Equipement";
            this.labelEquipement.Click += new System.EventHandler(this.labelEquipement_Click);
            // 
            // labelQuantite
            // 
            this.labelQuantite.AutoSize = true;
            this.labelQuantite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelQuantite.Location = new System.Drawing.Point(46, 91);
            this.labelQuantite.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQuantite.Name = "labelQuantite";
            this.labelQuantite.Size = new System.Drawing.Size(62, 17);
            this.labelQuantite.TabIndex = 9;
            this.labelQuantite.Text = "Quantité";
            this.labelQuantite.Click += new System.EventHandler(this.labelQuantite_Click);
            // 
            // labelMesFigurines
            // 
            this.labelMesFigurines.AutoSize = true;
            this.labelMesFigurines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMesFigurines.Location = new System.Drawing.Point(466, 94);
            this.labelMesFigurines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMesFigurines.Name = "labelMesFigurines";
            this.labelMesFigurines.Size = new System.Drawing.Size(92, 17);
            this.labelMesFigurines.TabIndex = 10;
            this.labelMesFigurines.Text = "Mes figurines";
            this.labelMesFigurines.Click += new System.EventHandler(this.labelMesFigurines_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(158, 91);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // labelSubunity
            // 
            this.labelSubunity.AutoSize = true;
            this.labelSubunity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubunity.Location = new System.Drawing.Point(49, 220);
            this.labelSubunity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubunity.Name = "labelSubunity";
            this.labelSubunity.Size = new System.Drawing.Size(77, 17);
            this.labelSubunity.TabIndex = 22;
            this.labelSubunity.Text = "Sous Unité";
            this.labelSubunity.Click += new System.EventHandler(this.labelSubunity_Click);
            // 
            // ficheEquipement1
            // 
            this.ficheEquipement1.EquipementSelectionne = null;
            this.ficheEquipement1.Location = new System.Drawing.Point(158, 337);
            this.ficheEquipement1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ficheEquipement1.Name = "ficheEquipement1";
            this.ficheEquipement1.Size = new System.Drawing.Size(362, 245);
            this.ficheEquipement1.TabIndex = 21;
            this.ficheEquipement1.TexteFiltreEquipement = "";
            this.ficheEquipement1.Load += new System.EventHandler(this.ficheEquipement1_Load);
            // 
            // listeDeroulanteCharRank1
            // 
            this.listeDeroulanteCharRank1.CharactSelectionnee = null;
            this.listeDeroulanteCharRank1.Location = new System.Drawing.Point(158, 259);
            this.listeDeroulanteCharRank1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteCharRank1.Name = "listeDeroulanteCharRank1";
            this.listeDeroulanteCharRank1.Size = new System.Drawing.Size(201, 21);
            this.listeDeroulanteCharRank1.TabIndex = 20;
            this.listeDeroulanteCharRank1.Load += new System.EventHandler(this.listeDeroulanteCharRank1_Load);
            // 
            // listeDeroulanteSubUnity1
            // 
            this.listeDeroulanteSubUnity1.Location = new System.Drawing.Point(158, 216);
            this.listeDeroulanteSubUnity1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteSubUnity1.Name = "listeDeroulanteSubUnity1";
            this.listeDeroulanteSubUnity1.Size = new System.Drawing.Size(201, 21);
            this.listeDeroulanteSubUnity1.SubUnitySelectionnee = null;
            this.listeDeroulanteSubUnity1.TabIndex = 18;
            this.listeDeroulanteSubUnity1.Load += new System.EventHandler(this.listeDeroulanteSubUnity1_Load);
            // 
            // listeDeroulanteRank1
            // 
            this.listeDeroulanteRank1.Location = new System.Drawing.Point(158, 290);
            this.listeDeroulanteRank1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteRank1.Name = "listeDeroulanteRank1";
            this.listeDeroulanteRank1.RankSelectionnee = null;
            this.listeDeroulanteRank1.Size = new System.Drawing.Size(201, 21);
            this.listeDeroulanteRank1.TabIndex = 15;
            this.listeDeroulanteRank1.Load += new System.EventHandler(this.listeDeroulanteRank1_Load);
            // 
            // listeDeroulanteUnity1
            // 
            this.listeDeroulanteUnity1.Location = new System.Drawing.Point(158, 182);
            this.listeDeroulanteUnity1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteUnity1.Name = "listeDeroulanteUnity1";
            this.listeDeroulanteUnity1.Size = new System.Drawing.Size(201, 21);
            this.listeDeroulanteUnity1.TabIndex = 14;
            this.listeDeroulanteUnity1.UnitySelectionnee = null;
            this.listeDeroulanteUnity1.Load += new System.EventHandler(this.listeDeroulanteUnity1_Load);
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(158, 151);
            this.listeDeroulanteSousFaction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(201, 21);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 13;
            this.listeDeroulanteSousFaction1.Load += new System.EventHandler(this.listeDeroulanteSousFaction1_Load);
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(158, 120);
            this.listeDeroulanteFaction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(201, 21);
            this.listeDeroulanteFaction1.TabIndex = 12;
            this.listeDeroulanteFaction1.Load += new System.EventHandler(this.listeDeroulanteFaction1_Load);
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(958, -11);
            this.buttonOptionsUser1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(164, 37);
            this.buttonOptionsUser1.TabIndex = 11;
            this.buttonOptionsUser1.Utilisateur = null;
            this.buttonOptionsUser1.Load += new System.EventHandler(this.buttonOptionsUser1_Load);
            // 
            // PageMaCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelSubunity);
            this.Controls.Add(this.ficheEquipement1);
            this.Controls.Add(this.listeDeroulanteCharRank1);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.listeDeroulanteSubUnity1);
            this.Controls.Add(this.listeDeroulanteRank1);
            this.Controls.Add(this.listeDeroulanteUnity1);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.labelMesFigurines);
            this.Controls.Add(this.labelQuantite);
            this.Controls.Add(this.labelEquipement);
            this.Controls.Add(this.labelRang);
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
        private System.Windows.Forms.Label labelRang;
        private System.Windows.Forms.Label labelEquipement;
        private System.Windows.Forms.Label labelQuantite;
        private System.Windows.Forms.Label labelMesFigurines;
        private ButtonOptionsUser buttonOptionsUser1;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private ListeDeroulanteUnity listeDeroulanteUnity1;
        private ListeDeroulanteRank listeDeroulanteRank1;
        private ListeDeroulanteSubUnity listeDeroulanteSubUnity1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private ListeDeroulanteCharRank listeDeroulanteCharRank1;
        private FicheEquipement ficheEquipement1;
        private System.Windows.Forms.Label labelSubunity;
    }
}
