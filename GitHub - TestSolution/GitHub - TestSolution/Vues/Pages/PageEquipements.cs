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
    public partial class PageEquipements : UserControl
    {
        public event EventHandler SurAnnulation = null;
        public event EventHandler SurValidation = null;

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

        /// <summary>
        /// Permet d'accéder au membre privé m_Stuff depuis une autre classe
        /// </summary>
        public Stuff Stuff
        {
            get
            {
                return m_Stuff;
            }
        }
        #endregion

        public PageEquipements()
        {
            InitializeComponent();
            m_Utilisateur = null;
            menuAdmin1.MaPageActive = 5;

            #region Initialisation de la ListView des caractéristiques
            listViewCaracteristiques.View = View.Details;
            listViewCaracteristiques.Columns.Clear();
            listViewCaracteristiques.Columns.Add(new ColumnHeader()
            {
                Text = "Caractéristique",
                TextAlign = HorizontalAlignment.Left

            });
            listViewCaracteristiques.Columns.Add(new ColumnHeader()
            {
                Text = "Valeur",
                TextAlign = HorizontalAlignment.Left

            });
            listViewCaracteristiques.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            #endregion

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

            // TODO: Modifier la page de la manière suivante:
            // Ajouter la modification de l'équipement 
            //                  * Vérifier unicité qd ajoute caractéristique à équipement
            //                  * Modifier le nom
            //                  * Modifier la valeur d'une de ces caractéristique
            //                  * Supprimer une caractéristique d'un équipement
            // Listes déroulantes mettre en dropdown au lieu de dropdownlist
            // Ajouter un machin autocomplete dans le ctor voir listederoulante faction ligne 40-41
            listeDeroulanteStuff1.Stuff = Program.GMBD.EnumererStuff(null, null, null, PDSGBD.MyDB.CreerCodeSql("st_name"));
            listeDeroulanteStuff1.SurChangementSelection += ListeStuffChangementSelection;

            listeDeroulanteFeature1.Feature = Program.GMBD.EnumererFeature(null, null, null, PDSGBD.MyDB.CreerCodeSql("fe_name"));
            listeDeroulanteFeature1.SurChangementSelection += ListeFeatureChangementSelection;
            
            
        }


        #region Méthodes relatives à l'ajout d'équipement
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

        /// <summary>
        /// Méthode permettant d'ajouter un nouvel équipement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            //Stuff StuffExistant = new Stuff();

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
                if (Stuff.Enregistrer(Program.GMBD.BD, Stuff))
                {
                    listeDeroulanteStuff1.Stuff = Program.GMBD.EnumererStuff(null, null, null, PDSGBD.MyDB.CreerCodeSql("st_name"));
                }
                
                listeDeroulanteStuff1.StuffSelectionnee = Stuff;
                listeDeroulanteType.TypeSelectionne = null;
                textBoxNomEquipement.Text = string.Empty;
                textBoxNomEquipement.Text = string.Empty;
                m_StuffEnEdition.Name = null;
                m_StuffEnEdition.Type = null;
                errorProvider1.Clear();
                //listeDeroulanteStuff1.Stuff = Program.GMBD.EnumererStuff(null, null, null, PDSGBD.MyDB.CreerCodeSql("st_name"));
                
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

        //private void textBoxNomEquipement_TextChanged(object sender, EventArgs e)
        //{
          //  errorProvider1.Clear();
        //}
        private void textBoxNomEquipement_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
        }
        private void textBoxNomEquipement_Leave(object sender, EventArgs e)
        {
            m_StuffEnEdition.Name = textBoxNomEquipement.Text;
        }

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
            //Réagir sur évenement leave (perte de focus)
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

        #region Méthodes relatives à l'ajout des caractéristiques d'un équipement

        private void ListeStuffChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteFeature1.FeatureSelectionnee = null;
            textBoxValeur.Clear();
            rafraichirListViewCaracteristiques();
        }

        private void rafraichirListViewCaracteristiques()
        {
            StuffFeature EssaiCar = new StuffFeature();
            EssaiCar.Stuff = listeDeroulanteStuff1.StuffSelectionnee;
            listViewCaracteristiques.Items.Clear();

            foreach (StuffFeature sf in EssaiCar.Stuff.Features)
            {
                Feature f = sf.Feature;
                ListViewItem NouvelElement = new ListViewItem()
                {
                    Text = f.Name,
                    Tag = sf.Id
                };
                NouvelElement.SubItems.Add(string.Format("{0}", sf.Value));
                listViewCaracteristiques.Items.Add(NouvelElement);
            }
        }

        private void ListeFeatureChangementSelection(object sender, EventArgs e)
        {
            //Ajouter qqch

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Ajouter qqch
        }

        /// <summary>
        /// Méthode permettant d'ajouter un StuffFeature
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterCaract_Click(object sender, EventArgs e)
        {
            StuffFeature Essai = new StuffFeature();
            Essai.Stuff = listeDeroulanteStuff1.StuffSelectionnee;
            Essai.Feature = listeDeroulanteFeature1.FeatureSelectionnee;
            Essai.Value = textBoxValeur.Text;
            Essai.Enregistrer(Program.GMBD.BD, Essai);
            rafraichirListViewCaracteristiques();
        }
        #endregion

        #region Gestion du panneau

        private void linkLabelDashboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageMenuDashboard>(
                        (Page) =>
                        {
                            Page.Utilisateur = Utilisateur;
                            return true;
                        });
        }



        #endregion

        private void PageAjouterEquipements_Load(object sender, EventArgs e)
        {
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;
            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié
            if (Utilisateur != null) if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;
        }

        
    }
}
