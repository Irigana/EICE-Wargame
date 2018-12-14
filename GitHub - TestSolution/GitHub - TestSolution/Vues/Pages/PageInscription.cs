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
    public partial class PageInscription : UserControl
    {
        public PageInscription()
        {
            InitializeComponent();
            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            errorProviderValidation.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }

        private void linkLabelDejaInscrit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageConnexion>();
        }

        private void buttonSInscrire_Click(object sender, EventArgs e)
        {
            if (string.Compare(textBoxAvecTextInvisibleMdp.Text, textBoxAvecTextInvisibleMdpConf.Text) != 0)
            {
                errorProviderInscription.SetError(textBoxAvecTextInvisibleMdp, "Le mot de passe ne correspond pas");
                errorProviderInscription.SetError(textBoxAvecTextInvisibleMdpConf, "Le mot de passe ne correspond pas");
                return;
            }

            Utilisateur UtilisateurExistant = Program.GMBD.EnumererUtilisateur(null, new MyDB.CodeSql("JOIN role ON user.u_fk_role_id = role.r_id"),
                                                                               new MyDB.CodeSql("WHERE user.u_name = {0}", textBoxAvecTextInvisibleLogin.Text), null).FirstOrDefault();

            if (UtilisateurExistant != null)
            {
                errorProviderInscription.SetError(textBoxAvecTextInvisibleLogin, "Ce login est déjà utilisé, veuillez en choisir un autre !");
            }

            Utilisateur NouvelUtilisateur = new Utilisateur();
            NouvelUtilisateur.Login = textBoxAvecTextInvisibleLogin.Text;
            NouvelUtilisateur.MotDePasse = Outils.hash(textBoxAvecTextInvisibleMdp.Text);
            NouvelUtilisateur.Role = Program.GMBD.EnumererRole(null, null, new MyDB.CodeSql("WHERE role.r_id = {0}", 1), null).FirstOrDefault();

            if ((UtilisateurExistant == null) && (NouvelUtilisateur.EstValide))
            {
                Program.GMBD.AjouterUtilisateur(NouvelUtilisateur);
                errorProviderInscription.Clear();                

                PopUpConfirmation FormConfirmation = new PopUpConfirmation();
                FormConfirmation.LabelDuTexte = "Inscription terminée.\nVoulez-vous aller sur la page de connexion ?";
                FormConfirmation.ShowDialog();
                if (FormConfirmation.Confirmation)
                {
                    Form_Principal.Instance.CreerPageCourante<PageConnexion>();
                }
                else if (FormConfirmation.Annulation)
                {
                    textBoxAvecTextInvisibleLogin.Text = "";
                    textBoxAvecTextInvisibleMdp.Text = "";
                    textBoxAvecTextInvisibleMdpConf.Text = "";
                    textBoxAvecTextInvisibleMdp.RefreshMdpApresAcceptation();
                    textBoxAvecTextInvisibleMdp.MotDePasseCache = true;
                    textBoxAvecTextInvisibleMdpConf.RefreshMdpApresAcceptation();
                    textBoxAvecTextInvisibleMdpConf.MotDePasseCache = true;
                    errorProviderValidation.SetError(buttonSInscrire, "Votre inscription a été enregistrée");
                }
            }
        }


        private void textBoxAvecTextInvisibleMdpConf_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonSInscrire_Click(null, null);
            }

        }

        private void textBoxAvecTextInvisibleLogin_Enter(object sender, EventArgs e)
        {
            errorProviderValidation.Clear();
        }

        private void textBoxAvecTextInvisibleMdp_Enter(object sender, EventArgs e)
        {
            errorProviderValidation.Clear();
        }

        private void textBoxAvecTextInvisibleMdpConf_Enter(object sender, EventArgs e)
        {
            errorProviderValidation.Clear();
        }
    }
}
