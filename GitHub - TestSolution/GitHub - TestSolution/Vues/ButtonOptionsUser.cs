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
    public partial class ButtonOptionsUser : UserControl
    {
        public ButtonOptionsUser()
        {
            InitializeComponent();
        }

        public void ButtonOptionsUserUpdate()
        {
            buttonUser.Text = PageConnexion.Utilisateur.Login.ToString();
            if (PageConnexion.Utilisateur.Login.ToString().Length > 15) buttonUser.TextAlign = ContentAlignment.MiddleRight;
            else buttonUser.TextAlign = ContentAlignment.MiddleCenter;
        }
        
        private void buttonUser_Click(object sender, EventArgs e)
        {
            Point screenPoint = buttonUser.PointToScreen(new Point(buttonUser.Left, buttonUser.Bottom));
            if (screenPoint.Y + contextMenuStripUser.Size.Height > Screen.PrimaryScreen.WorkingArea.Height)
            {
                contextMenuStripUser.Show(buttonUser, new Point(0, -contextMenuStripUser.Size.Height));
            }
            else
            {
                contextMenuStripUser.Show(buttonUser, new Point(0, buttonUser.Height));
            }
        }        
        

    }
}
