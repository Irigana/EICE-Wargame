using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EICE_WARGAME
{
    public partial class Form_Principal : Form
    {
        public Utilisateur UtilisateurConnecte { get; set; }

        public Form_Principal()
        {
            InitializeComponent();
                       
        }
                       
        private void pageConnexion1_Leave(object sender, EventArgs e)
        {
            if (pageConnexion1.Utilisateur != null)
            {                
                pageMenuPrincipal1.BringToFront();
                pageConnexion1.SendToBack();
            }
            else
            {
                pageInscription1.Visible = true;
                pageInscription1.BringToFront();
            }
            if(pageConnexion1.EstIdentifie)
            {
                UtilisateurConnecte = pageConnexion1.Utilisateur;
            }
        }

        private void PageInscription_Leave(object sender, EventArgs e)
        {
            if (pageConnexion1.Utilisateur != null)
            {
                pageMenuPrincipal1.BringToFront();
                pageConnexion1.SendToBack();
            }
            else
            {
                pageConnexion1.Visible = true;
                pageConnexion1.BringToFront();
            }
        }
        
        
    }
}
