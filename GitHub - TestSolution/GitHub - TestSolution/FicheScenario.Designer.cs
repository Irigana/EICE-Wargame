namespace EICE_WARGAME
{
    partial class FicheScenario
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ficheSpecifiteScenario1 = new EICE_WARGAME.FicheSpecifiteScenario();
            this.listeDeroulanteUnity1 = new EICE_WARGAME.ListeDeroulanteUnity();
            this.labelOptionnel = new System.Windows.Forms.Label();
            this.labelObligatoire = new System.Windows.Forms.Label();
            this.labelRechercherUnity = new System.Windows.Forms.Label();
            this.numericUpDownObligatoire = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.labelOblige = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelsupp = new System.Windows.Forms.Label();
            this.buttonSupprimer = new System.Windows.Forms.Button();
            this.buttonAjouter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ValidationProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObligatoire)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2, 400);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(504, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 400);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(4, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(500, 2);
            this.panel4.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(4, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(500, 2);
            this.panel3.TabIndex = 2;
            // 
            // ficheSpecifiteScenario1
            // 
            this.ficheSpecifiteScenario1.Location = new System.Drawing.Point(110, 206);
            this.ficheSpecifiteScenario1.Name = "ficheSpecifiteScenario1";
            this.ficheSpecifiteScenario1.Size = new System.Drawing.Size(299, 162);
            this.ficheSpecifiteScenario1.SpecificiteSelectionne = null;
            this.ficheSpecifiteScenario1.TabIndex = 5;
            // 
            // listeDeroulanteUnity1
            // 
            this.listeDeroulanteUnity1.Location = new System.Drawing.Point(45, 82);
            this.listeDeroulanteUnity1.Name = "listeDeroulanteUnity1";
            this.listeDeroulanteUnity1.Size = new System.Drawing.Size(179, 25);
            this.listeDeroulanteUnity1.TabIndex = 6;
            this.listeDeroulanteUnity1.UnitySelectionnee = null;
            // 
            // labelOptionnel
            // 
            this.labelOptionnel.AutoSize = true;
            this.labelOptionnel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelOptionnel.Location = new System.Drawing.Point(336, 26);
            this.labelOptionnel.Name = "labelOptionnel";
            this.labelOptionnel.Size = new System.Drawing.Size(96, 25);
            this.labelOptionnel.TabIndex = 3;
            this.labelOptionnel.Text = "Optionnel";
            // 
            // labelObligatoire
            // 
            this.labelObligatoire.AutoSize = true;
            this.labelObligatoire.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelObligatoire.Location = new System.Drawing.Point(76, 26);
            this.labelObligatoire.Name = "labelObligatoire";
            this.labelObligatoire.Size = new System.Drawing.Size(106, 25);
            this.labelObligatoire.TabIndex = 4;
            this.labelObligatoire.Text = "Obligatoire";
            // 
            // labelRechercherUnity
            // 
            this.labelRechercherUnity.AutoSize = true;
            this.labelRechercherUnity.Location = new System.Drawing.Point(42, 62);
            this.labelRechercherUnity.Name = "labelRechercherUnity";
            this.labelRechercherUnity.Size = new System.Drawing.Size(160, 17);
            this.labelRechercherUnity.TabIndex = 7;
            this.labelRechercherUnity.Text = "Selectionnez une unité :";
            // 
            // numericUpDownObligatoire
            // 
            this.numericUpDownObligatoire.Location = new System.Drawing.Point(45, 141);
            this.numericUpDownObligatoire.Name = "numericUpDownObligatoire";
            this.numericUpDownObligatoire.Size = new System.Drawing.Size(179, 22);
            this.numericUpDownObligatoire.TabIndex = 8;
            this.numericUpDownObligatoire.Enter += new System.EventHandler(this.numericUpDownObligatoire_Enter);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(287, 84);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(179, 22);
            this.numericUpDown2.TabIndex = 9;
            this.numericUpDown2.Enter += new System.EventHandler(this.numericUpDown2_Enter);
            // 
            // labelOblige
            // 
            this.labelOblige.AutoSize = true;
            this.labelOblige.Location = new System.Drawing.Point(42, 121);
            this.labelOblige.Name = "labelOblige";
            this.labelOblige.Size = new System.Drawing.Size(63, 17);
            this.labelOblige.TabIndex = 10;
            this.labelOblige.Text = "Minimum";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel5.Location = new System.Drawing.Point(257, 11);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(2, 189);
            this.panel5.TabIndex = 11;
            // 
            // labelsupp
            // 
            this.labelsupp.AutoSize = true;
            this.labelsupp.Location = new System.Drawing.Point(284, 64);
            this.labelsupp.Name = "labelsupp";
            this.labelsupp.Size = new System.Drawing.Size(204, 17);
            this.labelsupp.TabIndex = 12;
            this.labelsupp.Text = "Unité supplémentaire maximum";
            // 
            // buttonSupprimer
            // 
            this.buttonSupprimer.BackColor = System.Drawing.SystemColors.Window;
            this.buttonSupprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSupprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonSupprimer.Location = new System.Drawing.Point(266, 371);
            this.buttonSupprimer.Name = "buttonSupprimer";
            this.buttonSupprimer.Size = new System.Drawing.Size(143, 29);
            this.buttonSupprimer.TabIndex = 45;
            this.buttonSupprimer.Text = "Supprimer";
            this.buttonSupprimer.UseVisualStyleBackColor = false;
            // 
            // buttonAjouter
            // 
            this.buttonAjouter.BackColor = System.Drawing.SystemColors.Window;
            this.buttonAjouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonAjouter.Location = new System.Drawing.Point(110, 371);
            this.buttonAjouter.Name = "buttonAjouter";
            this.buttonAjouter.Size = new System.Drawing.Size(143, 29);
            this.buttonAjouter.TabIndex = 46;
            this.buttonAjouter.Text = "Ajouter";
            this.buttonAjouter.UseVisualStyleBackColor = false;
            this.buttonAjouter.Click += new System.EventHandler(this.buttonAjouter_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ValidationProvider
            // 
            this.ValidationProvider.ContainerControl = this;
            // 
            // FicheScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonAjouter);
            this.Controls.Add(this.buttonSupprimer);
            this.Controls.Add(this.labelsupp);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.labelOblige);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDownObligatoire);
            this.Controls.Add(this.labelRechercherUnity);
            this.Controls.Add(this.listeDeroulanteUnity1);
            this.Controls.Add(this.ficheSpecifiteScenario1);
            this.Controls.Add(this.labelObligatoire);
            this.Controls.Add(this.labelOptionnel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FicheScenario";
            this.Size = new System.Drawing.Size(509, 407);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownObligatoire)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private FicheSpecifiteScenario ficheSpecifiteScenario1;
        private ListeDeroulanteUnity listeDeroulanteUnity1;
        private System.Windows.Forms.Label labelOptionnel;
        private System.Windows.Forms.Label labelObligatoire;
        private System.Windows.Forms.Label labelRechercherUnity;
        private System.Windows.Forms.NumericUpDown numericUpDownObligatoire;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Label labelOblige;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelsupp;
        private System.Windows.Forms.Button buttonSupprimer;
        private System.Windows.Forms.Button buttonAjouter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider ValidationProvider;
    }
}
