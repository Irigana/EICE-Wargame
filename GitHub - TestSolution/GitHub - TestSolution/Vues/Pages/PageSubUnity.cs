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
            listeDeroulanteUnity1.Enabled = false;


            listeDeroulanteFaction1.Faction = Program.GMBD.EnumererFaction(null, null, null, null);
            listeDeroulanteFaction1.SurChangementSelection += ListeFaction_SurChangementSelection;
            listeDeroulanteSousFaction1.SurChangementSelection += ListeSousFaction_SurChangementSelection;
            listeDeroulanteUnity1.SurChangementSelection += ListeDeroulanteUnity_SurChangementSelection;
            
            ficheSubUnity1.SurChangementSelection += FicheSousUnity_SurChangementSelection;

            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            ValidationProvider.Icon = Icon.FromHandle(ImageRessource.GetHicon());

        }

        private void ChargerSubSub(int IdFaction,int IdSousFaction,int IdUnity)
        {
            ficheSubSub1.SubSub = Program.GMBD.EnumererSubSub(null,
                    new MyDB.CodeSql(@"JOIN subunity ON sub_sub.ss_fk_su_id_master = subunity.su_id
                                       JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                    new MyDB.CodeSql("WHERE su_fk_unity_id = {0} AND su_fk_subfaction_id = {1} AND sf_fk_faction_id = {2}",
                    listeDeroulanteUnity1.UnitySelectionnee.Id,listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,listeDeroulanteFaction1.FactionSelectionnee.Id),
                    new MyDB.CodeSql("ORDER BY su_name"));
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
            if(listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                listeDeroulanteUnity1.Enabled = false;
                listeDeroulanteUnity1.ResetTextUnity();
                textBoxSousUnity.Enabled = false;
                ficheSubSub1.NettoyerListView();
                ficheSubSub1.Enabled = false;
                ficheSubUnity1.NettoyerListView();
                ficheSubUnity1.Enabled = false;
                ficheSubUnitySlave.Enabled = false;
                ficheSubUnitySlave.NettoyerListView();
                buttonAjouterSubUnity.Enabled = false;

                ficheSubUnitySlave.TexteFiltreSubUnity = "";
                ficheSubSub1.TexteFiltreSubSub = "";
                ficheSubUnity1.TexteFiltreSubUnity = "";
            }
        }

        private void ListeSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteUnity1.Enabled = true;
            listeDeroulanteUnity1.Unity = Program.GMBD.EnumererUnity(null, null,null, null);
            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {                
                listeDeroulanteUnity1.ResetTextUnity();
                textBoxSousUnity.Enabled = false;
                ficheSubSub1.NettoyerListView();
                ficheSubSub1.Enabled = false;
                ficheSubUnity1.NettoyerListView();
                ficheSubUnity1.Enabled = false;
                ficheSubUnitySlave.Enabled = false;
                ficheSubUnitySlave.NettoyerListView();
                buttonAjouterSubUnity.Enabled = false;
                ficheSubUnitySlave.TexteFiltreSubUnity = "";
                ficheSubSub1.TexteFiltreSubSub = "";
                ficheSubUnity1.TexteFiltreSubUnity = "";
            }
        }


        private void ListeDeroulanteUnity_SurChangementSelection(object sender,EventArgs e)
        {
            textBoxSousUnity.Enabled = true;
            ficheSubUnity1.Enabled = true;
            ficheSubSub1.Enabled = true;
            buttonAjouterSubUnity.Enabled = true;
            buttonModifier.Enabled = false;
            buttonSupprimerSubUnity.Enabled = false;
            ChargerFicheSansFiltre(ficheSubUnity1, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,listeDeroulanteUnity1.UnitySelectionnee.Id);

            ficheSubUnity1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheSubUnity1.TexteFiltreSubUnity != "")
                {
                    ficheSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null,
                    new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                    new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND su_name LIKE {2} AND subunity.su_fk_unity_id = {3} ",
                    listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                    string.Format(c_CritereQuiContient, ficheSubUnity1.TexteFiltreSubUnity), listeDeroulanteUnity1.UnitySelectionnee.Id),
                    new MyDB.CodeSql("ORDER BY su_name"));
                }
                else
                {
                    ChargerFicheSansFiltre(ficheSubUnity1,listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,listeDeroulanteUnity1.UnitySelectionnee.Id);
                }
            };

            ChargerFicheSansFiltre(ficheSubUnitySlave,listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
            ficheSubUnitySlave.SurChangementFiltre += (s, ev) =>
            {
                if (ficheSubUnitySlave.TexteFiltreSubUnity != "")
                {
                    ficheSubUnitySlave.SubUnity = Program.GMBD.EnumererSubUnity(null,
                    new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                    new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND su_name LIKE {2} AND subunity.su_fk_unity_id = {3}",
                    listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                    string.Format(c_CritereQuiContient, ficheSubUnitySlave.TexteFiltreSubUnity), listeDeroulanteUnity1.UnitySelectionnee.Id),
                    new MyDB.CodeSql("ORDER BY su_name"));
                }
                else
                {
                    ChargerFicheSansFiltre(ficheSubUnitySlave,listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
                }
            };


            ChargerSubSub(listeDeroulanteFaction1.FactionSelectionnee.Id,listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,listeDeroulanteUnity1.UnitySelectionnee.Id);

            ficheSubSub1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheSubSub1.TexteFiltreSubSub != "")
                {
                    ficheSubSub1.SubSub = Program.GMBD.EnumererSubSub(null,
                    new MyDB.CodeSql(@"JOIN subunity ON sub_sub.ss_fk_su_id_master  = subunity.su_id
                                       JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                    new MyDB.CodeSql(@"WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND su_name LIKE {2} AND subunity.su_fk_unity_id = {3}",
                    listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                    string.Format(c_CritereQuiContient, ficheSubSub1.TexteFiltreSubSub), listeDeroulanteUnity1.UnitySelectionnee.Id),
                    new MyDB.CodeSql("ORDER BY su_name"));
                }
                else
                {
                    ChargerSubSub(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
                }
            };

        }

        private void ChargerFicheSansFiltre(FicheSubUnity FicheSubUnity, int IdFaction, int IdSousFaction, int IdUnity)
        {
            FicheSubUnity.SubUnity = Program.GMBD.EnumererSubUnity(null,
                   new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                   new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND subunity.su_fk_unity_id = {2}",
                   IdFaction, IdSousFaction, IdUnity),
                   new MyDB.CodeSql("ORDER BY su_name"));
        }

        private void FicheSousUnity_SurChangementSelection(object sender,EventArgs e)
        {
            if (ficheSubUnity1.SubUnitySelectionne != null)
            {
                buttonAjouterSubUnity.Enabled = false;
                buttonAnnulerSubUnity.Enabled = true;
                buttonSupprimerSubUnity.Enabled = true;
                buttonModifier.Enabled = true;
                ficheSubUnitySlave.Enabled = true;
                buttonAttacher.Enabled = true;
                buttonDelier.Enabled = true;
                textBoxSousUnity.Text = ficheSubUnity1.SubUnitySelectionne.Name;

                
            }            
        }
        

        private void buttonAjouterSubUnity_Click(object sender, EventArgs e)
        {
            m_SubUnityEnEdition = new SubUnity();
            m_SubUnityEnEdition.SurErreur += SubUnityEnEdition_SurErreur;
            m_SubUnityEnEdition.AvantChangement += SubUnityEnEdition_AvantChangement;
            m_SubUnityEnEdition.ApresChangement += SubUnityEnEdition_ApresChangement;

            m_SubUnityEnEdition.Unity = listeDeroulanteUnity1.UnitySelectionnee;
            m_SubUnityEnEdition.Name = textBoxSousUnity.Text;
            m_SubUnityEnEdition.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
            if(m_SubUnityEnEdition.EstValide && Program.GMBD.AjouterSubUnity(m_SubUnityEnEdition))
            {
                textBoxSousUnity.Text = "";
                ChargerFicheSansFiltre(ficheSubUnity1, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
                ChargerFicheSansFiltre(ficheSubUnitySlave, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);

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
                m_SubUnityEnEdition.Unity = listeDeroulanteUnity1.UnitySelectionnee;
                if(m_SubUnityEnEdition.EstValide && Program.GMBD.ModifierSubUnity(m_SubUnityEnEdition))
                {
                    ChargerSubSub(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
                    ChargerFicheSansFiltre(ficheSubUnity1, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
                    ChargerFicheSansFiltre(ficheSubUnitySlave, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);

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
                        if (Program.GMBD.SupprimerSubUnity(ficheSubUnity1.SubUnitySelectionne))
                        {
                            ValidationProvider.SetError(textBoxSousUnity, "Votre sous unité a bien été supprimée");
                            ChargerFicheSansFiltre(ficheSubUnity1, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
                            ChargerFicheSansFiltre(ficheSubUnitySlave, listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);

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
            ficheSubUnity1.NettoyerListView();
            buttonAnnulerSubUnity.Enabled = false;
            buttonModifier.Enabled = false;
            buttonSupprimerSubUnity.Enabled = false;
            buttonAjouterSubUnity.Enabled = false;
            textBoxSousUnity.Text = "";
            buttonAttacher.Enabled = false;
            ficheSubUnitySlave.NettoyerListView();
            ficheSubUnitySlave.SubUnitySelectionne = null;
            listeDeroulanteUnity1.ResetTextUnity();
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
                            new MyDB.CodeSql(@"WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1} AND su_name = {2} AND su_id <> {3} AND subunity.su_fk_unity_id = {4}",
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                            textBoxSousUnity.Text, ficheSubUnity1.SubUnitySelectionne.Id, listeDeroulanteUnity1.UnitySelectionnee.Id), null).FirstOrDefault();

                        if (SubUnityExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Cette sous unité existe déjà pour cette faction et sous faction, veuillez en choisir une autre !");
                        }
                    }
                    // Si il est en ajout
                    else if (ficheSubUnity1.SubUnitySelectionne == null)
                    {
                        SubUnity SubUnityExiste = Program.GMBD.EnumererSubUnity(null,
                           new MyDB.CodeSql(@" JOIN subfaction ON subunity.su_fk_subfaction_id = subfaction.sf_id"),
                           new MyDB.CodeSql(@"WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1} AND su_name = {2} AND subunity.su_fk_unity_id = {3} ",
                           listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                           textBoxSousUnity.Text, listeDeroulanteUnity1.UnitySelectionnee.Id), null).FirstOrDefault();

                        if (SubUnityExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Cette sous unité existe déjà, veuillez en choisir une autre !");
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
            buttonAjouterSubUnity.Enabled = true;
        }



        #endregion

        private void textBoxSousUnity_Enter(object sender, EventArgs e)
        {
            errorProviderUnity.Clear();
            ValidationProvider.Clear();
        }

        private void buttonAttacher_Click(object sender, EventArgs e)
        {
            if((ficheSubUnity1.SubUnitySelectionne != null)&&(ficheSubUnitySlave.SubUnitySelectionne != null))
            {
                SubSub NouveauLien = new SubSub();
                NouveauLien.Master = ficheSubUnity1.SubUnitySelectionne;
                NouveauLien.Slave = ficheSubUnitySlave.SubUnitySelectionne;

                if (NouveauLien.EstValide && Program.GMBD.AjouterSubSub(NouveauLien))
                {
                    ChargerSubSub(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);                    
                }
            }
        }

        private void buttonDelier_Click(object sender, EventArgs e)
        {
            if(ficheSubSub1.SubSubSelectionne != null)
            {
                SubUnity SubUnityLie = Program.GMBD.EnumererSubUnity(null, null, new MyDB.CodeSql(" WHERE ((subunity.su_id IN(SELECT sub_sub.ss_fk_su_id_master FROM sub_sub)) AND (subunity.su_id NOT IN(SELECT char_rank.cr_sub_id FROM char_rank) AND subunity.su_id NOT IN (SELECT stuff_subunity.cfs_fk_subunity_id FROM stuff_subunity))AND (subunity.su_id = {0} OR subunity.su_id = {1}))", ficheSubSub1.SubSubSelectionne.Master.Id,ficheSubSub1.SubSubSelectionne.Slave.Id), null).FirstOrDefault();
                if (SubUnityLie == null)
                {
                    PopUpConfirmation FormConfirmation = new PopUpConfirmation();
                    FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer ce \nlien entre ces 2 sous unités ?";
                    FormConfirmation.ShowDialog();
                    if (FormConfirmation.Confirmation)
                    {
                        if (Program.GMBD.SupprimerSubSub(ficheSubSub1.SubSubSelectionne))
                        {
                            ValidationProvider.SetError(buttonDelier, "Votre lien entre les sous unité a bien été supprimée");
                            ChargerSubSub(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, listeDeroulanteUnity1.UnitySelectionnee.Id);
                        }
                    }
                    else if (FormConfirmation.Annulation)
                    {
                        // Ne rien faire
                    }
                }
                else
                {
                    errorProviderUnity.SetError(textBoxSousUnity, "Ces sous unité sont déjà utilisées, impossible de la supprimer avant de supprimer les élements attacher");
                }
            }
        }
    }

}
