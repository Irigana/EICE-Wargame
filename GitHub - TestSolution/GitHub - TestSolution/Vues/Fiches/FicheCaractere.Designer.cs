namespace EICE_WARGAME
{
    partial class FicheCaractere
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
            this.listViewCaractere = new System.Windows.Forms.ListView();
            this.textBoxCaractere = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewCaractere
            // 
            this.listViewCaractere.FullRowSelect = true;
            this.listViewCaractere.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewCaractere.HideSelection = false;
            this.listViewCaractere.Location = new System.Drawing.Point(0, 28);
            this.listViewCaractere.Name = "listViewCaractere";
            this.listViewCaractere.Size = new System.Drawing.Size(398, 257);
            this.listViewCaractere.TabIndex = 2;
            this.listViewCaractere.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxCaractere
            // 
            this.textBoxCaractere.Location = new System.Drawing.Point(0, 0);
            this.textBoxCaractere.Name = "textBoxCaractere";
            this.textBoxCaractere.Size = new System.Drawing.Size(398, 22);
            this.textBoxCaractere.TabIndex = 3;
            this.textBoxCaractere.TextChanged += new System.EventHandler(this.textFiltre_TextChanged);
            this.textBoxCaractere.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFiltre_KeyPress);
            // 
            // FicheCaractere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxCaractere);
            this.Controls.Add(this.listViewCaractere);
            this.Name = "FicheCaractere";
            this.Size = new System.Drawing.Size(401, 287);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewCaractere;
        private System.Windows.Forms.TextBox textBoxCaractere;
    }
}
