namespace EICE_WARGAME
{
    partial class PageFaction
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
            this.labelFaction = new System.Windows.Forms.Label();
            this.panelLigne = new System.Windows.Forms.Panel();
            this.labelRechercherFaction = new System.Windows.Forms.Label();
            this.textBoxFaction = new System.Windows.Forms.TextBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.errorProviderErreurFaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelNew = new System.Windows.Forms.Label();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.ficheFaction1 = new EICE_WARGAME.FicheFaction();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreurFaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelFaction.ForeColor = System.Drawing.Color.SlateGray;
            this.labelFaction.Location = new System.Drawing.Point(233, 20);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(152, 46);
            this.labelFaction.TabIndex = 2;
            this.labelFaction.Text = "Faction";
            // 
            // panelLigne
            // 
            this.panelLigne.BackColor = System.Drawing.Color.SteelBlue;
            this.panelLigne.Location = new System.Drawing.Point(241, 69);
            this.panelLigne.Name = "panelLigne";
            this.panelLigne.Size = new System.Drawing.Size(1200, 3);
            this.panelLigne.TabIndex = 31;
            // 
            // labelRechercherFaction
            // 
            this.labelRechercherFaction.AutoSize = true;
            this.labelRechercherFaction.Location = new System.Drawing.Point(738, 206);
            this.labelRechercherFaction.Name = "labelRechercherFaction";
            this.labelRechercherFaction.Size = new System.Drawing.Size(156, 17);
            this.labelRechercherFaction.TabIndex = 33;
            this.labelRechercherFaction.Text = "Rechercher une faction";
            // 
            // textBoxFaction
            // 
            this.textBoxFaction.Location = new System.Drawing.Point(739, 522);
            this.textBoxFaction.Name = "textBoxFaction";
            this.textBoxFaction.Size = new System.Drawing.Size(286, 22);
            this.textBoxFaction.TabIndex = 34;
            this.textBoxFaction.Enter += new System.EventHandler(this.textBoxFaction_Enter);
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Location = new System.Drawing.Point(665, 560);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(105, 29);
            this.buttonAjouter.TabIndex = 35;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Location = new System.Drawing.Point(776, 560);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(105, 29);
            this.buttonModifier.TabIndex = 36;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            this.buttonModifier.Click += new System.EventHandler(this.buttonModifier_Click);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Location = new System.Drawing.Point(887, 560);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(105, 29);
            this.buttonAnnuler.TabIndex = 37;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Location = new System.Drawing.Point(998, 560);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(105, 29);
            this.buttonSupprimer.TabIndex = 38;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            this.buttonSupprimer.Click += new System.EventHandler(this.buttonSupprimer_Click);
            // 
            // errorProviderErreurFaction
            // 
            this.errorProviderErreurFaction.BlinkRate = 0;
            this.errorProviderErreurFaction.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderErreurFaction.ContainerControl = this;
            // 
            // ValidationProvider
            // 
            this.ValidationProvider.BlinkRate = 0;
            this.ValidationProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ValidationProvider.ContainerControl = this;
            // 
            // labelNew
            // 
            this.labelNew.AutoSize = true;
            this.labelNew.Location = new System.Drawing.Point(671, 525);
            this.labelNew.Name = "labelNew";
            this.labelNew.Size = new System.Drawing.Size(62, 17);
            this.labelNew.TabIndex = 40;
            this.labelNew.Text = "Faction :";
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
            this.menuAdmin1.Load += new System.EventHandler(this.PageFaction_Load);
            // 
            // ficheFaction1
            // 
            this.ficheFaction1.FactionSelectionne = null;
            this.ficheFaction1.Location = new System.Drawing.Point(736, 226);
            this.ficheFaction1.Name = "ficheFaction1";
            this.ficheFaction1.Size = new System.Drawing.Size(290, 295);
            this.ficheFaction1.TabIndex = 32;
            this.ficheFaction1.TexteFiltreFaction = "";
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
            // PageFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelNew);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.textBoxFaction);
            this.Controls.Add(this.labelRechercherFaction);
            this.Controls.Add(this.ficheFaction1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelFaction);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Name = "PageFaction";
            this.Size = new System.Drawing.Size(1500, 750);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderErreurFaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Panel panelLigne;
        private FicheFaction ficheFaction1;
        private System.Windows.Forms.Label labelRechercherFaction;
        private System.Windows.Forms.TextBox textBoxFaction;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.ErrorProvider errorProviderErreurFaction;
        private System.Windows.Forms.ErrorProvider ValidationProvider;
        private System.Windows.Forms.Label labelNew;
        private MenuAdmin menuAdmin1;
    }
}
