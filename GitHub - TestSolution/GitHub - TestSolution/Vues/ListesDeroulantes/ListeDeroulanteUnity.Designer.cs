namespace EICE_WARGAME
{
    partial class ListeDeroulanteUnity
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
            this.comboBoxUnity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxUnity
            // 
            this.comboBoxUnity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxUnity.FormattingEnabled = true;
            this.comboBoxUnity.Location = new System.Drawing.Point(0, 0);
            this.comboBoxUnity.Name = "comboBoxUnity";
            this.comboBoxUnity.Size = new System.Drawing.Size(213, 24);
            this.comboBoxUnity.TabIndex = 0;
            // 
            // ListeDeroulanteUnity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxUnity);
            this.Name = "ListeDeroulanteUnity";
            this.Size = new System.Drawing.Size(213, 27);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxUnity;
    }
}
