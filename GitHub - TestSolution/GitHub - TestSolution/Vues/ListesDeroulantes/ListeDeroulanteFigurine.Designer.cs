namespace EICE_WARGAME
{
    partial class ListeDeroulanteFigurine
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
            this.comboBoxFigurine = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxFigurine
            // 
            this.comboBoxFigurine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxFigurine.FormattingEnabled = true;
            this.comboBoxFigurine.Location = new System.Drawing.Point(0, 0);
            this.comboBoxFigurine.Name = "comboBoxFigurine";
            this.comboBoxFigurine.Size = new System.Drawing.Size(235, 24);
            this.comboBoxFigurine.TabIndex = 0;
            // 
            // ListeDeroulanteFigurine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxFigurine);
            this.Name = "ListeDeroulanteFigurine";
            this.Size = new System.Drawing.Size(235, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFigurine;
    }
}
