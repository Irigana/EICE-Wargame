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

        #region Armée
        private Army m_Army = null;
        public Army Army
        {
            get
            {
                return m_Army;
            }
            set
            {
                if ((m_Army == null) && (value != null))
                {
                    m_Army = value;
                }
            }
        }
        #endregion


        public PageImpressionCarteUnite()
        {

            InitializeComponent();
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);

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
            string Query = string.Format(@"SELECT army.ar_name, subunity.su_name, figurine.fi_id, charact.ch_name, rank.ra_name, stuff.st_name, stuff_char_rank.scr_cost, subunity.su_id FROM army
                                            JOIN army_unity ON army_unity.aru_army_id = army.ar_id
                                            JOIN army_unity_figurine ON army_unity_figurine.auf_fk_army_unity_id = army_unity.aru_id
                                            JOIN char_rank ON army_unity_figurine.auf_fk_rank_id = char_rank.cr_id
                                            JOIN figurine ON army_unity_figurine.auf_fk_figurine_id = figurine.fi_id
                                            JOIN figurine_stuff ON fs_fk_figurine_id = fi_id 
											JOIN stuff on stuff.st_id = figurine_stuff.fs_fk_stuff_id
                                            JOIn stuff_char_rank ON  stuff_char_rank.scr_fk_stuff_id = stuff.st_id
                                            JOIN rank ON rank.ra_id = char_rank.cr_fk_ra_id
                                            JOIN charact ON figurine.fi_fk_character_id = charact.ch_id 
                                            JOIN subunity ON char_rank.cr_sub_id = subunity.su_id
                                            JOIN user ON user.u_id = army.ar_fk_user_id");
                                          //  WHERE user.u_id = {0} AND ar_id = {0}", Utilisateur, Army.Id);
            MySqlCommand Command = new MySqlCommand(Query);
            DataTable DTC = new DataTable();
            a_db = new GMBD();
            MySqlConnection Connexion = new MySqlConnection(a_db.Param());
            Command.Connection = Connexion;
            Connexion.Open();
            DTC.Load(Command.ExecuteReader());
            Connexion.Close();
            int lastEntry = -1;
            int lastEntrySub = -1;
            for (int i = 0; i < DTC.Rows.Count; i++)
            {
                int test = int.Parse(DTC.Rows[i][2].ToString());
                string NomSousUnite = DTC.Rows[i][1].ToString();
                string NomFIgurine = DTC.Rows[i][3].ToString();
                string NomRank = DTC.Rows[i][4].ToString();
                string NomEquipement = DTC.Rows[i][5].ToString();
                string Cost = DTC.Rows[i][6].ToString();
                int testsub = int.Parse(DTC.Rows[i][7].ToString());
                if (test == lastEntry)
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = "", Dock = DockStyle.Fill }, 0, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomRank, Dock = DockStyle.Fill }, 1, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomEquipement, Dock = DockStyle.Fill }, 2, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Cost, Dock = DockStyle.Fill }, 3, i+1);
                    lastEntry = test;
                    lastEntrySub = testsub;
                }
                else if (testsub == lastEntrySub)
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomFIgurine, Dock = DockStyle.Fill }, 0, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomRank, Dock = DockStyle.Fill }, 1, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomEquipement, Dock = DockStyle.Fill }, 2, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Cost, Dock = DockStyle.Fill }, 3, i+1);
                    lastEntry = test;
                    lastEntrySub = testsub;
                }
                else
                {
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomSousUnite, Dock = DockStyle.Fill }, 0, i);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomFIgurine, Dock = DockStyle.Fill }, 0, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomRank, Dock = DockStyle.Fill }, 1, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = NomEquipement, Dock = DockStyle.Fill }, 2, i+1);
                    tableLayoutPanel1.Controls.Add(new Label() { Text = Cost, Dock = DockStyle.Fill }, 3, i+1);
                    lastEntry = test;
                    lastEntrySub = testsub;
                }
                

            }

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
