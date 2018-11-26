
namespace EICE_WARGAME
{
    partial class PageInscription
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
            this.linkLabelDejaInscrit = new System.Windows.Forms.LinkLabel();
            this.labelInscription = new System.Windows.Forms.Label();
            this.errorProviderInscription = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonSInscrire = new System.Windows.Forms.Button();
            this.textBoxAvecTextInvisibleMdpConf = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleLogin = new EICE_WARGAME.TextBoxAvecTextInvisible();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInscription)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelDejaInscrit
            // 
            this.linkLabelDejaInscrit.AutoSize = true;
            this.linkLabelDejaInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.linkLabelDejaInscrit.Location = new System.Drawing.Point(659, 512);
            this.linkLabelDejaInscrit.Name = "linkLabelDejaInscrit";
            this.linkLabelDejaInscrit.Size = new System.Drawing.Size(78, 17);
            this.linkLabelDejaInscrit.TabIndex = 5;
            this.linkLabelDejaInscrit.TabStop = true;
            this.linkLabelDejaInscrit.Text = "Déjà inscrit";
            this.linkLabelDejaInscrit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDejaInscrit_LinkClicked);
            // 
            // labelInscription
            // 
            this.labelInscription.AutoSize = true;
            this.labelInscription.Font = new System.Drawing.Font("Verdana", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscription.Location = new System.Drawing.Point(651, 199);
            this.labelInscription.Name = "labelInscription";
            this.labelInscription.Size = new System.Drawing.Size(257, 53);
            this.labelInscription.TabIndex = 0;
            this.labelInscription.Text = "Inscription";
            // 
            // errorProviderInscription
            // 
            this.errorProviderInscription.ContainerControl = this;
            // 
            // buttonSInscrire
            // 
            this.buttonSInscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.buttonSInscrire.Image = global::EICE_WARGAME.Properties.Resources.Validation25px;
            this.buttonSInscrire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSInscrire.Location = new System.Drawing.Point(661, 462);
            this.buttonSInscrire.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSInscrire.Name = "buttonSInscrire";
            this.buttonSInscrire.Size = new System.Drawing.Size(237, 32);
            this.buttonSInscrire.TabIndex = 6;
            this.buttonSInscrire.Text = "S\'inscrire";
            this.buttonSInscrire.UseVisualStyleBackColor = true;
            this.buttonSInscrire.Click += new System.EventHandler(this.buttonSInscrire_Click);
            // 
            // textBoxAvecTextInvisibleMdpConf
            // 
            this.textBoxAvecTextInvisibleMdpConf.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdpConf.Location = new System.Drawing.Point(660, 409);
            this.textBoxAvecTextInvisibleMdpConf.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdpConf.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleMdpConf.Name = "textBoxAvecTextInvisibleMdpConf";
            this.textBoxAvecTextInvisibleMdpConf.PlaceHolder = "Confirmation mot de passe";
            this.textBoxAvecTextInvisibleMdpConf.Size = new System.Drawing.Size(239, 22);
            this.textBoxAvecTextInvisibleMdpConf.TabIndex = 3;
            this.textBoxAvecTextInvisibleMdpConf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAvecTextInvisibleMdpConf_KeyDown);
            // 
            // textBoxAvecTextInvisibleMdp
            // 
            this.textBoxAvecTextInvisibleMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdp.Location = new System.Drawing.Point(660, 350);
            this.textBoxAvecTextInvisibleMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleMdp.Name = "textBoxAvecTextInvisibleMdp";
            this.textBoxAvecTextInvisibleMdp.PlaceHolder = "Mot de passe";
            this.textBoxAvecTextInvisibleMdp.Size = new System.Drawing.Size(239, 22);
            this.textBoxAvecTextInvisibleMdp.TabIndex = 2;
            // 
            // textBoxAvecTextInvisibleLogin
            // 
            this.textBoxAvecTextInvisibleLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleLogin.Location = new System.Drawing.Point(660, 295);
            this.textBoxAvecTextInvisibleLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleLogin.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleLogin.Name = "textBoxAvecTextInvisibleLogin";
            this.textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            this.textBoxAvecTextInvisibleLogin.Size = new System.Drawing.Size(239, 22);
            this.textBoxAvecTextInvisibleLogin.TabIndex = 1;
            // 
            // PageInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSInscrire);
            this.Controls.Add(this.labelInscription);
            this.Controls.Add(this.linkLabelDejaInscrit);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdpConf);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleLogin);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageInscription";
            this.Size = new System.Drawing.Size(1500, 750);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleLogin;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdp;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdpConf;
        private System.Windows.Forms.LinkLabel linkLabelDejaInscrit;
        private System.Windows.Forms.Label labelInscription;
        private System.Windows.Forms.ErrorProvider errorProviderInscription;
        private System.Windows.Forms.Button buttonSInscrire;
    }
}
