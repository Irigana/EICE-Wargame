
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
            this.linkLabelCreerCompte = new System.Windows.Forms.LinkLabel();
            this.errorProviderConnexion = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBoxCadenaFerme = new System.Windows.Forms.PictureBox();
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.textBoxAvecTextInvisibleMdp = new EICE_WARGAME.TextBoxAvecTextInvisible();
            this.textBoxAvecTextInvisibleLogin = new EICE_WARGAME.TextBoxAvecTextInvisible();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConnexion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaFerme)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelCreerCompte
            // 
            this.linkLabelCreerCompte.AutoSize = true;
            this.linkLabelCreerCompte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCreerCompte.Location = new System.Drawing.Point(709, 487);
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
            // pictureBoxCadenaFerme
            // 
            this.pictureBoxCadenaFerme.Image = global::EICE_WARGAME.Properties.Resources.Title_warhammer_2;
            this.pictureBoxCadenaFerme.Location = new System.Drawing.Point(370, 40);
            this.pictureBoxCadenaFerme.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxCadenaFerme.Name = "pictureBoxCadenaFerme";
            this.pictureBoxCadenaFerme.Size = new System.Drawing.Size(870, 165);
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
            this.buttonConnexion.Image = global::EICE_WARGAME.Properties.Resources.CadenaOuvert25px;
            this.buttonConnexion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonConnexion.Location = new System.Drawing.Point(660, 418);
            this.buttonConnexion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(232, 46);
            this.buttonConnexion.TabIndex = 2;
            this.buttonConnexion.Text = "Se connecter";
            this.buttonConnexion.UseVisualStyleBackColor = false;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnecter_Click);
            // 
            // textBoxAvecTextInvisibleMdp
            // 
            this.textBoxAvecTextInvisibleMdp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvecTextInvisibleMdp.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleMdp.Location = new System.Drawing.Point(660, 368);
            this.textBoxAvecTextInvisibleMdp.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleMdp.MotDePasseCache = true;
            this.textBoxAvecTextInvisibleMdp.Name = "textBoxAvecTextInvisibleMdp";
            this.textBoxAvecTextInvisibleMdp.PlaceHolder = "Mot de passe";
            this.textBoxAvecTextInvisibleMdp.Size = new System.Drawing.Size(231, 28);
            this.textBoxAvecTextInvisibleMdp.TabIndex = 1;
            this.textBoxAvecTextInvisibleMdp.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxAvecTextInvisibleMdp_KeyDown);
            // 
            // textBoxAvecTextInvisibleLogin
            // 
            this.textBoxAvecTextInvisibleLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxAvecTextInvisibleLogin.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.textBoxAvecTextInvisibleLogin.Location = new System.Drawing.Point(660, 314);
            this.textBoxAvecTextInvisibleLogin.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxAvecTextInvisibleLogin.MotDePasseCache = false;
            this.textBoxAvecTextInvisibleLogin.Name = "textBoxAvecTextInvisibleLogin";
            this.textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            this.textBoxAvecTextInvisibleLogin.Size = new System.Drawing.Size(231, 28);
            this.textBoxAvecTextInvisibleLogin.TabIndex = 0;
            this.textBoxAvecTextInvisibleLogin.Tag = "";
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
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PageConnexion";
            this.Size = new System.Drawing.Size(1500, 750);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConnexion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCadenaFerme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleLogin;
        private TextBoxAvecTextInvisible textBoxAvecTextInvisibleMdp;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.LinkLabel linkLabelCreerCompte;
        private System.Windows.Forms.ErrorProvider errorProviderConnexion;
        private System.Windows.Forms.PictureBox pictureBoxCadenaFerme;
    }
}
