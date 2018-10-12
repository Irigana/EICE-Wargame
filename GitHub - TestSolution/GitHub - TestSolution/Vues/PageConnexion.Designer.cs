namespace GitHub___TestSolution
{
    partial class PageConnexion
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
            this.labelSeConnecter = new System.Windows.Forms.Label();
            this.linkLabelCreerCompte = new System.Windows.Forms.LinkLabel();
            this.pictureBoxCadenaFerme = new System.Windows.Forms.PictureBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.textBoxAvecTextInvisibleMdp = new GitHub___TestSolution.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleLogin = new GitHub___TestSolution.TextBoxAvecTextInvisible();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaFerme)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeConnecter
            // 
            this.labelSeConnecter.AutoSize = true;
            this.labelSeConnecter.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeConnecter.Location = new System.Drawing.Point(159, 123);
            this.labelSeConnecter.Name = "labelSeConnecter";
            this.labelSeConnecter.Size = new System.Drawing.Size(239, 42);
            this.labelSeConnecter.TabIndex = 0;
            this.labelSeConnecter.Text = "Se connecter";
            // 
            // linkLabelCreerCompte
            // 
            this.linkLabelCreerCompte.AutoSize = true;
            this.linkLabelCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreerCompte.Location = new System.Drawing.Point(215, 396);
            this.linkLabelCreerCompte.Name = "linkLabelCreerCompte";
            this.linkLabelCreerCompte.Size = new System.Drawing.Size(134, 20);
            this.linkLabelCreerCompte.TabIndex = 4;
            this.linkLabelCreerCompte.TabStop = true;
            this.linkLabelCreerCompte.Text = "Créer un compte";
            // 
            // pictureBoxCadenaFerme
            // 
            this.pictureBoxCadenaFerme.Image = global::GitHub___TestSolution.Properties.Resources.CadenaFerme1;
            this.pictureBoxCadenaFerme.Location = new System.Drawing.Point(233, 14);
            this.pictureBoxCadenaFerme.Name = "pictureBoxCadenaFerme";
            this.pictureBoxCadenaFerme.Size = new System.Drawing.Size(96, 95);
            this.pictureBoxCadenaFerme.TabIndex = 5;
            this.pictureBoxCadenaFerme.TabStop = false;
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.BackColor = System.Drawing.SystemColors.Window;
            this.buttonConnexion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonConnexion.FlatAppearance.BorderSize = 2;
            this.buttonConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonConnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConnexion.Image = global::GitHub___TestSolution.Properties.Resources.CadenaOuvert25px;
            this.buttonConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnexion.Location = new System.Drawing.Point(166, 303);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(232, 46);
            this.buttonConnexion.TabIndex = 3;
            this.buttonConnexion.Text = "Se connecter";
            this.buttonConnexion.UseVisualStyleBackColor = false;
            // 
            // textBoxAvecTextInvisibleMdp
            // 
            this.textBoxAvecTextInvisibleMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvecTextInvisibleMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdp.Location = new System.Drawing.Point(166, 241);
            this.textBoxAvecTextInvisibleMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdp.Name = "textBoxAvecTextInvisibleMdp";
            this.textBoxAvecTextInvisibleMdp.Size = new System.Drawing.Size(232, 28);
            this.textBoxAvecTextInvisibleMdp.TabIndex = 2;
            this.textBoxAvecTextInvisibleMdp.Text = "Mot de passe";
            // 
            // textBoxAvecTextInvisibleLogin
            // 
            this.textBoxAvecTextInvisibleLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvecTextInvisibleLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleLogin.Location = new System.Drawing.Point(166, 195);
            this.textBoxAvecTextInvisibleLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleLogin.Name = "textBoxAvecTextInvisibleLogin";
            this.textBoxAvecTextInvisibleLogin.Size = new System.Drawing.Size(232, 28);
            this.textBoxAvecTextInvisibleLogin.TabIndex = 1;
            this.textBoxAvecTextInvisibleLogin.Text = "Login";
            // 
            // PageConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pictureBoxCadenaFerme);
            this.Controls.Add(this.linkLabelCreerCompte);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleLogin);
            this.Controls.Add(this.labelSeConnecter);
            this.Name = "PageConnexion";
            this.Size = new System.Drawing.Size(553, 489);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaFerme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSeConnecter;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleLogin;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdp;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.LinkLabel linkLabelCreerCompte;
        private System.Windows.Forms.PictureBox pictureBoxCadenaFerme;
    }
}
