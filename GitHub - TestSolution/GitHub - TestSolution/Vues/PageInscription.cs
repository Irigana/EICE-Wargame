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
        }

        private void linkLabelDejaInscrit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
        }

        private void buttonSInscrire_Click(object sender, EventArgs e)
        {
            if(string.Compare(textBoxAvecTextInvisibleMdp.Text,textBoxAvecTextInvisibleMdpConf.Text) != 0)
            {
                errorProviderInscription.SetError(textBoxAvecTextInvisibleMdp, "Le mot de passe ne correspond pas");
                errorProviderInscription.SetError(textBoxAvecTextInvisibleMdpConf, "Le mot de passe ne correspond pas");
                return;
            }

            Utilisateur UtilisateurExistant = Program.GMBD.EnumererUtilisateur(null, new MyDB.CodeSql("JOIN role ON user.id_role = role.id"),
                                                                               new MyDB.CodeSql("WHERE user.name = {0}", textBoxAvecTextInvisibleLogin.Text), null).FirstOrDefault();

            if(UtilisateurExistant != null)
            {
                errorProviderInscription.SetError(textBoxAvecTextInvisibleLogin, "Ce login est déjà utilisé, veuillez en choisir un autre !");
            }

            Utilisateur NouvelUtilisateur = new Utilisateur();
            NouvelUtilisateur.Login = textBoxAvecTextInvisibleLogin.Text;
            NouvelUtilisateur.MotDePasse = textBoxAvecTextInvisibleMdp.Text;
            NouvelUtilisateur.Role = Program.GMBD.EnumererRole(null, null, new MyDB.CodeSql("WHERE role.id = {0}", 1), null).FirstOrDefault();

            if((UtilisateurExistant == null) && (NouvelUtilisateur.EstValide))
            {
                Program.GMBD.AjouterUtilisateur(NouvelUtilisateur);
                errorProviderInscription.Clear();
                textBoxAvecTextInvisibleLogin.Text = "";
                textBoxAvecTextInvisibleMdp.Text = "";
                textBoxAvecTextInvisibleMdpConf.Text = "";
            }
        }

        
    }
}
