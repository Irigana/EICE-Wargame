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
        private Utilisateur m_Utilisateur = null;

        public Utilisateur Utilisateur
        {
            get
            {
                return m_Utilisateur;
            }
            set
            {
                if ((m_Utilisateur == null) && (value != null))
                {
                    m_Utilisateur = value;
                }
            }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ButtonOptionsUser()
        {
            InitializeComponent();
            m_Utilisateur = null;     
        }

        /// <summary>
        /// Permet de mettre à jour le text du controle utilisateur et d'y placer le nom de l'utilisateur connecté
        /// </summary>
        public void ButtonOptionsUserUpdate()
        {
            buttonUser.Text = m_Utilisateur.Login.ToString();
            if (m_Utilisateur.Login.ToString().Length > 15) buttonUser.TextAlign = ContentAlignment.MiddleRight;
            else buttonUser.TextAlign = ContentAlignment.MiddleCenter;
        }
        
        /// <summary>
        /// Bouton avec une liste déroulante
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Se produit lorsque l'on clique sur "Editer mon profil"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void editionDuProfilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageEditionUser>(
                        (Page) =>
                        {
                            Page.Utilisateur = Utilisateur;
                            return true;
                        });
        }

        /// <summary>
        /// Se produit losque l'on clique sur "Se déconnecter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void seDéconnecterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageConnexion>();
        }
        
    }
}
