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
    public partial class PageInscription : UserControl
    {
        public PageInscription()
        {
            InitializeComponent();                    
        }

        private void linkLabelDejaInscrit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.SendToBack();
        }
    }
}
