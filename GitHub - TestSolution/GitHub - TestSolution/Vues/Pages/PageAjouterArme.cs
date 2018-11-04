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
    public partial class PageAjouterArme : UserControl
    {
        #region Utilisateur
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
                    buttonOptionsUser1.Utilisateur = m_Utilisateur;
                }
            }
        }
        #endregion

        #region Equipement
        private Stuff m_Stuff;
        private Stuff m_StuffEnEdition;


        public Stuff Stuff
        {
            get
            {
                return m_Stuff;
            }
        }

        public event EventHandler SurAnnulation = null;
        public event EventHandler SurValidation = null;
        #endregion

        public PageAjouterArme()
        {
            InitializeComponent();
            m_Utilisateur = null;

            // Remplir la liste de type
            listeDeroulanteType.Type = Program.GMBD.EnumererType(null, null, null, PDSGBD.MyDB.CreerCodeSql("ty_name"));
            // Attacher la méthode qui doit se produire lorsqu'il y a un changement de sélection
            listeDeroulanteType.SurChangementSelection += ListeTypeChangementSelection;
           
            // Création d'une instance de type stuff, y attacher quelques méthodes
            m_StuffEnEdition = new Stuff();
            m_StuffEnEdition.SurErreur += StuffEnEdition_SurErreur;
            m_StuffEnEdition.AvantChangement += StuffEnEdition_AvantChangement;
            m_StuffEnEdition.ApresChangement += StuffEnEdition_ApresChangement;

            // L'utilisateur ne peut pas encoder de nom tant qu'il n'a pas choisi un type d'équipement
            textBoxNomEquipement.Enabled = false;
            // Visibilité est cochée par défaut
            checkBoxVisibility.Checked = true;
        }
        
        private void ListeTypeChangementSelection(object sender, EventArgs e)
        {
            // le type de l'équipement en édition devient le type sélectionné
            m_StuffEnEdition.Type = listeDeroulanteType.TypeSelectionne;

            // j'autorise d'entrer du texte dans le textbox
            if ((textBoxNomEquipement.Enabled == false))
            {
                textBoxNomEquipement.Enabled = true;
                textBoxNomEquipement.Enabled = true;
            }
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            m_Stuff = new Stuff();
            m_Stuff.Name = m_StuffEnEdition.Name;
            m_Stuff.Type = m_StuffEnEdition.Type;
            m_Stuff.Visibility = m_StuffEnEdition.Visibility;

            if (SurValidation != null)
            {
                SurValidation(this, EventArgs.Empty);
            }
            else
            {
                Stuff.Enregistrer(Program.GMBD.BD, Stuff);
                listeDeroulanteType.TypeSelectionne = null;
                textBoxNomEquipement.Text = string.Empty;
                textBoxNomEquipement.Text = string.Empty;
                m_StuffEnEdition.Name = null;
                m_StuffEnEdition.Type = null;
            }
        }

        private void checkBoxVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxVisibility.Checked == true)
            {
                m_StuffEnEdition.Visibility = 1;
            }
            else
            {
                m_StuffEnEdition.Visibility = 0;
            }

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (SurAnnulation != null)
            {
                SurAnnulation(this, EventArgs.Empty);
            }
            else
            {
                listeDeroulanteType.TypeSelectionne = null;
                textBoxNomEquipement.Text = string.Empty;
                m_StuffEnEdition.Name = null;
                m_StuffEnEdition.Type = null;
            }
        }

        private void textBoxNomEquipement_TextChanged(object sender, EventArgs e)
        {
            m_StuffEnEdition.Name = textBoxNomEquipement.Text;
        }

        #region Gestion de l'équipement en édition
        private void StuffEnEdition_SurErreur(Stuff Entite, Stuff.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Stuff.Champ.Name:
                    errorProvider1.SetError(textBoxNomEquipement, MessageErreur);
                    break;
            }
            buttonAjouter.Enabled = false;
        }

        private void StuffEnEdition_AvantChangement(Stuff Entite, Stuff.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case Stuff.Champ.Name:
                    Stuff StuffExistant = Program.GMBD.EnumererStuff(null, null, new PDSGBD.MyDB.CodeSql("WHERE st_name = {0}", textBoxNomEquipement.Text), null).FirstOrDefault();

                    if (StuffExistant != null)
                    {
                        AccumulateurErreur.NotifierErreur("Cet équipement existe déjà, veuillez en choisir un autre !");

                    }
                    break;
            }
        }

        private void StuffEnEdition_ApresChangement(Stuff Entite, Stuff.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {
                case Stuff.Champ.Name:
                    errorProvider1.SetError(textBoxNomEquipement, null);
                    textBoxNomEquipement.Text = m_StuffEnEdition.Name;
                    break;

            }
            buttonAjouter.Enabled = m_StuffEnEdition.EstValide;
        }
        #endregion

        #region Gestion du panneau
        private void listeDeroulanteType_Load(object sender, EventArgs e)
        {
            if (Utilisateur != null)
            {
                buttonOptionsUser1.ButtonOptionsUserUpdate();
            }
            else
            {
                Form_Principal.Instance.CreerPageCourante<PageConnexion>();
            }
        }

        private void linkLabelDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageMenuDashboard>(
                        (Page) =>
                        {
                            Page.Utilisateur = Utilisateur;
                            return true;
                        });
        }

        private void linkLabelFigurines_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        #endregion
    }
}
