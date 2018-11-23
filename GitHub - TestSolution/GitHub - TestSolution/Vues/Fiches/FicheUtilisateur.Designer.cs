namespace EICE_WARGAME
{
    partial class FicheUtilisateur
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
            this.listViewUsers = new System.Windows.Forms.ListView();
            this.textBoxRechercheUser = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listViewUsers
            // 
            this.listViewUsers.Location = new System.Drawing.Point(3, 31);
            this.listViewUsers.Name = "listViewUsers";
            this.listViewUsers.Size = new System.Drawing.Size(410, 430);
            this.listViewUsers.TabIndex = 1;
            this.listViewUsers.UseCompatibleStateImageBehavior = false;
            this.listViewUsers.SelectedIndexChanged += new System.EventHandler(this.listViewUsers_SelectedIndexChanged);
            // 
            // textBoxRechercheUser
            // 
            this.textBoxRechercheUser.Location = new System.Drawing.Point(3, 5);
            this.textBoxRechercheUser.Name = "textBoxRechercheUser";
            this.textBoxRechercheUser.Size = new System.Drawing.Size(410, 22);
            this.textBoxRechercheUser.TabIndex = 0;
            this.textBoxRechercheUser.TextChanged += new System.EventHandler(this.textRecherche_TextChanged);
            // 
            // FicheUtilisateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxRechercheUser);
            this.Controls.Add(this.listViewUsers);
            this.Name = "FicheUtilisateur";
            this.Size = new System.Drawing.Size(415, 464);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listViewUsers;
        private System.Windows.Forms.TextBox textBoxRechercheUser;
    }
}
