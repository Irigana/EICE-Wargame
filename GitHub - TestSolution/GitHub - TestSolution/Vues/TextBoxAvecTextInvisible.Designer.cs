namespace EICE_WARGAME
{
    partial class TextBoxAvecTextInvisible
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
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxText
            // 
            this.textBoxText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxText.ForeColor = System.Drawing.SystemColors.GrayText;
            this.textBoxText.Location = new System.Drawing.Point(0, 0);
            this.textBoxText.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(215, 26);
            this.textBoxText.TabIndex = 0;
            this.textBoxText.Enter += new System.EventHandler(this.textBoxText_Enter);
            this.textBoxText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Enter_Press);
            this.textBoxText.Leave += new System.EventHandler(this.textBoxText_Leave);
            // 
            // TextBoxAvecTextInvisible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxText);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TextBoxAvecTextInvisible";
            this.Size = new System.Drawing.Size(215, 22);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxText;
    }
}
