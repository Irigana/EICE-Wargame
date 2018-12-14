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
            this.panelLigne = new System.Windows.Forms.Panel();
            this.labelSousUnity = new System.Windows.Forms.Label();
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelSubUnityAttacher = new System.Windows.Forms.Label();
            this.labelNewSubUnity = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.buttonAnnulerSubUnity = new System.Windows.Forms.Button();
            this.buttonSupprimerSubUnity = new System.Windows.Forms.Button();
            this.buttonAjouterSubUnity = new System.Windows.Forms.Button();
            this.ficheSubUnity1 = new EICE_WARGAME.FicheSubUnity();
            this.listeDeroulanteSousFaction1 = new EICE_WARGAME.ListeDeroulanteSousFaction();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.SuspendLayout();
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
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelFaction.Location = new System.Drawing.Point(454, 123);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(65, 18);
            this.labelFaction.TabIndex = 52;
            this.labelFaction.Text = "Faction :";
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSousFaction.Location = new System.Drawing.Point(454, 192);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(99, 18);
            this.labelSousFaction.TabIndex = 53;
            this.labelSousFaction.Text = "Sous faction :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.ForeColor = System.Drawing.Color.SteelBlue;
            this.panel1.Location = new System.Drawing.Point(241, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 3);
            this.panel1.TabIndex = 50;
            // 
            // labelSubUnityAttacher
            // 
            this.labelSubUnityAttacher.AutoSize = true;
            this.labelSubUnityAttacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelSubUnityAttacher.ForeColor = System.Drawing.Color.SlateGray;
            this.labelSubUnityAttacher.Location = new System.Drawing.Point(236, 414);
            this.labelSubUnityAttacher.Name = "labelSubUnityAttacher";
            this.labelSubUnityAttacher.Size = new System.Drawing.Size(350, 29);
            this.labelSubUnityAttacher.TabIndex = 49;
            this.labelSubUnityAttacher.Text = "Sous unité attachée (Optionnel)";
            // 
            // labelNewSubUnity
            // 
            this.labelNewSubUnity.AutoSize = true;
            this.labelNewSubUnity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNewSubUnity.Location = new System.Drawing.Point(457, 263);
            this.labelNewSubUnity.Name = "labelNewSubUnity";
            this.labelNewSubUnity.Size = new System.Drawing.Size(86, 18);
            this.labelNewSubUnity.TabIndex = 55;
            this.labelNewSubUnity.Text = "Sous unité :";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(457, 284);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(208, 22);
            this.textBox1.TabIndex = 56;
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelRecherche.Location = new System.Drawing.Point(805, 83);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(193, 18);
            this.labelRecherche.TabIndex = 58;
            this.labelRecherche.Text = "Rechercher une sous unité :";
            // 
            // buttonAnnulerSubUnity
            // 
            this.buttonAnnulerSubUnity.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnulerSubUnity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerSubUnity.Location = new System.Drawing.Point(507, 353);
            this.buttonAnnulerSubUnity.Name = "buttonAnnulerSubUnity";
            this.buttonAnnulerSubUnity.Size = new System.Drawing.Size(121, 39);
            this.buttonAnnulerSubUnity.TabIndex = 61;
            this.buttonAnnulerSubUnity.Text = "Annuler";
            this.buttonAnnulerSubUnity.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimerSubUnity
            // 
            this.buttonSupprimerSubUnity.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerSubUnity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerSubUnity.Location = new System.Drawing.Point(634, 353);
            this.buttonSupprimerSubUnity.Name = "buttonSupprimerSubUnity";
            this.buttonSupprimerSubUnity.Size = new System.Drawing.Size(121, 39);
            this.buttonSupprimerSubUnity.TabIndex = 62;
            this.buttonSupprimerSubUnity.Text = "Supprimer";
            this.buttonSupprimerSubUnity.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterSubUnity
            // 
            this.buttonAjouterSubUnity.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterSubUnity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSubUnity.Location = new System.Drawing.Point(380, 353);
            this.buttonAjouterSubUnity.Name = "buttonAjouterSubUnity";
            this.buttonAjouterSubUnity.Size = new System.Drawing.Size(121, 39);
            this.buttonAjouterSubUnity.TabIndex = 59;
            this.buttonAjouterSubUnity.Text = "Ajouter";
            this.buttonAjouterSubUnity.UseVisualStyleBackColor = false;
            // 
            // ficheSubUnity1
            // 
            this.ficheSubUnity1.Enabled = false;
            this.ficheSubUnity1.Location = new System.Drawing.Point(805, 104);
            this.ficheSubUnity1.Name = "ficheSubUnity1";
            this.ficheSubUnity1.Size = new System.Drawing.Size(293, 295);
            this.ficheSubUnity1.SubUnitySelectionne = null;
            this.ficheSubUnity1.TabIndex = 57;
            this.ficheSubUnity1.TexteFiltreSubUnity = "";
            // 
            // listeDeroulanteSousFaction1
            // 
            this.listeDeroulanteSousFaction1.Enabled = false;
            this.listeDeroulanteSousFaction1.Location = new System.Drawing.Point(457, 212);
            this.listeDeroulanteSousFaction1.Name = "listeDeroulanteSousFaction1";
            this.listeDeroulanteSousFaction1.Size = new System.Drawing.Size(208, 24);
            this.listeDeroulanteSousFaction1.SousFactionSelectionnee = null;
            this.listeDeroulanteSousFaction1.TabIndex = 54;
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(457, 143);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(208, 25);
            this.listeDeroulanteFaction1.TabIndex = 51;
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
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 0;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // PageSubUnity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAnnulerSubUnity);
            this.Controls.Add(this.buttonSupprimerSubUnity);
            this.Controls.Add(this.buttonAjouterSubUnity);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.ficheSubUnity1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNewSubUnity);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelSubUnityAttacher);
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
        private System.Windows.Forms.Label labelNewSubUnity;
        private System.Windows.Forms.TextBox textBox1;
        private FicheSubUnity ficheSubUnity1;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.Button buttonAnnulerSubUnity;
        private System.Windows.Forms.Button buttonSupprimerSubUnity;
        private System.Windows.Forms.Button buttonAjouterSubUnity;
        private System.Windows.Forms.Label labelSubUnityAttacher;
    }
}
