namespace EICE_WARGAME
{
    partial class ListeDeroulanteStuff
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
            this.comboBoxStuff = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxStuff
            // 
            this.comboBoxStuff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxStuff.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStuff.FormattingEnabled = true;
            this.comboBoxStuff.Location = new System.Drawing.Point(0, 0);
            this.comboBoxStuff.Name = "comboBoxStuff";
            this.comboBoxStuff.Size = new System.Drawing.Size(206, 24);
            this.comboBoxStuff.TabIndex = 0;
            // 
            // ListeDeroulanteStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxStuff);
            this.Name = "ListeDeroulanteStuff";
            this.Size = new System.Drawing.Size(206, 26);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxStuff;
    }
}
