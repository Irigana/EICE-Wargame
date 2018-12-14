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
            this.buttonExportPDF = new System.Windows.Forms.Button();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.ficheFigurineStuff1 = new EICE_WARGAME.FicheFigurineStuff();
            this.SuspendLayout();
            // 
            // buttonExportPDF
            // 
            this.buttonExportPDF.Location = new System.Drawing.Point(0, 496);
            this.buttonExportPDF.Name = "buttonExportPDF";
            this.buttonExportPDF.Size = new System.Drawing.Size(1010, 23);
            this.buttonExportPDF.TabIndex = 13;
            this.buttonExportPDF.Text = "EXPORT PDF";
            this.buttonExportPDF.UseVisualStyleBackColor = true;
            this.buttonExportPDF.Click += new System.EventHandler(this.button_Export_PDF_Click);
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
            // ficheFigurineStuff1
            // 
            this.ficheFigurineStuff1.FigurineSelectionne = null;
            this.ficheFigurineStuff1.Location = new System.Drawing.Point(361, 13);
            this.ficheFigurineStuff1.Margin = new System.Windows.Forms.Padding(2);
            this.ficheFigurineStuff1.Name = "ficheFigurineStuff1";
            this.ficheFigurineStuff1.Size = new System.Drawing.Size(274, 467);
            this.ficheFigurineStuff1.TabIndex = 14;
            this.ficheFigurineStuff1.TexteFiltreFigurineStuff = "";
            // 
            // PageImpressionCarteUnite
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ficheFigurineStuff1);
            this.Controls.Add(this.buttonExportPDF);
            this.Name = "PageImpressionCarteUnite";
            this.Size = new System.Drawing.Size(1010, 519);
            this.Load += new System.EventHandler(this.PageImpressionCarteUnite_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonOptionsUser buttonOptionsUser1;
        private System.Windows.Forms.Button buttonExportPDF;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private FicheFigurineStuff ficheFigurineStuff1;
    }
}
