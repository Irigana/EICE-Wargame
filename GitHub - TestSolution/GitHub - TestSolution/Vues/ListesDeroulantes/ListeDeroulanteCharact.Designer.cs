namespace EICE_WARGAME
{
    partial class ListeDeroulanteChar
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
            this.comboBoxChar = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxChar
            // 
            this.comboBoxChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxChar.FormattingEnabled = true;
            this.comboBoxChar.Location = new System.Drawing.Point(0, 0);
            this.comboBoxChar.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxChar.Name = "comboBoxChar";
            this.comboBoxChar.Size = new System.Drawing.Size(195, 21);
            this.comboBoxChar.TabIndex = 0;
            // 
            // ListeDeroulanteChar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxChar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ListeDeroulanteChar";
            this.Size = new System.Drawing.Size(195, 24);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChar;
    }
}
