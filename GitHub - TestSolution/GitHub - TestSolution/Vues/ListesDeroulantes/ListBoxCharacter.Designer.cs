namespace EICE_WARGAME
{
    partial class ListBoxCharacter
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
            this.checkedListBoxCharacter = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // checkedListBoxCharacter
            // 
            this.checkedListBoxCharacter.FormattingEnabled = true;
            this.checkedListBoxCharacter.Location = new System.Drawing.Point(0, 3);
            this.checkedListBoxCharacter.Name = "checkedListBoxCharacter";
            this.checkedListBoxCharacter.Size = new System.Drawing.Size(200, 191);
            this.checkedListBoxCharacter.TabIndex = 0;
            // 
            // ListBoxCharacter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkedListBoxCharacter);
            this.Name = "ListBoxCharacter";
            this.Size = new System.Drawing.Size(208, 204);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBoxCharacter;
    }
}
