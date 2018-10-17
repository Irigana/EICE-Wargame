using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub___TestSolution
{
    public partial class PageConnexion : UserControl
    {
        public PageConnexion()
        {
            InitializeComponent();
            textBoxAvecTextInvisibleLogin.PlaceHolder = "Login";
            textBoxAvecTextInvisibleMdp.PlaceHolder = "Mot de passe";
               
        }
        

        private void linkLabelCreerCompte_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
