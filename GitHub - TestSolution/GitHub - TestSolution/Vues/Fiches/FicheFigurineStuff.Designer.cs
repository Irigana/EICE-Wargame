namespace EICE_WARGAME
{
    partial class FicheFigurineStuff
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
            this.textBoxRecherche = new System.Windows.Forms.TextBox();
            this.listViewFigurineStuff = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(2, 2);
            this.textBoxRecherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(453, 20);
            this.textBoxRecherche.TabIndex = 0;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textFiltre_TextChanged);
            // 
            // listViewFigurineStuff
            // 
            this.listViewFigurineStuff.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewFigurineStuff.Location = new System.Drawing.Point(2, 25);
            this.listViewFigurineStuff.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewFigurineStuff.Name = "listViewFigurineStuff";
            this.listViewFigurineStuff.Size = new System.Drawing.Size(453, 435);
            this.listViewFigurineStuff.TabIndex = 1;
            this.listViewFigurineStuff.UseCompatibleStateImageBehavior = false;
            // 
            // FicheFigurineStuff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewFigurineStuff);
            this.Controls.Add(this.textBoxRecherche);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FicheFigurineStuff";
            this.Size = new System.Drawing.Size(457, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.ListView listViewFigurineStuff;
    }
}
