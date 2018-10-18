
namespace EICE_WARGAME
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
            this.components = new System.ComponentModel.Container();
            this.labelSeConnecter = new System.Windows.Forms.Label();
            this.linkLabelCreerCompte = new System.Windows.Forms.LinkLabel();
            this.errorProviderConnexion = new System.Windows.Forms.ErrorProvider(this.components);
            this.textBoxAvecTextInvisibleMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleLogin = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.pictureBoxCadenaFerme = new System.Windows.Forms.PictureBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonOptionsUser1 = new EICE_WARGAME.ButtonOptionsUser();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConnexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaFerme)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSeConnecter
            // 
            this.labelSeConnecter.AutoSize = true;
            this.labelSeConnecter.Font = new System.Drawing.Font("Comic Sans MS", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSeConnecter.Location = new System.Drawing.Point(650, 200);
            this.labelSeConnecter.Name = "labelSeConnecter";
            this.labelSeConnecter.Size = new System.Drawing.Size(258, 53);
            this.labelSeConnecter.TabIndex = 0;
            this.labelSeConnecter.Text = "Se connecter";
            // 
            // linkLabelCreerCompte
            // 
            this.linkLabelCreerCompte.AutoSize = true;
            this.linkLabelCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreerCompte.Location = new System.Drawing.Point(710, 454);
            this.linkLabelCreerCompte.Name = "linkLabelCreerCompte";
            this.linkLabelCreerCompte.Size = new System.Drawing.Size(134, 20);
            this.linkLabelCreerCompte.TabIndex = 3;
            this.linkLabelCreerCompte.TabStop = true;
            this.linkLabelCreerCompte.Text = "Créer un compte";
            this.linkLabelCreerCompte.Click += new System.EventHandler(this.linkLabelCreerCompte_Click);
            // 
            // errorProviderConnexion
            // 
            this.errorProviderConnexion.ContainerControl = this;
            // 
            // textBoxAvecTextInvisibleMdp
            // 
            this.textBoxAvecTextInvisibleMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvecTextInvisibleMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdp.Location = new System.Drawing.Point(660, 335);
            this.textBoxAvecTextInvisibleMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleMdp.Name = "textBoxAvecTextInvisibleMdp";
            this.textBoxAvecTextInvisibleMdp.PlaceHolder = "Mot de passe";
            this.textBoxAvecTextInvisibleMdp.Size = new System.Drawing.Size(231, 28);
            this.textBoxAvecTextInvisibleMdp.TabIndex = 1;
            // 
            // textBoxAvecTextInvisibleLogin
            // 
            this.textBoxAvecTextInvisibleLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvecTextInvisibleLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleLogin.Location = new System.Drawing.Point(660, 280);
            this.textBoxAvecTextInvisibleLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleLogin.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleLogin.Name = "textBoxAvecTextInvisibleLogin";
            this.textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            this.textBoxAvecTextInvisibleLogin.Size = new System.Drawing.Size(231, 28);
            this.textBoxAvecTextInvisibleLogin.TabIndex = 0;
            this.textBoxAvecTextInvisibleLogin.Tag = "";
            // 
            // pictureBoxCadenaFerme
            // 
            this.pictureBoxCadenaFerme.Image = global::EICE__WARGAME.Properties.Resources.CadenaFerme75px;
            this.pictureBoxCadenaFerme.Location = new System.Drawing.Point(725, 85);
            this.pictureBoxCadenaFerme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
            this.buttonConnexion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonConnexion.Image = global::EICE__WARGAME.Properties.Resources.CadenaFerme25px;
            this.buttonConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnexion.Location = new System.Drawing.Point(660, 385);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(232, 46);
            this.buttonConnexion.TabIndex = 2;
            this.buttonConnexion.Text = "Se connecter";
            this.buttonConnexion.UseVisualStyleBackColor = false;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnecter_Click);
            // 
            // buttonOptionsUser1
            // 
            this.buttonOptionsUser1.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser1.Location = new System.Drawing.Point(1317, 3);
            this.buttonOptionsUser1.Name = "buttonOptionsUser1";
            this.buttonOptionsUser1.Size = new System.Drawing.Size(180, 45);
            this.buttonOptionsUser1.TabIndex = 6;
            // 
            // PageConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.buttonOptionsUser1);
            this.Controls.Add(this.pictureBoxCadenaFerme);
            this.Controls.Add(this.linkLabelCreerCompte);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.textBoxAvecTextInvisibleMdp);
            this.Controls.Add(this.textBoxAvecTextInvisibleLogin);
            this.Controls.Add(this.labelSeConnecter);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageConnexion";
            this.Size = new System.Drawing.Size(1500, 750);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConnexion)).EndInit();
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
        private System.Windows.Forms.ErrorProvider errorProviderConnexion;
        private EICE_WARGAME.ButtonOptionsUser buttonOptionsUser1;
    }
}
