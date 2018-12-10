namespace EICE_WARGAME
{
    partial class ListeDeroulanteScenario
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
            this.comboBoxScenario = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxScenario
            // 
            this.comboBoxScenario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxScenario.FormattingEnabled = true;
            this.comboBoxScenario.Location = new System.Drawing.Point(0, 0);
            this.comboBoxScenario.Name = "comboBoxScenario";
            this.comboBoxScenario.Size = new System.Drawing.Size(235, 24);
            this.comboBoxScenario.TabIndex = 0;
            // 
            // ListeDeroulanteScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxScenario);
            this.Name = "ListeDeroulanteScenario";
            this.Size = new System.Drawing.Size(235, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxScenario;
    }
}
