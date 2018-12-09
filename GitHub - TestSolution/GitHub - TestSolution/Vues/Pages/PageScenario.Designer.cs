namespace EICE_WARGAME
{
    partial class PageScenario
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
            this.labelScenario = new System.Windows.Forms.Label();
            this.labelNomScenario = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonNouveauCamp = new System.Windows.Forms.Button();
            this.ficheScenarioCamp2 = new EICE_WARGAME.FicheScenario();
            this.ficheScenarioCamp1 = new EICE_WARGAME.FicheScenario();
            this.buttonRetourDashBoard1 = new EICE_WARGAME.ButtonRetourDashBoard();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
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
            // labelScenario
            // 
            this.labelScenario.AutoSize = true;
            this.labelScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelScenario.ForeColor = System.Drawing.Color.SlateGray;
            this.labelScenario.Location = new System.Drawing.Point(233, 20);
            this.labelScenario.Name = "labelScenario";
            this.labelScenario.Size = new System.Drawing.Size(179, 46);
            this.labelScenario.TabIndex = 47;
            this.labelScenario.Text = "Scénario";
            // 
            // labelNomScenario
            // 
            this.labelNomScenario.AutoSize = true;
            this.labelNomScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.labelNomScenario.Location = new System.Drawing.Point(407, 92);
            this.labelNomScenario.Name = "labelNomScenario";
            this.labelNomScenario.Size = new System.Drawing.Size(130, 18);
            this.labelNomScenario.TabIndex = 50;
            this.labelNomScenario.Text = "Nom du scénario :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(410, 122);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 22);
            this.textBox1.TabIndex = 51;
            // 
            // buttonNouveauCamp
            // 
            this.buttonNouveauCamp.BackColor = System.Drawing.SystemColors.Window;
            this.buttonNouveauCamp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNouveauCamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonNouveauCamp.Location = new System.Drawing.Point(820, 382);
            this.buttonNouveauCamp.Name = "buttonNouveauCamp";
            this.buttonNouveauCamp.Size = new System.Drawing.Size(43, 40);
            this.buttonNouveauCamp.TabIndex = 54;
            this.buttonNouveauCamp.Text = "+";
            this.buttonNouveauCamp.UseVisualStyleBackColor = false;
            this.buttonNouveauCamp.Click += new System.EventHandler(this.buttonNouveauCamp_Click);
            // 
            // ficheScenarioCamp2
            // 
            this.ficheScenarioCamp2.Enabled = false;
            this.ficheScenarioCamp2.Location = new System.Drawing.Point(882, 210);
            this.ficheScenarioCamp2.Name = "ficheScenarioCamp2";
            this.ficheScenarioCamp2.Size = new System.Drawing.Size(509, 407);
            this.ficheScenarioCamp2.TabIndex = 53;
            // 
            // ficheScenarioCamp1
            // 
            this.ficheScenarioCamp1.Location = new System.Drawing.Point(292, 210);
            this.ficheScenarioCamp1.Name = "ficheScenarioCamp1";
            this.ficheScenarioCamp1.Size = new System.Drawing.Size(509, 407);
            this.ficheScenarioCamp1.TabIndex = 52;
            // 
            // buttonRetourDashBoard1
            // 
            this.buttonRetourDashBoard1.Location = new System.Drawing.Point(196, 3);
            this.buttonRetourDashBoard1.Name = "buttonRetourDashBoard1";
            this.buttonRetourDashBoard1.Size = new System.Drawing.Size(44, 34);
            this.buttonRetourDashBoard1.TabIndex = 49;
            this.buttonRetourDashBoard1.Utilisateur = null;
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
            // PageScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonNouveauCamp);
            this.Controls.Add(this.ficheScenarioCamp2);
            this.Controls.Add(this.ficheScenarioCamp1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelNomScenario);
            this.Controls.Add(this.buttonRetourDashBoard1);
            this.Controls.Add(this.panelLigne);
            this.Controls.Add(this.labelScenario);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.menuAdmin1);
            this.Name = "PageScenario";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageScenario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuAdmin menuAdmin1;
        private ButtonOptionsUser buttonOptionsUser1;
        private ButtonRetourDashBoard buttonRetourDashBoard1;
        private System.Windows.Forms.Panel panelLigne;
        private System.Windows.Forms.Label labelScenario;
        private System.Windows.Forms.Label labelNomScenario;
        private System.Windows.Forms.TextBox textBox1;
        private FicheScenario ficheScenarioCamp1;
        private FicheScenario ficheScenarioCamp2;
        private System.Windows.Forms.Button buttonNouveauCamp;
    }
}
