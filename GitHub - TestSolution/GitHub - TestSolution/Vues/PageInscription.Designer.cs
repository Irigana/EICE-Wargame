
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
            this.buttonSInscrire = new System.Windows.Forms.Button();
            this.linkLabelDejaInscrit = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAvecTextInvisibleMdpConf = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleLogin = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.errorProviderInscription = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInscription)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSInscrire
            // 
            this.buttonSInscrire.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSInscrire.Image = global::EICE__WARGAME.Properties.Resources.Validation;
            this.buttonSInscrire.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSInscrire.Location = new System.Drawing.Point(229, 376);
            this.buttonSInscrire.Name = "buttonSInscrire";
            this.buttonSInscrire.Size = new System.Drawing.Size(237, 36);
            this.buttonSInscrire.TabIndex = 4;
            this.buttonSInscrire.Text = "S\'inscrire";
            this.buttonSInscrire.UseVisualStyleBackColor = true;
            this.buttonSInscrire.Click += new System.EventHandler(this.buttonSInscrire_Click);
            // 
            // linkLabelDejaInscrit
            // 
            this.linkLabelDejaInscrit.AutoSize = true;
            this.linkLabelDejaInscrit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.linkLabelDejaInscrit.Location = new System.Drawing.Point(226, 415);
            this.linkLabelDejaInscrit.Name = "linkLabelDejaInscrit";
            this.linkLabelDejaInscrit.Size = new System.Drawing.Size(78, 17);
            this.linkLabelDejaInscrit.TabIndex = 5;
            this.linkLabelDejaInscrit.TabStop = true;
            this.linkLabelDejaInscrit.Text = "Déjà inscrit";
            this.linkLabelDejaInscrit.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelDejaInscrit_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inscription";
            // 
            // textBoxAvecTextInvisibleMdpConf
            // 
            this.textBoxAvecTextInvisibleMdpConf.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdpConf.Location = new System.Drawing.Point(227, 312);
            this.textBoxAvecTextInvisibleMdpConf.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdpConf.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleMdpConf.Name = "textBoxAvecTextInvisibleMdpConf";
            this.textBoxAvecTextInvisibleMdpConf.PlaceHolder = "Confirmation mot de passe";
            this.textBoxAvecTextInvisibleMdpConf.Size = new System.Drawing.Size(239, 22);
            this.textBoxAvecTextInvisibleMdpConf.TabIndex = 3;
            // 
            // textBoxAvecTextInvisibleMdp
            // 
            this.textBoxAvecTextInvisibleMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdp.Location = new System.Drawing.Point(227, 253);
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
            this.textBoxAvecTextInvisibleLogin.Location = new System.Drawing.Point(227, 199);
            this.textBoxAvecTextInvisibleLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleLogin.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleLogin.Name = "textBoxAvecTextInvisibleLogin";
            this.textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            this.textBoxAvecTextInvisibleLogin.Size = new System.Drawing.Size(239, 22);
            this.textBoxAvecTextInvisibleLogin.TabIndex = 1;
            // 
            // errorProviderInscription
            // 
            this.errorProviderInscription.ContainerControl = this;
            // 
            // PageInscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelDejaInscrit);
            this.Controls.Add(this.buttonSInscrire);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdpConf);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleLogin);
            this.Name = "PageInscription";
            this.Size = new System.Drawing.Size(650, 550);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderInscription)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleLogin;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdp;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdpConf;
        private System.Windows.Forms.Button buttonSInscrire;
        private System.Windows.Forms.LinkLabel linkLabelDejaInscrit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProviderInscription;
    }
}
