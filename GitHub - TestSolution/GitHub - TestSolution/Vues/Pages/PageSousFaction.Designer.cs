namespace EICE_WARGAME
{
    partial class PageSousFaction
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
            this.labelSousFactionTitre = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.labelChoisirFaction = new System.Windows.Forms.Label();
            this.buttonAjouterSF = new System.Windows.Forms.Button();
            this.buttonModifierSF = new System.Windows.Forms.Button();
            this.buttonSupprimerSF = new System.Windows.Forms.Button();
            this.buttonAnnulerSF = new System.Windows.Forms.Button();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.labelRecherche = new System.Windows.Forms.Label();
            this.textBoxSousFaction = new System.Windows.Forms.TextBox();
            this.errorProviderSousFaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderValider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ficheSousFaction1 = new EICE_WARGAME.FicheSousFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSousFaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSousFactionTitre
            // 
            this.labelSousFactionTitre.AutoSize = true;
            this.labelSousFactionTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelSousFactionTitre.ForeColor = System.Drawing.Color.SlateGray;
            this.labelSousFactionTitre.Location = new System.Drawing.Point(233, 20);
            this.labelSousFactionTitre.Name = "labelSousFactionTitre";
            this.labelSousFactionTitre.Size = new System.Drawing.Size(242, 46);
            this.labelSousFactionTitre.TabIndex = 1;
            this.labelSousFactionTitre.Text = "Sous faction";
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSousFaction.Location = new System.Drawing.Point(597, 232);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(91, 18);
            this.labelSousFaction.TabIndex = 2;
            this.labelSousFaction.Text = "Sous faction";
            // 
            // labelChoisirFaction
            // 
            this.labelChoisirFaction.AutoSize = true;
            this.labelChoisirFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelChoisirFaction.Location = new System.Drawing.Point(597, 169);
            this.labelChoisirFaction.Name = "labelChoisirFaction";
            this.labelChoisirFaction.Size = new System.Drawing.Size(131, 18);
            this.labelChoisirFaction.TabIndex = 6;
            this.labelChoisirFaction.Text = "Choisir une faction";
            // 
            // buttonAjouterSF
            // 
            this.buttonAjouterSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSF.Location = new System.Drawing.Point(670, 505);
            this.buttonAjouterSF.Name = "buttonAjouterSF";
            this.buttonAjouterSF.Size = new System.Drawing.Size(105, 29);
            this.buttonAjouterSF.TabIndex = 26;
            this.buttonAjouterSF.Text = "Ajouter";
            this.buttonAjouterSF.UseVisualStyleBackColor = false;
            this.buttonAjouterSF.Click += new System.EventHandler(this.buttonAjouterSF_Click);
            // 
            // buttonModifierSF
            // 
            this.buttonModifierSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifierSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierSF.Location = new System.Drawing.Point(781, 505);
            this.buttonModifierSF.Name = "buttonModifierSF";
            this.buttonModifierSF.Size = new System.Drawing.Size(105, 29);
            this.buttonModifierSF.TabIndex = 27;
            this.buttonModifierSF.Text = "Modifier";
            this.buttonModifierSF.UseVisualStyleBackColor = false;
            this.buttonModifierSF.Click += new System.EventHandler(this.buttonModifierSF_Click);
            // 
            // buttonSupprimerSF
            // 
            this.buttonSupprimerSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerSF.Location = new System.Drawing.Point(1003, 505);
            this.buttonSupprimerSF.Name = "buttonSupprimerSF";
            this.buttonSupprimerSF.Size = new System.Drawing.Size(105, 29);
            this.buttonSupprimerSF.TabIndex = 28;
            this.buttonSupprimerSF.Text = "Supprimer";
            this.buttonSupprimerSF.UseVisualStyleBackColor = false;
            this.buttonSupprimerSF.Click += new System.EventHandler(this.buttonSupprimerSF_Click);
            // 
            // buttonAnnulerSF
            // 
            this.buttonAnnulerSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnulerSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerSF.Location = new System.Drawing.Point(892, 505);
            this.buttonAnnulerSF.Name = "buttonAnnulerSF";
            this.buttonAnnulerSF.Size = new System.Drawing.Size(105, 29);
            this.buttonAnnulerSF.TabIndex = 29;
            this.buttonAnnulerSF.Text = "Annuler";
            this.buttonAnnulerSF.UseVisualStyleBackColor = false;
            this.buttonAnnulerSF.Click += new System.EventHandler(this.buttonAnnulerSF_Click);
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 30;
            // 
            // labelRecherche
            // 
            this.labelRecherche.AutoSize = true;
            this.labelRecherche.Location = new System.Drawing.Point(889, 170);
            this.labelRecherche.Name = "labelRecherche";
            this.labelRecherche.Size = new System.Drawing.Size(190, 17);
            this.labelRecherche.TabIndex = 32;
            this.labelRecherche.Text = "Rechercher une sous faction";
            // 
            // textBoxSousFaction
            // 
            this.textBoxSousFaction.Location = new System.Drawing.Point(600, 253);
            this.textBoxSousFaction.Name = "textBoxSousFaction";
            this.textBoxSousFaction.Size = new System.Drawing.Size(286, 22);
            this.textBoxSousFaction.TabIndex = 33;
            this.textBoxSousFaction.Enter += new System.EventHandler(this.textBoxSousFaction_Enter);
            // 
            // errorProviderSousFaction
            // 
            this.errorProviderSousFaction.BlinkRate = 0;
            this.errorProviderSousFaction.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderSousFaction.ContainerControl = this;
            // 
            // errorProviderValider
            // 
            this.errorProviderValider.BlinkRate = 0;
            this.errorProviderValider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderValider.ContainerControl = this;
            // 
            // ficheSousFaction1
            // 
            this.ficheSousFaction1.Location = new System.Drawing.Point(892, 190);
            this.ficheSousFaction1.Name = "ficheSousFaction1";
            this.ficheSousFaction1.Size = new System.Drawing.Size(289, 286);
            this.ficheSousFaction1.SousFactionSelectionne = null;
            this.ficheSousFaction1.TabIndex = 31;
            this.ficheSousFaction1.TexteDuFiltre = "";
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 23;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // listeDeroulanteFaction1
            // 
            this.listeDeroulanteFaction1.FactionSelectionnee = null;
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(600, 190);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(286, 25);
            this.listeDeroulanteFaction1.TabIndex = 5;
            // 
            // menuAdmin1
            // 
            this.menuAdmin1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuAdmin1.EstAdmin = false;
            this.menuAdmin1.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin1.MaPageActive = 0;
            this.menuAdmin1.Name = "menuAdmin1";
            this.menuAdmin1.Size = new System.Drawing.Size(190, 750);
            this.menuAdmin1.TabIndex = 34;
            this.menuAdmin1.Utilisateur = null;
            // 
            // buttonRetourDashBoard1
            // 
            this.buttonRetourDashBoard1.Location = new System.Drawing.Point(196, 3);
            this.buttonRetourDashBoard1.Name = "buttonRetourDashBoard1";
            this.buttonRetourDashBoard1.Size = new System.Drawing.Size(44, 34);
            this.buttonRetourDashBoard1.TabIndex = 35;
            this.buttonRetourDashBoard1.Utilisateur = null;
            // 
            // PageSousFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.textBoxSousFaction);
            this.Controls.Add(this.labelRecherche);
            this.Controls.Add(this.ficheSousFaction1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.buttonAnnulerSF);
            this.Controls.Add(this.buttonSupprimerSF);
            this.Controls.Add(this.buttonModifierSF);
            this.Controls.Add(this.buttonAjouterSF);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.labelChoisirFaction);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.labelSousFaction);
            this.Controls.Add(this.labelSousFactionTitre);
            this.Name = "PageSousFaction";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageAjoutFactionSousFaction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSousFaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSousFactionTitre;
        private System.Windows.Forms.Label labelSousFaction;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private System.Windows.Forms.Label labelChoisirFaction;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonAjouterSF;
        private System.Windows.Forms.Button buttonModifierSF;
        private System.Windows.Forms.Button buttonSupprimerSF;
        private System.Windows.Forms.Button buttonAnnulerSF;
        private System.Windows.Forms.Panel panelLigne;
        private FicheSousFaction ficheSousFaction1;
        private System.Windows.Forms.Label labelRecherche;
        private System.Windows.Forms.TextBox textBoxSousFaction;
        private System.Windows.Forms.ErrorProvider errorProviderSousFaction;
        private System.Windows.Forms.ErrorProvider errorProviderValider;
        private MenuAdmin menuAdmin1;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
    }
}
