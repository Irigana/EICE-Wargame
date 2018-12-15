namespace EICE_WARGAME
{
    partial class PageImpressionCarteUnite
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PageImpressionCarteUnite));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.button_Imprimer = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonReturn = new System.Windows.Forms.Button();
            this.buttonOptionsUser2 = new EICE_WARGAME.ButtonOptionsUser();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // button_Imprimer
            // 
            this.button_Imprimer.BackColor = System.Drawing.Color.SteelBlue;
            this.button_Imprimer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_Imprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Imprimer.Location = new System.Drawing.Point(0, 471);
            this.button_Imprimer.Name = "button_Imprimer";
            this.button_Imprimer.Size = new System.Drawing.Size(1010, 48);
            this.button_Imprimer.TabIndex = 17;
            this.button_Imprimer.Text = "Imprimer";
            this.button_Imprimer.UseVisualStyleBackColor = false;
            this.button_Imprimer.Click += new System.EventHandler(this.ButtonPrint_OnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "Test";
            this.columnHeader1.Text = "Test";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "Test";
            this.columnHeader2.Text = "Test";
            this.columnHeader2.Width = 100;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(229, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(563, 217);
            this.tableLayoutPanel1.TabIndex = 19;
            // 
            // buttonReturn
            // 
            this.buttonReturn.FlatAppearance.BorderSize = 0;
            this.buttonReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReturn.Image = global::EICE_WARGAME.Properties.Resources.ReturnLogo35px;
            this.buttonReturn.Location = new System.Drawing.Point(2, 3);
            this.buttonReturn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonReturn.Name = "buttonReturn";
            this.buttonReturn.Size = new System.Drawing.Size(33, 32);
            this.buttonReturn.TabIndex = 20;
            this.buttonReturn.UseVisualStyleBackColor = true;
            // 
            // buttonOptionsUser2
            // 
            this.buttonOptionsUser2.BackColor = System.Drawing.Color.Transparent;
            this.buttonOptionsUser2.Location = new System.Drawing.Point(846, 2);
            this.buttonOptionsUser2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonOptionsUser2.Name = "buttonOptionsUser2";
            this.buttonOptionsUser2.Size = new System.Drawing.Size(164, 37);
            this.buttonOptionsUser2.TabIndex = 21;
            this.buttonOptionsUser2.Utilisateur = null;
            // 
            // PageImpressionCarteUnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonOptionsUser2);
            this.Controls.Add(this.buttonReturn);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_Imprimer);
            this.Name = "PageImpressionCarteUnite";
            this.Size = new System.Drawing.Size(1010, 519);
            this.Load += new System.EventHandler(this.PageImpressionCarteUnite_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Windows.Forms.Button button_Imprimer;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonReturn;
        private ButtonOptionsUser buttonOptionsUser2;
    }
}
