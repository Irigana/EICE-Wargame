namespace EICE_WARGAME
{
    partial class FicheEquipementSansRecherche
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
            this.listViewEquipement = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // listViewEquipement
            // 
            this.listViewEquipement.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listViewEquipement.Location = new System.Drawing.Point(2, 2);
            this.listViewEquipement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listViewEquipement.Name = "listViewEquipement";
            this.listViewEquipement.Size = new System.Drawing.Size(216, 233);
            this.listViewEquipement.TabIndex = 1;
            this.listViewEquipement.UseCompatibleStateImageBehavior = false;
            // 
            // FicheEquipementSansRecherche
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewEquipement);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FicheEquipementSansRecherche";
            this.Size = new System.Drawing.Size(220, 240);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listViewEquipement;
    }
}
