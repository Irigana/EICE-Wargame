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
    public partial class TextBoxAvecTextInvisible : UserControl
    {

        private bool m_AfficherPlaceHolder;
        
        // Variable permettant la sauvegarde du login après la perte du focus
        private string m_TexteActuel;        

        // Texte du PlaceHolder
        private string m_TextePlaceHolder;

        // Propriété mise en public pour pouvoir mettre à true quand il s'agit d'un texte devant être masqué
        public bool MotDePasseCache { get; set; }

        public TextBoxAvecTextInvisible()
        {
            InitializeComponent();
            m_AfficherPlaceHolder = true;
            m_TexteActuel = string.Empty;
            m_TextePlaceHolder = string.Empty;
            AfficherPlaceHolder();
            
        }

        private void AfficherPlaceHolder()
        {
            if (m_AfficherPlaceHolder)
            {
                textBoxText.Font = new Font(textBoxText.Font, FontStyle.Italic);
                textBoxText.ForeColor = SystemColors.GrayText;
                if (textBoxText.Focused) textBoxText.TextChanged -= TextBoxText_TextChanged;
                
                textBoxText.Text = PlaceHolder;
                if (textBoxText.Focused) textBoxText.TextChanged += TextBoxText_TextChanged;
            }
            else
            {
                NePasAfficherPlaceHolder();
            }
        }
        
        private void NePasAfficherPlaceHolder()
        {
            textBoxText.Font = new Font(textBoxText.Font, FontStyle.Regular);
            textBoxText.ForeColor = SystemColors.WindowText;
        }

        /// <summary>
        /// Action qui se produit au moment où l'on rentre dans la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxText_Enter(object sender, EventArgs e)
        {
            textBoxText.Text = m_TexteActuel;
            m_AfficherPlaceHolder = string.IsNullOrEmpty(m_TexteActuel);
            NePasAfficherPlaceHolder();
            textBoxText.TextChanged += TextBoxText_TextChanged;
        }


        /// <summary>
        /// Action qui se produit au moment où l'on quitte la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxText_Leave(object sender, EventArgs e)
        {
            // Annule le texte caché si un texte n'est pas encoder par l'utilisateur
            if(string.IsNullOrEmpty(m_TexteActuel)) textBoxText.PasswordChar = '\0';

            textBoxText.TextChanged -= TextBoxText_TextChanged;
            AfficherPlaceHolder();
            
        }

        /// <summary>
        /// Action qui se produit au moment où un changement dans le texte se produit dans la textBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TextBoxText_TextChanged(object sender, EventArgs e)
        {
            // Permet de cacher le texte
            if(MotDePasseCache == true)
            {
                textBoxText.PasswordChar = '●';
            }
            // Permet de récupérer le texte encoder par l'utilisateur 
            m_TexteActuel = textBoxText.Text;
            // Permet de voir s'il faut activer le PlaceHolder
            m_AfficherPlaceHolder = string.IsNullOrEmpty(m_TexteActuel);
        }

        /// <summary>
        /// Permet un refresh des textbox avec caractère mot de passe après un clique sur un bouton ( pour faire un refresh )
        /// </summary>
        public void RefreshMdpApresAcceptation()
        {
            this.MotDePasseCache = false;
            textBoxText.PasswordChar = '\0';
            // Permet de récupérer le texte encoder par l'utilisateur 
            //m_TexteActuel = textBoxText.Text;
            // Permet de voir s'il faut activer le PlaceHolder
            m_AfficherPlaceHolder = string.IsNullOrEmpty(m_TexteActuel);
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
                return m_TexteActuel;
            }
            set
            {
                if (value == null) value = string.Empty;
                if (value != m_TexteActuel)
                {
                    m_TexteActuel = value;
                    textBoxText.Text = m_TexteActuel;
                    m_AfficherPlaceHolder = string.IsNullOrEmpty(m_TexteActuel);
                    AfficherPlaceHolder();
                   
                }
            }
        }        

        /// <summary>
        /// Permet d'accéder à la propriété PlaceHolder du control user
        /// </summary>
        public string PlaceHolder
        {
            get
            {
                return m_TextePlaceHolder;
            }
            set
            {
                if (value == null) value = string.Empty;
                if (value != m_TextePlaceHolder)
                {
                    m_TextePlaceHolder = value;
                    AfficherPlaceHolder();
                    
                }
            }
        }


        public event KeyEventHandler EnterPress;

        private void Enter_Press(object sender, KeyEventArgs e)
        {
            
            if (this.EnterPress != null)
                this.EnterPress(this, e);
        }

    }
}