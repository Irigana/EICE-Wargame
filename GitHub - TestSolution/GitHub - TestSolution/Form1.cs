using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GitHub___TestSolution
{
    public partial class Form_Principal : Form
    {

        public Form_Principal()
        {
            InitializeComponent();
            
        }
        
        

        private void pageConnexion1_Leave(object sender, EventArgs e)
        {
            PageInscription.Visible = true;
            PageInscription.BringToFront();
        }

        private void PageInscription_Leave(object sender, EventArgs e)
        {
            pageConnexion1.BringToFront();
        }

        private void pageConnexion1_VisibleChanged(object sender, EventArgs e)
        {
            PageInscription.Hide();
        }
    }
}
