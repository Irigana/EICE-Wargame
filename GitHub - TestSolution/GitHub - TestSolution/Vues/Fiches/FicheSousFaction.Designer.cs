namespace EICE_WARGAME
{
    partial class FicheSousFaction
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
            this.listViewSousFaction = new System.Windows.Forms.ListView();
            this.textBoxSousFaction = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewSousFaction
            // 
            this.listViewSousFaction.FullRowSelect = true;
            this.listViewSousFaction.HideSelection = false;
            this.listViewSousFaction.Location = new System.Drawing.Point(0, 28);
            this.listViewSousFaction.Name = "listViewSousFaction";
            this.listViewSousFaction.Size = new System.Drawing.Size(285, 257);
            this.listViewSousFaction.TabIndex = 2;
            this.listViewSousFaction.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxSousFaction
            // 
            this.textBoxSousFaction.Location = new System.Drawing.Point(0, 0);
            this.textBoxSousFaction.Name = "textBoxSousFaction";
            this.textBoxSousFaction.Size = new System.Drawing.Size(285, 22);
            this.textBoxSousFaction.TabIndex = 3;
            this.textBoxSousFaction.TextChanged += new System.EventHandler(this.textFiltre_TextChanged);
            this.textBoxSousFaction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFiltre_KeyPress);
            // 
            // FicheSousFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSousFaction);
            this.Controls.Add(this.listViewSousFaction);
            this.Name = "FicheSousFaction";
            this.Size = new System.Drawing.Size(286, 287);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewSousFaction;
        private System.Windows.Forms.TextBox textBoxSousFaction;
    }
}
