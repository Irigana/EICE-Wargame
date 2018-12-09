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
    public partial class PageScenario : UserControl
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
                    buttonOptionsUser1.Utilisateur = m_Utilisateur;
                }
            }
        }
        #endregion


        public PageScenario()
        {
            InitializeComponent();
            menuAdmin1.MaPageActive = 1;
            int test = ficheScenarioCamp1.QG;         
        }

        private void PageScenario_Load(object sender, EventArgs e)
        {
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;

            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié            
            if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;
        }

        private void buttonNouveauCamp_Click(object sender, EventArgs e)
        {
            ficheScenarioCamp2.Enabled = true;
            int test = ficheScenarioCamp1.QG;
        }
    }
}
