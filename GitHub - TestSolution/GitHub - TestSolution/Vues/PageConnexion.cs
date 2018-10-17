using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EICE_Wargame
{
    public partial class PageConnexion : UserControl
    {
        public PageConnexion()
        {
            InitializeComponent();
            textBoxAvecTextInvisibleLogin.TexteValeur = "Login";
            textBoxAvecTextInvisibleMdp.TexteValeur = "Mot de passe";           
        }
        
        


    }
}
