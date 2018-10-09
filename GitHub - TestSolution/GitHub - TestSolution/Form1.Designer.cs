namespace GitHub___TestSolution
{
    partial class Form_Test_Github
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
            this.buttonChangerCouleur = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonChangerCouleur
            // 
            this.buttonChangerCouleur.Location = new System.Drawing.Point(85, 40);
            this.buttonChangerCouleur.Name = "buttonChangerCouleur";
            this.buttonChangerCouleur.Size = new System.Drawing.Size(139, 44);
            this.buttonChangerCouleur.TabIndex = 0;
            this.buttonChangerCouleur.Text = "Changer la couleur";
            this.buttonChangerCouleur.UseVisualStyleBackColor = true;
            this.buttonChangerCouleur.Click += new System.EventHandler(this.buttonChangerCouleur_Click);
            // 
            // Form_Test_Github
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 321);
            this.Controls.Add(this.buttonChangerCouleur);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form_Test_Github";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonChangerCouleur;
    }
}

