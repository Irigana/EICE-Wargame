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
using MySql.Data.MySqlClient;
using PDSGBD;

namespace EICE_WARGAME
{
    public partial class PageImpressionCarteUnite : UserControl
    {

        private PrintDocument printDocument1 = new PrintDocument();
        private GMBD a_db = new GMBD();

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
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
        }

        #region Methode d'impression

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
            printableListView1.Columns.Add(new ColumnHeader()
            {
                Name = "Figurine",
                Text = "Figurine",
                TextAlign = HorizontalAlignment.Center,
            });
            printableListView1.Columns.Add(new ColumnHeader()
            {
                Name = "Equipement",
                Text = "Equipement",
                TextAlign = HorizontalAlignment.Center,
            });

            // Rows

            foreach (DataRow row in table.Rows)
            {
                ListViewItem item = new ListViewItem();
                for (int i = 1; i < table.Columns.Count; i++)
                {
                   
                    item.Text = row[i].ToString();
                    item.SubItems.Add(item.Name);
                }           
            printableListView1.Items.Add(item);
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


        #endregion

        private void ButtonPageSetup_OnClick(object sender, System.EventArgs e)
        {
            printableListView1.PageSetup();
        }

        private void ButtonPrintPreview_OnClick(object sender, System.EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void ButtonPrint_OnClick(object sender, System.EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();


        }


        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
            tableLayoutPanel1.DrawToBitmap(memoryImage, new Rectangle(new Point(0, 0), this.Size));
        }


        private void printDocument1_PrintPage(System.Object sender,
        System.Drawing.Printing.PrintPageEventArgs e)
        {

            // Insert code to render the page here.
            // This code will be called when the PrintPreviewDialog.Show 
            // method is called.

            // The following code will render a simple
            // message on the document in the dialog.
            string text = "In document_PrintPage method.";
            System.Drawing.Font printFont =
                new System.Drawing.Font("Arial", 35,
                System.Drawing.FontStyle.Regular);

            e.Graphics.DrawString(text, printFont,
                System.Drawing.Brushes.Black, 0, 0);
        }


        private void PageImpressionCarteUnite_Load(object sender, EventArgs e)
        {
            string Query = string.Format(@"SELECT * FROM figurine 
                                           JOIN figurine_stuff On fs_fk_figurine_id = fi_id 
                                           JOIN charact on figurine.fi_fk_character_id = charact.ch_id 
                                           JOIN stuff on stuff.st_id = figurine_stuff.fs_fk_stuff_id");
            MySqlCommand Command = new MySqlCommand(Query);
            DataTable DTC = new DataTable();
            a_db = new GMBD();
            MySqlConnection Connexion = new MySqlConnection(a_db.Param());
            Command.Connection = Connexion;
            Connexion.Open();
            DTC.Load(Command.ExecuteReader());
            Connexion.Close();
            int lastEntry = -1;
            for (int i = 0; i < DTC.Rows.Count; i++)
            {
                int test = int.Parse(DTC.Rows[i][0].ToString());
                string NomFIgurine = DTC.Rows[i][7].ToString();
                string NomEquipement = DTC.Rows[i][10].ToString();
                if (test == lastEntry)
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = "", Dock = DockStyle.Fill }, 0, i);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomEquipement, Dock = DockStyle.Fill }, 1, i);
                    lastEntry = test;
                }
                else
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomFIgurine, Dock = DockStyle.Fill }, 0, i);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomEquipement, Dock = DockStyle.Fill }, 1, i);
                    lastEntry = test;
                }

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
