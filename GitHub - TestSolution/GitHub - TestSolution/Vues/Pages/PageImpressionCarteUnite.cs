using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Drawing.Imaging;


namespace EICE_WARGAME
{
    public partial class PageImpressionCarteUnite : UserControl
    {

        private PrintDocument printDocument1 = new PrintDocument();
        private System.Windows.Forms.CheckBox m_cbFitToPage;
        /// <summary>
        /// Required designer variable.
        /// </summary>


        #region Utilisateur
        private Utilisateur m_Utilisateur = null;

        public Utilisateur Utilisateur
        {
            get
            {
                return m_Utilisateur;
            }
            set
            {
                if ((m_Utilisateur == null) && (value != null))
                {
                    m_Utilisateur = value;
  //                  buttonOptionsUser1.Utilisateur = m_Utilisateur;
                }
            }
        }
        #endregion        

        public PageImpressionCarteUnite()
        {

            InitializeComponent();
        }


        void button_Export_PDF_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog PrintPreviewDialog1 = new PrintPreviewDialog();
            PrintDialog printDiablog1 = new PrintDialog();


            CaptureScreen();
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
           // printDocument1.Print();
        }


        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(this.Width, this.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }

        private void printDocument1_PrintPage(Object sender,
               PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }


        private void PageImpressionCarteUnite_Load(object sender, EventArgs e)
        {

        }


        #region Test

        private void FillList()
        {
            // Read data from xml file
            DataSet ds = new DataSet();
            try
            {
                ds.ReadXml("Orders.xml", XmlReadMode.ReadSchema);
                FillList(this.printableListView1, ds.Tables["ORDERS"]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void FillList(ListView list, DataTable table)
        {
            list.SuspendLayout();

            // Clear list
            list.Items.Clear();
            list.Columns.Clear();

            // Columns
            foreach (DataColumn col in table.Columns)
            {
                ColumnHeader ch = new ColumnHeader();
                ch.Text = col.Caption;
                if (IsNumeric(col.DataType))
                    ch.TextAlign = HorizontalAlignment.Right;
                ch.Width = 100;
                list.Columns.Add(ch);
            }

            // Rows
            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem();
                item.Text = row[0].ToString();

                for (int i = 1; i < table.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                list.Items.Add(item);
            }

            list.ResumeLayout();
        }

        private bool IsNumeric(System.Type dataType)
        {
            switch (System.Type.GetTypeCode(dataType))
            {
                case TypeCode.Byte:
                case TypeCode.SByte:
                case TypeCode.Decimal:
                case TypeCode.Double:
                case TypeCode.Int16:
                case TypeCode.Int32:
                case TypeCode.Int64:
                case TypeCode.Single:
                case TypeCode.UInt16:
                case TypeCode.UInt32:
                case TypeCode.UInt64:
                    return true;
                default:
                    return false;
            }
        }

        private void ButtonPageSetup_OnClick(object sender, System.EventArgs e)
        {
            printableListView1.PageSetup();
        }

        private void ButtonPrintPreview_OnClick(object sender, System.EventArgs e)
        {
            printableListView1.Title = "Test Printable List View";
           // printableListView1.FitToPage = m_cbFitToPage.Checked;
            printableListView1.PrintPreview();
        }

        private void ButtonPrint_OnClick(object sender, System.EventArgs e)
        {
            printableListView1.Title = "Test Printable List View";
          //  printableListView1.FitToPage = m_cbFitToPage.Checked;
            printableListView1.Print();
        }



        #endregion

    }
}
