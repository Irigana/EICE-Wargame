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

    public partial class PageMaCollection : UserControl
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

        public PageMaCollection()
        {
            InitializeComponent();
            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);
            listeDeroulanteFaction1.SurChangementSelection += ListeDeroulanteFaction_SurChangementSelection;
            listeDeroulanteSousFaction1.Enabled = false;
            listeDeroulanteUnity1.Enabled = false;
            listeDeroulanteSubUnity1.Enabled = false;
            listeDeroulanteChar1.Enabled = false;
            ficheEquipementSansRecherche1.Enabled = false;
            ficheEquipementSurFigurine1.Enabled = false;
        }

        private void ListeDeroulanteFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSousFaction1.Enabled = true;
            listeDeroulanteSousFaction1.ResetTextSousFaction();
            Program.GMBD.MettreAJourListeSousFaction(listeDeroulanteSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
            listeDeroulanteSousFaction1.SurChangementSelection += ListeDeroulanteSousFaction_SurChangementSelection;
        }

        private void ListeDeroulanteSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteUnity1.Enabled = true;
            listeDeroulanteUnity1.Unity = Program.GMBD.EnumererUnity(null, null, null, MyDB.CreerCodeSql("un_name"));
            listeDeroulanteUnity1.SurChangementSelection += ListeDeroulanteUnity_SurChangementSelection;
        }

        private void ListeDeroulanteUnity_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSubUnity1.Enabled = true;
            listeDeroulanteSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null, null, new MyDB.CodeSql("WHERE su_fk_unity_id = {0}", listeDeroulanteUnity1.UnitySelectionnee.Id),
                                                                                          new MyDB.CodeSql("ORDER BY su_name"));
            listeDeroulanteSubUnity1.SurChangementSelection += ListeDeroulanteSubUnity_SurChangementSelection;
        }

        private void ListeDeroulanteSubUnity_SurChangementSelection(object sender, EventArgs e)
        {
            //TODO FILTRER SUR LA FACTION - SOUS FACTION
            listeDeroulanteChar1.Enabled = true;
            listeDeroulanteSubUnity1.SubUnitySelectionnee.Unity = listeDeroulanteUnity1.UnitySelectionnee;
            listeDeroulanteChar1.Charact = Program.GMBD.EnumererCaractere(null, new MyDB.CodeSql(@"JOIN char_rank ON char_rank.cr_fk_ch_id = charact.ch_id 
                                                                                                   JOIN rank ON char_rank.cr_fk_ra_id = rank.ra_id 
                                                                                                   JOIN subunity ON char_rank.cr_sub_id = subunity.su_id 
                                                                                                   JOIN unity ON subunity.su_fk_unity_id = unity.un_id 
                                                                                                   JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id 
                                                                                                   JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),
                                                                                                    new MyDB.CodeSql(@"WHERE fa_id = {0} AND sf_id = {1}
                                                                                                                        AND un_id = {2} AND su_id = {3}",
                                                                                                             listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                                                                                                             listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                                                                                                    new MyDB.CodeSql(@"GROUP BY ch_id ORDER BY ch_name"));
            // ici tu réagis au moment de ta selection comme tu as fais au dessus pour aller dans ta méthode
            listeDeroulanteChar1.SurChangementSelection += ListeDeroulanteChar_SurChangementSelection;
        }

        private void ListeDeroulanteChar_SurChangementSelection(object sender, EventArgs e)
        {
            ficheEquipementSansRecherche1.Enabled = true;
            ficheEquipementSansRecherche1.Equipement = Program.GMBD.EnumererStuff(
                        null,
                        new MyDB.CodeSql(@"JOIN stuff_char_rank ON scr_fk_stuff_id = st_id
                                           JOIN char_rank ON scr_fk_char_rank_id = cr_id
                                           JOIN charact ON cr_fk_ch_id = ch_id"),
                       new MyDB.CodeSql("WHERE ch_id = {0}", listeDeroulanteChar1.CharactSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY st_name"));
        }

        private void FicheFigurineStuff_SurChangementSelection(object sender, EventArgs e)
        {
            ficheEquipementSurFigurine1.Enabled = true;
            ficheEquipementSansRecherche1.Enabled = true;
            if (ficheFigurineStuff1.FigurineSelectionne != null)
            {
                ficheEquipementSurFigurine1.Equipement = Program.GMBD.EnumererStuff(null,
                                                                                    new MyDB.CodeSql("JOIN figurine_stuff on fs_fk_stuff_id = st_id"),
                                                                                    new MyDB.CodeSql("WHERE fs_fk_figurine_id = {0}", ficheFigurineStuff1.FigurineSelectionne.Id),
                                                                                    new MyDB.CodeSql("ORDER BY st_name"));

                ficheEquipementSansRecherche1.Equipement = Program.GMBD.EnumererStuff(null,                                                                                       
                                                                                      new MyDB.CodeSql(@"JOIN stuff_char_rank ON scr_fk_stuff_id = st_id
                                                                                                         JOIN char_rank ON scr_fk_char_rank_id = cr_id
                                                                                                         JOIN charact ON cr_fk_ch_id = ch_id"),
                                                                                      new MyDB.CodeSql("WHERE ch_id = {0}", ficheFigurineStuff1.FigurineSelectionne.Charact.Id),
                                                                                      new MyDB.CodeSql("ORDER BY st_name"));
            }

        }

        private void buttonReturn_Click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageMenuPrincipal>(
                        (Page) =>
                        {
                            Page.Utilisateur = Utilisateur;
                            return true;
                        });
        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void AjoutEquipementSurFigurine(object sender, EventArgs e)
        {
          //  if ((ficheEquipementSansRecherche1.EquipementSelectionne != null) && (ficheFigurineStuff1.FigurineSelectionne != null))
           // {
            FigurineStuff NouvelleFigurineStuff = new FigurineStuff();
            // NouvelleFigurine.SurErreur += FigurineEnEdition_SurErreur;
            // NouvelleFigurine.AvantChangement += FigurineEnEdition_AvantChangement;
            // NouvelleFigurine.ApresChangement += FigurineEnEdition_ApresChangement;
            NouvelleFigurineStuff.Figurine = ficheFigurineStuff1.FigurineSelectionne;
            NouvelleFigurineStuff.Stuff = ficheEquipementSansRecherche1.EquipementSelectionne;
            if ((NouvelleFigurineStuff.EstValide) && Program.GMBD.AjouterFigurineStuff(NouvelleFigurineStuff))
            {
                ficheEquipementSurFigurine1.Equipement = Program.GMBD.EnumererStuff(null,
                                                                                    new MyDB.CodeSql("JOIN figurine_stuff on fs_fk_stuff_id = st_id"),
                                                                                    new MyDB.CodeSql("WHERE fs_fk_figurine_id = {0}", ficheFigurineStuff1.FigurineSelectionne.Id),
                                                                                    new MyDB.CodeSql("ORDER BY st_name"));
            }
            //}
        }

        private void EnleverEquipementSurFigurine(object sender, EventArgs e)
        {
            if ((ficheEquipementSurFigurine1.EquipementSelectionne != null) && (ficheFigurineStuff1.FigurineSelectionne != null))
            {
                FigurineStuff FigurineStuff = new FigurineStuff();
                FigurineStuff.Stuff = ficheEquipementSansRecherche1.EquipementSelectionne;
                FigurineStuff.Figurine = ficheFigurineStuff1.FigurineSelectionne;
                FigurineStuff.Supprimer(Program.GMBD.BD, FigurineStuff);
            }
        }

        //Reste du boulot ICI en dessous ! 
        #region Caractère en édition
        /// <summary>
        /// Methode permettant de réagir sur l'erreur d'un ajout ou d'une édition de caractère
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="MessageErreur"></param>
//        private void FigurineEnEdition_SurErreur(Charact Entite, Charact.Champ Champ, string MessageErreur)
//        {
//            switch (Champ)
//            {
//                case Charact.Champ.Name:
//              //      errorProviderErreurFigurine.SetError(textBoxFigurine, MessageErreur);
//                    break;
//            }
//            buttonAjouterPersonnage.Enabled = false;
//        }
        #endregion


        private void buttonCréerFigurine_Click(object sender, EventArgs e)
        {
            Faction FactionExiste = null;
            SousFaction SousFactionExiste = null;

            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                FactionExiste = Program.GMBD.EnumererFaction(null,
                                                             null,
                                                             new MyDB.CodeSql("WHERE faction.fa_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                                                             null).FirstOrDefault();
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
                                if ((UnityExiste != null) && (listeDeroulanteSubUnity1.SubUnitySelectionnee != null))
                                {

                                    SubUnity SubUnityExiste = Program.GMBD.EnumererSubUnity(null,
                                                                                            new MyDB.CodeSql(@"JOIN unity ON subunity.su_fk_unity_id = unity.un_id
                                                                                                                "),
                                                                                            new MyDB.CodeSql(" WHERE un_id = {0} AND su_id = {1}",
                                                                                            listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                                                                                            null).FirstOrDefault();
                                    if (SubUnityExiste != null)
                                    {
                                        if (listeDeroulanteChar1.CharactSelectionnee != null)
                                        {
                                            Charact CharactExiste = Program.GMBD.EnumererCaractere(null,
                                                                                                   new MyDB.CodeSql(@"JOIN char_rank on cr_fk_ch_id = ch_id
                                                                                                                      JOIN subunity on cr_sub_id = su_id"),
                                                                                                   new MyDB.CodeSql(" WHERE ch_id = {0} AND su_id = {1}",
                                                                                                   listeDeroulanteChar1.CharactSelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                                                                                                   null).FirstOrDefault();
                                            if(CharactExiste != null)
                                            {
                                                Figurine NouvelleFigurine = new Figurine();
                                                // NouvelleFigurine.SurErreur += FigurineEnEdition_SurErreur;
                                                // NouvelleFigurine.AvantChangement += FigurineEnEdition_AvantChangement;
                                                // NouvelleFigurine.ApresChangement += FigurineEnEdition_ApresChangement;
                                                NouvelleFigurine.Charact = listeDeroulanteChar1.CharactSelectionnee;
                                                NouvelleFigurine.Utilisateur = Utilisateur;
                                                if((NouvelleFigurine.EstValide) && Program.GMBD.AjouterFigurine(NouvelleFigurine))
                                                {
                                                      Program.GMBD.MettreAJourFicheFigurine(ficheFigurineStuff1, Utilisateur.Id);
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void MaCollectionONLoad(object sender, EventArgs e)
        {
            Program.GMBD.MettreAJourFicheFigurine(ficheFigurineStuff1, Utilisateur.Id);
        }
    }
}