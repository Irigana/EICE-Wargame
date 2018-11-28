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
    public partial class PageCaractere : UserControl
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

        private Charact m_CaractereEnEdition;

        public PageCaractere()
        {
            InitializeComponent();

            buttonAnnulerCaract.Enabled = false;
            buttonModifierCaract.Enabled = false;
            buttonSupprimerCaract.Enabled = false;
            buttonAjouterCaract.Enabled = false;
            ficheCaractere1.Enabled = false;
            menuAdmin1.MaPageActive = 2;            

            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);

            m_CaractereEnEdition = new Charact();
            /*
            m_CaractereEnEdition.SurErreur += CaractereEnEdition_SurErreur;
            m_CaractereEnEdition.AvantChangement += CaractereEnEdition_AvantChangement;
            m_CaractereEnEdition.ApresChangement += CaractereEnEdition_ApresChangement;
            */


            ficheCaractere1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheCaractere1.TexteDuFiltre != "")
                {
                    ficheCaractere1.Caractere = Program.GMBD.EnumererCaractere(
                        null,
                        null,
                        new MyDB.CodeSql("WHERE charact.ch_name LIKE {0}",
                                         string.Format(c_CritereQuiContient, ficheCaractere1.TexteDuFiltre)),
                        new MyDB.CodeSql("ORDER BY charact.ch_name"));
                }
                else
                {
                    ChargerCaractere();
                }


            };

            listeDeroulanteFaction1.SurChangementSelection += ListeDeroulanteFaction_SurChangementSelection;
            //Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            //ValidationProvider.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }

        private void ChargerCaractere()
        {
            Program.GMBD.EnumererCaractere(null, null, null, new MyDB.CodeSql("ORDER BY ch_name"));
        }

        private void ListeDeroulanteFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSousFaction1.Enabled = true;
            Program.GMBD.MettreAJourListeSousFaction(listeDeroulanteSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
            listeDeroulanteSousFaction1.SurChangementSelection += ListeDeroulanteSousFaction_SurChangementSelection;
        }

        private void ListeDeroulanteSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            ficheCaractere1.Enabled = true;
            ficheCaractere1.Caractere = Program.GMBD.EnumererCaractere(new MyDB.CodeSql("*"),
                new MyDB.CodeSql("JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),
                new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1}", listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id)
                                                                        ,new MyDB.CodeSql("ORDER BY ch_name"));
            listeDeroulanteSousFaction1.SurChangementSelection += ficheFaction_SurChangementSelection;

        }

        private void ficheFaction_SurChangementSelection(object sender, EventArgs e)
        {
            if ((ficheCaractere1.CaractereSelectionne != null)&&(listeDeroulanteFaction1.FactionSelectionnee != null) &&(listeDeroulanteSousFaction1.SousFactionSelectionnee !=null))
            {
                
                buttonAjouterCaract.Enabled = false;
                buttonAnnulerCaract.Enabled = true;
                buttonModifierCaract.Enabled = true;
                buttonSupprimerCaract.Enabled = true;

                ficheCaractere1.ActiverTextBox = true;
                textBoxCaractere.Text = ficheCaractere1.CaractereSelectionne.Name;

                errorProviderErreurCaractere.Clear();
                ValidationProvider.Clear();
            }
            else
            {
                buttonAjouterCaract.Enabled = true;
                buttonAnnulerCaract.Enabled = false;
                buttonModifierCaract.Enabled = false;
                buttonSupprimerCaract.Enabled = false;
            }

       }
       
        private void PageCaractere_Load(object sender, EventArgs e)
        {
             // Permet de passer l'utilisateur par le controler MenuAdmin
             menuAdmin1.Utilisateur = Utilisateur;

            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié            
            if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;
            
        }
    }   
}
