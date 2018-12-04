namespace EICE_WARGAME
{
    partial class PageGestionFigurines
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
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.labelTitreFigurine = new System.Windows.Forms.Label();
            this.labelFaction = new System.Windows.Forms.Label();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.labelNomFigurine = new System.Windows.Forms.Label();
            this.textBoxNomFigurine = new System.Windows.Forms.TextBox();
            this.labelRang = new System.Windows.Forms.Label();
            this.textBoxNomRang = new System.Windows.Forms.TextBox();
            this.labelType = new System.Windows.Forms.Label();
            this.listeDeroulanteType1 = new EICE_WARGAME.ListeDeroulanteType();
            this.labelPointsUnite = new System.Windows.Forms.Label();
            this.textBoxPtsParUnite = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelCaracteristiques = new System.Windows.Forms.Label();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // menuAdmin1
            // 
            this.menuAdmin1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuAdmin1.EstAdmin = false;
            this.menuAdmin1.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin1.MaPageActive = 0;
            this.menuAdmin1.Name = "menuAdmin1";
            this.menuAdmin1.Size = new System.Drawing.Size(190, 750);
            this.menuAdmin1.TabIndex = 0;
            this.menuAdmin1.Utilisateur = null;
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
            // labelTitreFigurine
            // 
            this.labelTitreFigurine.AutoSize = true;
            this.labelTitreFigurine.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelTitreFigurine.ForeColor = System.Drawing.Color.SlateGray;
            this.labelTitreFigurine.Location = new System.Drawing.Point(233, 20);
            this.labelTitreFigurine.Name = "labelTitreFigurine";
            this.labelTitreFigurine.Size = new System.Drawing.Size(163, 46);
            this.labelTitreFigurine.TabIndex = 2;
            this.labelTitreFigurine.Text = "Figurine";
            // 
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelFaction.Location = new System.Drawing.Point(294, 127);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(64, 20);
            this.labelFaction.TabIndex = 3;
            this.labelFaction.Text = "Faction";
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.ForeColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 33;
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(655, 148);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(208, 25);
            this.listeDeroulanteFaction1.TabIndex = 34;
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSousFaction.Location = new System.Drawing.Point(652, 127);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(91, 18);
            this.labelSousFaction.TabIndex = 35;
            this.labelSousFaction.Text = "Sous faction";
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(298, 148);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(208, 24);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 36;
            // 
            // labelNomFigurine
            // 
            this.labelNomFigurine.AutoSize = true;
            this.labelNomFigurine.Location = new System.Drawing.Point(1029, 130);
            this.labelNomFigurine.Name = "labelNomFigurine";
            this.labelNomFigurine.Size = new System.Drawing.Size(123, 17);
            this.labelNomFigurine.TabIndex = 37;
            this.labelNomFigurine.Text = "Nom de la firguine";
            // 
            // textBoxNomFigurine
            // 
            this.textBoxNomFigurine.Location = new System.Drawing.Point(1032, 150);
            this.textBoxNomFigurine.Name = "textBoxNomFigurine";
            this.textBoxNomFigurine.Size = new System.Drawing.Size(208, 22);
            this.textBoxNomFigurine.TabIndex = 38;
            // 
            // labelRang
            // 
            this.labelRang.AutoSize = true;
            this.labelRang.Location = new System.Drawing.Point(295, 230);
            this.labelRang.Name = "labelRang";
            this.labelRang.Size = new System.Drawing.Size(42, 17);
            this.labelRang.TabIndex = 39;
            this.labelRang.Text = "Rang";
            // 
            // textBoxNomRang
            // 
            this.textBoxNomRang.Location = new System.Drawing.Point(298, 250);
            this.textBoxNomRang.Name = "textBoxNomRang";
            this.textBoxNomRang.Size = new System.Drawing.Size(208, 22);
            this.textBoxNomRang.TabIndex = 40;
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(652, 230);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(40, 17);
            this.labelType.TabIndex = 41;
            this.labelType.Text = "Type";
            // 
            // listeDeroulanteType1
            // 
            this.listeDeroulanteType1.Location = new System.Drawing.Point(655, 250);
            this.listeDeroulanteType1.Name = "listeDeroulanteType1";
            this.listeDeroulanteType1.Size = new System.Drawing.Size(208, 25);
            this.listeDeroulanteType1.TabIndex = 42;
            this.listeDeroulanteType1.TypeSelectionne = null;
            // 
            // labelPointsUnite
            // 
            this.labelPointsUnite.AutoSize = true;
            this.labelPointsUnite.Location = new System.Drawing.Point(1029, 230);
            this.labelPointsUnite.Name = "labelPointsUnite";
            this.labelPointsUnite.Size = new System.Drawing.Size(107, 17);
            this.labelPointsUnite.TabIndex = 43;
            this.labelPointsUnite.Text = "Points par unité";
            // 
            // textBoxPtsParUnite
            // 
            this.textBoxPtsParUnite.Location = new System.Drawing.Point(1032, 252);
            this.textBoxPtsParUnite.Name = "textBoxPtsParUnite";
            this.textBoxPtsParUnite.Size = new System.Drawing.Size(208, 22);
            this.textBoxPtsParUnite.TabIndex = 44;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(241, 358);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 3);
            this.panel1.TabIndex = 34;
            // 
            // labelCaracteristiques
            // 
            this.labelCaracteristiques.AutoSize = true;
            this.labelCaracteristiques.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelCaracteristiques.ForeColor = System.Drawing.Color.SlateGray;
            this.labelCaracteristiques.Location = new System.Drawing.Point(233, 364);
            this.labelCaracteristiques.Name = "labelCaracteristiques";
            this.labelCaracteristiques.Size = new System.Drawing.Size(308, 46);
            this.labelCaracteristiques.TabIndex = 45;
            this.labelCaracteristiques.Text = "Caracteristiques";
            // 
            // buttonRetourDashBoard1
            // 
            this.buttonRetourDashBoard1.Location = new System.Drawing.Point(196, 3);
            this.buttonRetourDashBoard1.Name = "buttonRetourDashBoard1";
            this.buttonRetourDashBoard1.Size = new System.Drawing.Size(44, 34);
            this.buttonRetourDashBoard1.TabIndex = 46;
            this.buttonRetourDashBoard1.Utilisateur = null;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(298, 443);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(46, 17);
            this.label.TabIndex = 47;
            this.label.Text = "label1";
            // 
            // PageGestionFigurines
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label);
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.labelCaracteristiques);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBoxPtsParUnite);
            this.Controls.Add(this.labelPointsUnite);
            this.Controls.Add(this.listeDeroulanteType1);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.textBoxNomRang);
            this.Controls.Add(this.labelRang);
            this.Controls.Add(this.textBoxNomFigurine);
            this.Controls.Add(this.labelNomFigurine);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.labelSousFaction);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelFaction);
            this.Controls.Add(this.labelTitreFigurine);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.menuAdmin1);
            this.Name = "PageGestionFigurines";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageGestionFigurine_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuAdmin menuAdmin1;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Label labelTitreFigurine;
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Panel panelLigne;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private System.Windows.Forms.Label labelSousFaction;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private System.Windows.Forms.Label labelNomFigurine;
        private System.Windows.Forms.TextBox textBoxNomFigurine;
        private System.Windows.Forms.Label labelRang;
        private System.Windows.Forms.TextBox textBoxNomRang;
        private System.Windows.Forms.Label labelType;
        private ListeDeroulanteType listeDeroulanteType1;
        private System.Windows.Forms.Label labelPointsUnite;
        private System.Windows.Forms.TextBox textBoxPtsParUnite;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelCaracteristiques;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
        private System.Windows.Forms.Label label;
    }
}
