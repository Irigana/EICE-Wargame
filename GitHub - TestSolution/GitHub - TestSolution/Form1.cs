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
    public partial class Form_Test_Github : Form
    {
        public Form_Test_Github()
        {
            InitializeComponent();
        }

        private void buttonChangerCouleur_Click(object sender, EventArgs e)
        {
			if (BackColor == SystemColors.Control)
			{
				BackColor = Color.Blue;
			}
			else
			{
				BackColor = SystemColors.Control;
			}
        }
    }
}
