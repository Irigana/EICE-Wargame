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


        public PageMaCollection()
        {
            InitializeComponent();
            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);
            listeDeroulanteFaction1.SurChangementSelection += ListeDeroulanteFaction_SurChangementSelection;
        }
            // Program.GMBD.MettreAJourListeSousFaction(listeDeroulanteSousFaction1);

        private void ListeDeroulanteFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSousFaction1.Enabled = true;
            listeDeroulanteSousFaction1.ResetTextSousFaction();
            Program.GMBD.MettreAJourListeSousFaction(listeDeroulanteSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
            listeDeroulanteSousFaction1.SurChangementSelection += ListeDeroulanteSousFaction_SurChangementSelection;
        }

        private void ListeDeroulanteSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
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
            listeDeroulanteSubUnity1.SubUnitySelectionnee.Unity = listeDeroulanteUnity1.UnitySelectionnee;
            listeDeroulanteCharRank1.Charact = Program.GMBD.EnumererPersonnage(null, new MyDB.CodeSql(@"JOIN charact ON char_rank.cr_fk_ch_id = charact.ch_id 
                                                                                                        JOIN rank ON char_rank.cr_fk_ra_id = rank.ra_id
                                                                                                        JOIN subunity ON char_rank.cr_sub_id = subunity.su_id    
                                                                                                        JOIN unity ON subunity.su_fk_unity_id = unity.un_id                                                                   
                                                                                                        JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                                                                                        JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),
                                                                                                    new MyDB.CodeSql(@"WHERE fa_id = {0} AND sf_id = {1}
                                                                                                                        AND un_id = {2} AND su_id = {3}",
                                                                                                             listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                                                                                                             listeDeroulanteUnity1.UnitySelectionnee.Id, listeDeroulanteSubUnity1.SubUnitySelectionnee.Id),
                                                                                                        MyDB.CreerCodeSql("ORDER BY ch_name"));
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

        private void labelFigurine_Click(object sender, EventArgs e)
        {

        }

        private void labelSubunity_Click(object sender, EventArgs e)
        {

        }

        private void ficheEquipement1_Load(object sender, EventArgs e)
        {

        }

        private void listeDeroulanteCharRank1_Load(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listeDeroulanteSubUnity1_Load(object sender, EventArgs e)
        {

        }

        private void listeDeroulanteRank1_Load(object sender, EventArgs e)
        {

        }

        private void listeDeroulanteUnity1_Load(object sender, EventArgs e)
        {

        }

        private void listeDeroulanteSousFaction1_Load(object sender, EventArgs e)
        {

        }

        private void listeDeroulanteFaction1_Load(object sender, EventArgs e)
        {

        }

        private void buttonOptionsUser1_Load(object sender, EventArgs e)
        {

        }

        private void labelMesFigurines_Click(object sender, EventArgs e)
        {

        }

        private void labelQuantite_Click(object sender, EventArgs e)
        {

        }

        private void labelEquipement_Click(object sender, EventArgs e)
        {

        }

        private void labelRang_Click(object sender, EventArgs e)
        {

        }

        private void labelUnity_Click(object sender, EventArgs e)
        {

        }

        private void labelSousFaction_Click(object sender, EventArgs e)
        {

        }

        private void labelFaction_Click(object sender, EventArgs e)
        {

        }

        private void panelLigneSeparatrice_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelMaCollection_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
