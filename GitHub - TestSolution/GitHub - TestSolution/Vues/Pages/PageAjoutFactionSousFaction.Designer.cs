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
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.labelFaction = new System.Windows.Forms.Label();
            this.labelSousFaction = new System.Windows.Forms.Label();
            this.menuAdmin1 = new EICE_WARGAME.MenuAdmin();
            this.panelSeparateur = new System.Windows.Forms.Panel();
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
            // labelFaction
            // 
            this.labelFaction.AutoSize = true;
            this.labelFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelFaction.Location = new System.Drawing.Point(375, 100);
            this.labelFaction.Name = "labelFaction";
            this.labelFaction.Size = new System.Drawing.Size(152, 46);
            this.labelFaction.TabIndex = 1;
            this.labelFaction.Text = "Faction";
            // 
            // labelSousFaction
            // 
            this.labelSousFaction.AutoSize = true;
            this.labelSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.labelSousFaction.Location = new System.Drawing.Point(950, 100);
            this.labelSousFaction.Name = "labelSousFaction";
            this.labelSousFaction.Size = new System.Drawing.Size(242, 46);
            this.labelSousFaction.TabIndex = 2;
            this.labelSousFaction.Text = "Sous faction";
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
            // panelSeparateur
            // 
            this.panelSeparateur.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelSeparateur.Location = new System.Drawing.Point(750, 64);
            this.panelSeparateur.Name = "panelSeparateur";
            this.panelSeparateur.Size = new System.Drawing.Size(5, 600);
            this.panelSeparateur.TabIndex = 4;
            // 
            // PageAjoutFactionSousFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelSeparateur);
            this.Controls.Add(this.menuAdmin1);
            this.Controls.Add(this.labelSousFaction);
            this.Controls.Add(this.labelFaction);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Name = "PageAjoutFactionSousFaction";
            this.Size = new System.Drawing.Size(1500, 750);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Label labelFaction;
        private System.Windows.Forms.Label labelSousFaction;
        private MenuAdmin menuAdmin1;
        private System.Windows.Forms.Panel panelSeparateur;
    }
}
