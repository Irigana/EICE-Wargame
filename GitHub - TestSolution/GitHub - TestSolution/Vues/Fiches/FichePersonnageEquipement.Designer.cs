﻿namespace EICE_WARGAME
{
    partial class FichePersonnageEquipement
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
            this.SuspendLayout();
            // 
            // listViewCaractere
            // 
            this.listViewCaractere.GridLines = true;
            this.listViewCaractere.Location = new System.Drawing.Point(4, 4);
            this.listViewCaractere.Name = "listViewCaractere";
            this.listViewCaractere.Size = new System.Drawing.Size(390, 250);
            this.listViewCaractere.TabIndex = 0;
            this.listViewCaractere.UseCompatibleStateImageBehavior = false;
            this.listViewCaractere.View = System.Windows.Forms.View.Details;
            // 
            // FichePersonnageEquipement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewCaractere);
            this.Name = "FichePersonnageEquipement";
            this.Size = new System.Drawing.Size(400, 260);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewCaractere;
    }
}
