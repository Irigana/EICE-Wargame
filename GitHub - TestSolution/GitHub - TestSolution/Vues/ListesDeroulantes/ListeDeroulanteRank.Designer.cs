namespace EICE_WARGAME
{
    partial class ListeDeroulanteRank
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
            this.comboBoxRank = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxRank
            // 
            this.comboBoxRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxRank.FormattingEnabled = true;
            this.comboBoxRank.Location = new System.Drawing.Point(0, 0);
            this.comboBoxRank.Name = "comboBoxRank";
            this.comboBoxRank.Size = new System.Drawing.Size(246, 24);
            this.comboBoxRank.TabIndex = 0;
            // 
            // ListeDeroulanteRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxRank);
            this.Name = "ListeDeroulanteRank";
            this.Size = new System.Drawing.Size(246, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxRank;
    }
}
