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
            this.labelSousFactionTitre = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.labelChoisirFaction = new System.Windows.Forms.Label();
            this.buttonAjouterSF = new System.Windows.Forms.Button();
            this.buttonModifierSF = new System.Windows.Forms.Button();
            this.buttonSupprimerSF = new System.Windows.Forms.Button();
            this.buttonAnnulerSF = new System.Windows.Forms.Button();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.ficheSousFaction1 = new EICE_WARGAME.FicheSousFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.listeDeroulanteFaction1 = new EICE_WARGAME.ListeDeroulanteFaction();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.SuspendLayout();
            // 
            // labelSousFactionTitre
            // 
            this.labelSousFactionTitre.AutoSize = true;
            this.labelSousFactionTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
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
            this.labelSousFaction.Location = new System.Drawing.Point(617, 240);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(91, 18);
            this.labelSousFaction.TabIndex = 2;
            this.labelSousFaction.Text = "Sous faction";
            // 
            // labelChoisirFaction
            // 
            this.labelChoisirFaction.AutoSize = true;
            this.labelChoisirFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelChoisirFaction.Location = new System.Drawing.Point(577, 160);
            this.labelChoisirFaction.Name = "labelChoisirFaction";
            this.labelChoisirFaction.Size = new System.Drawing.Size(131, 18);
            this.labelChoisirFaction.TabIndex = 6;
            this.labelChoisirFaction.Text = "Choisir une faction";
            // 
            // buttonAjouterSF
            // 
            this.buttonAjouterSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSF.Location = new System.Drawing.Point(1082, 240);
            this.buttonAjouterSF.Name = "buttonAjouterSF";
            this.buttonAjouterSF.Size = new System.Drawing.Size(92, 29);
            this.buttonAjouterSF.TabIndex = 26;
            this.buttonAjouterSF.Text = "Ajouter";
            this.buttonAjouterSF.UseVisualStyleBackColor = false;
            this.buttonAjouterSF.Click += new System.EventHandler(this.buttonAjouterSF_Click);
            // 
            // buttonModifierSF
            // 
            this.buttonModifierSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifierSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierSF.Location = new System.Drawing.Point(1082, 275);
            this.buttonModifierSF.Name = "buttonModifierSF";
            this.buttonModifierSF.Size = new System.Drawing.Size(92, 29);
            this.buttonModifierSF.TabIndex = 27;
            this.buttonModifierSF.Text = "Modifier";
            this.buttonModifierSF.UseVisualStyleBackColor = false;
            this.buttonModifierSF.Click += new System.EventHandler(this.buttonModifierSF_Click);
            // 
            // buttonSupprimerSF
            // 
            this.buttonSupprimerSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerSF.Location = new System.Drawing.Point(1082, 345);
            this.buttonSupprimerSF.Name = "buttonSupprimerSF";
            this.buttonSupprimerSF.Size = new System.Drawing.Size(92, 29);
            this.buttonSupprimerSF.TabIndex = 28;
            this.buttonSupprimerSF.Text = "Supprimer";
            this.buttonSupprimerSF.UseVisualStyleBackColor = false;
            // 
            // buttonAnnulerSF
            // 
            this.buttonAnnulerSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnulerSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerSF.Location = new System.Drawing.Point(1082, 310);
            this.buttonAnnulerSF.Name = "buttonAnnulerSF";
            this.buttonAnnulerSF.Size = new System.Drawing.Size(92, 29);
            this.buttonAnnulerSF.TabIndex = 29;
            this.buttonAnnulerSF.Text = "Annuler";
            this.buttonAnnulerSF.UseVisualStyleBackColor = false;
            this.buttonAnnulerSF.Click += new System.EventHandler(this.buttonAnnulerSF_Click);
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 30;
            // 
            // ficheSousFaction1
            // 
            this.ficheSousFaction1.Location = new System.Drawing.Point(739, 240);
            this.ficheSousFaction1.Name = "ficheSousFaction1";
            this.ficheSousFaction1.NombreDeSousFactionFiltre = -1;
            this.ficheSousFaction1.ReactionEnDirectSurChangementFiltre = false;
            this.ficheSousFaction1.Size = new System.Drawing.Size(337, 284);
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
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(739, 160);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(282, 25);
            this.listeDeroulanteFaction1.TabIndex = 5;
            // 
            // menuAdmin1
            // 
            this.menuAdmin1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuAdmin1.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin1.Name = "menuAdmin1";
            this.menuAdmin1.Size = new System.Drawing.Size(190, 750);
            this.menuAdmin1.TabIndex = 3;
            this.menuAdmin1.Utilisateur = null;
            // 
            // PageSousFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ficheSousFaction1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.buttonAnnulerSF);
            this.Controls.Add(this.buttonSupprimerSF);
            this.Controls.Add(this.buttonModifierSF);
            this.Controls.Add(this.buttonAjouterSF);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.labelChoisirFaction);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.labelSousFaction);
            this.Controls.Add(this.labelSousFactionTitre);
            this.Name = "PageSousFaction";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageAjoutFactionSousFaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelSousFactionTitre;
        private System.Windows.Forms.Label labelSousFaction;
        private MenuAdmin menuAdmin1;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private System.Windows.Forms.Label labelChoisirFaction;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonAjouterSF;
        private System.Windows.Forms.Button buttonModifierSF;
        private System.Windows.Forms.Button buttonSupprimerSF;
        private System.Windows.Forms.Button buttonAnnulerSF;
        private System.Windows.Forms.Panel panelLigne;
        private FicheSousFaction ficheSousFaction1;
    }
}
