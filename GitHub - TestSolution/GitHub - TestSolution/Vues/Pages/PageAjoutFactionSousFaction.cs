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
    public partial class PageAjoutFactionSousFaction : UserControl
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

        private Faction m_FactionEnEdition;

        public PageAjoutFactionSousFaction()
        {
            InitializeComponent();
            m_Utilisateur = null;

            //-------------------------
            buttonAnnulerFaction.Enabled = false;
            buttonModifierFaction.Enabled = false;
            buttonSupprimerFaction.Enabled = false;
            //-------------------------
            buttonAnnulerSF.Enabled = false;
            buttonModifierSF.Enabled = false;
            buttonSupprimerSF.Enabled = false;
            //-------------------------

            listeDeroulanteFaction1.Faction = Program.GMBD.EnumererFaction(null,
                                                                           null,
                                                                           null,
                                                                           new MyDB.CodeSql(" ORDER BY fa_name"));
            listeDeroulanteFaction1.SurChangementSelection += ListeFactionSurSelectionFaction;      

            
            
        }

        private void ListeFactionSurSelectionFaction(object sender, EventArgs e)
        {
            buttonAnnulerFaction.Enabled = true;
            buttonModifierFaction.Enabled = true;
            buttonSupprimerFaction.Enabled = true;
            m_FactionEnEdition = listeDeroulanteFaction1.FactionSelectionnee;
            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                textBoxFaction.Text = listeDeroulanteFaction1.FactionSelectionnee.Name;
            }
            
            IU.Initialiser(listViewSousFactions, "Sous faction");
            IU.Remplir(listViewSousFactions, Program.GMBD.EnumererSousFaction(null,
                                                                                new MyDB.CodeSql("WHERE sf_fk_faction_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                                                                                new MyDB.CodeSql("ORDER BY sf_name"),null),
                   SousFaction => new string[]
                   {
                            SousFaction.Name
                   });            

        }

        private void PageAjoutFactionSousFaction_Load(object sender, EventArgs e)
        {
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
        }

        private void listViewSousFactions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void listViewSousFactions_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            
        }
    }
}
