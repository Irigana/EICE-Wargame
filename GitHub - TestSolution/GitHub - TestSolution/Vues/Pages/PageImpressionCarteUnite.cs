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


        #endregion

        private void ButtonPageSetup_OnClick(object sender, System.EventArgs e)
        {
            printableListView1.PageSetup();
        }

        private void ButtonPrintPreview_OnClick(object sender, System.EventArgs e)
        {
            printableListView1.Title = "Test Printable List View";
            printableListView1.PrintPreview();
        }

        private void ButtonPrint_OnClick(object sender, System.EventArgs e)
        {
            printableListView1.Title = "Test Printable List View";
            printableListView1.Print();
        }






        private void PageImpressionCarteUnite_Load(object sender, EventArgs e)
        {
            //            ListView Unité = new ListView();
            //            Unité = printableListView1.Name.Contains("Unité");
            //            FillList(printableListView1.Name.Contains("Unité"));

            //MySqlConnection Connexion = new MySqlConnection(a_db.Param());
            string Query = string.Format("SELECT un_name FROM unity");
            MySqlCommand Command = new MySqlCommand(Query);
            DataTable DTC = new DataTable();
            a_db = new GMBD();
            MySqlConnection Connexion = new MySqlConnection(a_db.Param());
            Command.Connection = Connexion;
            Connexion.Open();
            DTC.Load(Command.ExecuteReader());
            Connexion.Close();
            FillList(printableListView1, DTC);

        }

        private void printableListView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
