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
            this.SuspendLayout();
            // 
            // buttonEquipement
            // 
            this.buttonEquipement.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonEquipement.Location = new System.Drawing.Point(-1, 272);
            this.buttonEquipement.Name = "buttonEquipement";
            this.buttonEquipement.Size = new System.Drawing.Size(190, 130);
            this.buttonEquipement.TabIndex = 2;
            this.buttonEquipement.Text = "Equipements";
            this.buttonEquipement.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonEquipement.UseVisualStyleBackColor = true;
            // 
            // buttonFigurine
            // 
            this.buttonFigurine.FlatAppearance.BorderSize = 0;
            this.buttonFigurine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFigurine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonFigurine.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonFigurine.Location = new System.Drawing.Point(0, 136);
            this.buttonFigurine.Name = "buttonFigurine";
            this.buttonFigurine.Size = new System.Drawing.Size(190, 130);
            this.buttonFigurine.TabIndex = 1;
            this.buttonFigurine.Text = "Figurine";
            this.buttonFigurine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonFigurine.UseVisualStyleBackColor = true;
            // 
            // buttonScenario
            // 
            this.buttonScenario.FlatAppearance.BorderSize = 0;
            this.buttonScenario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScenario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.buttonScenario.Location = new System.Drawing.Point(0, 0);
            this.buttonScenario.Name = "buttonScenario";
            this.buttonScenario.Size = new System.Drawing.Size(190, 130);
            this.buttonScenario.TabIndex = 0;
            this.buttonScenario.Text = "Scenario";
            this.buttonScenario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonScenario.UseVisualStyleBackColor = true;
            // 
            // MenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.buttonEquipement);
            this.Controls.Add(this.buttonFigurine);
            this.Controls.Add(this.buttonScenario);
            this.Name = "MenuAdmin";
            this.Size = new System.Drawing.Size(190, 542);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonScenario;
        private System.Windows.Forms.Button buttonFigurine;
        private System.Windows.Forms.Button buttonEquipement;
    }
}
