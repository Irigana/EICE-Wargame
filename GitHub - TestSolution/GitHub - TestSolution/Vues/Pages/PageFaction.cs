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
    public partial class PageFaction : UserControl
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


        public PageFaction()
        {
            InitializeComponent();


            buttonAnnuler.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
            buttonAjouter.Enabled = true;
            menuAdmin1.MaPageActive = 3;

            m_FactionEnEdition = new Faction();
            m_FactionEnEdition.SurErreur += FactionEnEdition_SurErreur;
            m_FactionEnEdition.AvantChangement += FactionEnEdition_AvantChangement;
            m_FactionEnEdition.ApresChangement += FactionEnEdition_ApresChangement;

            ChargerFaction();

            ficheFaction1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheFaction1.TexteFiltreFaction != "")
                {
                    ficheFaction1.Faction = Program.GMBD.EnumererFaction(
                        null,
                        null,
                        new MyDB.CodeSql("WHERE faction.fa_name LIKE {0}",
                                         string.Format(c_CritereQuiContient, ficheFaction1.TexteFiltreFaction)),
                        new MyDB.CodeSql("ORDER BY fa_name"));
                }
                else
                {
                    ChargerFaction();
                }


            };
                Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            ValidationProvider.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }
        /// <summary>
        /// Se produit sur le chargement de ma page
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void PageFaction_Load(object sender, EventArgs e)
        {
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;
            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié            
            if (Utilisateur != null) if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;
            
            ficheFaction1.SurChangementSelection += ficheFaction_SurChangementSelection;
        }


        /// <summary>
        /// Chargement des sous factions dans la fiche
        /// </summary>
        private void ChargerFaction()
        {
            ficheFaction1.Faction = Program.GMBD.EnumererFaction(
             null,
             null,
             null,
             new MyDB.CodeSql("ORDER BY fa_name"));

        }


        private void ficheFaction_SurChangementSelection(object sender, EventArgs e)
        {
            if (ficheFaction1.FactionSelectionne != null)
            {
                buttonAjouter.Enabled = false;
                buttonAnnuler.Enabled = true;
                buttonModifier.Enabled = true;
                buttonSupprimer.Enabled = true;
                textBoxFaction.Text = ficheFaction1.FactionSelectionne.Name;

                errorProviderErreurFaction.Clear();
                ValidationProvider.Clear();
            }
            else
            {
                buttonAjouter.Enabled = true;
                buttonAnnuler.Enabled = false;
                buttonModifier.Enabled = false;
                buttonSupprimer.Enabled = false;
            }
        }



        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Faction FactionExiste = null;
            
            FactionExiste = Program.GMBD.EnumererFaction(null,
                                                            null,
                                                            new MyDB.CodeSql("WHERE fa_name = {0}",textBoxFaction.Text),
                                                            null).FirstOrDefault();
            // Si la faction n'existe pas, on crée une nouvelle faction
            if (FactionExiste == null)
            {
                Faction NouvelleFaction = new Faction();
                NouvelleFaction.SurErreur += FactionEnEdition_SurErreur;

                NouvelleFaction.Name = textBoxFaction.Text;
                

                if ((NouvelleFaction.EstValide) && (Program.GMBD.AjouterFaction(NouvelleFaction)))
                {
                    ChargerFaction();
                    ValidationProvider.SetError(textBoxFaction, "Faction correctement ajouté");
                }

            }
            else
            {
                errorProviderErreurFaction.SetError(textBoxFaction, "Cette faction existe déjà");
            }   
            buttonAnnuler.Enabled = false;
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ficheFaction1.TexteFiltreFaction = "";
            textBoxFaction.Text = "";
            buttonAjouter.Enabled = true;
            buttonAnnuler.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimer.Enabled = false;
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (ficheFaction1.FactionSelectionne != null)
            {


                m_FactionEnEdition = ficheFaction1.FactionSelectionne;
                m_FactionEnEdition.SurErreur += FactionEnEdition_SurErreur;
                m_FactionEnEdition.AvantChangement += FactionEnEdition_AvantChangement;
                m_FactionEnEdition.ApresChangement += FactionEnEdition_ApresChangement;

                m_FactionEnEdition.Name = textBoxFaction.Text;

                if ((m_FactionEnEdition.EstValide) && (Program.GMBD.ModifierFaction(m_FactionEnEdition)))
                {
                    ChargerFaction();
                    ficheFaction1.TexteFiltreFaction = "";
                    textBoxFaction.Text = "";
                }

            }
        }


        /// <summary>
        /// Methode permettant de réagir sur l'erreur d'une edition de faction
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="MessageErreur"></param>
        private void FactionEnEdition_SurErreur(Faction Entite, Faction.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Faction.Champ.Name:
                    errorProviderErreurFaction.SetError(textBoxFaction, MessageErreur);
                    break;
            }
            buttonAjouter.Enabled = false;
        }

        /// <summary>
        /// Methode permettant de vérifier si la faction existe avant le changement de celle ci dans la base de données
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurActuelle"></param>
        /// <param name="NouvelleValeur"></param>
        /// <param name="AccumulateurErreur"></param>
        private void FactionEnEdition_AvantChangement(Faction Entite, Faction.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case Faction.Champ.Name:
                    Faction FactionExistante = Program.GMBD.EnumererFaction(null, null, new PDSGBD.MyDB.CodeSql("WHERE faction.fa_name = {0} AND faction.fa_id <> {1}", textBoxFaction.Text, ficheFaction1.FactionSelectionne.Id), null).FirstOrDefault();

                    if (FactionExistante != null)
                    {
                        AccumulateurErreur.NotifierErreur("Cette faction existe déjà, veuillez en choisir une autre !");
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
        private void FactionEnEdition_ApresChangement(Faction Entite, Faction.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {
                case Faction.Champ.Name:
                    ValidationProvider.SetError(textBoxFaction, "Votre faction a bien été modifiée");
                    break;

            }
            buttonAjouter.Enabled = m_FactionEnEdition.EstValide;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            PopUpConfirmation FormConfirmation = new PopUpConfirmation();
            
            SousFaction FactionLie = Program.GMBD.EnumererSousFaction(null, null, new MyDB.CodeSql("WHERE sf_fk_faction_id = {0}", ficheFaction1.FactionSelectionne.Id), null).FirstOrDefault();            
            if (FactionLie == null)
            {
                FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer cet enregistrement ?";                               

                FormConfirmation.ShowDialog();
                // S'il accepte
                if (FormConfirmation.Confirmation)
                {
                    if ((ficheFaction1.FactionSelectionne != null) && (Program.GMBD.SupprimerFaction(ficheFaction1.FactionSelectionne)))
                    {
                        ChargerFaction();
                        buttonAjouter.Enabled = true;
                        buttonAnnuler.Enabled = false;
                        buttonModifier.Enabled = false;
                        buttonSupprimer.Enabled = false;
                        ValidationProvider.SetError(textBoxFaction, "Suppresion correctement effectuée");
                        textBoxFaction.Text = "";
                    }
                }
                // S'il refuse
                else if (FormConfirmation.Annulation)
                {
                    // ne rien faire
                }
            }
            else
            {
                errorProviderErreurFaction.SetError(textBoxFaction, "Cette faction est utilisée par une sous faction, veuillez la supprimer avant de supprimer cette sous faction");
            }
        }

        private void textBoxFaction_Enter(object sender, EventArgs e)
        {
            errorProviderErreurFaction.Clear();
            ValidationProvider.Clear();
            if (textBoxFaction.Text == "") buttonAjouter.Enabled = true;
        }

    }



}
