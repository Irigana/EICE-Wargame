namespace EICE_WARGAME
{
    partial class PageSubUnity
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
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.labelSousUnity = new System.Windows.Forms.Label();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 0;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // buttonRetourDashBoard1
            // 
            this.buttonRetourDashBoard1.Location = new System.Drawing.Point(196, 3);
            this.buttonRetourDashBoard1.Name = "buttonRetourDashBoard1";
            this.buttonRetourDashBoard1.Size = new System.Drawing.Size(44, 34);
            this.buttonRetourDashBoard1.TabIndex = 50;
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
            this.menuAdmin1.TabIndex = 49;
            this.menuAdmin1.Utilisateur = null;
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.ForeColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 48;
            // 
            // labelSousUnity
            // 
            this.labelSousUnity.AutoSize = true;
            this.labelSousUnity.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelSousUnity.ForeColor = System.Drawing.Color.SlateGray;
            this.labelSousUnity.Location = new System.Drawing.Point(233, 20);
            this.labelSousUnity.Name = "labelSousUnity";
            this.labelSousUnity.Size = new System.Drawing.Size(209, 46);
            this.labelSousUnity.TabIndex = 47;
            this.labelSousUnity.Text = "Sous unité";
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(365, 124);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(208, 24);
            this.listeDeroulanteFaction1.TabIndex = 51;
            // 
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFaction.Location = new System.Drawing.Point(362, 104);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(65, 18);
            this.labelFaction.TabIndex = 52;
            this.labelFaction.Text = "Faction :";
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSousFaction.Location = new System.Drawing.Point(362, 173);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(99, 18);
            this.labelSousFaction.TabIndex = 53;
            this.labelSousFaction.Text = "Sous faction :";
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(365, 193);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(208, 24);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 54;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(241, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 3);
            this.panel1.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label1.ForeColor = System.Drawing.Color.SlateGray;
            this.label1.Location = new System.Drawing.Point(236, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 29);
            this.label1.TabIndex = 49;
            this.label1.Text = "Optionnel";
            // 
            // PageSubUnity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listeDeroulanteSousFaction1);
            this.Controls.Add(this.labelSousFaction);
            this.Controls.Add(this.labelFaction);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelSousUnity);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Name = "PageSubUnity";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageSubUnity_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonOptionsUser buttonOptionsUser1;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
        private MenuAdmin menuAdmin1;
        private System.Windows.Forms.Panel panelLigne;
        private System.Windows.Forms.Label labelSousUnity;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Label labelSousFaction;
        private ListeDeroulanteSousFaction listeDeroulanteSousFaction1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}
