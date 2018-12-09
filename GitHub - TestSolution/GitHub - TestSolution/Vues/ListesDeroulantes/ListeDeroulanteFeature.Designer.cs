namespace EICE_WARGAME
{
    partial class ListeDeroulanteFeature
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
            this.comboBoxFeature = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxFeature
            // 
            this.comboBoxFeature.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFeature.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFeature.FormattingEnabled = true;
            this.comboBoxFeature.Location = new System.Drawing.Point(0, 0);
            this.comboBoxFeature.Name = "comboBoxFeature";
            this.comboBoxFeature.Size = new System.Drawing.Size(200, 24);
            this.comboBoxFeature.TabIndex = 0;
            this.comboBoxFeature.SelectedIndexChanged += new System.EventHandler(this.ComboFeature_SelectedIndexChanged);
            // 
            // ListeDeroulanteFeature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxFeature);
            this.Name = "ListeDeroulanteFeature";
            this.Size = new System.Drawing.Size(200, 25);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFeature;
    }
}
