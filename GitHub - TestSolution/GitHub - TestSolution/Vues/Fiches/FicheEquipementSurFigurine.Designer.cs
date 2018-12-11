namespace EICE_WARGAME
{
    partial class FicheEquipementSurFigurine
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
            this.listViewEquipement = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBoxRecherche
            // 
            this.textBoxRecherche.Location = new System.Drawing.Point(3, 3);
            this.textBoxRecherche.Name = "textBoxRecherche";
            this.textBoxRecherche.Size = new System.Drawing.Size(286, 22);
            this.textBoxRecherche.TabIndex = 0;
            this.textBoxRecherche.TextChanged += new System.EventHandler(this.textFiltre_TextChanged);
            // 
            // listViewEquipement
            // 
            this.listViewEquipement.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEquipement.Location = new System.Drawing.Point(3, 31);
            this.listViewEquipement.Name = "listViewEquipement";
            this.listViewEquipement.Size = new System.Drawing.Size(286, 257);
            this.listViewEquipement.TabIndex = 1;
            this.listViewEquipement.UseCompatibleStateImageBehavior = false;
            // 
            // FicheEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewEquipement);
            this.Controls.Add(this.textBoxRecherche);
            this.Name = "FicheEquipement";
            this.Size = new System.Drawing.Size(293, 295);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxRecherche;
        private System.Windows.Forms.ListView listViewEquipement;
    }
}
