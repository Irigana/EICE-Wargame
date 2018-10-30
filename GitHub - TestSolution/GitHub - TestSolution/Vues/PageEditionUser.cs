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
        }

        private void PageEditionUser_Load(object sender, EventArgs e)
        {
            buttonOptionsUser1.ButtonOptionsUserUpdate();
            textBoxAvecTextInvisibleLogin.Text = Utilisateur.Login.ToString();
        }

        private void buttonValiderModif_Click(object sender, EventArgs e)
        {
            errorProviderEdition.Clear();
            bool ModificationEffectuee = false;

            Utilisateur UtilisateurExiste = Program.GMBD.EnumererUtilisateur(null, new MyDB.CodeSql("JOIN role ON user.u_fk_role_id = role.r_id"),
                                                                             new MyDB.CodeSql("WHERE user.u_id <> {0} AND user.u_name = {1}", Utilisateur.Id, textBoxAvecTextInvisibleLogin.Text), null).FirstOrDefault();
            if (UtilisateurExiste != null)
            {
                errorProviderEdition.SetError(textBoxAvecTextInvisibleLogin, "Le pseudo que vous encodez existe déjà, veuillez en mettre un autre");

            }

            if (UtilisateurExiste == null)
            {
                Utilisateur UtilisateurEnEdition = Utilisateur;
                // Si l'utilisateur a mis le bon mot de passe de confirmation et que son login a changé
                if ((string.Compare(UtilisateurEnEdition.MotDePasse.ToString(), Outils.hash(textBoxAvecTextInvisibleMdpInitial.Text.ToString())) == 0) 
                    && (string.Compare(Utilisateur.Login.ToString(),Outils.hash(textBoxAvecTextInvisibleLogin.Text.ToString())) != 0))
                {
                    UtilisateurEnEdition.Login = textBoxAvecTextInvisibleLogin.Text;
                    ModificationEffectuee = true;
                }
                // Si le mot de passe de l'utilisateur est différent et que les textbox du nouveau mot de passe sont pas vide et égale
                if((string.Compare(UtilisateurEnEdition.MotDePasse.ToString(),textBoxAvecTextInvisibleNouveauMdp.Text.ToString()) != 0)
                    && ((textBoxAvecTextInvisibleConfNewMdp.Text != "") && (textBoxAvecTextInvisibleNouveauMdp.Text != ""))
                    && (string.Compare(textBoxAvecTextInvisibleNouveauMdp.Text.ToString(),textBoxAvecTextInvisibleConfNewMdp.Text.ToString()) == 0))
                {
                    UtilisateurEnEdition.MotDePasse = Outils.hash(textBoxAvecTextInvisibleNouveauMdp.Text);
                    ModificationEffectuee = true;
                }
                if((UtilisateurEnEdition.EstValide) && (ModificationEffectuee == true))
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
    }
}