using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EICE_WARGAME
{
    public partial class PageAjouterArme : UserControl
    {
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
                    buttonOptionsUser1.Utilisateur = m_Utilisateur;
                }
            }
        }

        public PageAjouterArme()
        {
            InitializeComponent();
            m_Utilisateur = null;
            listeDeroulanteType.Type = Program.GMBD.EnumererType(null, null, null, PDSGBD.MyDB.CreerCodeSql("ty_name"));
        }

        private void listeDeroulanteType_Load(object sender, EventArgs e)
        {
            if (Utilisateur != null)
            {
                buttonOptionsUser1.ButtonOptionsUserUpdate();
            }
            else
            {
                Form_Principal.Instance.CreerPageCourante<PageConnexion>();
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
           
        }

        private void linkLabelDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageMenuDashboard>(
                        (Page) =>
                        {
                            Page.Utilisateur = Utilisateur;
                            return true;
                        });
        }

        private void linkLabelFigurines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }
    }
}
