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
    public partial class PageArmee : UserControl
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

        private Army m_Army;
        private ArmyUnity m_ArmyUnity;
        private ArmyUnityFigurine m_ArmyUnityFigurine;
        private Figurine m_Figurine;
        private FigurineStuff m_FigurineStuff;

        
        #endregion

        public PageArmee()
        {
            InitializeComponent();

            z_listeDeroulanteScenario.Scenario = Program.GMBD.EnumererScenario(null, null, null,
                                                    new MyDB.CodeSql("ORDER BY sc_name"));
            z_listeDeroulanteScenario.SurChangementSelection += Scenario_SurChangementSelection;
            
            //z_listeDeroulanteFigurine.SurChangementSelection += Figurine_SurChangementSelection;
        }

        private void Scenario_SurChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteCamp.Camp = Program.GMBD.EnumererCamp(null, new MyDB.CodeSql(@"
                                    JOIN scenario_camp ON scenario_camp.sca_fk_camp_id = camp.ca_id
                                    JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id AND scenario.sc_id = {0}",
                                    z_listeDeroulanteScenario.ScenarioSelectionnee.Id), null, null);
            z_listeDeroulanteCamp.SurChangementSelection += Camp_surChangementSelection;
        }


        private void Camp_surChangementSelection(object sender, EventArgs e)
        {
            // J'ai un condi_camp donc je vois quelles unity j'ai besoin
            z_listeDeroulanteFaction.Faction = Program.GMBD.EnumererFaction(null, null, null, new MyDB.CodeSql("ORDER BY fa_name"));
            z_listeDeroulanteFaction.SurChangementSelection += Faction_surChangementSelection;
        }

        private void Faction_surChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteSousFaction.SousFaction = Program.GMBD.EnumererSousFaction(null, null, 
                new MyDB.CodeSql("WHERE sf_fk_faction_id = {0}", z_listeDeroulanteFaction.FactionSelectionnee.Id),
                new MyDB.CodeSql("ORDER BY sf_name"));
            z_listeDeroulanteSousFaction.SurChangementSelection += SousFaction_surChangementSelection;
        }

        private void SousFaction_surChangementSelection(object sender, EventArgs e)
        {
            // Je dois afficher les unités qui sont dans condi_camp
            z_listeDeroulanteUnity.Unity = Program.GMBD.EnumererUnity(null, null, null, null);
            z_listeDeroulanteUnity.SurChangementSelection += Unity_surChangementSelection;
        }

        private void Unity_surChangementSelection(object sender, EventArgs e)
        {
            // J'affiche les subunity liées à cette unity
            z_listeDeroulanteSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null, null,
                new MyDB.CodeSql("WHERE su_fk_subfaction_id = {0} AND su_fk_unity_id = {1}", 
                z_listeDeroulanteSousFaction.SousFactionSelectionnee.Id, z_listeDeroulanteUnity.UnitySelectionnee.Id), null);
            z_listeDeroulanteSubUnity1.SurChangementSelection += Subunity_surChangementSelection;
        }

        private void Subunity_surChangementSelection(object sender, EventArgs e)
        {
            // J'affiche les characters qui vont dans cette subunity et dont l'user a une figurine
            z_listeDeroulanteChar.Charact = Program.GMBD.EnumererCaractere(new MyDB.CodeSql("DISTINCT ch_id, ch_name, ch_fk_subfaction_id"),
                new MyDB.CodeSql("JOIN figurine ON fi_fk_character_id = charact.ch_id"), new MyDB.CodeSql("WHERE fi_fk_user_id = {0}", Utilisateur.Id),
                new MyDB.CodeSql("ORDER BY ch_name"));

           z_listeDeroulanteChar.SurChangementSelection += Charact_surChangementSelection;
        }

        private void Charact_surChangementSelection(object sender, EventArgs e)
        {
            // J'affiche les équipements que cette figurine a
            z_listeDeroulanteStuff.Stuff = Program.GMBD.EnumererStuff(new MyDB.CodeSql("DISTINCT st_id, st_name, st_fk_type_id, st_visibility"),
                new MyDB.CodeSql(@"JOIN figurine_stuff ON stuff.st_id = figurine_stuff.fs_fk_stuff_id
                                    JOIN figurine ON figurine_stuff.fs_fk_figurine_id = figurine.fi_id AND figurine.fi_fk_user_id = {0}
                                    JOIN charact ON charact.ch_id = figurine.fi_fk_character_id AND ch_id = {1}", Utilisateur.Id, z_listeDeroulanteChar.CharactSelectionnee.Id),null,null);

            // J'obtiens la figurine
            m_Figurine = Program.GMBD.EnumererFigurine(null, null,
                new MyDB.CodeSql("WHERE fi_fk_character_id = {0} AND fi_fk_user_id = {1}", z_listeDeroulanteChar.CharactSelectionnee.Id, Utilisateur.Id,
                z_listeDeroulanteCamp.CampSelectionnee.Id), null).FirstOrDefault();
            
            z_listeDeroulanteStuff.SurChangementSelection += Stuff_SurChangementSelection;
            
        }

        private void Stuff_SurChangementSelection(object sender, EventArgs e)
        {
            // J'ai le stuff de la figurine
            // Je dois faire un figurinestuff?
            m_FigurineStuff = new FigurineStuff();
            m_FigurineStuff = Program.GMBD.EnumererFigurineStuff(null, null,
                new MyDB.CodeSql("WHERE fs_fk_figurine_id = {0} AND fs_fk_stuff_id",m_Figurine.Id, z_listeDeroulanteStuff.StuffSelectionnee.Id), null).FirstOrDefault();

            z_listeDeroulanteRank.Rank = Program.GMBD.EnumererRank(new MyDB.CodeSql("DISTINCT rank.ra_id, rank.ra_name"), 
                new MyDB.CodeSql(@"JOIN char_rank ON char_rank.cr_fk_ra_id = rank.ra_id  AND char_rank.cr_fk_ch_id = {0} 
                                    JOIN stuff_char_rank ON stuff_char_rank.scr_fk_char_rank_id = char_rank.cr_id 
                                    JOIN figurine ON figurine.fi_fk_character_id = 60 AND figurine.fi_fk_user_id = {1} ", 
                                    z_listeDeroulanteChar.CharactSelectionnee.Id, Utilisateur.Id),
                new MyDB.CodeSql("WHERE stuff_char_rank.scr_fk_stuff_id = {0}", z_listeDeroulanteStuff.StuffSelectionnee.Id), null);
            z_listeDeroulanteRank.SurChangementSelection += Rank_SurChangementSelection;
        }

        private void Rank_SurChangementSelection(object sencder, EventArgs e)
        {
            StuffCharactRank SCR = new StuffCharactRank();
            SCR = Program.GMBD.EnumererStuffCharactRank(new MyDB.CodeSql("DISTINCT stuff_char_rank.scr_id, stuff_char_rank.scr_fk_stuff_id, stuff_char_rank.scr_fk_char_rank_id, stuff_char_rank.scr_cost, stuff_char_rank.scr_min, stuff_char_rank.scr_max"),
                new MyDB.CodeSql(@"JOIN char_rank ON char_rank.cr_id = stuff_char_rank.scr_fk_char_rank_id
                                    JOIN rank ON char_rank.cr_fk_ra_id = rank.ra_id And rank.ra_id = {0}
                                    JOIN figurine ON figurine.fi_fk_character_id = {1} AND figurine.fi_fk_user_id = {2}",
                                    z_listeDeroulanteRank.RankSelectionnee.Id, z_listeDeroulanteChar.CharactSelectionnee.Id, Utilisateur.Id),
                new MyDB.CodeSql("WHERE stuff_char_rank.scr_fk_stuff_id = {0} AND char_rank.cr_fk_ch_id = {1}", 
                        z_listeDeroulanteStuff.StuffSelectionnee.Id, z_listeDeroulanteChar.CharactSelectionnee.Id), null).FirstOrDefault();

            z_textBox.Text = SCR.Cout.ToString();
        }

        private void z_buttonAjoutArmee_Click(object sender, EventArgs e)
        {
            Scenario_Camp SC = new Scenario_Camp();
            SC = Program.GMBD.EnumererScenarioCamp(null, null,
                new MyDB.CodeSql("WHERE sca_fk_scenario_id = {0} AND sca_fk_camp_id = {1}", z_listeDeroulanteScenario.ScenarioSelectionnee.Id,
                z_listeDeroulanteCamp.CampSelectionnee.Id), null).FirstOrDefault();
            if (SC != null)
            {
                m_Army = new Army();
                m_Army.Name = z_textBoxName.Text;
                m_Army.ScenarioCamp = SC;
                m_Army.Utilisateur = Utilisateur;
                m_Army.PointsMaximum = Convert.ToInt32(z_textBoxPointsMax.Text);

                Army ArmyExiste = null;
                ArmyExiste = Program.GMBD.EnumererArmy(null,
                                                            null,
                                                            new MyDB.CodeSql("WHERE ar_name = {0}", m_Army.Name),
                                                            null).FirstOrDefault();
                if (ArmyExiste == null)
                {
                    if(m_Army.Enregistrer(Program.GMBD.BD, m_Army))
                    {
                        m_ArmyUnity = new ArmyUnity();
                        m_ArmyUnity.Army = m_Army;
                    }
                    // Validation OK
                }
                else
                {
                    // faire qqch
                }


            }
        }

        private void q_buttonAjouter_Click(object sender, EventArgs e)
        {
            m_ArmyUnityFigurine = new ArmyUnityFigurine();
            m_ArmyUnityFigurine.ArmyUnity = m_ArmyUnity;
            m_ArmyUnityFigurine.Figurine = m_Figurine;
            m_ArmyUnityFigurine.Enregistrer(Program.GMBD.BD, m_ArmyUnityFigurine);
        }

        private void print_button_click(object sender, EventArgs e)
        {
            Form_Principal.Instance.CreerPageCourante<PageImpressionCarteUnite>((Page) =>
            {
                Page.Utilisateur = Utilisateur;
                return true;
            });
        }
    }
}
