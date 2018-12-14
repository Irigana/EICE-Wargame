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

        public const int MonUser = 27;
        #endregion

        public PageArmee()
        {
            InitializeComponent();
            
            z_listeDeroulanteChar.Charact = Program.GMBD.EnumererCaractere(new MyDB.CodeSql("DISTINCT ch_id, ch_name, ch_fk_subfaction_id"),
                new MyDB.CodeSql("JOIN figurine ON fi_fk_character_id = charact.ch_id"), new MyDB.CodeSql("WHERE fi_fk_user_id = {0}", MonUser),
                new MyDB.CodeSql("ORDER BY ch_name"));
            z_listeDeroulanteChar.SurChangementSelection += Charact_surChangementSelection;
            //z_listeDeroulanteFigurine.SurChangementSelection += Figurine_SurChangementSelection;
        }

        private void Charact_surChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteStuff.Stuff = Program.GMBD.EnumererStuff(new MyDB.CodeSql("DISTINCT st_id, st_name, st_fk_type_id, st_visibility"),
                new MyDB.CodeSql(@"JOIN figurine_stuff ON stuff.st_id = figurine_stuff.fs_fk_stuff_id
                                    JOIN figurine ON figurine_stuff.fs_fk_figurine_id = figurine.fi_id AND figurine.fi_fk_user_id = {0}
                                    JOIN charact ON charact.ch_id = figurine.fi_fk_character_id AND ch_id = {1}", MonUser, z_listeDeroulanteChar.CharactSelectionnee.Id),null,null);
            z_listeDeroulanteStuff.SurChangementSelection += Stuff_SurChangementSelection;
            
        }

        private void Stuff_SurChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteRank.Rank = Program.GMBD.EnumererRank(new MyDB.CodeSql("DISTINCT rank.ra_id, rank.ra_name"), 
                new MyDB.CodeSql(@"JOIN char_rank ON char_rank.cr_fk_ra_id = rank.ra_id  AND char_rank.cr_fk_ch_id = {0} 
                                    JOIN stuff_char_rank ON stuff_char_rank.scr_fk_char_rank_id = char_rank.cr_id 
                                    JOIN figurine ON figurine.fi_fk_character_id = 60 AND figurine.fi_fk_user_id = {1} ", 
                                    z_listeDeroulanteChar.CharactSelectionnee.Id, MonUser),
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
                                    z_listeDeroulanteRank.RankSelectionnee.Id, z_listeDeroulanteChar.CharactSelectionnee.Id, MonUser),
                new MyDB.CodeSql("WHERE stuff_char_rank.scr_fk_stuff_id = {0} AND char_rank.cr_fk_ch_id = {1}", 
                        z_listeDeroulanteStuff.StuffSelectionnee.Id, z_listeDeroulanteChar.CharactSelectionnee.Id), null).FirstOrDefault();

            z_textBox.Text = SCR.Cout.ToString();
        }
    }
}
