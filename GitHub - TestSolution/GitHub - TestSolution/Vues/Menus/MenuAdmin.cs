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
    public partial class MenuAdmin : UserControl
    {
        
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
                }
            }
        }
        #endregion
        
        public MenuAdmin()
        {
            InitializeComponent();

        }
        private bool m_EstAdmin;

        public bool EstAdmin
        {
            get
            {
                return m_EstAdmin;
            }
            set
            {
                if (value != m_EstAdmin)
                {
                    m_EstAdmin = value;
                    if (m_EstAdmin == true) buttonGestionUser.Show();
                }
            }
        }

        private void buttonEquipement_Click(object sender, EventArgs e)
        {          
            // Permet de tester si la page actuelle n'est pas déjà la page d'ajout de l'équipement
            if(Form_Principal.Instance.PageCourante.Name.ToString() != new PageEquipements().Name.ToString())
            {
                // Sinon on crée la page d'ajout d'équipements
                Form_Principal.Instance.CreerPageCourante<PageEquipements>((Page) =>
                {
                    Page.Utilisateur = Utilisateur;                    
                    return true;
                });
                        
            }            
        }

        private void buttonSousFaction_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageSousFaction>((Page) =>
            {
                Page.Utilisateur = Utilisateur;
                return true;
            });
        }

        private void buttonFaction_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageFaction>((Page) =>
            {
                Page.Utilisateur = Utilisateur;
                return true;
            });
        }

        private void buttonMenuUser_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageGestionUser>((Page) =>
            {
                Page.Utilisateur = Utilisateur;
                return true;
            });
        }
        
    }
}
