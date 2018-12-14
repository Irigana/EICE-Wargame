namespace EICE_WARGAME
{
    partial class PageMenuPrincipal
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
            this.labelMenuPrincipal = new System.Windows.Forms.Label();
            this.buttonMesArmees = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.buttonMaCollection = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            this.SuspendLayout();
            // 
            // labelMenuPrincipal
            // 
            this.labelMenuPrincipal.AutoSize = true;
            this.labelMenuPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.labelMenuPrincipal.ForeColor = System.Drawing.Color.SlateGray;
            this.labelMenuPrincipal.Location = new System.Drawing.Point(608, 81);
            this.labelMenuPrincipal.Name = "labelMenuPrincipal";
            this.labelMenuPrincipal.Size = new System.Drawing.Size(351, 58);
            this.labelMenuPrincipal.TabIndex = 0;
            this.labelMenuPrincipal.Text = "Menu principal";
            // 
            // buttonMesArmees
            // 
            this.buttonMesArmees.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMesArmees.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMesArmees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMesArmees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMesArmees.Location = new System.Drawing.Point(635, 290);
            this.buttonMesArmees.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMesArmees.Name = "buttonMesArmees";
            this.buttonMesArmees.Size = new System.Drawing.Size(300, 55);
            this.buttonMesArmees.TabIndex = 4;
            this.buttonMesArmees.Text = "Mes armées";
            this.buttonMesArmees.UseVisualStyleBackColor = false;
            this.buttonMesArmees.Click += new System.EventHandler(this.buttonMesArmees_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDeconnexion.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDeconnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDeconnexion.Image = global::EICE_WARGAME.Properties.Resources.LogOffLogo30px;
            this.buttonDeconnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDeconnexion.Location = new System.Drawing.Point(635, 479);
            this.buttonDeconnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(300, 55);
            this.buttonDeconnexion.TabIndex = 6;
            this.buttonDeconnexion.Text = "Se déconnecter";
            this.buttonDeconnexion.UseVisualStyleBackColor = false;
            this.buttonDeconnexion.Click += new System.EventHandler(this.buttonDeconnexion_Click);
            // 
            // buttonMaCollection
            // 
            this.buttonMaCollection.BackColor = System.Drawing.SystemColors.Window;
            this.buttonMaCollection.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonMaCollection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaCollection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonMaCollection.Image = global::EICE_WARGAME.Properties.Resources.FigurineWarhammer30px;
            this.buttonMaCollection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonMaCollection.Location = new System.Drawing.Point(635, 199);
            this.buttonMaCollection.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonMaCollection.Name = "buttonMaCollection";
            this.buttonMaCollection.Size = new System.Drawing.Size(300, 55);
            this.buttonMaCollection.TabIndex = 5;
            this.buttonMaCollection.Text = "Ma collection";
            this.buttonMaCollection.UseVisualStyleBackColor = false;
            this.buttonMaCollection.Click += new System.EventHandler(this.buttonMaCollection_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.BackColor = System.Drawing.SystemColors.Window;
            this.buttonDashboard.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.buttonDashboard.Image = global::EICE_WARGAME.Properties.Resources.Dashboard40px;
            this.buttonDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDashboard.Location = new System.Drawing.Point(635, 380);
            this.buttonDashboard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(300, 55);
            this.buttonDashboard.TabIndex = 3;
            this.buttonDashboard.Text = "Dashboard";
            this.buttonDashboard.UseVisualStyleBackColor = false;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1276, 2);
            this.buttonOptionsUser1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(221, 46);
            this.buttonOptionsUser1.TabIndex = 1;
            this.buttonOptionsUser1.Utilisateur = null;
            // 
            // PageMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonMaCollection);
            this.Controls.Add(this.buttonMesArmees);
            this.Controls.Add(this.buttonDashboard);
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.labelMenuPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageMenuPrincipal";
            this.Size = new System.Drawing.Size(1500, 750);
            this.Load += new System.EventHandler(this.PageMenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMenuPrincipal;
        private EICE_WARGAME.ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonDashboard;
        private System.Windows.Forms.Button buttonMesArmees;
        private System.Windows.Forms.Button buttonMaCollection;
        private System.Windows.Forms.Button buttonDeconnexion;
    }
}
