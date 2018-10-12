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
   
        public TextBoxAvecTextInvisible()
        {
            InitializeComponent();

            
        }

        // Permet de récupérer la valeur du texte de la textbox en question pour l'afficher
        public string TexteValeur { get; set; }
        

        // Variable permettant la sauvegarde du pseudo après la perte du focus
        string SauvegardeLogin;

        /// <summary>
        /// Action qui se produit au moment où l'on rentre dans la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxText_Enter(object sender, EventArgs e)
        {
            if(textBoxText.Text == TexteValeur)
            {

                textBoxText.Font = new Font(textBoxText.Font, FontStyle.Regular);
                textBoxText.ForeColor = SystemColors.WindowText;                
                textBoxText.Text = "";
            }
            else if(textBoxText.Text != "")
            {
                textBoxText.Text = SauvegardeLogin;
            }
        }

        /// <summary>
        /// Action qui se produit au moment où l'on quitte la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxText_Leave(object sender, EventArgs e)
        {
            if (textBoxText.Text == "")
            {
                textBoxText.Font = new Font(textBoxText.Font, FontStyle.Italic);
                textBoxText.Text = TexteValeur;
                textBoxText.ForeColor = SystemColors.GrayText;

            }
            else if(textBoxText.Text != "")
            {
                SauvegardeLogin = textBoxText.Text;
            }
        }

        /// <summary>
        /// Permet d'accéder à la propriété text du control user (n'est pas accessible sans cette fonction)
        /// </summary>
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
