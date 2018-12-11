using System;
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


        private bool m_FeatureValidee = false;
        private const string c_CritereQuiContient = "%{0}%";

        private CharactRank m_PersonnageEnEdition;
        CharactFeature m_CFEnEdition;

        public PagePersonnage()
        {
            InitializeComponent();

            buttonAnnulerPersonnage.Enabled = false;
            buttonModifierPersonnage.Enabled = false;
            buttonSupprimerPersonnage.Enabled = false;
            buttonAjouterPersonnage.Enabled = false;
            buttonAjouterCaracteristique.Enabled = false;
            buttonSupprimerCaracteristique.Enabled = false;
            buttonModifCaracteristique.Enabled = false;            
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
            listeDeroulanteUnity1.Enabled = true;
            listeDeroulanteUnity1.Unity = Program.GMBD.EnumererUnity(new MyDB.CodeSql("unity.un_id,unity.un_name"),
                null,null,
                new MyDB.CodeSql("ORDER BY un_name"));
            listeDeroulanteUnity1.SurChangementSelection += ListeDeroulanteUnity_SurChangementSelection;

        }

        private void ListeDeroulanteUnity_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSubUnity1.Enabled = true;
            listeDeroulanteSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(new MyDB.CodeSql("su_id,su_name"),
                null,
                new MyDB.CodeSql("WHERE su_fk_unity_id = {0}",
                listeDeroulanteUnity1.UnitySelectionnee.Id),
                new MyDB.CodeSql("ORDER BY su_name"));
            listeDeroulanteSubUnity1.SurChangementSelection += ListeDeroulanteSubUnity_SurChangementSelection;
        }

        private void ListeDeroulanteSubUnity_SurChangementSelection(object sender, EventArgs e)
        {
            numericUpDown1.Enabled = true;
            listeDeroulanteRank1.Enabled = true;
            textBoxCaractere.Enabled = true;
            buttonAjouterPersonnage.Enabled = true;
            ficheCaractere1.ActiverTextBox = true;
            ficheCaractere1.Caractere = Program.GMBD.EnumererPersonnage(null,
                new MyDB.CodeSql(@"JOIN charact ON charact.ch_id = char_rank.cr_fk_ch_id
                                    JOIN rank ON rank.ra_id = char_rank.cr_fk_ra_id
                                    JOIN subunity ON char_rank.cr_sub_id = subunity.su_id                                                                     
                                    JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id"),
                new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND su_fk_unity_id = {2} AND su_id = {3}",
                listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                new MyDB.CodeSql("ORDER BY su_name"));
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
                numericUpDown2.Enabled = true;
                listeDeroulanteFeature1.Enabled = true;
                ficheCaractere1.ActiverTextBox = true;
                buttonAjouterCaracteristique.Enabled = true;


                listeDeroulanteRank1.RankSelectionnee = ficheCaractere1.CaractereSelectionne.Rank;
                numericUpDown1.Value = ficheCaractere1.CaractereSelectionne.Cost;
                textBoxCaractere.Text = ficheCaractere1.CaractereSelectionne.Caractere.Name;
                textBoxPersonnageSelectionne.Text = ficheCaractere1.CaractereSelectionne.Caractere.Name.ToString();
                ficheCaracteristique1.Caracteristique = Program.GMBD.EnumererCharactFeature(null,
                new MyDB.CodeSql(@"JOIN char_rank ON char_rank_feature.crf_fk_char_rank_id = char_rank.cr_id
                JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id
                JOIN rank ON rank.ra_id = char_rank.cr_fk_ra_id
                JOIN subunity ON char_rank.cr_sub_id = subunity.su_id                
                JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id                                 
                JOIN feature ON feature.fe_id = crf_fk_feature_id"),
                new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0} AND sf_id = {1} AND subunity.su_fk_unity_id = {2} AND su_id = {3} AND ch_id = {4} AND ra_id = {5}",
                listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id,
                ficheCaractere1.CaractereSelectionne.Id,listeDeroulanteRank1.RankSelectionnee.Id),
                new MyDB.CodeSql("ORDER BY fe_name"));
                ficheCaracteristique1.SurChangementSelection += FicheCaracteristique_SurChangementSelection;

                listeDeroulanteFeature1.Enabled = true;
                listeDeroulanteFeature1.Feature = Program.GMBD.EnumererFeature(null, null, new MyDB.CodeSql("WHERE fe_filtre = {0} OR {1}", "P","PE"), new MyDB.CodeSql(" ORDER BY fe_name"));                               

                errorProviderErreurCaractere.Clear();
                ValidationProvider.Clear();

                listeDeroulanteFeature1.SurChangementSelection += ListeDeroulanteFeature_SurChangementSelection;
                RafraichirListViewCaracteristiques();
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
            errorProviderErreurCaractere.Clear();
            ValidationProvider.Clear();
            numericUpDown2.Enabled = true;
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
                                                                                    null,
                                                                    new MyDB.CodeSql("WHERE un_id = {0}",
                                                                    listeDeroulanteUnity1.UnitySelectionnee.Id),
                                                                    null).FirstOrDefault();
                                if ((UnityExiste != null)&&(listeDeroulanteSubUnity1.SubUnitySelectionnee != null))
                                {

                                    SubUnity SubUnityExiste = Program.GMBD.EnumererSubUnity(null,
                                                                                            new MyDB.CodeSql(@"JOIN unity ON subunity.su_fk_unity_id = unity.un_id
                                                                                                                "),
                                                                                            new MyDB.CodeSql(" WHERE un_id = {0} AND su_id = {1}",
                                                                                            listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                                                                                            null).FirstOrDefault();
                                    if (SubUnityExiste != null)
                                    {

                                        Charact NouveauCaractere = new Charact();
                                        NouveauCaractere.SurErreur += CaractereEnEdition_SurErreur;
                                        NouveauCaractere.AvantChangement += CaractereEnEdition_AvantChangement;
                                        NouveauCaractere.ApresChangement += CaractereEnEdition_ApresChangement;
                                        NouveauCaractere.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
                                        NouveauCaractere.Name = textBoxCaractere.Text;

                                        Charact CaractereExistant = Program.GMBD.EnumererCaractere(null, null, new MyDB.CodeSql("WHERE ch_name = {0}",textBoxCaractere.Text), null).FirstOrDefault();
                                        if (CaractereExistant == null)
                                        {
                                            if ((NouveauCaractere.EstValide) && (Program.GMBD.AjouterCaractere(NouveauCaractere)))
                                            {

                                                CharactRank NouveauPersonnage = new CharactRank();
                                                NouveauPersonnage.Caractere = NouveauCaractere;
                                                NouveauPersonnage.Cost = Convert.ToInt32(numericUpDown1.Value);
                                                NouveauPersonnage.SubUnity = listeDeroulanteSubUnity1.SubUnitySelectionnee;
                                                NouveauPersonnage.AvantChangement += PersonnageEnEdition_AvantChangement;
                                                NouveauPersonnage.Rank = listeDeroulanteRank1.RankSelectionnee;
                                                if ((NouveauPersonnage.EstValide) && Program.GMBD.AjouterPersonnage(NouveauPersonnage))
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
                                        else//
                                        {
                                            errorProviderErreurCaractere.Clear();
                                            ValidationProvider.Clear();
                                            CharactRank NouveauPersonnage = new CharactRank();
                                            NouveauPersonnage.Caractere = CaractereExistant;
                                            NouveauPersonnage.AvantChangement += PersonnageEnEdition_AvantChangement;
                                            NouveauPersonnage.Rank = listeDeroulanteRank1.RankSelectionnee;
                                            NouveauPersonnage.Cost = Convert.ToInt32(numericUpDown1.Value);
                                            NouveauPersonnage.SubUnity = listeDeroulanteSubUnity1.SubUnitySelectionnee;                             
                                            if ((NouveauPersonnage.EstValide) && Program.GMBD.AjouterPersonnage(NouveauPersonnage))
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
                Charact CaractereExistant = Program.GMBD.EnumererCaractere(null, null, new MyDB.CodeSql("WHERE ch_name = {0}", textBoxCaractere.Text), null).FirstOrDefault();
                if (CaractereExistant == null)
                {
                    m_PersonnageEnEdition.Caractere.Name = textBoxCaractere.Text;
                }
                else
                {
                    m_PersonnageEnEdition.Caractere = CaractereExistant;
                }

                // TODO : StuffCharactRank LienExistant = Program.GMBD.EnumererStuff

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
                if ((ficheCaractere1.CaractereSelectionne != null) && (Program.GMBD.SupprimerPersonnage(ficheCaractere1.CaractereSelectionne)))
                {
                    Program.GMBD.MettreAJourFicheCaractere(ficheCaractere1, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id);
                    buttonAjouterPersonnage.Enabled = true;
                    buttonAnnulerPersonnage.Enabled = false;
                    buttonModifierPersonnage.Enabled = false;
                    buttonSupprimerPersonnage.Enabled = false;
                    buttonAjouterCaracteristique.Enabled = false;
                    listeDeroulanteFeature1.Enabled = false;
                    numericUpDown2.Enabled = false;
                    ficheCaracteristique1.NettoyerListView();
                    textBoxPersonnageSelectionne.Clear();
                    ValidationProvider.SetError(ficheCaractere1, "Suppression correctement effectuée");
                    textBoxCaractere.Text = "";
                }
                else
                {

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
                            new MyDB.CodeSql(@"JOIN char_rank ON charact.ch_id = char_rank.cr_fk_ch_id
                                                JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id                                                
                                                JOIN subunity ON char_rank.cr_sub_id = subunity.su_id"),
                            new MyDB.CodeSql(@"WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1}
                                                AND charact.ch_name = {2} AND char_rank.cr_fk_ra_id = {3}
                                                AND subunity.su_id = {4} AND subunity.su_fk_unity_id = {5}", 
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                            textBoxCaractere.Text, listeDeroulanteRank1.RankSelectionnee.Id,
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
                            new MyDB.CodeSql(@"JOIN char_rank ON charact.ch_id = char_rank.cr_fk_ch_id
                                                JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id                                                
                                                JOIN subunity ON char_rank.cr_sub_id = subunity.su_id"),
                             new MyDB.CodeSql(@"WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1}
                                                AND charact.ch_name = {2} AND char_rank.cr_fk_ra_id = {5}
                                                AND subunity.su_id = {3} AND subunity.su_fk_unity_id = {4}",
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                            textBoxCaractere.Text, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteRank1.RankSelectionnee.Id), null).FirstOrDefault();
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
                case CharactRank.Champ.Rank:
                    errorProviderErreurCaractere.SetError(listeDeroulanteFaction1, MessageErreur);
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
                        if ((numericUpDown1.Value > int.MaxValue) || (numericUpDown1.Value < 0))
                        {
                            errorProviderErreurCaractere.SetError(numericUpDown1,"Votre coût doit être supérieur ou égal à 1");
                            AccumulateurErreur.NotifierErreur("Ce coût n'est pas correct, veuillez en choisir une autre !");
                        }
                        CharactRank PersonnageAvecCeRankExiste = Program.GMBD.EnumererPersonnage(null, null, new MyDB.CodeSql("WHERE cr_fk_ra_id = {0} AND cr_fk_ch_id = {1}", Entite.Rank.Id, Entite.Caractere.Id), null).FirstOrDefault();
                        if (PersonnageAvecCeRankExiste != null)
                        {
                            errorProviderErreurCaractere.SetError(listeDeroulanteRank1, "Un personnage avec ce rank existe déjà");
                            AccumulateurErreur.NotifierErreur("Un personnage avec ce rank existe déjà");
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

        private void buttonAjouterCaracteristique_Click(object sender, EventArgs e)
        {
            m_CFEnEdition = new CharactFeature();
            m_CFEnEdition.AvantChangement += FeatureEnEdition_AvantChangement;
            m_CFEnEdition.ApresChangement += FeatureEnEdition_ApresChangement;
            m_CFEnEdition.CharactRank = ficheCaractere1.CaractereSelectionne;
            m_CFEnEdition.Feature = listeDeroulanteFeature1.FeatureSelectionnee;            
            m_CFEnEdition.Value = Convert.ToInt32(numericUpDown2.Value);
            if(Program.GMBD.AjouterFeaturePersonnage(m_CFEnEdition))
            {
                RafraichirListViewCaracteristiques();
            }
            else
            {
                errorProviderErreurCaractere.SetError(listeDeroulanteFeature1, "Caractère déjà utilisé pour ce personnage");
            }
        }

        private void buttonModifCaracteristique_Click(object sender, EventArgs e)
        {

            m_CFEnEdition = new CharactFeature();
            m_CFEnEdition = ficheCaracteristique1.FeatureSelectionne;
            m_CFEnEdition.AvantChangement += FeatureEnEdition_AvantChangement;
            m_CFEnEdition.ApresChangement += FeatureEnEdition_ApresChangement;
            m_CFEnEdition.CharactRank = ficheCaractere1.CaractereSelectionne;
            m_CFEnEdition.Feature = listeDeroulanteFeature1.FeatureSelectionnee;

            // Pas le choix de le mettre ici sinon il supprime ma valeur en le convertissant 
            if(numericUpDown2.Value > Int32.MaxValue)
            {
                errorProviderErreurCaractere.SetError(numericUpDown2, "Votre nombre est trop grand");
                m_FeatureValidee = false;
            }
            else if(numericUpDown2.Value < 0)
            {
                m_FeatureValidee = false;
                errorProviderErreurCaractere.SetError(numericUpDown2, " Votre nombre ne peut être inférieur à 0");
            }

            m_CFEnEdition.Value = Convert.ToInt32(numericUpDown2.Value);
            if ((m_CFEnEdition.EstValide) &&(m_FeatureValidee == true)&& (Program.GMBD.ModifierFeaturePersonnage(m_CFEnEdition)))
            {
                RafraichirListViewCaracteristiques();
            }
            else
            {
            }
        }

        private void RafraichirListViewCaracteristiques()
        {
            ficheCaracteristique1.Caracteristique = Program.GMBD.EnumererCharactFeature(null, new MyDB.CodeSql("JOIN feature ON char_rank_feature.crf_fk_feature_id = feature.fe_id"), new MyDB.CodeSql("WHERE crf_fk_char_rank_id = {0}", ficheCaractere1.CaractereSelectionne.Id), null);
        }


        private void FeatureEnEdition_AvantChangement(CharactFeature Entite, CharactFeature.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {

            switch (Champ)
            {
                case CharactFeature.Champ.Feature:
                    {

                        m_FeatureValidee = true;

                        // Si en ajout
                        if (ficheCaracteristique1.FeatureSelectionne == null)
                        {
                            Feature FeatureExiste = Program.GMBD.EnumererFeature(null, new MyDB.CodeSql(@"JOIN char_rank_feature ON char_rank_feature.crf_fk_feature_id = feature.fe_id
                                                                                                        JOIN char_rank ON char_rank_feature.crf_fk_char_rank_id = char_rank.cr_id                                                                                                      
                                                                                                        JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id 
                                                                                                        JOIN subunity ON char_rank.cr_sub_id = subunity.su_id
                                                                                                        JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id"),
                                                                             new MyDB.CodeSql("WHERE char_rank_feature.crf_fk_char_rank_id = {0} AND subfaction.sf_id = {1} AND subfaction.sf_fk_faction_id = {2}  AND subunity.su_id = {3} AND subunity.su_fk_unity_id = {4} AND char_rank.cr_fk_ra_id = {5} AND feature.fe_id = {6} ",
                                                                             ficheCaractere1.CaractereSelectionne.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteFaction1.FactionSelectionnee.Id,
                                                                             listeDeroulanteSubUnity1.SubUnitySelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteRank1.RankSelectionnee.Id, listeDeroulanteFeature1.FeatureSelectionnee.Id), null).FirstOrDefault();
                            if (FeatureExiste != null)
                            {
                                m_FeatureValidee = false;
                                AccumulateurErreur.NotifierErreur("Ce personnage dispose déjà de cette caractèristique, veuillez en choisir une autre !");
                            }
                        }
                        // Si en modification
                        else if (ficheCaracteristique1.FeatureSelectionne != null)
                        {
                            Feature FeatureExiste = Program.GMBD.EnumererFeature(null, new MyDB.CodeSql(@"JOIN char_rank_feature ON char_rank_feature.crf_fk_feature_id = feature.fe_id
                                                                                                        JOIN char_rank ON char_rank_feature.crf_fk_char_rank_id = char_rank.cr_id                                                                                                      
                                                                                                        JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id 
                                                                                                        JOIN subunity ON char_rank.cr_sub_id = subunity.su_id
                                                                                                        JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id"),
                                                                             new MyDB.CodeSql("WHERE charact.ch_id <> {0} AND subfaction.sf_id = {1} AND subfaction.sf_fk_faction_id = {2}  AND subunity.su_id = {3} AND subunity.su_fk_unity_id = {4} AND char_rank.cr_fk_ra_id = {5} AND feature.fe_id = {6} AND char_rank_feature.crf_fk_char_rank_id = {7}",
                                                                             ficheCaractere1.CaractereSelectionne.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteFaction1.FactionSelectionnee.Id,
                                                                             listeDeroulanteSubUnity1.SubUnitySelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteRank1.RankSelectionnee.Id, listeDeroulanteFeature1.FeatureSelectionnee.Id, ficheCaractere1.CaractereSelectionne.Id), null).FirstOrDefault();
                            if (FeatureExiste != null)
                            {
                                m_FeatureValidee = false;
                                AccumulateurErreur.NotifierErreur("Ce personnage dispose déjà de cette caractèristique, veuillez en choisir une autre !");
                                errorProviderErreurCaractere.SetError(listeDeroulanteFeature1, "Ce personnage dispose déjà de cette caractèristique, veuillez en choisir une autre !");
                            }
                        }
                        break;
                    }               
            }
        }

        private void FeatureEnEdition_ApresChangement(CharactFeature Entite, CharactFeature.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {               
                case CharactFeature.Champ.Value:
                    // Si modification
                    if ((ficheCaracteristique1.FeatureSelectionne != null) && (m_FeatureValidee == true))
                    {
                        ValidationProvider.SetError(numericUpDown2, "Votre coût a bien été modifiée");
                    }
                    // Si ajout
                    else if ((ficheCaracteristique1.FeatureSelectionne == null)&& (m_FeatureValidee == true))
                    {
                       
                         ValidationProvider.SetError(numericUpDown2,"Votre coût a bien ajoutée");
                       
                    }
                    break;
            }
            buttonAjouterCaracteristique.Enabled = m_CFEnEdition.EstValide;
        }        
        
        private void FicheCaracteristique_SurChangementSelection(object sender,EventArgs e)
        {
            
            if (ficheCaracteristique1.FeatureSelectionne != null)
            {
                buttonModifCaracteristique.Enabled = true;
                buttonSupprimerCaracteristique.Enabled = true;
                buttonAjouterCaracteristique.Enabled = false;
                numericUpDown2.Value = ficheCaracteristique1.FeatureSelectionne.Value;
                listeDeroulanteFeature1.FeatureSelectionnee = ficheCaracteristique1.FeatureSelectionne.Feature;
            }
            else
            {
                numericUpDown2.Value = 0;
                listeDeroulanteFeature1.FeatureSelectionnee = null;
                buttonModifCaracteristique.Enabled = false;
                buttonSupprimerCaracteristique.Enabled = false;
                buttonAjouterCaracteristique.Enabled = true;
            }           
        }

        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            errorProviderErreurCaractere.Clear();
            ValidationProvider.Clear();
        }

        private void buttonAnnulerFeature_Click(object sender, EventArgs e)
        {
            ficheCaracteristique1.FeatureSelectionne = null;
            numericUpDown2.Value = 0;
            listeDeroulanteFeature1.FeatureSelectionnee = null;
            buttonAjouterCaracteristique.Enabled = true;
            buttonModifCaracteristique.Enabled = false;
            buttonSupprimerCaracteristique.Enabled = false;
            buttonAnnulerFeature.Enabled = false;
            errorProviderErreurCaractere.Clear();
            ValidationProvider.Clear();
        }

        private void buttonSupprimerCaracteristique_Click(object sender, EventArgs e)
        {
            if(ficheCaracteristique1.FeatureSelectionne != null)
            {
                if(Program.GMBD.SupprimerFeaturePersonnage(ficheCaracteristique1.FeatureSelectionne))
                {
                    RafraichirListViewCaracteristiques();
                    ValidationProvider.SetError(ficheCaracteristique1, "Votre caractèristique a été supprimée");
                }
            }
        }
    }   
}
