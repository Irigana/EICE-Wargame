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
    public partial class PagePersonnage : UserControl
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

        private CharactRank m_PersonnageEnEdition;

        public PagePersonnage()
        {
            InitializeComponent();

            buttonAnnulerPersonnage.Enabled = false;
            buttonModifierPersonnage.Enabled = false;
            buttonSupprimerPersonnage.Enabled = false;
            buttonAjouterPersonnage.Enabled = false;
            textBoxCaractere.Enabled = false;
            menuAdmin1.MaPageActive = 2;


            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);
            listeDeroulanteFeature1.FeatureSelectionnee = null;
            m_PersonnageEnEdition = new CharactRank();

            m_PersonnageEnEdition.SurErreur += PersonnageEnEdition_SurErreur;
            m_PersonnageEnEdition.AvantChangement += PersonnageEnEdition_AvantChangement;
            m_PersonnageEnEdition.ApresChangement += PersonnageEnEdition_ApresChangement;


            ficheCaractere1.SurChangementSelection += ficheCaractere_SurChangementSelection;

            listeDeroulanteFaction1.SurChangementSelection += ListeDeroulanteFaction_SurChangementSelection;
            //ficheCaractere1.SurChangementSelection += ficheFaction_SurChangementSelection;
            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            ValidationProvider.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }

        private void ChargerCaracteristique()
        {
            ficheCaracteristique1.Caracteristique = Program.GMBD.EnumererCharactFeature(null,
                new MyDB.CodeSql(@"JOIN feature ON crf_fk_feature_id = fe_id
                                    JOIN char_rank ON crf_fk_char_rank_id = cr_id"),
                new MyDB.CodeSql("WHERE cr_fk_ch_id = {0}", ficheCaractere1.CaractereSelectionne.Id), null);
        }
        #region Sur changement de selection
        private void ListeDeroulanteFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSousFaction1.Enabled = true;
            buttonAjouterPersonnage.Enabled = false;

            buttonAnnulerPersonnage.Enabled = false;
            buttonModifierPersonnage.Enabled = false;
            buttonSupprimerPersonnage.Enabled = false;

            listeDeroulanteSousFaction1.ResetTextSousFaction();
            ficheCaractere1.NettoyerListView();
            Program.GMBD.MettreAJourListeSousFaction(listeDeroulanteSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
            listeDeroulanteSousFaction1.SurChangementSelection += ListeDeroulanteSousFaction_SurChangementSelection;
        }

        private void ListeDeroulanteSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteUnity1.Unity = Program.GMBD.EnumererUnity(new MyDB.CodeSql("DISTINCT unity.un_id,unity.un_name"),
                new MyDB.CodeSql(@"JOIN subunity ON unity.un_id = subunity.su_fk_unity_id
                                    JOIN char_rank ON subunity.su_id = char_rank.cr_sub_id
                                    JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id                                    
                                    JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                    JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id "),
                new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1}", listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id),
                new MyDB.CodeSql("ORDER BY un_name"));
            listeDeroulanteUnity1.SurChangementSelection += ListeDeroulanteUnity_SurChangementSelection;

        }

        private void ListeDeroulanteUnity_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(new MyDB.CodeSql("DISTINCT su_id,su_name"),
                new MyDB.CodeSql(@"JOIN unity ON subunity.su_fk_unity_id = unity.un_id
                                    JOIN char_rank ON subunity.su_id = char_rank.cr_sub_id
                                    JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id                                    
                                    JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                    JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id "),
                new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1} AND un_id = {2}",
                listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id),
                new MyDB.CodeSql("ORDER BY su_name"));
            listeDeroulanteSubUnity1.SurChangementSelection += ListeDeroulanteSubUnity_SurChangementSelection;
        }

        private void ListeDeroulanteSubUnity_SurChangementSelection(object sender, EventArgs e)
        {
            ficheCaractere1.Caractere = Program.GMBD.EnumererPersonnage(null,
                new MyDB.CodeSql(@"JOIN charact ON charact.ch_id = char_rank.cr_fk_ch_id
                                    JOIN rank ON rank.ra_id = char_rank.cr_fk_ra_id
                                    JOIN subunity ON char_rank.cr_sub_id = subunity.su_id    
                                    JOIN unity ON subunity.su_fk_unity_id = unity.un_id                                                                   
                                    JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                    JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id "),
                new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1} AND un_id = {2} AND su_id = {3}",
                listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                new MyDB.CodeSql("ORDER BY su_name"));
            textBoxCaractere.Enabled = true;
            buttonAjouterPersonnage.Enabled = true;
            listeDeroulanteRank1.Rank = Program.GMBD.EnumererRank(null, null, null, new MyDB.CodeSql("ORDER BY ra_name"));


        }

        private void ficheCaractere_SurChangementSelection(object sender, EventArgs e)
        {
            if ((ficheCaractere1.CaractereSelectionne != null) &&
                (listeDeroulanteFaction1.FactionSelectionnee != null) &&
                (listeDeroulanteSousFaction1.SousFactionSelectionnee != null) &&
                (listeDeroulanteUnity1.UnitySelectionnee != null) &&
                (listeDeroulanteSubUnity1.SubUnitySelectionnee != null))
            {

                buttonAjouterPersonnage.Enabled = false;
                buttonAnnulerPersonnage.Enabled = true;
                buttonModifierPersonnage.Enabled = true;
                buttonSupprimerPersonnage.Enabled = true;


                listeDeroulanteRank1.RankSelectionnee = ficheCaractere1.CaractereSelectionne.Rank;
                numericUpDown1.Value = ficheCaractere1.CaractereSelectionne.Cost;
                textBoxCaractere.Text = ficheCaractere1.CaractereSelectionne.Caractere.Name;
                textBoxPersonnageSelectionne.Text = ficheCaractere1.CaractereSelectionne.Caractere.Name.ToString();

                ficheCaractere1.ActiverTextBox = true;
                ficheCaracteristique1.Caracteristique = Program.GMBD.EnumererCharactFeature(null,
                new MyDB.CodeSql(@"JOIN charact ON charact.ch_id = char_rank.cr_fk_ch_id
                JOIN rank ON rank.ra_id = char_rank.cr_fk_ra_id
                JOIN subunity ON char_rank.cr_sub_id = subunity.su_id
                JOIN unity ON subunity.su_fk_unity_id = unity.un_id
                JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id 
                JOIN char_rank_feature ON char_rank.cr_id = crf_fk_char_rank_id
                JOIN feature ON feature.fe_id = crf_fk_feature_id"),
                new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1} AND un_id = {2} AND su_id = {3} AND ch_id = {4} AND ra_id = {5}",
                listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id,
                ficheCaractere1.CaractereSelectionne.Id,listeDeroulanteRank1.RankSelectionnee.Id),
                new MyDB.CodeSql("ORDER BY fe_name")); 
                listeDeroulanteFeature1.Enabled = true;
                listeDeroulanteFeature1.Feature = Program.GMBD.EnumererFeature(null, null, new MyDB.CodeSql("WHERE fe_filtre = {0}", "P"), new MyDB.CodeSql(" ORDER BY fe_name"));
                

                textBoxValeur.Clear();

                errorProviderErreurCaractere.Clear();
                ValidationProvider.Clear();

                listeDeroulanteFeature1.SurChangementSelection += ListeDeroulanteFeature_SurChangementSelection;

            }
            else if ((listeDeroulanteFaction1.FactionSelectionnee != null) &&
                (listeDeroulanteSousFaction1.SousFactionSelectionnee != null) &&
                (listeDeroulanteUnity1.UnitySelectionnee != null) &&
                (listeDeroulanteSubUnity1.SubUnitySelectionnee != null))
            {
                buttonAjouterPersonnage.Enabled = true;
                buttonAnnulerPersonnage.Enabled = false;
                buttonModifierPersonnage.Enabled = false;
                buttonSupprimerPersonnage.Enabled = false;
            }
            else
            {
                buttonAjouterPersonnage.Enabled = false;
                buttonAnnulerPersonnage.Enabled = false;
                buttonModifierPersonnage.Enabled = false;
                buttonSupprimerPersonnage.Enabled = false;
            }

        }
    

        private void ListeDeroulanteFeature_SurChangementSelection(object sender, EventArgs e)
        {
            textBoxValeur.Enabled = true;
            buttonAjouterCaracteristique.Enabled = true;            
        }

        #endregion
        private void PageCaractere_Load(object sender, EventArgs e)
        {
             // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;

            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié            
            if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;            
        }

        private void buttonAjouterCaract_Click(object sender, EventArgs e)
        {
            // Je met faction et sous faction pour vérifier qu'ils soient pas supprimer entre temps par un autre utilisateur et éviter un crash de requete
            Faction FactionExiste = null;
            SousFaction SousFactionExiste = null;

            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                FactionExiste = Program.GMBD.EnumererFaction(null,
                                                             null,
                                                             new MyDB.CodeSql("WHERE faction.fa_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                                                             null).FirstOrDefault();
                // Si la faction n'existe pas, on crée une nouvelle faction
                if (FactionExiste != null)
                {

                    if (listeDeroulanteSousFaction1.SousFactionSelectionnee != null)
                    {
                        SousFactionExiste = Program.GMBD.EnumererSousFaction(null,
                                                                             null,
                                                                             new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1}", listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id),
                                                                             null).FirstOrDefault();
                        if (SousFactionExiste != null)
                        {
                            

                            if (listeDeroulanteUnity1.UnitySelectionnee != null)
                            {
                                Unity UnityExiste = Program.GMBD.EnumererUnity(null,
                                                                                    new MyDB.CodeSql(@"JOIN subunity ON unity.un_id = subunity.su_fk_unity_id
                                                                                        JOIN char_rank ON subunity.su_id = char_rank.cr_sub_id
                                                                                        JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id                                    
                                                                                        JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                                                                        JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id "),
                                                                    new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1} AND un_id = {2}",
                                                                    listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id),
                                                                    null).FirstOrDefault();
                                if (UnityExiste != null)
                                {

                                    SubUnity SubUnityExiste = Program.GMBD.EnumererSubUnity(null,
                                                                                            new MyDB.CodeSql(@"JOIN unity ON subunity.su_fk_unity_id = unity.un_id
                                                                                                                JOIN char_rank ON subunity.su_id = char_rank.cr_sub_id
                                                                                                                JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id                                    
                                                                                                                JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                                                                                                JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id "),
                                                                                            new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1} AND un_id = {2} AND su_id = {3}",
                                                                                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                                                                                            null).FirstOrDefault();
                                    if (SubUnityExiste != null)
                                    {

                                        Charact NouveauCaractere = new Charact();
                                        NouveauCaractere.SurErreur += CaractereEnEdition_SurErreur;
                                        NouveauCaractere.AvantChangement += CaractereEnEdition_AvantChangement;
                                        NouveauCaractere.ApresChangement += CaractereEnEdition_ApresChangement;
                                        NouveauCaractere.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
                                        NouveauCaractere.Name = textBoxCaractere.Text;

                                        if ((NouveauCaractere.EstValide) && (Program.GMBD.AjouterCaractere(NouveauCaractere)))
                                        {

                                            CharactRank NouveauPersonnage = new CharactRank();
                                            NouveauPersonnage.Caractere = NouveauCaractere;
                                            NouveauPersonnage.Cost = Convert.ToInt32(numericUpDown1.Value);
                                            NouveauPersonnage.SubUnity = listeDeroulanteSubUnity1.SubUnitySelectionnee;
                                            NouveauPersonnage.Rank = listeDeroulanteRank1.RankSelectionnee;
                                            if((NouveauPersonnage.EstValide) && Program.GMBD.AjouterPersonnage(NouveauPersonnage))
                                            {
                                                Program.GMBD.MettreAJourFicheCaractere(ficheCaractere1, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id);
                                                errorProviderErreurCaractere.Clear();
                                                ValidationProvider.SetError(textBoxCaractere, "Personnage correctement ajouté");
                                                textBoxCaractere.Text = NouveauCaractere.Name;

                                                ficheCaractere1.TexteDuFiltre = "";
                                                listeDeroulanteRank1.RankSelectionnee = null;
                                                numericUpDown1.Value = 0;
                                                ficheCaractere1.CaractereSelectionne = null;
                                            }
                                            else
                                            {
                                                Program.GMBD.SupprimerCaractere(NouveauCaractere);
                                            }
                                        }
                                        

                                            
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            
            textBoxCaractere.Text = "";
            buttonAjouterPersonnage.Enabled = true;
        }

        private void buttonModifierPersonnage_Click(object sender, EventArgs e)
        {
            if ((listeDeroulanteFaction1.FactionSelectionnee != null) && 
                (listeDeroulanteSousFaction1.SousFactionSelectionnee != null) &&
                (listeDeroulanteUnity1.UnitySelectionnee != null) &&
                (listeDeroulanteSubUnity1.SubUnitySelectionnee != null) &&
                (ficheCaractere1.CaractereSelectionne != null))
            {

                m_PersonnageEnEdition = ficheCaractere1.CaractereSelectionne;
                m_PersonnageEnEdition.SurErreur += PersonnageEnEdition_SurErreur;
                m_PersonnageEnEdition.AvantChangement += PersonnageEnEdition_AvantChangement;
                m_PersonnageEnEdition.ApresChangement += PersonnageEnEdition_ApresChangement;

                m_PersonnageEnEdition.Caractere.SurErreur += CaractereEnEdition_SurErreur;
                m_PersonnageEnEdition.Caractere.AvantChangement += CaractereEnEdition_AvantChangement;
                m_PersonnageEnEdition.Caractere.ApresChangement += CaractereEnEdition_ApresChangement;

                
                m_PersonnageEnEdition.Cost = Convert.ToInt32(numericUpDown1.Value);
                m_PersonnageEnEdition.Caractere.Name = textBoxCaractere.Text;
                if(listeDeroulanteRank1.RankSelectionnee != null) m_PersonnageEnEdition.Rank = listeDeroulanteRank1.RankSelectionnee;
                m_PersonnageEnEdition.Caractere.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
                if ((m_PersonnageEnEdition.EstValide) && (Program.GMBD.ModifierPersonnage(m_PersonnageEnEdition)))
                {
                    Program.GMBD.MettreAJourFicheCaractere(ficheCaractere1,listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id);
                    ficheCaractere1.TexteDuFiltre = "";
                    textBoxCaractere.Text = "";
                    numericUpDown1.Value = 0;
                    listeDeroulanteRank1.RankSelectionnee = null;
                    ficheCaractere1.CaractereSelectionne = null;
                }

            }
        }

        private void buttonAnnulerCaract_Click(object sender, EventArgs e)
        {
            ficheCaractere1.TexteDuFiltre = "";            
            textBoxCaractere.Text = "";
            ficheCaractere1.CaractereSelectionne = null;
        }

        private void buttonSupprimerCaract_Click(object sender, EventArgs e)
        {
            PopUpConfirmation FormConfirmation = new PopUpConfirmation();
            // TODO : Vérifier si il a des enregistrement pour modifier le texte en dessous et dire à l'utilisateur le nombre d'element qu'a ce caractère

            FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer ce caractère ?";
            FormConfirmation.ShowDialog();
            if (FormConfirmation.Confirmation)
            {
                if ((ficheCaractere1.CaractereSelectionne != null) && (Program.GMBD.SupprimerCaractere(ficheCaractere1.CaractereSelectionne.Caractere)))
                {
                    Program.GMBD.MettreAJourFicheCaractere(ficheCaractere1, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id);
                    buttonAjouterPersonnage.Enabled = true;
                    buttonAnnulerPersonnage.Enabled = false;
                    buttonModifierPersonnage.Enabled = false;
                    buttonSupprimerPersonnage.Enabled = false;
                    ValidationProvider.SetError(textBoxCaractere, "Suppression correctement effectuée");
                    textBoxCaractere.Text = "";
                }
            }
            else if (FormConfirmation.Annulation)
            {
                // ne rien faire
            }
        }

        #region Caractère en édition
        /// <summary>
        /// Methode permettant de réagir sur l'erreur d'un ajout ou d'une édition de caractère
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="MessageErreur"></param>
        private void CaractereEnEdition_SurErreur(Charact Entite, Charact.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Charact.Champ.Name:
                    errorProviderErreurCaractere.SetError(textBoxCaractere, MessageErreur);
                    break;
            }
            buttonAjouterPersonnage.Enabled = false;
        }
        
        /// <summary>
        /// Methode permettant de vérifier si la sous faction existe avant le changement de celle ci dans la base de données
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurActuelle"></param>
        /// <param name="NouvelleValeur"></param>
        /// <param name="AccumulateurErreur"></param>
        private void CaractereEnEdition_AvantChangement(Charact Entite, Charact.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case Charact.Champ.Name:
                    // Si il est en modification
                    if (ficheCaractere1.CaractereSelectionne != null)
                    {
                        Charact CaractereExiste = Program.GMBD.EnumererCaractere(null, 
                            new MyDB.CodeSql(@"JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id 
                                                JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id
                                                JOIN subunity ON char_rank.cr_sub_id = subunity.su_id    
                                                JOIN unity ON subunity.su_fk_unity_id = unity.un_id"),
                            new MyDB.CodeSql(@"WHERE faction.fa_id = {0} AND subfaction.sf_id = {1}
                                                AND charact.ch_name = {2} AND charact.ch_id <> {3}
                                                AND subunity.su_id = {4} AND unity.un_id = {5}", 
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                            textBoxCaractere.Text, ficheCaractere1.CaractereSelectionne.Caractere.Id,
                            listeDeroulanteSubUnity1.SubUnitySelectionnee.Id,listeDeroulanteUnity1.UnitySelectionnee.Id), null).FirstOrDefault();

                        if (CaractereExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Ce caractère existe déjà, veuillez en choisir une autre !");
                        }
                    }
                    // Si il est en ajout
                    else if (ficheCaractere1.CaractereSelectionne == null)
                    {
                        Charact CaractereExiste = Program.GMBD.EnumererCaractere(null,
                            new MyDB.CodeSql("JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),                        
                            new MyDB.CodeSql("WHERE faction.fa_id = {0} AND subfaction.sf_id = {1} AND charact.ch_name = {2}",
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, textBoxCaractere.Text), null).FirstOrDefault();

                        if (CaractereExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Ce caractère existe déjà, veuillez en choisir une autre !");
                        }
                    }
                    break;
            }
        }

        private void CaractereEnEdition_ApresChangement(Charact Entite, Charact.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {
                case Charact.Champ.Name:
                    if (ficheCaractere1.CaractereSelectionne != null)
                    {
                        ValidationProvider.SetError(textBoxCaractere, "Votre caractère a bien été modifié");
                    }
                    else if(ficheCaractere1.CaractereSelectionne == null)
                    {
                        ValidationProvider.SetError(textBoxCaractere, "Votre caractère a bien été ajouté");
                    }

                    break;

            }
            buttonAjouterPersonnage.Enabled = m_PersonnageEnEdition.EstValide;
        }
        #endregion



        #region Caractère en édition
        /// <summary>
        /// Methode permettant de réagir sur l'erreur d'un ajout ou d'une édition de caractère
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="MessageErreur"></param>
        private void PersonnageEnEdition_SurErreur(CharactRank Entite, CharactRank.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case CharactRank.Champ.Cost:
                    errorProviderErreurCaractere.SetError(numericUpDown1, MessageErreur);
                    break;
            }
            buttonAjouterPersonnage.Enabled = false;
        }

        /// <summary>
        /// Methode permettant de vérifier si la sous faction existe avant le changement de celle ci dans la base de données
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurActuelle"></param>
        /// <param name="NouvelleValeur"></param>
        /// <param name="AccumulateurErreur"></param>
        private void PersonnageEnEdition_AvantChangement(CharactRank Entite, CharactRank.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case CharactRank.Champ.Cost:
                    {
                        if ((Entite.Cost > int.MaxValue) || (Entite.Cost < 0))
                        {
                            AccumulateurErreur.NotifierErreur("Ce coût n'est pas correct, veuillez en choisir une autre !");
                        }
                        break;
                    }                   
            }
        }

        private void PersonnageEnEdition_ApresChangement(CharactRank Entite, CharactRank.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {
                case CharactRank.Champ.Cost:
                    if (ficheCaractere1.CaractereSelectionne != null)
                    {
                        ValidationProvider.SetError(numericUpDown1, "Votre cout a bien été modifié");
                        numericUpDown1.Value = Entite.Cost;
                    }                    
                    break;
            }
            buttonAjouterPersonnage.Enabled = m_PersonnageEnEdition.EstValide;
        }
        #endregion

        private void textBoxCaractere_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            ficheCaractere1.CaractereSelectionne = null;
            buttonAjouterCaract.Enabled = true;
            buttonAnnulerCaract.Enabled = false;
            buttonModifierCaract.Enabled = false;
            buttonSupprimerCaract.Enabled = false;
            */
        }        

        private void textBoxCaractere_Enter(object sender, EventArgs e)
        {
            errorProviderErreurCaractere.Clear();
            ValidationProvider.Clear();
        }

        private void numericUpDown1_Enter(object sender, EventArgs e)
        {
            errorProviderErreurCaractere.Clear();
            ValidationProvider.Clear();
        }
    }   
}