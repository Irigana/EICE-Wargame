namespace EICE_WARGAME
{
    partial class ListeDeroulanteCamp
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
            this.comboBoxCamp = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxCamp
            // 
            this.comboBoxCamp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCamp.FormattingEnabled = true;
            this.comboBoxCamp.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCamp.Name = "comboBoxCamp";
            this.comboBoxCamp.Size = new System.Drawing.Size(235, 24);
            this.comboBoxCamp.TabIndex = 0;
            // 
            // ListeDeroulanteCamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxCamp);
            this.Name = "ListeDeroulanteCamp";
            this.Size = new System.Drawing.Size(235, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCamp;
    }
}
