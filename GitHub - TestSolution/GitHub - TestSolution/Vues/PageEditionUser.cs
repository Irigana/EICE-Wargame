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
    public partial class PageEditionUser : UserControl
    {
        public PageEditionUser()
        {
            InitializeComponent();
            if (PageConnexion.Utilisateur != null)
            {
                textBoxAvecTextInvisibleLogin.Text = PageConnexion.Utilisateur.Login;
                buttonOptionsUser1.ButtonOptionsUserUpdate();
            }
        }

        private void PageEditionUser_VisibleChanged(object sender, EventArgs e)
        {

        }
    }
}
