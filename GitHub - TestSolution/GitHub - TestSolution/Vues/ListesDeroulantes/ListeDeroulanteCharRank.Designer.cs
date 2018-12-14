namespace EICE_WARGAME
{
    partial class ListeDeroulanteCharRank
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
            this.comboBoxCharRank = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxCharRank
            // 
            this.comboBoxCharRank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxCharRank.FormattingEnabled = true;
            this.comboBoxCharRank.Location = new System.Drawing.Point(0, 0);
            this.comboBoxCharRank.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxCharRank.Name = "comboBoxCharRank";
            this.comboBoxCharRank.Size = new System.Drawing.Size(195, 21);
            this.comboBoxCharRank.TabIndex = 0;
            // 
            // ListeDeroulanteCharRank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxCharRank);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ListeDeroulanteCharRank";
            this.Size = new System.Drawing.Size(195, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCharRank;
    }
}
