namespace EICE_WARGAME
{
    partial class ListeDeroulanteSubUnity
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
            this.comboBoxSubUnity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxSubUnity
            // 
            this.comboBoxSubUnity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxSubUnity.FormattingEnabled = true;
            this.comboBoxSubUnity.Location = new System.Drawing.Point(0, 0);
            this.comboBoxSubUnity.Name = "comboBoxSubUnity";
            this.comboBoxSubUnity.Size = new System.Drawing.Size(220, 24);
            this.comboBoxSubUnity.TabIndex = 0;
            // 
            // ListeDeroulanteSubUnity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxSubUnity);
            this.Name = "ListeDeroulanteSubUnity";
            this.Size = new System.Drawing.Size(220, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxSubUnity;
    }
}
