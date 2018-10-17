namespace GitHub___TestSolution
{
    partial class Form_Principal
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

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.pageConnexion1 = new GitHub___TestSolution.PageConnexion();
            this.PageInscription = new GitHub___TestSolution.Inscription();
            this.SuspendLayout();
            // 
            // pageConnexion1
            // 
            this.pageConnexion1.BackColor = System.Drawing.SystemColors.Control;
            this.pageConnexion1.Location = new System.Drawing.Point(228, 66);
            this.pageConnexion1.Name = "pageConnexion1";
            this.pageConnexion1.Size = new System.Drawing.Size(553, 489);
            this.pageConnexion1.TabIndex = 1;
            this.pageConnexion1.VisibleChanged += new System.EventHandler(this.pageConnexion1_VisibleChanged);
            this.pageConnexion1.Leave += new System.EventHandler(this.pageConnexion1_Leave);
            // 
            // PageInscription
            // 
            this.PageInscription.Location = new System.Drawing.Point(171, 30);
            this.PageInscription.Name = "PageInscription";
            this.PageInscription.Size = new System.Drawing.Size(650, 550);
            this.PageInscription.TabIndex = 2;
            this.PageInscription.Visible = false;
            // 
            // Form_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 668);
            this.Controls.Add(this.pageConnexion1);
            this.Controls.Add(this.PageInscription);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Principal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private PageConnexion pageConnexion1;
        private Inscription PageInscription;
    }
}

