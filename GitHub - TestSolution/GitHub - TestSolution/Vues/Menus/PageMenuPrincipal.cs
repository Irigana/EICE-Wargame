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
    public partial class PageMenuPrincipal : UserControl
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

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public PageMenuPrincipal()
        {
            InitializeComponent();
            m_Utilisateur = null;
            buttonDashboard.Hide();
        }               

        private void PageMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Utilisateur != null)
            {
                buttonOptionsUser1.ButtonOptionsUserUpdate();
                if((Utilisateur.Role.Id == 2) || (Utilisateur.Role.Id == 3))
                {
                    buttonDashboard.Show();
                }
                else
                {
                    this.buttonDeconnexion.Location = new Point(475, 325);
                }
            }
            else
            {
                Form_Principal.Instance.CreerPageCourante<PageConnexion>();
            }
        }        

        private void buttonDeconnexion_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageConnexion>();
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageMenuDashboard>(
                (page) =>
                {
                    page.Utilisateur = Utilisateur;
                    return true;
                });
        }
    }
}
