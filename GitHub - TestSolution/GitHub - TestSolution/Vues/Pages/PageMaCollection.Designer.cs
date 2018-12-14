﻿namespace EICE_WARGAME
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
            this.labelMesFigurines = new System.Windows.Forms.Label();
            this.labelSubunity = new System.Windows.Forms.Label();
            this.buttonAjoutEquipementSurPersonnage = new System.Windows.Forms.Button();
            this.buttonEnleverEquipementSurPersonnage = new System.Windows.Forms.Button();
            this.buttonAnnulerPersonnage = new System.Windows.Forms.Button();
            this.buttonSupprimerPersonnage = new System.Windows.Forms.Button();
            this.buttonAjouterFigurine = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ficheFigurineStuff1 = new EICE_WARGAME.FicheFigurineStuff();
            this.ficheEquipementSansRecherche1 = new EICE_WARGAME.FicheEquipementSansRecherche();
            this.ficheEquipementSurFigurine1 = new EICE_WARGAME.FicheEquipementSurFigurine();
            this.listeDeroulanteChar1 = new EICE_WARGAME.ListeDeroulanteChar();
            this.listeDeroulanteSubUnity1 = new EICE_WARGAME.ListeDeroulanteSubUnity();
            this.listeDeroulanteUnity1 = new EICE_WARGAME.ListeDeroulanteUnity();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelMaCollection
            // 
            this.labelMaCollection.AutoSize = true;
            this.labelMaCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelMaCollection.ForeColor = System.Drawing.Color.SlateGray;
            this.labelMaCollection.Location = new System.Drawing.Point(17, 41);
            this.labelMaCollection.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMaCollection.Name = "labelMaCollection";
            this.labelMaCollection.Size = new System.Drawing.Size(203, 37);
            this.labelMaCollection.TabIndex = 0;
            this.labelMaCollection.Text = "Ma collection";
            // 
            // panelLigneSeparatrice
            // 
            this.panelLigneSeparatrice.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigneSeparatrice.ForeColor = System.Drawing.Color.SteelBlue;
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
            this.labelFaction.Location = new System.Drawing.Point(118, 88);
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
            this.labelSousFaction.Location = new System.Drawing.Point(392, 88);
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
            this.labelUnity.Location = new System.Drawing.Point(118, 137);
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
            this.labelFigurine.Location = new System.Drawing.Point(256, 191);
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
            this.labelEquipement.Location = new System.Drawing.Point(119, 317);
            this.labelEquipement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEquipement.Name = "labelEquipement";
            this.labelEquipement.Size = new System.Drawing.Size(153, 17);
            this.labelEquipement.TabIndex = 8;
            this.labelEquipement.Text = "Equipements portables";
            // 
            // labelMesFigurines
            // 
            this.labelMesFigurines.AutoSize = true;
            this.labelMesFigurines.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelMesFigurines.Location = new System.Drawing.Point(715, 87);
            this.labelMesFigurines.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMesFigurines.Name = "labelMesFigurines";
            this.labelMesFigurines.Size = new System.Drawing.Size(100, 17);
            this.labelMesFigurines.TabIndex = 10;
            this.labelMesFigurines.Text = "Mes figurines :";
            // 
            // labelSubunity
            // 
            this.labelSubunity.AutoSize = true;
            this.labelSubunity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelSubunity.Location = new System.Drawing.Point(392, 137);
            this.labelSubunity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSubunity.Name = "labelSubunity";
            this.labelSubunity.Size = new System.Drawing.Size(85, 17);
            this.labelSubunity.TabIndex = 22;
            this.labelSubunity.Text = "Sous Unité :";
            // 
            // buttonAjoutEquipementSurPersonnage
            // 
            this.buttonAjoutEquipementSurPersonnage.Location = new System.Drawing.Point(354, 369);
            this.buttonAjoutEquipementSurPersonnage.Name = "buttonAjoutEquipementSurPersonnage";
            this.buttonAjoutEquipementSurPersonnage.Size = new System.Drawing.Size(29, 23);
            this.buttonAjoutEquipementSurPersonnage.TabIndex = 27;
            this.buttonAjoutEquipementSurPersonnage.Text = ">";
            this.buttonAjoutEquipementSurPersonnage.UseVisualStyleBackColor = true;
            this.buttonAjoutEquipementSurPersonnage.Click += new System.EventHandler(this.AjoutEquipementSurFigurine);
            // 
            // buttonEnleverEquipementSurPersonnage
            // 
            this.buttonEnleverEquipementSurPersonnage.Location = new System.Drawing.Point(354, 398);
            this.buttonEnleverEquipementSurPersonnage.Name = "buttonEnleverEquipementSurPersonnage";
            this.buttonEnleverEquipementSurPersonnage.Size = new System.Drawing.Size(29, 23);
            this.buttonEnleverEquipementSurPersonnage.TabIndex = 28;
            this.buttonEnleverEquipementSurPersonnage.Text = "<";
            this.buttonEnleverEquipementSurPersonnage.UseVisualStyleBackColor = true;
            this.buttonEnleverEquipementSurPersonnage.Click += new System.EventHandler(this.EnleverEquipementSurFigurine);
            // 
            // buttonAnnulerPersonnage
            // 
            this.buttonAnnulerPersonnage.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnulerPersonnage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerPersonnage.Location = new System.Drawing.Point(418, 248);
            this.buttonAnnulerPersonnage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAnnulerPersonnage.Name = "buttonAnnulerPersonnage";
            this.buttonAnnulerPersonnage.Size = new System.Drawing.Size(91, 32);
            this.buttonAnnulerPersonnage.TabIndex = 47;
            this.buttonAnnulerPersonnage.Text = "Annuler";
            this.buttonAnnulerPersonnage.UseVisualStyleBackColor = false;
            this.buttonAnnulerPersonnage.Click += new System.EventHandler(this.button_annuler_click);
            // 
            // buttonSupprimerPersonnage
            // 
            this.buttonSupprimerPersonnage.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerPersonnage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerPersonnage.Location = new System.Drawing.Point(323, 248);
            this.buttonSupprimerPersonnage.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSupprimerPersonnage.Name = "buttonSupprimerPersonnage";
            this.buttonSupprimerPersonnage.Size = new System.Drawing.Size(91, 32);
            this.buttonSupprimerPersonnage.TabIndex = 48;
            this.buttonSupprimerPersonnage.Text = "Supprimer";
            this.buttonSupprimerPersonnage.UseVisualStyleBackColor = false;
            this.buttonSupprimerPersonnage.Click += new System.EventHandler(this.buttonSupprimerFigurine_Click);
            // 
            // buttonAjouterFigurine
            // 
            this.buttonAjouterFigurine.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterFigurine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterFigurine.Location = new System.Drawing.Point(228, 248);
            this.buttonAjouterFigurine.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAjouterFigurine.Name = "buttonAjouterFigurine";
            this.buttonAjouterFigurine.Size = new System.Drawing.Size(91, 32);
            this.buttonAjouterFigurine.TabIndex = 45;
            this.buttonAjouterFigurine.Text = "Ajouter";
            this.buttonAjouterFigurine.UseVisualStyleBackColor = false;
            this.buttonAjouterFigurine.Click += new System.EventHandler(this.buttonCréerFigurine_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(396, 317);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 17);
            this.label1.TabIndex = 49;
            this.label1.Text = "Equipements portés";
            // 
            // ficheFigurineStuff1
            // 
            this.ficheFigurineStuff1.FigurineSelectionne = null;
            this.ficheFigurineStuff1.Location = new System.Drawing.Point(718, 106);
            this.ficheFigurineStuff1.Margin = new System.Windows.Forms.Padding(2);
            this.ficheFigurineStuff1.Name = "ficheFigurineStuff1";
            this.ficheFigurineStuff1.Size = new System.Drawing.Size(284, 478);
            this.ficheFigurineStuff1.TabIndex = 33;
            this.ficheFigurineStuff1.TexteFiltreFigurineStuff = "";
            this.ficheFigurineStuff1.SurChangementSelection += new System.EventHandler(this.FicheFigurineStuff_SurChangementSelection);
            // 
            // ficheEquipementSansRecherche1
            // 
            this.ficheEquipementSansRecherche1.EquipementSelectionne = null;
            this.ficheEquipementSansRecherche1.Location = new System.Drawing.Point(121, 336);
            this.ficheEquipementSansRecherche1.Margin = new System.Windows.Forms.Padding(2);
            this.ficheEquipementSansRecherche1.Name = "ficheEquipementSansRecherche1";
            this.ficheEquipementSansRecherche1.Size = new System.Drawing.Size(220, 240);
            this.ficheEquipementSansRecherche1.TabIndex = 32;
            // 
            // ficheEquipementSurFigurine1
            // 
            this.ficheEquipementSurFigurine1.EquipementSelectionne = null;
            this.ficheEquipementSurFigurine1.Location = new System.Drawing.Point(395, 336);
            this.ficheEquipementSurFigurine1.Margin = new System.Windows.Forms.Padding(2);
            this.ficheEquipementSurFigurine1.Name = "ficheEquipementSurFigurine1";
            this.ficheEquipementSurFigurine1.Size = new System.Drawing.Size(220, 240);
            this.ficheEquipementSurFigurine1.TabIndex = 30;
            // 
            // listeDeroulanteChar1
            // 
            this.listeDeroulanteChar1.CharactSelectionnee = null;
            this.listeDeroulanteChar1.Location = new System.Drawing.Point(259, 210);
            this.listeDeroulanteChar1.Margin = new System.Windows.Forms.Padding(2);
            this.listeDeroulanteChar1.Name = "listeDeroulanteChar1";
            this.listeDeroulanteChar1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteChar1.TabIndex = 24;
            // 
            // listeDeroulanteSubUnity1
            // 
            this.listeDeroulanteSubUnity1.Location = new System.Drawing.Point(395, 156);
            this.listeDeroulanteSubUnity1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteSubUnity1.Name = "listeDeroulanteSubUnity1";
            this.listeDeroulanteSubUnity1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteSubUnity1.SubUnitySelectionnee = null;
            this.listeDeroulanteSubUnity1.TabIndex = 18;
            // 
            // listeDeroulanteUnity1
            // 
            this.listeDeroulanteUnity1.Location = new System.Drawing.Point(121, 156);
            this.listeDeroulanteUnity1.Margin = new System.Windows.Forms.Padding(2);
            this.listeDeroulanteUnity1.Name = "listeDeroulanteUnity1";
            this.listeDeroulanteUnity1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteUnity1.TabIndex = 14;
            this.listeDeroulanteUnity1.UnitySelectionnee = null;
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(395, 107);
            this.listeDeroulanteSousFaction1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 13;
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(121, 107);
            this.listeDeroulanteFaction1.Margin = new System.Windows.Forms.Padding(2);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(218, 21);
            this.listeDeroulanteFaction1.TabIndex = 12;
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
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 50;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.printButton_Click);
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
            // PageMaCollection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAnnulerPersonnage);
            this.Controls.Add(this.buttonSupprimerPersonnage);
            this.Controls.Add(this.buttonAjouterFigurine);
            this.Controls.Add(this.ficheFigurineStuff1);
            this.Controls.Add(this.ficheEquipementSansRecherche1);
            this.Controls.Add(this.ficheEquipementSurFigurine1);
            this.Controls.Add(this.buttonEnleverEquipementSurPersonnage);
            this.Controls.Add(this.buttonAjoutEquipementSurPersonnage);
            this.Controls.Add(this.listeDeroulanteChar1);
            this.Controls.Add(this.labelSubunity);
            this.Controls.Add(this.listeDeroulanteSubUnity1);
            this.Controls.Add(this.listeDeroulanteUnity1);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.labelMesFigurines);
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
            this.Size = new System.Drawing.Size(1125, 586);
            this.Load += new System.EventHandler(this.MaCollectionONLoad);
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
        private System.Windows.Forms.Label labelMesFigurines;
        private ButtonOptionsUser buttonOptionsUser1;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private ListeDeroulanteUnity listeDeroulanteUnity1;
        private ListeDeroulanteSubUnity listeDeroulanteSubUnity1;
        private System.Windows.Forms.Label labelSubunity;
        private ListeDeroulanteChar listeDeroulanteChar1;
        private System.Windows.Forms.Button buttonAjoutEquipementSurPersonnage;
        private System.Windows.Forms.Button buttonEnleverEquipementSurPersonnage;
        private FicheEquipementSurFigurine ficheEquipementSurFigurine1;
        private FicheEquipementSansRecherche ficheEquipementSansRecherche1;
        private FicheFigurineStuff ficheFigurineStuff1;
        private System.Windows.Forms.Button buttonAnnulerPersonnage;
        private System.Windows.Forms.Button buttonSupprimerPersonnage;
        private System.Windows.Forms.Button buttonAjouterFigurine;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}
