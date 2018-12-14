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
        #endregion

        public PageArmee()
        {
            InitializeComponent();
            int MonUser = 22;
            // Je teste la figurine qui a plusieurs stuffs
            z_listeDeroulanteFigurine.Figurine = Program.GMBD.EnumererFigurine(null, null,
                new MyDB.CodeSql("WHERE fi_fk_user_id = 22"), null);

            z_listeDeroulanteFigurine.SurChangementSelection += Figurine_SurChangementSelection;
        }

        private void Figurine_SurChangementSelection(object sender, EventArgs e)
        {
            z_listeDeroulanteStuff.Stuff = Program.GMBD.EnumererStuff(null,
                new MyDB.CodeSql(@"JOIN figurine_stuff ON stuff.st_id = figurine_stuff.fs_fk_stuff_id
                                    JOIN figurine ON figurine_stuff.fs_fk_figurine_id = figurine.fi_id AND figurine.fi_fk_user_id = 22
                                    JOIN charact ON charact.ch_id = figurine.fi_fk_character_id"),null,null);
        }
        
    }
}
