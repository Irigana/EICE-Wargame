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
    public partial class PageConnexion : UserControl
    {

        GMBD s_GMBD = new GMBD();

        Utilisateur m_Utilisateur = null;

        public Utilisateur Utilisateur
        {
            get
            {
                return m_Utilisateur;
            }
        }

        public bool EstIdentifie
        {
            get
            {
                return m_Utilisateur != null;
            }
        }

        public PageConnexion()
        {
            InitializeComponent();
            textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            textBoxAvecTextInvisibleMdp.PlaceHolder = "Mot de passe";
               
        }

        private void linkLabelCreerCompte_Click(object sender, EventArgs e)
        {
            this.SendToBack();
        }

        private void buttonConnecter_Click(object sender, EventArgs e)
        {
            if ((textBoxAvecTextInvisibleLogin != null) && (textBoxAvecTextInvisibleMdp != null))
            {
                s_GMBD.Initialiser();
                Utilisateur Utilisateur = s_GMBD.ConnexionApplication(textBoxAvecTextInvisibleLogin.Text, textBoxAvecTextInvisibleMdp.Text);
                if (Utilisateur == null)
                {
                    errorProviderConnexion.SetError(textBoxAvecTextInvisibleLogin, "Le pseudo ou le mot de passe est incorrect");
                    errorProviderConnexion.SetIconPadding(textBoxAvecTextInvisibleLogin, 4);
                }
                else if (!Outils.TesterEgaliteNoms(Utilisateur.Role.NomRole, "Administrateur"))
                {
                    errorProviderConnexion.SetError(textBoxAvecTextInvisibleLogin, "Vous n'avez pas accès à cet application, seul les administrateurs y sont autoriser");
                    errorProviderConnexion.SetIconPadding(textBoxAvecTextInvisibleLogin, 4);
                }
                else if (Outils.TesterEgaliteNoms(Utilisateur.Role.NomRole, "Administrateur"))
                {
                    m_Utilisateur = Utilisateur;
                    this.Dispose();
                }

            }
        }
    }
}
