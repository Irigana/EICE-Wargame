namespace EICE_WARGAME
{
    partial class ButtonOptionsUser
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStripUser = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editionDuProfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seDéconnecterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonUser = new System.Windows.Forms.Button();
            this.contextMenuStripUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripUser
            // 
            this.contextMenuStripUser.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editionDuProfilToolStripMenuItem,
            this.seDéconnecterToolStripMenuItem});
            this.contextMenuStripUser.Name = "contextMenuStripUser";
            this.contextMenuStripUser.Size = new System.Drawing.Size(187, 52);
            // 
            // editionDuProfilToolStripMenuItem
            // 
            this.editionDuProfilToolStripMenuItem.Name = "editionDuProfilToolStripMenuItem";
            this.editionDuProfilToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.editionDuProfilToolStripMenuItem.Text = "Edition du profil";
            this.editionDuProfilToolStripMenuItem.Click += new System.EventHandler(this.editionDuProfilToolStripMenuItem_Click);
            // 
            // seDéconnecterToolStripMenuItem
            // 
            this.seDéconnecterToolStripMenuItem.Name = "seDéconnecterToolStripMenuItem";
            this.seDéconnecterToolStripMenuItem.Size = new System.Drawing.Size(186, 24);
            this.seDéconnecterToolStripMenuItem.Text = "Se déconnecter";
            this.seDéconnecterToolStripMenuItem.Click += new System.EventHandler(this.seDéconnecterToolStripMenuItem_Click);
            // 
            // buttonUser
            // 
            this.buttonUser.BackColor = System.Drawing.SystemColors.Control;
            this.buttonUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonUser.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.buttonUser.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonUser.Image = global::EICE_WARGAME.Properties.Resources.UserIcon25px;
            this.buttonUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonUser.Location = new System.Drawing.Point(0, 0);
            this.buttonUser.Name = "buttonUser";
            this.buttonUser.Size = new System.Drawing.Size(219, 45);
            this.buttonUser.TabIndex = 1;
            this.buttonUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonUser.UseVisualStyleBackColor = false;
            this.buttonUser.Click += new System.EventHandler(this.buttonUser_Click);
            // 
            // ButtonOptionsUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.buttonUser);
            this.Name = "ButtonOptionsUser";
            this.Size = new System.Drawing.Size(219, 45);
            this.contextMenuStripUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStripUser;
        private System.Windows.Forms.ToolStripMenuItem editionDuProfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seDéconnecterToolStripMenuItem;
        private System.Windows.Forms.Button buttonUser;
    }
}
