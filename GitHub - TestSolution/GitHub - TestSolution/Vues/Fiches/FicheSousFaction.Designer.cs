namespace EICE_WARGAME
{
    partial class FicheSousFaction
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
            this.listViewSousFaction = new System.Windows.Forms.ListView();
            this.textBoxSousFaction = new System.Windows.Forms.TextBox();
            this.errorProviderSousFaction = new System.Windows.Forms.ErrorProvider(this.components);
            this.ActionValidee = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSousFaction)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionValidee)).BeginInit();
            this.SuspendLayout();
            // 
            // listViewSousFaction
            // 
            this.listViewSousFaction.Location = new System.Drawing.Point(0, 28);
            this.listViewSousFaction.Name = "listViewSousFaction";
            this.listViewSousFaction.Size = new System.Drawing.Size(282, 257);
            this.listViewSousFaction.TabIndex = 2;
            this.listViewSousFaction.UseCompatibleStateImageBehavior = false;
            // 
            // textBoxSousFaction
            // 
            this.textBoxSousFaction.Location = new System.Drawing.Point(0, 0);
            this.textBoxSousFaction.Name = "textBoxSousFaction";
            this.textBoxSousFaction.Size = new System.Drawing.Size(282, 22);
            this.textBoxSousFaction.TabIndex = 3;
            this.textBoxSousFaction.TextChanged += new System.EventHandler(this.textFiltre_TextChanged);
            this.textBoxSousFaction.Enter += new System.EventHandler(this.textBoxSousFaction_Enter);
            this.textBoxSousFaction.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textFiltre_KeyPress);
            this.textBoxSousFaction.Leave += new System.EventHandler(this.textBoxSousFaction_Leave);
            // 
            // errorProviderSousFaction
            // 
            this.errorProviderSousFaction.ContainerControl = this;
            // 
            // ActionValidee
            // 
            this.ActionValidee.BlinkRate = 0;
            this.ActionValidee.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ActionValidee.ContainerControl = this;
            // 
            // FicheSousFaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxSousFaction);
            this.Controls.Add(this.listViewSousFaction);
            this.Name = "FicheSousFaction";
            this.Size = new System.Drawing.Size(327, 293);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSousFaction)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActionValidee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView listViewSousFaction;
        private System.Windows.Forms.TextBox textBoxSousFaction;
        private System.Windows.Forms.ErrorProvider errorProviderSousFaction;
        private System.Windows.Forms.ErrorProvider ActionValidee;
    }
}
