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
    public partial class PageSubUnity : UserControl
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

        private SubUnity m_SubUnityEnEdition;

        public PageSubUnity()
        {
            InitializeComponent();
            buttonAjouterSubUnity.Enabled = false;
            buttonAnnulerSubUnity.Enabled = false;
            buttonSupprimerSubUnity.Enabled = false;
            buttonModifier.Enabled = false;
            listeDeroulanteSousFaction1.Enabled = false;
            textBoxSousUnity.Enabled = false;
            buttonAttacher.Enabled = false;
            buttonDelier.Enabled = false;
            ficheSubUnitySlave.Enabled = false;

            listeDeroulanteFaction1.Faction = Program.GMBD.EnumererFaction(null, null, null, null);
            listeDeroulanteFaction1.SurChangementSelection += ListeFaction_SurChangementSelection;
            listeDeroulanteSousFaction1.SurChangementSelection += ListeSousFaction_SurChangementSelection;

        }

        private void PageSubUnity_Load(object sender, EventArgs e)
        {
            
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;
            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié            
            if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;

        }

        private void ListeFaction_SurChangementSelection(object sender,EventArgs e)
        {
            listeDeroulanteSousFaction1.Enabled = true;
            listeDeroulanteSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(null, null, new MyDB.CodeSql("WHERE sf_fk_faction_id ={0}", listeDeroulanteFaction1.FactionSelectionnee.Id),null);
        }

        private void ListeSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            textBoxSousUnity.Enabled = true;
            ficheSubUnity1.Enabled = true;
            buttonAjouterSubUnity.Enabled = true;
            buttonModifier.Enabled = false;
            buttonSupprimerSubUnity.Enabled = false;
            ChargerFicheSansFiltre(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);

            ficheSubUnity1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheSubUnity1.TexteFiltreSubUnity != "")
                {
                    ficheSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null,
                    new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                    new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND su_name LIKE {2}",
                    listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                    string.Format(c_CritereQuiContient, ficheSubUnity1.TexteFiltreSubUnity)),
                    new MyDB.CodeSql("ORDER BY su_name"));
                }
                else
                {
                    ChargerFicheSansFiltre(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);     
                }
            };


            ficheSubUnity1.SurChangementSelection += FicheSousUnity_SurChangementSelection;


        }

        private void ChargerFicheSansFiltre(int IdSousFaction, int IdFaction)
        {
            ficheSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null,
                   new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                   new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1}",
                   IdSousFaction, IdFaction),
                   new MyDB.CodeSql("ORDER BY su_name"));
        }

        private void FicheSousUnity_SurChangementSelection(object sender,EventArgs e)
        {
            buttonAjouterSubUnity.Enabled = false;
            buttonAnnulerSubUnity.Enabled = true;
            buttonSupprimerSubUnity.Enabled = true;
            buttonModifier.Enabled = true;
            ficheSubUnitySlave.Enabled = true;
            buttonAttacher.Enabled = true;
            buttonDelier.Enabled = true;
            ficheSubUnity1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheSubUnity1.TexteFiltreSubUnity != "")
                {
                    ficheSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null,
                    new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                    new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND su_name LIKE {2}",
                    listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                    string.Format(c_CritereQuiContient, ficheSubUnity1.TexteFiltreSubUnity)),
                    new MyDB.CodeSql("ORDER BY su_name"));
                }
                else
                {
                    ChargerFicheSansFiltre(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);
                }
            };
        }
        

        private void buttonAjouterSubUnity_Click(object sender, EventArgs e)
        {
            m_SubUnityEnEdition = new SubUnity();
            m_SubUnityEnEdition.SurErreur += SubUnityEnEdition_SurErreur;
            m_SubUnityEnEdition.AvantChangement += SubUnityEnEdition_AvantChangement;
            m_SubUnityEnEdition.ApresChangement += SubUnityEnEdition_ApresChangement;

            m_SubUnityEnEdition.Name = textBoxSousUnity.Text;
            m_SubUnityEnEdition.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
            if(m_SubUnityEnEdition.EstValide && Program.GMBD.AjouterSubUnity(m_SubUnityEnEdition))
            {
                ChargerFicheSansFiltre(listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteFaction1.FactionSelectionnee.Id);
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {
            if (ficheSubUnity1.SubUnitySelectionne != null)
            {
                m_SubUnityEnEdition = ficheSubUnity1.SubUnitySelectionne;
                m_SubUnityEnEdition.SurErreur += SubUnityEnEdition_SurErreur;
                m_SubUnityEnEdition.AvantChangement += SubUnityEnEdition_AvantChangement;
                m_SubUnityEnEdition.ApresChangement += SubUnityEnEdition_ApresChangement;

                m_SubUnityEnEdition.Name = textBoxSousUnity.Text;
                m_SubUnityEnEdition.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
                if(m_SubUnityEnEdition.EstValide && Program.GMBD.ModifierSubUnity(m_SubUnityEnEdition))
                {
                    ChargerFicheSansFiltre(listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteFaction1.FactionSelectionnee.Id);
                }
            }
        }

        private void buttonSupprimerSubUnity_Click(object sender, EventArgs e)
        {
            if (ficheSubUnity1.SubUnitySelectionne != null)
            {                
                SubUnity SubUnityLie = Program.GMBD.EnumererSubUnity(null,null,new MyDB.CodeSql("WHERE ((subunity.su_id IN(SELECT char_rank.cr_sub_id FROM char_rank) OR subunity.su_id IN(SELECT sub_sub.ss_fk_su_id_master FROM sub_sub) OR subunity.su_id IN (SELECT stuff_subunity.cfs_fk_subunity_id FROM stuff_subunity))) AND subunity.su_id = {0}", ficheSubUnity1.SubUnitySelectionne.Id), null).FirstOrDefault();
                if (SubUnityLie == null)
                {
                    PopUpConfirmation FormConfirmation = new PopUpConfirmation();
                    FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer cette sous unité ?";
                    FormConfirmation.ShowDialog();
                    if (FormConfirmation.Confirmation)
                    {
                        if (Program.GMBD.SupprimerSubUnity(SubUnityLie))
                        {
                            ValidationProvider.SetError(textBoxSousUnity, "Votre sous unité a bien été supprimée");
                            ChargerFicheSansFiltre(listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteFaction1.FactionSelectionnee.Id);
                        }
                    }
                    else if (FormConfirmation.Annulation)
                    {
                        // Ne rien faire
                    }
                }
                else
                {
                    errorProviderUnity.SetError(textBoxSousUnity, "Cette sous unité est déjà utilisé, impossible de la supprimer avant de supprimer les élements attacher");
                }
            }
        }

        private void buttonAnnulerSubUnity_Click(object sender, EventArgs e)
        {
            listeDeroulanteSousFaction1.ResetTextSousFaction();
            ficheSubUnity1.NettoyerListView();
            buttonAnnulerSubUnity.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimerSubUnity.Enabled = false;
            buttonAjouterSubUnity.Enabled = false;
        }



        #region Unity en édition SurErreur / AvantChangement / ApresChangement
        /// <summary>
        /// Methode permettant de réagir sur l'erreur d'un ajout ou d'une édition d'une unité
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="MessageErreur"></param>
        private void SubUnityEnEdition_SurErreur(SubUnity Entite, SubUnity.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case SubUnity.Champ.Name:
                    errorProviderUnity.SetError(textBoxSousUnity, MessageErreur);
                    break;
            }
            buttonAjouterSubUnity.Enabled = false;
        }

        /// <summary>
        /// Methode permettant de vérifier si la sous unité existe avant le changement de celle ci dans la base de données
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurActuelle"></param>
        /// <param name="NouvelleValeur"></param>
        /// <param name="AccumulateurErreur"></param>
        private void SubUnityEnEdition_AvantChangement(SubUnity Entite, SubUnity.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case SubUnity.Champ.Name:
                    // Si il est en modification
                    if (ficheSubUnity1.SubUnitySelectionne != null)
                    {
                        SubUnity SubUnityExiste = Program.GMBD.EnumererSubUnity(null,
                            new MyDB.CodeSql(@" JOIN subfaction ON subunity.su_fk_subfaction_id = subfaction.sf_id"),
                            new MyDB.CodeSql(@"WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1} AND su_name = {2} AND su_id <> {3}",
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                            textBoxSousUnity.Text,ficheSubUnity1.SubUnitySelectionne.Id), null).FirstOrDefault();

                        if (SubUnityExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Cette sous unité existe déjà pour cette faction et sous faction, veuillez en choisir une autre !");
                        }
                    }
                    // Si il est en ajout
                    else if (ficheSubUnity1.SubUnitySelectionne == null)
                    {
                        Charact CaractereExiste = Program.GMBD.EnumererCaractere(null,
                            new MyDB.CodeSql(@"JOIN subfaction ON subunity.su_fk_subfaction_id = subfaction.sf_id"),
                             new MyDB.CodeSql(@"WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1}
                                                AND subunity.su_name = {2} ",
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                            textBoxSousUnity.Text), null).FirstOrDefault();
                        if (CaractereExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Cette sous faction existe déjà pour cette faction et sous faction, veuillez en choisir une autre !");
                        }
                    }
                    break;
            }
        }

        /// <summary>
        /// Notifie l'encodeur des éventuelles réussites d'insertions
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurPrecedente"></param>
        /// <param name="ValeurActuelle"></param>
        private void SubUnityEnEdition_ApresChangement(SubUnity Entite, SubUnity.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {
                case SubUnity.Champ.Name:
                    if (ficheSubUnity1.SubUnitySelectionne != null)
                    {
                        ValidationProvider.SetError(textBoxSousUnity, "Votre sous unité a bien été modifié");
                    }
                    else if (ficheSubUnity1.SubUnitySelectionne == null)
                    {
                        ValidationProvider.SetError(textBoxSousUnity, "Votre caractère a bien été ajouté");
                    }

                    break;

            }
            buttonAjouterSubUnity.Enabled = m_SubUnityEnEdition.EstValide;
        }


        #endregion

        
    }

}
