﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSGBD;

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

        private const string c_CritereQuiContient = "%{0}%";

        #region Equipement
        private Stuff m_Stuff;
        private Stuff m_StuffEnEdition;

        private CharactRank m_CharRank;

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
            z_listeDeroulanteType.Type = Program.GMBD.EnumererType(null, null, null, PDSGBD.MyDB.CreerCodeSql("ty_name"));
            // Attacher la méthode qui doit se produire lorsqu'il y a un changement de sélection
            z_listeDeroulanteType.SurChangementSelection += ListeTypeChangementSelection;
           
            // Création d'une instance de type stuff, y attacher quelques méthodes
            m_StuffEnEdition = new Stuff();
            m_StuffEnEdition.SurErreur += StuffEnEdition_SurErreur;
            m_StuffEnEdition.AvantChangement += StuffEnEdition_AvantChangement;
            m_StuffEnEdition.ApresChangement += StuffEnEdition_ApresChangement;

            // L'utilisateur ne peut pas encoder de nom tant qu'il n'a pas choisi un type d'équipement
            z_textBoxNomEquipement.Enabled = false;
            // Visibilité est cochée par défaut
            z_checkBoxVisibility.Checked = true;

            // TODO: Modifier la page de la manière suivante:
            // Ajouter la modification de l'équipement 
            //                  * Vérifier unicité qd ajoute caractéristique à équipement
            //                  * Modifier le nom
            //                  * Modifier la valeur d'une de ces caractéristique
            //                  * Supprimer une caractéristique d'un équipement
            // Listes déroulantes mettre en dropdown au lieu de dropdownlist
            // Ajouter un machin autocomplete dans le ctor voir listederoulante faction ligne 40-41
            z_listeDeroulanteStuff.Stuff = Program.GMBD.EnumererStuff(null, null, null, PDSGBD.MyDB.CreerCodeSql("st_name"));
            z_listeDeroulanteStuff.SurChangementSelection += ListeStuffChangementSelection;

            z_listeDeroulanteFeature.Feature = Program.GMBD.EnumererFeature(null, null, null, PDSGBD.MyDB.CreerCodeSql("fe_name"));
            z_listeDeroulanteFeature.SurChangementSelection += ListeFeatureChangementSelection;

            z_listeDeroulanteFaction.Faction = Program.GMBD.EnumererFaction(null, null, null, PDSGBD.MyDB.CreerCodeSql("fa_name"));
            z_listeDeroulanteFaction.SurChangementSelection += ListeDeroulanteFaction_SurChangementSelection;

            
            
            // Permet de réagir sur le changement de filtre pour aller rechercher les différents équipements qui correspondent au filtre
            z_ficheEquipement.SurChangementFiltre += (s, ev) =>
            {
                if (z_ficheEquipement.TexteFiltreEquipement != "")
                {
                    z_ficheEquipement.Equipement = Program.GMBD.EnumererStuff(
                        null,
                        null,
                        new MyDB.CodeSql("WHERE stuff.st_name LIKE {0}",
                                         string.Format(c_CritereQuiContient, z_ficheEquipement.TexteFiltreEquipement)),
                        new MyDB.CodeSql("ORDER BY st_name"));
                }
                else
                {
                    Program.GMBD.EnumererStuff(null, null, null, PDSGBD.MyDB.CreerCodeSql("st_name"));
                }


            };
            
            z_listeDeroulanteCharRank.SurChangementSelection += ListeDeroulanteCharRank_SurChangementSelection;

            // Equipable devrait être visible uniquement si il y a un equipement
            // dans la liste equipable par ça doit être des charact rank 
            // Rajouter le coût de l'équipement par personnage sélectionné
            // Ajouter un filtre faction et sous-faction pour proposer des characters cohérents dans la listview equipables par 
            // Listview avec Personnage 
            // Qd l'utilisateur appuie sur approuver les liaisons => faire les insert dans la db

        }


        #region Méthodes relatives à l'ajout d'équipement
        private void ListeTypeChangementSelection(object sender, EventArgs e)
        {
            // le type de l'équipement en édition devient le type sélectionné
            m_StuffEnEdition.Type = z_listeDeroulanteType.TypeSelectionne;

            // j'autorise d'entrer du texte dans le textbox
            if ((z_textBoxNomEquipement.Enabled == false))
            {
                z_textBoxNomEquipement.Enabled = true;
                z_textBoxNomEquipement.Enabled = true;
            }


            z_ficheEquipement.Equipement = Program.GMBD.EnumererStuff(null, null, new MyDB.CodeSql("WHERE st_fk_type_id = {0}", z_listeDeroulanteType.TypeSelectionne.Id),
                                                                        new MyDB.CodeSql("ORDER BY st_name"));
            z_ficheEquipement.SurChangementSelection += FicheEquipement_SurChangementSelection;
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
                    z_listeDeroulanteStuff.Stuff = Program.GMBD.EnumererStuff(null, null, null, PDSGBD.MyDB.CreerCodeSql("st_name"));
                }
                
                z_listeDeroulanteStuff.StuffSelectionnee = Stuff;
                z_listeDeroulanteType.TypeSelectionne = null;
                z_textBoxNomEquipement.Text = string.Empty;
                z_textBoxNomEquipement.Text = string.Empty;
                m_StuffEnEdition.Name = null;
                m_StuffEnEdition.Type = null;
                errorProvider1.Clear();
                //listeDeroulanteStuff1.Stuff = Program.GMBD.EnumererStuff(null, null, null, PDSGBD.MyDB.CreerCodeSql("st_name"));
                
            }
        }

        private void checkBoxVisibility_CheckedChanged(object sender, EventArgs e)
        {
            if (z_checkBoxVisibility.Checked == true)
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
                z_listeDeroulanteType.TypeSelectionne = null;
                z_textBoxNomEquipement.Text = string.Empty;
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
            m_StuffEnEdition.Name = z_textBoxNomEquipement.Text;
        }

        private void StuffEnEdition_SurErreur(Stuff Entite, Stuff.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Stuff.Champ.Name:
                    errorProvider1.SetError(z_textBoxNomEquipement, MessageErreur);
                    break;
            }
            q_buttonAjouter.Enabled = false;
        }

        private void StuffEnEdition_AvantChangement(Stuff Entite, Stuff.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            //Réagir sur évenement leave (perte de focus)
            switch (Champ)
            {
                case Stuff.Champ.Name:
                    Stuff StuffExistant = Program.GMBD.EnumererStuff(null, null, new PDSGBD.MyDB.CodeSql("WHERE st_name = {0}", z_textBoxNomEquipement.Text), null).FirstOrDefault();

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
                    errorProvider1.SetError(z_textBoxNomEquipement, null);
                    z_textBoxNomEquipement.Text = m_StuffEnEdition.Name;
                    break;

            }
            q_buttonAjouter.Enabled = m_StuffEnEdition.EstValide;
        }
        #endregion

        #region Méthodes relatives à l'ajout des caractéristiques d'un équipement

        private void ListeStuffChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteFeature.FeatureSelectionnee = null;
            z_textBoxValeur.Clear();
            rafraichirListViewCaracteristiques();
        }

        private void rafraichirListViewCaracteristiques()
        {
            StuffFeature EssaiCar = new StuffFeature();
            EssaiCar.Stuff = z_listeDeroulanteStuff.StuffSelectionnee;
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
            Essai.Stuff = z_listeDeroulanteStuff.StuffSelectionnee;
            Essai.Feature = z_listeDeroulanteFeature.FeatureSelectionnee;
            Essai.Value = z_textBoxValeur.Text;
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

        private void ListeDeroulanteFaction_SurChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteSousFaction.Enabled = true;
            z_listeDeroulanteSousFaction.ResetTextSousFaction();
            Program.GMBD.MettreAJourListeSousFaction(z_listeDeroulanteSousFaction, z_listeDeroulanteFaction.FactionSelectionnee.Id);
            z_listeDeroulanteSousFaction.SurChangementSelection += ListeDeroulanteSousFaction_SurChangementSelection;
        }

        /// <summary>
        /// Lors du changement de sélection de la sous-faction la checkedlistbox des personnages est remplie avec les personnages correspondants à celle-ci
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeDeroulanteSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteUnity.Unity = Program.GMBD.EnumererUnity(null, null, null, PDSGBD.MyDB.CreerCodeSql("un_name"));
            z_listeDeroulanteUnity.SurChangementSelection += ListeDeroulanteUnity_SurChangementSelection;
        }

        private void ListeDeroulanteUnity_SurChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteSubUnity.Enabled = true;

            z_listeDeroulanteSubUnity.SubUnity = Program.GMBD.EnumererSubUnity(null, null, new MyDB.CodeSql("WHERE su_fk_unity_id = {0}", z_listeDeroulanteUnity.UnitySelectionnee.Id),
                                                                        new MyDB.CodeSql("ORDER BY su_name"));
            z_listeDeroulanteSubUnity.SurChangementSelection += ListeDeroulanteSubUnity_SurChangementSelection;
        }

        private void ListeDeroulanteSubUnity_SurChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteSubUnity.SubUnitySelectionnee.Unity = z_listeDeroulanteUnity.UnitySelectionnee;
            z_listeDeroulanteCharRank.Charact = Program.GMBD.EnumererPersonnage(null, new MyDB.CodeSql(@"JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id 
                                                                                                        JOIN rank ON char_rank.cr_fk_ra_id = rank.ra_id
                                                                                                        JOIN subunity ON char_rank.cr_sub_id = subunity.su_id    
                                                                                                        JOIN unity ON subunity.su_fk_unity_id = unity.un_id                                                                   
                                                                                                        JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                                                                                        JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),
                                                                                                    new MyDB.CodeSql(@"WHERE fa_id = {0} AND sf_id = {1}
                                                                                                                        AND un_id = {2} AND su_id = {3}",
                                                                                                             z_listeDeroulanteFaction.FactionSelectionnee.Id, z_listeDeroulanteSousFaction.SousFactionSelectionnee.Id,
                                                                                                             z_listeDeroulanteUnity.UnitySelectionnee.Id, z_listeDeroulanteSubUnity.SubUnitySelectionnee.Id),
                                                                                                    PDSGBD.MyDB.CreerCodeSql("ORDER BY ch_name"));
        }

        



        private void PageAjouterEquipements_Load(object sender, EventArgs e)
        {
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;
            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié
            if (Utilisateur != null) if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;
        }

        private void FicheEquipement_SurChangementSelection(object sender, EventArgs e)
        {
            if ((z_listeDeroulanteType.TypeSelectionne != null) && (z_ficheEquipement.EquipementSelectionne != null))
            {
                m_Stuff = new Stuff();
                m_Stuff = z_ficheEquipement.EquipementSelectionne;
                m_Stuff.Type = z_listeDeroulanteType.TypeSelectionne;
            }
        }

        private void ListeDeroulanteCharRank_SurChangementSelection(object sender, EventArgs e)
        {
            m_CharRank = new CharactRank();
            m_CharRank = z_listeDeroulanteCharRank.CharactSelectionnee;
            m_CharRank.Caractere.SousFaction = z_listeDeroulanteSousFaction.SousFactionSelectionnee;
            m_CharRank.SubUnity = z_listeDeroulanteSubUnity.SubUnitySelectionnee;
        }

        private void buttonAjouterEquipable_Click(object sender, EventArgs e)
        {
            if( (m_Stuff != null) && (z_listeDeroulanteCharRank.CharactSelectionnee != null))
            {
                StuffCharactRank StChRa = new StuffCharactRank();
                StChRa.CharactRank = z_listeDeroulanteCharRank.CharactSelectionnee;
                StChRa.Stuff = m_Stuff;
                StChRa.Cout = Convert.ToInt32(z_numericUpDownCout.Value);
                StChRa.Min = Convert.ToInt32(z_numericUpDownMinimum.Value);
                StChRa.Max = Convert.ToInt32(z_numericUpDownMaximum.Value);

                StChRa.Enregistrer(Program.GMBD.BD, StChRa);

                
            }
        }
    }
}
