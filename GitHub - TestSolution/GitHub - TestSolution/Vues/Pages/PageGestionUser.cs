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
    public partial class PageGestionUser : UserControl
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

        private const string c_CritereQuiContient = "%{0}%";

        public PageGestionUser()
        {
            InitializeComponent();
            buttonSupprimer.Enabled = false;
            buttonDestitution.Enabled = false;
            buttonPromouvoir.Enabled = false;
            menuAdmin1.MaPageActive = 7;

            ChargerUsers();

            ficheUtilisateur1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheUtilisateur1.TexteRechercheUser != "")
                {
                    ficheUtilisateur1.Utilisateur = Program.GMBD.EnumererUtilisateur(
                        null,
                        new MyDB.CodeSql("JOIN role ON role.r_id = user.u_fk_role_id"),
                        new MyDB.CodeSql("WHERE user.u_name LIKE {0}",
                                         string.Format(c_CritereQuiContient, ficheUtilisateur1.TexteRechercheUser)),
                        new MyDB.CodeSql("ORDER BY u_name"));
                }
                else
                {
                    ChargerUsers();
                }

            };



            ficheUtilisateur1.SurChangementSelection += ficheUsers_SurChangementSelection;
        }


        private void PageGestionUser_Load(object sender, EventArgs e)
        {
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;
            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié
            if (Utilisateur!= null) if(Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;
        }

        /// <summary>
        /// Chargement des sous factions dans la fiche
        /// </summary>
        private void ChargerUsers()
        {
            ficheUtilisateur1.Utilisateur = Program.GMBD.EnumererUtilisateur(
             null,
             new MyDB.CodeSql("JOIN role ON role.r_id = user.u_fk_role_id"),
             null,
             new MyDB.CodeSql("ORDER BY user.u_name"));

        }

        private void ficheUsers_SurChangementSelection(object sender, EventArgs e)
        {
            if (ficheUtilisateur1.UtilisateurSelectionne != null)
            {
                // Si admin
                if (Utilisateur.Role.Id == 2)
                {
                    // Si il ne s'est pas sélectionner lui même
                    if (Utilisateur.Id != ficheUtilisateur1.UtilisateurSelectionne.Id)
                    { 
                        // Si c'est un autre admin il ne peut rien faire
                        if(ficheUtilisateur1.UtilisateurSelectionne.Role.Id == 2)
                        {
                            buttonSupprimer.Enabled = false;
                            buttonPromouvoir.Enabled = false;
                            buttonDestitution.Enabled = false;
                        }
                        // Sinon
                        else
                        {
                            buttonSupprimer.Enabled = true;
                            buttonPromouvoir.Enabled = true;
                            buttonDestitution.Enabled = true;
                        }
                    }                   
                }
                else
                {
                    Form_Principal.Instance.CreerPageCourante<PageMenuDashboard>(
                    (page) =>
                    {
                        page.Utilisateur = Utilisateur;
                        return true;
                    });
                }
            }
            else
            {
                buttonSupprimer.Enabled = false;
                buttonPromouvoir.Enabled = false;
                buttonDestitution.Enabled = false;
            }
        }

        private void buttonPromouvoir_Click(object sender, EventArgs e)
        {
            if ((ficheUtilisateur1.UtilisateurSelectionne != null) && (ficheUtilisateur1.UtilisateurSelectionne.Role.Id == 1))
            {
                Role NouveauRole = Program.GMBD.EnumererRole(null, null, new MyDB.CodeSql("WHERE r_id = 3 "), null).FirstOrDefault();

                Utilisateur UtilisateurAPromouvoir = ficheUtilisateur1.UtilisateurSelectionne;
                UtilisateurAPromouvoir.Role = NouveauRole;

                if ((UtilisateurAPromouvoir.EstValide) && (Program.GMBD.ModifierUtilisateur(UtilisateurAPromouvoir)))
                {
                    ChargerUsers();
                }

            }
        }

        private void buttonDestitution_Click(object sender, EventArgs e)
        {
            if ((ficheUtilisateur1.UtilisateurSelectionne != null) && (Utilisateur.Id != ficheUtilisateur1.UtilisateurSelectionne.Id))
            {
                Role NouveauRole = Program.GMBD.EnumererRole(null, null, new MyDB.CodeSql("WHERE r_id = 1"), null).FirstOrDefault();

                Utilisateur UtilisateurADestituer = ficheUtilisateur1.UtilisateurSelectionne;
                UtilisateurADestituer.Role = NouveauRole;

                if ((UtilisateurADestituer.EstValide) && (Program.GMBD.ModifierUtilisateur(UtilisateurADestituer)))
                {
                    ChargerUsers();
                }

            }
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            if ((ficheUtilisateur1.UtilisateurSelectionne != null)
                && (Utilisateur.Id != ficheUtilisateur1.UtilisateurSelectionne.Id)
                && (Utilisateur.Role.Id == 2))
            {

                PopUpConfirmation FormConfirmation = new PopUpConfirmation();

                FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer " + ficheUtilisateur1.UtilisateurSelectionne.Login + " ?";

                FormConfirmation.ShowDialog();
                // S'il accepte
                if (FormConfirmation.Confirmation)
                {

                    if (Program.GMBD.SupprimerUtilisateur(ficheUtilisateur1.UtilisateurSelectionne))
                    {
                        ChargerUsers();
                    }

                }
            }
        }
    }
}
