namespace EICE_WARGAME
{
    partial class PageAjoutFactionSousFaction
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
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.labelChoisirFaction = new System.Windows.Forms.Label();
            this.labelTextBoxFaction = new System.Windows.Forms.Label();
            this.textBoxFaction = new System.Windows.Forms.TextBox();
            this.buttonAjoutFaction = new System.Windows.Forms.Button();
            this.buttonSupprimerFaction = new System.Windows.Forms.Button();
            this.buttonAnnulerFaction = new System.Windows.Forms.Button();
            this.buttonModifierFaction = new System.Windows.Forms.Button();
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
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelFaction.Location = new System.Drawing.Point(233, 20);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(152, 46);
            this.labelFaction.TabIndex = 1;
            this.labelFaction.Text = "Faction";
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelSousFaction.Location = new System.Drawing.Point(599, 262);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(91, 18);
            this.labelSousFaction.TabIndex = 2;
            this.labelSousFaction.Text = "Sous faction";
            // 
            // labelChoisirFaction
            // 
            this.labelChoisirFaction.AutoSize = true;
            this.labelChoisirFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelChoisirFaction.Location = new System.Drawing.Point(599, 131);
            this.labelChoisirFaction.Name = "labelChoisirFaction";
            this.labelChoisirFaction.Size = new System.Drawing.Size(131, 18);
            this.labelChoisirFaction.TabIndex = 6;
            this.labelChoisirFaction.Text = "Choisir une faction";
            // 
            // labelTextBoxFaction
            // 
            this.labelTextBoxFaction.AutoSize = true;
            this.labelTextBoxFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelTextBoxFaction.Location = new System.Drawing.Point(599, 186);
            this.labelTextBoxFaction.Name = "labelTextBoxFaction";
            this.labelTextBoxFaction.Size = new System.Drawing.Size(57, 18);
            this.labelTextBoxFaction.TabIndex = 8;
            this.labelTextBoxFaction.Text = "Faction";
            // 
            // textBoxFaction
            // 
            this.textBoxFaction.Location = new System.Drawing.Point(753, 182);
            this.textBoxFaction.Name = "textBoxFaction";
            this.textBoxFaction.Size = new System.Drawing.Size(282, 22);
            this.textBoxFaction.TabIndex = 9;
            // 
            // buttonAjoutFaction
            // 
            this.buttonAjoutFaction.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjoutFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjoutFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAjoutFaction.Location = new System.Drawing.Point(602, 568);
            this.buttonAjoutFaction.Name = "buttonAjoutFaction";
            this.buttonAjoutFaction.Size = new System.Drawing.Size(135, 49);
            this.buttonAjoutFaction.TabIndex = 10;
            this.buttonAjoutFaction.Text = "Ajouter";
            this.buttonAjoutFaction.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimerFaction
            // 
            this.buttonSupprimerFaction.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonSupprimerFaction.Location = new System.Drawing.Point(1025, 568);
            this.buttonSupprimerFaction.Name = "buttonSupprimerFaction";
            this.buttonSupprimerFaction.Size = new System.Drawing.Size(135, 49);
            this.buttonSupprimerFaction.TabIndex = 11;
            this.buttonSupprimerFaction.Text = "Supprimer";
            this.buttonSupprimerFaction.UseVisualStyleBackColor = false;
            // 
            // buttonAnnulerFaction
            // 
            this.buttonAnnulerFaction.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnulerFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnulerFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonAnnulerFaction.Location = new System.Drawing.Point(884, 568);
            this.buttonAnnulerFaction.Name = "buttonAnnulerFaction";
            this.buttonAnnulerFaction.Size = new System.Drawing.Size(135, 49);
            this.buttonAnnulerFaction.TabIndex = 12;
            this.buttonAnnulerFaction.Text = "Annuler";
            this.buttonAnnulerFaction.UseVisualStyleBackColor = false;
            // 
            // buttonModifierFaction
            // 
            this.buttonModifierFaction.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifierFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.buttonModifierFaction.Location = new System.Drawing.Point(743, 568);
            this.buttonModifierFaction.Name = "buttonModifierFaction";
            this.buttonModifierFaction.Size = new System.Drawing.Size(135, 49);
            this.buttonModifierFaction.TabIndex = 13;
            this.buttonModifierFaction.Text = "Modifier";
            this.buttonModifierFaction.UseVisualStyleBackColor = false;
            // 
            // buttonAjouterSF
            // 
            this.buttonAjouterSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterSF.Location = new System.Drawing.Point(1068, 262);
            this.buttonAjouterSF.Name = "buttonAjouterSF";
            this.buttonAjouterSF.Size = new System.Drawing.Size(92, 29);
            this.buttonAjouterSF.TabIndex = 26;
            this.buttonAjouterSF.Text = "Ajouter";
            this.buttonAjouterSF.UseVisualStyleBackColor = false;
            // 
            // buttonModifierSF
            // 
            this.buttonModifierSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifierSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifierSF.Location = new System.Drawing.Point(1068, 297);
            this.buttonModifierSF.Name = "buttonModifierSF";
            this.buttonModifierSF.Size = new System.Drawing.Size(92, 29);
            this.buttonModifierSF.TabIndex = 27;
            this.buttonModifierSF.Text = "Modifier";
            this.buttonModifierSF.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimerSF
            // 
            this.buttonSupprimerSF.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimerSF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimerSF.Location = new System.Drawing.Point(1068, 367);
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
            this.buttonAnnulerSF.Location = new System.Drawing.Point(1068, 332);
            this.buttonAnnulerSF.Name = "buttonAnnulerSF";
            this.buttonAnnulerSF.Size = new System.Drawing.Size(92, 29);
            this.buttonAnnulerSF.TabIndex = 29;
            this.buttonAnnulerSF.Text = "Annuler";
            this.buttonAnnulerSF.UseVisualStyleBackColor = false;
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
            this.ficheSousFaction1.Location = new System.Drawing.Point(751, 262);
            this.ficheSousFaction1.Name = "ficheSousFaction1";
            this.ficheSousFaction1.ReactionEnDirectSurChangementFiltre = false;
            this.ficheSousFaction1.Size = new System.Drawing.Size(291, 284);
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
            this.listeDeroulanteFaction1.Location = new System.Drawing.Point(751, 131);
            this.listeDeroulanteFaction1.Name = "listeDeroulanteFaction1";
            this.listeDeroulanteFaction1.Size = new System.Drawing.Size(282, 24);
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
            // PageAjoutFactionSousFaction
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
            this.Controls.Add(this.buttonModifierFaction);
            this.Controls.Add(this.buttonAnnulerFaction);
            this.Controls.Add(this.buttonSupprimerFaction);
            this.Controls.Add(this.buttonAjoutFaction);
            this.Controls.Add(this.textBoxFaction);
            this.Controls.Add(this.labelTextBoxFaction);
            this.Controls.Add(this.labelChoisirFaction);
            this.Controls.Add(this.listeDeroulanteFaction1);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.labelSousFaction);
            this.Controls.Add(this.labelFaction);
            this.Name = "PageAjoutFactionSousFaction";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageAjoutFactionSousFaction_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Label labelSousFaction;
        private MenuAdmin menuAdmin1;
        private ListeDeroulanteFaction listeDeroulanteFaction1;
        private System.Windows.Forms.Label labelChoisirFaction;
        private System.Windows.Forms.Label labelTextBoxFaction;
        private System.Windows.Forms.TextBox textBoxFaction;
        private System.Windows.Forms.Button buttonAjoutFaction;
        private System.Windows.Forms.Button buttonSupprimerFaction;
        private System.Windows.Forms.Button buttonAnnulerFaction;
        private System.Windows.Forms.Button buttonModifierFaction;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonAjouterSF;
        private System.Windows.Forms.Button buttonModifierSF;
        private System.Windows.Forms.Button buttonSupprimerSF;
        private System.Windows.Forms.Button buttonAnnulerSF;
        private System.Windows.Forms.Panel panelLigne;
        private FicheSousFaction ficheSousFaction1;
    }
}
