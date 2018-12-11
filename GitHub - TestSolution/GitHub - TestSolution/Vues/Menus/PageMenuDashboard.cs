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
                if (Utilisateur.Role.Id == 2)
                {
                    buttonGestionUser.Show();
                }
                else
                {
                    buttonScenario.Location = new Point(475, 185);
                    buttonScenario.Size = new Size(225, 45);

                    buttonFaction.Location = new Point(475, 235);
                    buttonFaction.Size = new Size(225, 45);

                    buttonSousFaction.Location = new Point(475, 285);
                    buttonSousFaction.Size = new Size(225, 45);

                    buttonPersonnage.Location = new Point(475, 335);
                    buttonPersonnage.Size = new Size(225, 45);

                    buttonEquipement.Location = new Point(475, 385);
                    buttonEquipement.Size = new Size(225, 45);

                    buttonRetourMenuPrincipal.Location = new Point(475, 435);
                    buttonRetourMenuPrincipal.Size = new Size(225, 45);

                    buttonGestionUser.Hide();
                }
            }
            else
            {
                Form_Principal.Instance.CreerPageCourante<PageConnexion>();
            }


        }

        private void buttonEquipements_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageEquipements>(
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
            Form_Principal.Instance.CreerPageCourante<PageSousFaction>(
                (page) =>
                {
                    page.Utilisateur = Utilisateur;
                    return true;
                });
        }

        private void buttonFaction_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageFaction>(
                            (page) =>
                            {
                                page.Utilisateur = Utilisateur;
                                return true;
                            });
        }

        private void buttonGestionUser_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageGestionUser>(
                            (page) =>
                            {
                                page.Utilisateur = Utilisateur;
                                return true;
                            });
        }

        private void buttonCaractère_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PagePersonnage>(
                            (page) =>
                            {
                                page.Utilisateur = Utilisateur;
                                return true;
                            });
        }

        private void buttonScenario_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageScenario>(
                            (page) =>
                            {
                                page.Utilisateur = Utilisateur;
                                return true;
                            });
        }
    }
}
