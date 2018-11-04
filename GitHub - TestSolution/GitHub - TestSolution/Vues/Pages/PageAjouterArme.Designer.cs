namespace EICE_WARGAME
{
    partial class PageAjouterArme
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
            this.labelCRUDArmes = new System.Windows.Forms.Label();
            this.panelLigneSeparatriceAjout = new System.Windows.Forms.Panel();
            this.labelNomArme = new System.Windows.Forms.Label();
            this.labelTypeArme = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelEquipablePar = new System.Windows.Forms.Label();
            this.checkedListBoxEquipable = new System.Windows.Forms.CheckedListBox();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.linkLabelDashboard = new System.Windows.Forms.LinkLabel();
            this.labelSepLink = new System.Windows.Forms.Label();
            this.labelFigurine = new System.Windows.Forms.Label();
            this.buttonModifier = new System.Windows.Forms.Button();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.checkBoxVisibility = new System.Windows.Forms.CheckBox();
            this.buttonAnnuler = new System.Windows.Forms.Button();
            this.textBoxNomEquipement = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAjouterCaract = new System.Windows.Forms.Button();
            this.listeDeroulanteStuff1 = new EICE_WARGAME.ListeDeroulanteStuff();
            this.listeDeroulanteFeature1 = new EICE_WARGAME.ListeDeroulanteFeature();
            this.listeDeroulanteType = new EICE_WARGAME.ListeDeroulanteType();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelCRUDArmes
            // 
            this.labelCRUDArmes.AutoSize = true;
            this.labelCRUDArmes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.labelCRUDArmes.Location = new System.Drawing.Point(223, 25);
            this.labelCRUDArmes.Name = "labelCRUDArmes";
            this.labelCRUDArmes.Size = new System.Drawing.Size(188, 36);
            this.labelCRUDArmes.TabIndex = 1;
            this.labelCRUDArmes.Text = "Equipements";
            // 
            // panelLigneSeparatriceAjout
            // 
            this.panelLigneSeparatriceAjout.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelLigneSeparatriceAjout.Location = new System.Drawing.Point(219, 75);
            this.panelLigneSeparatriceAjout.Name = "panelLigneSeparatriceAjout";
            this.panelLigneSeparatriceAjout.Size = new System.Drawing.Size(1250, 3);
            this.panelLigneSeparatriceAjout.TabIndex = 2;
            // 
            // labelNomArme
            // 
            this.labelNomArme.AutoSize = true;
            this.labelNomArme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelNomArme.Location = new System.Drawing.Point(225, 205);
            this.labelNomArme.Name = "labelNomArme";
            this.labelNomArme.Size = new System.Drawing.Size(166, 20);
            this.labelNomArme.TabIndex = 3;
            this.labelNomArme.Text = "Nom de l\'équipement";
            // 
            // labelTypeArme
            // 
            this.labelTypeArme.AutoSize = true;
            this.labelTypeArme.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelTypeArme.Location = new System.Drawing.Point(228, 147);
            this.labelTypeArme.Name = "labelTypeArme";
            this.labelTypeArme.Size = new System.Drawing.Size(167, 20);
            this.labelTypeArme.TabIndex = 5;
            this.labelTypeArme.Text = "Type de l\'équipement";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(219, 300);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1250, 3);
            this.panel1.TabIndex = 7;
            // 
            // labelEquipablePar
            // 
            this.labelEquipablePar.AutoSize = true;
            this.labelEquipablePar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.labelEquipablePar.Location = new System.Drawing.Point(224, 350);
            this.labelEquipablePar.Name = "labelEquipablePar";
            this.labelEquipablePar.Size = new System.Drawing.Size(164, 29);
            this.labelEquipablePar.TabIndex = 14;
            this.labelEquipablePar.Text = "Equipable par";
            // 
            // checkedListBoxEquipable
            // 
            this.checkedListBoxEquipable.FormattingEnabled = true;
            this.checkedListBoxEquipable.Location = new System.Drawing.Point(456, 342);
            this.checkedListBoxEquipable.Name = "checkedListBoxEquipable";
            this.checkedListBoxEquipable.Size = new System.Drawing.Size(265, 361);
            this.checkedListBoxEquipable.TabIndex = 15;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouter.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAjouter.Location = new System.Drawing.Point(1037, 678);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(140, 47);
            this.buttonAjouter.TabIndex = 18;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // linkLabelDashboard
            // 
            this.linkLabelDashboard.AutoSize = true;
            this.linkLabelDashboard.Location = new System.Drawing.Point(229, 85);
            this.linkLabelDashboard.Name = "linkLabelDashboard";
            this.linkLabelDashboard.Size = new System.Drawing.Size(78, 17);
            this.linkLabelDashboard.TabIndex = 19;
            this.linkLabelDashboard.TabStop = true;
            this.linkLabelDashboard.Text = "Dashboard";
            this.linkLabelDashboard.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDashboard_LinkClicked);
            // 
            // labelSepLink
            // 
            this.labelSepLink.AutoSize = true;
            this.labelSepLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelSepLink.Location = new System.Drawing.Point(305, 87);
            this.labelSepLink.Name = "labelSepLink";
            this.labelSepLink.Size = new System.Drawing.Size(16, 17);
            this.labelSepLink.TabIndex = 20;
            this.labelSepLink.Text = ">";
            // 
            // labelFigurine
            // 
            this.labelFigurine.AutoSize = true;
            this.labelFigurine.Location = new System.Drawing.Point(322, 86);
            this.labelFigurine.Name = "labelFigurine";
            this.labelFigurine.Size = new System.Drawing.Size(90, 17);
            this.labelFigurine.TabIndex = 21;
            this.labelFigurine.Text = "Equipements";
            // 
            // buttonModifier
            // 
            this.buttonModifier.BackColor = System.Drawing.SystemColors.Window;
            this.buttonModifier.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonModifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonModifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonModifier.Location = new System.Drawing.Point(1183, 678);
            this.buttonModifier.Name = "buttonModifier";
            this.buttonModifier.Size = new System.Drawing.Size(140, 47);
            this.buttonModifier.TabIndex = 22;
            this.buttonModifier.Text = "Modifier";
            this.buttonModifier.UseVisualStyleBackColor = false;
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSupprimer.Location = new System.Drawing.Point(1329, 678);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(140, 47);
            this.buttonSupprimer.TabIndex = 23;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // checkBoxVisibility
            // 
            this.checkBoxVisibility.AutoSize = true;
            this.checkBoxVisibility.Location = new System.Drawing.Point(417, 246);
            this.checkBoxVisibility.Name = "checkBoxVisibility";
            this.checkBoxVisibility.Size = new System.Drawing.Size(71, 21);
            this.checkBoxVisibility.TabIndex = 24;
            this.checkBoxVisibility.Text = "Visible";
            this.checkBoxVisibility.UseVisualStyleBackColor = true;
            this.checkBoxVisibility.CheckedChanged += new System.EventHandler(this.checkBoxVisibility_CheckedChanged);
            // 
            // buttonAnnuler
            // 
            this.buttonAnnuler.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAnnuler.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAnnuler.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonAnnuler.Location = new System.Drawing.Point(891, 678);
            this.buttonAnnuler.Name = "buttonAnnuler";
            this.buttonAnnuler.Size = new System.Drawing.Size(140, 47);
            this.buttonAnnuler.TabIndex = 25;
            this.buttonAnnuler.Text = "Annuler";
            this.buttonAnnuler.UseVisualStyleBackColor = false;
            this.buttonAnnuler.Click += new System.EventHandler(this.buttonAnnuler_Click);
            // 
            // textBoxNomEquipement
            // 
            this.textBoxNomEquipement.Location = new System.Drawing.Point(417, 205);
            this.textBoxNomEquipement.Name = "textBoxNomEquipement";
            this.textBoxNomEquipement.Size = new System.Drawing.Size(197, 22);
            this.textBoxNomEquipement.TabIndex = 26;
            this.textBoxNomEquipement.TextChanged += new System.EventHandler(this.textBoxNomEquipement_TextChanged);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Caractéristique";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(875, 246);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(206, 22);
            this.textBox1.TabIndex = 29;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(766, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Valeur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(766, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Equipement";
            // 
            // buttonAjouterCaract
            // 
            this.buttonAjouterCaract.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouterCaract.FlatAppearance.BorderColor = System.Drawing.SystemColors.WindowFrame;
            this.buttonAjouterCaract.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouterCaract.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonAjouterCaract.Location = new System.Drawing.Point(1120, 245);
            this.buttonAjouterCaract.Name = "buttonAjouterCaract";
            this.buttonAjouterCaract.Size = new System.Drawing.Size(148, 49);
            this.buttonAjouterCaract.TabIndex = 33;
            this.buttonAjouterCaract.Text = "Ajouter Caracteristique";
            this.buttonAjouterCaract.UseVisualStyleBackColor = false;
            this.buttonAjouterCaract.Click += new System.EventHandler(this.buttonAjouterCaract_Click);
            // 
            // listeDeroulanteStuff1
            // 
            this.listeDeroulanteStuff1.Location = new System.Drawing.Point(875, 155);
            this.listeDeroulanteStuff1.Name = "listeDeroulanteStuff1";
            this.listeDeroulanteStuff1.Size = new System.Drawing.Size(206, 26);
            this.listeDeroulanteStuff1.StuffSelectionnee = null;
            this.listeDeroulanteStuff1.TabIndex = 32;
            // 
            // listeDeroulanteFeature1
            // 
            this.listeDeroulanteFeature1.FeatureSelectionnee = null;
            this.listeDeroulanteFeature1.Location = new System.Drawing.Point(875, 200);
            this.listeDeroulanteFeature1.Name = "listeDeroulanteFeature1";
            this.listeDeroulanteFeature1.Size = new System.Drawing.Size(206, 25);
            this.listeDeroulanteFeature1.TabIndex = 28;
            // 
            // listeDeroulanteType
            // 
            this.listeDeroulanteType.Location = new System.Drawing.Point(417, 147);
            this.listeDeroulanteType.Name = "listeDeroulanteType";
            this.listeDeroulanteType.Size = new System.Drawing.Size(197, 25);
            this.listeDeroulanteType.TabIndex = 17;
            this.listeDeroulanteType.TypeSelectionne = null;
            this.listeDeroulanteType.Load += new System.EventHandler(this.listeDeroulanteType_Load);
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 16;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // menuAdmin1
            // 
            this.menuAdmin1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.menuAdmin1.Location = new System.Drawing.Point(0, 0);
            this.menuAdmin1.Name = "menuAdmin1";
            this.menuAdmin1.Size = new System.Drawing.Size(190, 750);
            this.menuAdmin1.TabIndex = 0;
            // 
            // PageAjouterArme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAjouterCaract);
            this.Controls.Add(this.listeDeroulanteStuff1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.listeDeroulanteFeature1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNomEquipement);
            this.Controls.Add(this.buttonAnnuler);
            this.Controls.Add(this.checkBoxVisibility);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.buttonModifier);
            this.Controls.Add(this.labelFigurine);
            this.Controls.Add(this.labelSepLink);
            this.Controls.Add(this.linkLabelDashboard);
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.listeDeroulanteType);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.checkedListBoxEquipable);
            this.Controls.Add(this.labelEquipablePar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelTypeArme);
            this.Controls.Add(this.labelNomArme);
            this.Controls.Add(this.panelLigneSeparatriceAjout);
            this.Controls.Add(this.labelCRUDArmes);
            this.Controls.Add(this.menuAdmin1);
            this.Name = "PageAjouterArme";
            this.Size = new System.Drawing.Size(1500, 750);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuAdmin menuAdmin1;
        private System.Windows.Forms.Label labelCRUDArmes;
        private System.Windows.Forms.Panel panelLigneSeparatriceAjout;
        private System.Windows.Forms.Label labelNomArme;
        private System.Windows.Forms.Label labelTypeArme;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelEquipablePar;
        private System.Windows.Forms.CheckedListBox checkedListBoxEquipable;
        private ButtonOptionsUser buttonOptionsUser1;
        private ListeDeroulanteType listeDeroulanteType;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.LinkLabel linkLabelDashboard;
        private System.Windows.Forms.Label labelSepLink;
        private System.Windows.Forms.Label labelFigurine;
        private System.Windows.Forms.Button buttonModifier;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.CheckBox checkBoxVisibility;
        private System.Windows.Forms.Button buttonAnnuler;
        private System.Windows.Forms.TextBox textBoxNomEquipement;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private ListeDeroulanteFeature listeDeroulanteFeature1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private ListeDeroulanteStuff listeDeroulanteStuff1;
        private System.Windows.Forms.Button buttonAjouterCaract;
    }
}
