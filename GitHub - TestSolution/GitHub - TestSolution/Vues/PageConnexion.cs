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

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public PageConnexion()
        {
            InitializeComponent();
            textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            textBoxAvecTextInvisibleMdp.PlaceHolder = "Mot de passe";
            textBoxAvecTextInvisibleLogin.EnterPress += new KeyEventHandler(textBoxAvecTextInvisibleMdp_KeyDown);
            textBoxAvecTextInvisibleMdp.EnterPress += new KeyEventHandler(textBoxAvecTextInvisibleMdp_KeyDown);
        }

        /// <summary>
        /// Lien pour aller vers la création de compte
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelCreerCompte_Click(object sender, EventArgs e)
        {
            textBoxAvecTextInvisibleLogin.Text = "";
            textBoxAvecTextInvisibleMdp.RefreshMdpApresAcceptation();
            textBoxAvecTextInvisibleMdp.Text = "";
            Form_Principal.Instance.CreerPageCourante<PageInscription>();                        
        }

        /// <summary>
        /// Bouton de connexion à l'application par l'utilisateur 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConnecter_Click(object sender, EventArgs e)
        {
            if ((textBoxAvecTextInvisibleLogin != null) && (textBoxAvecTextInvisibleMdp != null))
            {
                s_GMBD.Initialiser();
                Utilisateur Utilisateur = s_GMBD.ConnexionApplication(textBoxAvecTextInvisibleLogin.Text, Outils.hash(textBoxAvecTextInvisibleMdp.Text));
                if (Utilisateur == null)
                {
                    errorProviderConnexion.SetError(textBoxAvecTextInvisibleLogin, "Le login ou le mot de passe est incorrect");
                    errorProviderConnexion.SetIconPadding(textBoxAvecTextInvisibleLogin, 4);
                }                
                else if (Outils.TesterEgaliteNoms(Utilisateur.Role.NomRole, "Administrateur"))
                {
                    // TODO : si c'est un admin traitement particulier ? 
                }
                else
                {
                    Form_Principal.Instance.CreerPageCourante<PageMenuPrincipal>(
                        (Page) =>
                        {
                            Page.Utilisateur = Utilisateur;
                            return true;
                        });
                }

            }
        }

        private void textBoxAvecTextInvisibleMdp_KeyDown(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode == Keys.Enter)
            {
                buttonConnecter_Click(null, null);
            }
        }
    }
}
