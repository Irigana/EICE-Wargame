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
        public Form_Principal()
        {
            InitializeComponent();
            // permet de réagir sur l'action de visible une fois connecté
            pageMenuPrincipal1.Visible = false;
                       
        }
                       
        private void pageConnexion1_Leave(object sender, EventArgs e)
        {
            if (PageConnexion.Utilisateur != null)
            {
                pageMenuPrincipal1.Visible = true;
                pageMenuPrincipal1.BringToFront();
                //pageConnexion1.SendToBack();
            }
            else
            {
                pageInscription1.Visible = true;
                pageInscription1.BringToFront();
            }
            
        }

        private void PageInscription_Leave(object sender, EventArgs e)
        {
            if (PageConnexion.Utilisateur != null)
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

        private void pageMenuPrincipal1_Leave(object sender, EventArgs e)
        {
            if (PageConnexion.Utilisateur != null)
            {
                pageEditionUser1.BringToFront();
                pageMenuPrincipal1.SendToBack();
            }
            else
            {
                pageConnexion1.Visible = true;
                pageConnexion1.BringToFront();
            }
            

        }
    }
}
