﻿using System;
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
            buttonUser.Text = Utilisateur.Champs.Login.ToString();
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