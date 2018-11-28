namespace EICE_WARGAME
{
    partial class ListeDeroulanteSousFaction
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
            this.comboBoxListeSousFaction = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxListeSousFaction
            // 
            this.comboBoxListeSousFaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxListeSousFaction.FormattingEnabled = true;
            this.comboBoxListeSousFaction.Location = new System.Drawing.Point(0, 0);
            this.comboBoxListeSousFaction.Name = "comboBoxListeSousFaction";
            this.comboBoxListeSousFaction.Size = new System.Drawing.Size(208, 24);
            this.comboBoxListeSousFaction.TabIndex = 0;
            // 
            // ListeDeroulanteSousFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxListeSousFaction);
            this.Name = "ListeDeroulanteSousFaction";
            this.Size = new System.Drawing.Size(208, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxListeSousFaction;
    }
}
