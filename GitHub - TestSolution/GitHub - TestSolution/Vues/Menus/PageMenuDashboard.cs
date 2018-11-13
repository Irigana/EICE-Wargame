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
    public partial class PageMenuDashboard : UserControl
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

        public PageMenuDashboard()
        {
            InitializeComponent();
            m_Utilisateur = null;            
        }

        private void PageMenuDashBoard_Load(object sender, EventArgs e)
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

        private void buttonEquipements_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageAjouterEquipements>(
                (page) =>
            {
                page.Utilisateur = Utilisateur;
                return true;
            });
        }

        private void buttonRetourMenuPrincipal_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageMenuPrincipal>(
                (page) =>
                {
                    page.Utilisateur = Utilisateur;
                    return true;
                });                          
        }

        private void buttonFactionSF_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageAjoutFaction>(
                (page) =>
                {
                    page.Utilisateur = Utilisateur;
                    return true;
                });
        }
    }
}
