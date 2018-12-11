namespace EICE_WARGAME
{
    partial class FicheSpecifiteScenario
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
            this.listViewSpecificite = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewSpecificite
            // 
            this.listViewSpecificite.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewSpecificite.Location = new System.Drawing.Point(0, 0);
            this.listViewSpecificite.Name = "listViewSpecificite";
            this.listViewSpecificite.Size = new System.Drawing.Size(299, 268);
            this.listViewSpecificite.TabIndex = 0;
            this.listViewSpecificite.UseCompatibleStateImageBehavior = false;
            // 
            // FicheSpecifiteScenario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewSpecificite);
            this.Name = "FicheSpecifiteScenario";
            this.Size = new System.Drawing.Size(299, 268);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewSpecificite;
    }
}
