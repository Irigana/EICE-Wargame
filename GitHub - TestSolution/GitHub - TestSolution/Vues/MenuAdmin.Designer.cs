namespace EICE_WARGAME
{
    partial class MenuAdmin
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
            this.buttonEquipement = new System.Windows.Forms.Button();
            this.buttonFigurine = new System.Windows.Forms.Button();
            this.buttonScenario = new System.Windows.Forms.Button();
            this.buttonMenuUser = new System.Windows.Forms.Button();
            this.buttonSousFaction = new System.Windows.Forms.Button();
            this.buttonFaction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEquipement
            // 
            this.buttonEquipement.FlatAppearance.BorderSize = 0;
            this.buttonEquipement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEquipement.Location = new System.Drawing.Point(0, 224);
            this.buttonEquipement.Name = "buttonEquipement";
            this.buttonEquipement.Size = new System.Drawing.Size(190, 50);
            this.buttonEquipement.TabIndex = 2;
            this.buttonEquipement.Text = "Equipements";
            this.buttonEquipement.UseVisualStyleBackColor = true;
            this.buttonEquipement.Click += new System.EventHandler(this.buttonEquipement_Click);
            // 
            // buttonFigurine
            // 
            this.buttonFigurine.FlatAppearance.BorderSize = 0;
            this.buttonFigurine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFigurine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFigurine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFigurine.Location = new System.Drawing.Point(0, 56);
            this.buttonFigurine.Name = "buttonFigurine";
            this.buttonFigurine.Size = new System.Drawing.Size(190, 50);
            this.buttonFigurine.TabIndex = 1;
            this.buttonFigurine.Text = "Figurine";
            this.buttonFigurine.UseVisualStyleBackColor = true;
            // 
            // buttonScenario
            // 
            this.buttonScenario.FlatAppearance.BorderSize = 0;
            this.buttonScenario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonScenario.Location = new System.Drawing.Point(0, 0);
            this.buttonScenario.Name = "buttonScenario";
            this.buttonScenario.Size = new System.Drawing.Size(190, 50);
            this.buttonScenario.TabIndex = 0;
            this.buttonScenario.Text = "Scenario";
            this.buttonScenario.UseVisualStyleBackColor = true;
            // 
            // buttonMenuUser
            // 
            this.buttonMenuUser.FlatAppearance.BorderSize = 0;
            this.buttonMenuUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonMenuUser.Location = new System.Drawing.Point(0, 280);
            this.buttonMenuUser.Name = "buttonMenuUser";
            this.buttonMenuUser.Size = new System.Drawing.Size(190, 50);
            this.buttonMenuUser.TabIndex = 3;
            this.buttonMenuUser.Text = "Utilisateurs";
            this.buttonMenuUser.UseVisualStyleBackColor = true;
            // 
            // buttonSousFaction
            // 
            this.buttonSousFaction.FlatAppearance.BorderSize = 0;
            this.buttonSousFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSousFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonSousFaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonSousFaction.Location = new System.Drawing.Point(0, 168);
            this.buttonSousFaction.Name = "buttonSousFaction";
            this.buttonSousFaction.Size = new System.Drawing.Size(190, 50);
            this.buttonSousFaction.TabIndex = 4;
            this.buttonSousFaction.Text = "Sous faction";
            this.buttonSousFaction.UseVisualStyleBackColor = true;
            // 
            // buttonFaction
            // 
            this.buttonFaction.FlatAppearance.BorderSize = 0;
            this.buttonFaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFaction.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFaction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFaction.Location = new System.Drawing.Point(0, 112);
            this.buttonFaction.Name = "buttonFaction";
            this.buttonFaction.Size = new System.Drawing.Size(190, 50);
            this.buttonFaction.TabIndex = 5;
            this.buttonFaction.Text = "Faction";
            this.buttonFaction.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.buttonFaction);
            this.Controls.Add(this.buttonSousFaction);
            this.Controls.Add(this.buttonMenuUser);
            this.Controls.Add(this.buttonEquipement);
            this.Controls.Add(this.buttonFigurine);
            this.Controls.Add(this.buttonScenario);
            this.Name = "MenuAdmin";
            this.Size = new System.Drawing.Size(190, 750);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScenario;
        private System.Windows.Forms.Button buttonFigurine;
        private System.Windows.Forms.Button buttonEquipement;
        private System.Windows.Forms.Button buttonMenuUser;
        private System.Windows.Forms.Button buttonSousFaction;
        private System.Windows.Forms.Button buttonFaction;
    }
}
