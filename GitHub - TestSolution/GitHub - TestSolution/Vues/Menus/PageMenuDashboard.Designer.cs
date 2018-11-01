namespace EICE_WARGAME
{
    partial class PageMenuDashboard
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
            this.labelDashboard = new System.Windows.Forms.Label();
            this.pictureBoxLogoDashboard = new System.Windows.Forms.PictureBox();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.buttonFigurines = new System.Windows.Forms.Button();
            this.buttonRetourMenuPrincipal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // labelDashboard
            // 
            this.labelDashboard.AutoSize = true;
            this.labelDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.labelDashboard.Location = new System.Drawing.Point(662, 155);
            this.labelDashboard.Name = "labelDashboard";
            this.labelDashboard.Size = new System.Drawing.Size(236, 52);
            this.labelDashboard.TabIndex = 0;
            this.labelDashboard.Text = "Dashboard";
            // 
            // pictureBoxLogoDashboard
            // 
            this.pictureBoxLogoDashboard.Image = global::EICE_WARGAME.Properties.Resources.Dashboard150px;
            this.pictureBoxLogoDashboard.Location = new System.Drawing.Point(681, 6);
            this.pictureBoxLogoDashboard.Name = "pictureBoxLogoDashboard";
            this.pictureBoxLogoDashboard.Size = new System.Drawing.Size(184, 146);
            this.pictureBoxLogoDashboard.TabIndex = 1;
            this.pictureBoxLogoDashboard.TabStop = false;
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1278, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(219, 45);
            this.buttonOptionsUser1.TabIndex = 2;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // buttonFigurines
            // 
            this.buttonFigurines.BackColor = System.Drawing.SystemColors.Window;
            this.buttonFigurines.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonFigurines.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFigurines.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonFigurines.Image = global::EICE_WARGAME.Properties.Resources.FigurineWarhammer30px;
            this.buttonFigurines.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonFigurines.Location = new System.Drawing.Point(631, 245);
            this.buttonFigurines.Name = "buttonFigurines";
            this.buttonFigurines.Size = new System.Drawing.Size(300, 55);
            this.buttonFigurines.TabIndex = 3;
            this.buttonFigurines.Text = "Figurines";
            this.buttonFigurines.UseVisualStyleBackColor = false;
            this.buttonFigurines.Click += new System.EventHandler(this.buttonFigurines_Click);
            // 
            // buttonRetourMenuPrincipal
            // 
            this.buttonRetourMenuPrincipal.BackColor = System.Drawing.SystemColors.Window;
            this.buttonRetourMenuPrincipal.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonRetourMenuPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRetourMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonRetourMenuPrincipal.Location = new System.Drawing.Point(631, 394);
            this.buttonRetourMenuPrincipal.Name = "buttonRetourMenuPrincipal";
            this.buttonRetourMenuPrincipal.Size = new System.Drawing.Size(300, 55);
            this.buttonRetourMenuPrincipal.TabIndex = 4;
            this.buttonRetourMenuPrincipal.Text = "Menu principal";
            this.buttonRetourMenuPrincipal.UseVisualStyleBackColor = false;
            // 
            // PageMenuDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonRetourMenuPrincipal);
            this.Controls.Add(this.buttonFigurines);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.pictureBoxLogoDashboard);
            this.Controls.Add(this.labelDashboard);
            this.Name = "PageMenuDashboard";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageMenuDashBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDashboard;
        private System.Windows.Forms.PictureBox pictureBoxLogoDashboard;
        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonFigurines;
        private System.Windows.Forms.Button buttonRetourMenuPrincipal;
    }
}
