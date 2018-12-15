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


        }

        Bitmap printImage;

        private void CaptureScreen()
        {
            printImage = new Bitmap(tableLayoutPanel1.Width, tableLayoutPanel1.Height);
            tableLayoutPanel1.DrawToBitmap(printImage, new Rectangle(0, 0, printImage.Width, printImage.Height));
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += printDocument1_PrintPage;
            printPreviewDialog1.ShowDialog();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string text = "Liste des Unités de l'armée";
            Font printFont = new Font("Arial", 35, FontStyle.Regular);
            e.Graphics.DrawString(text, printFont, Brushes.Black, 0, 0);
            e.Graphics.DrawImage(printImage, 0, 0);
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

    }
}
