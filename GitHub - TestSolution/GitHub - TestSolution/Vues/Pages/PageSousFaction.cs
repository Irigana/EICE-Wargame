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
    public partial class PageSousFaction : UserControl
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


        private const string c_CritereQuiContient = "%{0}%";        

        private Faction m_FactionEnEdition;

        private SousFaction m_SousFactionEnEdition;

        public PageSousFaction()
        {
            InitializeComponent();
            m_Utilisateur = null;            
            //-------------------------
            buttonAnnulerSF.Enabled = false;
            buttonModifierSF.Enabled = false;
            buttonSupprimerSF.Enabled = false;
            buttonAjouterSF.Enabled = false;
            ficheSousFaction1.m_ActiverTextBox = false;
            //-------------------------

            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);
            listeDeroulanteFaction1.SurChangementSelection += ListeFactionSurSelectionFaction;

            // Permet la création de cette sous faction afin de lui affecter les 3 méthodes, sur erreur, avant changement, après changement
            m_SousFactionEnEdition = new SousFaction();
            m_SousFactionEnEdition.SurErreur += SousFactionEnEdition_SurErreur;
            m_SousFactionEnEdition.AvantChangement += SousFactionEnEdition_AvantChangement;
            m_SousFactionEnEdition.ApresChangement += SousFactionEnEdition_ApresChangement;




        }

        /// <summary>
        /// Méthode aggisant sur la sélection de ma liste déroulante de factions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListeFactionSurSelectionFaction(object sender, EventArgs e)
        {
            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                m_FactionEnEdition = listeDeroulanteFaction1.FactionSelectionnee;
                ficheSousFaction1.m_ActiverTextBox = true;
                buttonAjouterSF.Enabled = true;
                m_FiltrageActif = true;
            }
            else if(listeDeroulanteFaction1.m_PerteFaction)
            {
                ficheSousFaction1.NettoyerListView();
                ficheSousFaction1.m_ActiverTextBox = false;
                buttonAjouterSF.Enabled = false;
                buttonAnnulerSF.Enabled = false;
                buttonModifierSF.Enabled = false;
                buttonSupprimerSF.Enabled = false;
            }

            //Charge mes sous factions en fonction du choix de faction de l'utilisateur
            
            ChargerSousFaction();
            

            //Partie sur les sous factions et son filtre
            ficheSousFaction1.ReactionEnDirectSurChangementFiltre = true;
            ficheSousFaction1.SurChangementFiltre += (s, ev) =>
            {
                if (!m_FiltrageActif) return;
                if ((ficheSousFaction1.TexteDuFiltre != "")&&(listeDeroulanteFaction1.FactionSelectionnee != null))
                {
                    ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                        null,
                        null,
                        new MyDB.CodeSql("WHERE subfaction.sf_name LIKE {0} AND subfaction.sf_fk_faction_id = {1}",
                                         string.Format(c_CritereQuiContient, ficheSousFaction1.TexteDuFiltre), listeDeroulanteFaction1.FactionSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY sf_name"));
                    // Permet de récuperer le nombre d'enregistrement après le filtre
                    ficheSousFaction1.NombreDeSousFactionFiltre = ficheSousFaction1.SousFaction.Count();
                }
                else if (listeDeroulanteFaction1.FactionSelectionnee != null)
                {
                    ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                        null,null, 
                        new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY sf_name"));
                }


            };

            ficheSousFaction1.SurChangementSelection += ficheSousFaction_SurChangementSelection;

        }

       
        /// <summary>
        /// Chargement des sous factions dans la fiche
        /// </summary>
        private void ChargerSousFaction()
        {            
                ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                 null,
                 null,
                 new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}", m_FactionEnEdition.Id),
                 new MyDB.CodeSql("ORDER BY sf_name"));
                   
        }

        /// <summary>
        /// Permet de modifier l'affichage du formulaire en fonction du choix de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ficheSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            if (ficheSousFaction1.SousFactionSelectionne != null)
            {
                buttonAjouterSF.Enabled = false;
                buttonAnnulerSF.Enabled = true;
                buttonModifierSF.Enabled = true;
                buttonSupprimerSF.Enabled = true;
                m_FiltrageActif = false;
                ficheSousFaction1.TexteDuFiltre = ficheSousFaction1.SousFactionSelectionne.Name;
                m_FiltrageActif = true;
            }
            else
            {
                buttonAjouterSF.Enabled = true;
                buttonAnnulerSF.Enabled = false;
                buttonModifierSF.Enabled = false;
                buttonSupprimerSF.Enabled = false;
            }
        }

        private bool m_FiltrageActif = true;

        /// <summary>
        /// Se produit sur le chargement de ma page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageAjoutFactionSousFaction_Load(object sender, EventArgs e)
        {
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
        }

        /// <summary>
        /// Se produit lors du click sur l'ajout d'une sous faction
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAjouterSF_Click(object sender, EventArgs e)
        {            
            Faction FactionExiste = null;

            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                FactionExiste = Program.GMBD.EnumererFaction(null,
                                                             null,
                                                             new MyDB.CodeSql("WHERE faction.fa_id = {0} ", listeDeroulanteFaction1.FactionSelectionnee.Id),
                                                             null).FirstOrDefault();
                // Si la faction n'existe pas, on crée une nouvelle faction
                if (FactionExiste != null)
                {
                    SousFaction NouvelleSousFaction = new SousFaction();
                    NouvelleSousFaction.Faction = listeDeroulanteFaction1.FactionSelectionnee;
                    NouvelleSousFaction.Name = ficheSousFaction1.TexteDuFiltre;

                    SousFaction SousFactionExistant = Program.GMBD.EnumererSousFaction(null, null, new PDSGBD.MyDB.CodeSql("WHERE subfaction.sf_name = {0} AND subfaction.sf_fk_faction_id = {1}", ficheSousFaction1.TexteDuFiltre, listeDeroulanteFaction1.FactionSelectionnee.Id), null).FirstOrDefault();

                    if ((SousFactionExistant == null) && (NouvelleSousFaction.EstValide) && (Program.GMBD.AjouterSousFaction(NouvelleSousFaction)))
                    {
                        ficheSousFaction1.MessageValidation = "Ajout validé";
                        Program.GMBD.MettreAJourFicheSousFaction(ficheSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);                                
                    }
                    else if (SousFactionExistant != null)
                    {
                        ficheSousFaction1.MessageErreur = "Cette sous faction existe déjà pour cette faction";
                    }
                    else
                    {
                        ficheSousFaction1.MessageErreur = "L'ajout ne s'est pas effectué correctement";
                    }
                        
                }
            }
            ficheSousFaction1.TexteDuFiltre = "";
            buttonAnnulerSF.Enabled = false;
        }
     
        
        /// <summary>
        /// Se produit lors de l'annulation par l'utilisateur après avoir fait des modifications, de sélection ou d'écriture dans la textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAnnulerSF_Click(object sender, EventArgs e)
        {            
            ficheSousFaction1.TexteDuFiltre = "";
            buttonAjouterSF.Enabled = true;
            buttonAnnulerSF.Enabled = false;
            buttonModifierSF.Enabled = false;
            buttonSupprimerSF.Enabled = false;     
        }

        /// <summary>
        /// Se produit lors du click sur le bouton de modification par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonModifierSF_Click(object sender, EventArgs e)
        {            
            if ((listeDeroulanteFaction1.FactionSelectionnee != null) && (ficheSousFaction1.SousFactionSelectionne != null))
            {

                SousFaction SousFactionExiste = Program.GMBD.EnumererSousFaction(null, null, new PDSGBD.MyDB.CodeSql("WHERE subfaction.sf_name = {0} AND subfaction.sf_fk_faction_id = {1}", ficheSousFaction1.TexteDuFiltre, listeDeroulanteFaction1.FactionSelectionnee.Id), null).FirstOrDefault();

                if (SousFactionExiste == null)
                {
                    ficheSousFaction1.MessageErreur = "Cette sous faction n'existe pas";
                }
                else
                {

                    m_SousFactionEnEdition = SousFactionExiste;
                    m_SousFactionEnEdition.SurErreur += SousFactionEnEdition_SurErreur;
                    m_SousFactionEnEdition.AvantChangement += SousFactionEnEdition_AvantChangement;
                    m_SousFactionEnEdition.ApresChangement += SousFactionEnEdition_ApresChangement;
                    m_SousFactionEnEdition.Faction = m_FactionEnEdition;                    
                    m_SousFactionEnEdition.Name = ficheSousFaction1.TexteDuFiltre;

                    if ((m_SousFactionEnEdition.EstValide) && (Program.GMBD.ModifierSousFaction(m_SousFactionEnEdition)))
                    {
                        Program.GMBD.MettreAJourFicheSousFaction(ficheSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);                        
                    }
                    
                }
            }
        }

        /// <summary>
        /// Methode permettant de réagir sur l'erreur d'une edition de sous faction
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="MessageErreur"></param>
        private void SousFactionEnEdition_SurErreur(SousFaction Entite, SousFaction.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case SousFaction.Champ.Name:
                    ficheSousFaction1.MessageErreur = MessageErreur;
                    break;
            }
            buttonAjouterSF.Enabled = false;
        }
        
        /// <summary>
        /// Methode permettant de vérifier si la faction existe avant le changement de celle ci dans la base de données
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurActuelle"></param>
        /// <param name="NouvelleValeur"></param>
        /// <param name="AccumulateurErreur"></param>
        private void SousFactionEnEdition_AvantChangement(SousFaction Entite, SousFaction.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case SousFaction.Champ.Name:
                    SousFaction SousFactionExistant = Program.GMBD.EnumererSousFaction(null, null, new PDSGBD.MyDB.CodeSql("WHERE subfaction.sf_name = {0} AND subfaction.sf_id <> {1} AND subfaction.sf_fk_faction_id = {2}", ficheSousFaction1.TexteDuFiltre, ficheSousFaction1.SousFactionSelectionne.Id,listeDeroulanteFaction1.FactionSelectionnee.Id), null).FirstOrDefault();

                    if (SousFactionExistant != null)
                    {
                        AccumulateurErreur.NotifierErreur("Cette sous faction existe déjà, veuillez en choisir une autre !");

                    }
                    break;
            }
        }


        

        /// <summary>
        /// Methode permettant d'agir après le changement de cette faction
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurPrecedente"></param>
        /// <param name="ValeurActuelle"></param>
        private void SousFactionEnEdition_ApresChangement(SousFaction Entite, SousFaction.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {
                case SousFaction.Champ.Name:
                    ficheSousFaction1.TexteDuFiltre = "";
                    ficheSousFaction1.MessageValidation = "Votre sous faction a bien été modifiée";
                    break;

            }
            buttonAjouterSF.Enabled = m_FactionEnEdition.EstValide;
        }

        private void buttonSupprimerSF_Click(object sender, EventArgs e)
        {

            

            PopUpConfirmation FormConfirmation = new PopUpConfirmation();
            //DialogResult DialogResult = FormConfirmation.ShowDialog();

            // TODO : Vérifier si il a des enregistrement pour modifier le texte en dessous et dire à l'utilisateur le nombre de charact qu'a cet sous faction

            FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer cet enregistrement ?";
            FormConfirmation.ShowDialog();
            if(FormConfirmation.Confirmation)
            {
                if((ficheSousFaction1.SousFactionSelectionne != null ) && (Program.GMBD.SupprimerSousFaction(ficheSousFaction1.SousFactionSelectionne)))
                {
                    Program.GMBD.MettreAJourFicheSousFaction(ficheSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
                    buttonAjouterSF.Enabled = true;
                    buttonAnnulerSF.Enabled = false;
                    buttonModifierSF.Enabled = false;
                    buttonSupprimerSF.Enabled = false;
                    ficheSousFaction1.MessageValidation = "Suppresion correctement effectuée";
                }
            }
            else if(FormConfirmation.Annulation)
            {                
                // ne rien faire
            }
            else
            {
                ficheSousFaction1.MessageErreur = "Erreur interne, veuillez recommencer";
            }
        }
    }        
}

