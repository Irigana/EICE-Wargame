using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSGBD;

namespace EICE_WARGAME
{
    public partial class PageEditionUser : UserControl
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

        public PageEditionUser()
        {
            InitializeComponent();
            m_Utilisateur = null;
            textBoxAvecTextInvisibleNouveauMdp.EnterPress += new KeyEventHandler(textBoxAvecTextInvisible_KeyDown);
            textBoxAvecTextInvisibleConfNewMdp.EnterPress += new KeyEventHandler(textBoxAvecTextInvisible_KeyDown);
        }

        private void PageEditionUser_Load(object sender, EventArgs e)
        {
            buttonOptionsUser1.ButtonOptionsUserUpdate();
        }

        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            errorProviderEdition.Clear();
            bool ModificationEffectuee = false;
            
            Utilisateur UtilisateurEnEdition = Utilisateur;

            // Si le mot de passe de l'utilisateur est différent et que les textbox du nouveau mot de passe sont pas vide et égale
            if ((string.Compare(UtilisateurEnEdition.MotDePasse.ToString(),textBoxAvecTextInvisibleNouveauMdp.Text.ToString()) != 0)
                && ((textBoxAvecTextInvisibleConfNewMdp.Text != "") && (textBoxAvecTextInvisibleNouveauMdp.Text != ""))
                && (string.Compare(textBoxAvecTextInvisibleNouveauMdp.Text.ToString(),textBoxAvecTextInvisibleConfNewMdp.Text.ToString()) == 0))
            {

                if (string.Compare(Outils.hash(textBoxAvecTextInvisibleAncienMdp.Text.ToString()), UtilisateurEnEdition.MotDePasse) == 0)
                {
                    UtilisateurEnEdition.MotDePasse = Outils.hash(textBoxAvecTextInvisibleNouveauMdp.Text);
                    ModificationEffectuee = true;
                }
                else
                {
                    errorProviderEdition.SetError(textBoxAvecTextInvisibleAncienMdp, "Mot de passe incorrect");
                }
            }
            else if((string.Compare(textBoxAvecTextInvisibleNouveauMdp.Text.ToString(), textBoxAvecTextInvisibleConfNewMdp.Text.ToString()) != 0))
            {
                errorProviderEdition.SetError(textBoxAvecTextInvisibleConfNewMdp, "Le mot de pas ne correspond pas au nouveau mot de passe que vous souhaitez mettre");
            }
            if ((UtilisateurEnEdition.EstValide) && (ModificationEffectuee == true))
            {
                Program.GMBD.ModifierUtilisateur(UtilisateurEnEdition);                    
                Form_Principal.Instance.CreerPageCourante<PageEditionUser>(
                    (Page) =>
                    {
                        Page.Utilisateur = Utilisateur;
                        return true;
                    });
            }
            
        }

        private void buttonRetourMenu_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageMenuPrincipal>(
                        (Page) =>
                        {
                            Page.Utilisateur = Utilisateur;
                            return true;
                        });
        }

        private void textBoxAvecTextInvisible_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonValiderModif_Click(null, null);
            }
        }
    }
}