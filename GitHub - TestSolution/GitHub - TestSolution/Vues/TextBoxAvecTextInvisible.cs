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
    public partial class TextBoxAvecTextInvisible : UserControl
    {

        string SauvegardeTexte = null;

        public TextBoxAvecTextInvisible()
        {
            InitializeComponent();
        }

        private void textBoxText_Enter(object sender, EventArgs e)
        {
            if(textBoxText.Text != null)
            {
                SauvegardeTexte = textBoxText.Text;
                textBoxText.Text = "";
                textBoxText.ForeColor = SystemColors.WindowText;
            }
        }

        private void textBoxText_Leave(object sender, EventArgs e)
        {
            if(textBoxText.Text == "")
            {
                textBoxText.Text = SauvegardeTexte;
                textBoxText.ForeColor = SystemColors.GrayText;
            }
        }

        [EditorBrowsable(EditorBrowsableState.Always)]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        [Bindable(true)]
        public override string Text
        {
            get
            {
                return textBoxText.Text;
            }

            set
            {
                textBoxText.Text = value;
            }
        }

        
    }
}
