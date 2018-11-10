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


        private const string c_CritereQuiContient = "%{0}%";        

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

            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);
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

            //Charge mes sous factions en fonction du choix de faction de l'utilisateur
            ChargerSousFaction();

            //Partie sur les sous factions et son filtre
            ficheSousFaction1.ReactionEnDirectSurChangementFiltre = true;
            ficheSousFaction1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheSousFaction1.TexteDuFiltre != "")
                {


                    ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                        null,
                        null,
                        new MyDB.CodeSql("WHERE subfaction.sf_name LIKE {0} AND subfaction.sf_fk_faction_id = {1}",
                                         string.Format(c_CritereQuiContient, ficheSousFaction1.TexteDuFiltre), listeDeroulanteFaction1.FactionSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY subfaction.sf_name"));
                    // Permet de récuperer le nombre d'enregistrement après le filtre
                    ficheSousFaction1.NombreDeSousFactionFiltre = ficheSousFaction1.SousFaction.Count();
                }
                else
                {
                    ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                        null,null, 
                        new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY subfaction.sf_name"));
                }

                if (ficheSousFaction1.NombreDeSousFactionFiltre == 0)
                {

                    buttonAjouterSF.Enabled = true;
                    buttonAnnulerSF.Enabled = true;
                    buttonModifierSF.Enabled = false;
                    buttonSupprimerSF.Enabled = false;
                }
            };
            ficheSousFaction1.SurChangementSelection += ficheSousFaction_SurChangementSelection;
            ficheSousFaction_SurChangementSelection(ficheSousFaction1, EventArgs.Empty);

        }

        private void ChargerFaction()
        {

        }

        private void ChargerSousFaction()
        {
            ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                null,
                null,
                new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}",listeDeroulanteFaction1.FactionSelectionnee.Id),
                null);
        }

        /// <summary>
        /// Permet de modifier l'affichage du formulaire en fonction du choix de l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ficheSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            if (ficheSousFaction1.SousFactionSelectionne != null)
            {                                
                buttonAjouterSF.Enabled = false;
                buttonAnnulerSF.Enabled = true;
                buttonModifierSF.Enabled = true;
                buttonSupprimerSF.Enabled = true;
                ficheSousFaction1.TexteDuFiltre = ficheSousFaction1.SousFactionSelectionne.Name;             
            }
        }

        private void PageAjoutFactionSousFaction_Load(object sender, EventArgs e)
        {
            // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
        }

        private void buttonAjouterSF_Click(object sender, EventArgs e)
        {
            if ((listeDeroulanteFaction1.FactionSelectionnee != null) && (ficheSousFaction1.NombreDeSousFactionFiltre == 0))
            {

            }
            else if ((listeDeroulanteFaction1.FactionSelectionnee == null) && (textBoxFaction.Text.Length > 1))
            {
                Faction FactionExiste = Program.GMBD.EnumererFaction(null,
                                                                           null,
                                                                           new MyDB.CodeSql("WHERE faction.fa_name = {0}", textBoxFaction.Text),
                                                                           null/*new MyDB.CodeSql(" ORDER BY fa_name") ASK*/).FirstOrDefault();
                // Si la faction n'existe pas, crée on une nouvelle faction
                if (FactionExiste == null)
                {

                    Faction NouvelleFaction = new Faction();
                    NouvelleFaction.Name = textBoxFaction.Text;
                    if (NouvelleFaction.EstValide)
                    {
                        // Si l'ajout a fonctionné et que l'id est plus grand que 0                                                                    
                        if ((Program.GMBD.AjouterFaction(NouvelleFaction)) && (NouvelleFaction.Id > 0))
                        {
                            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);
                            listeDeroulanteFaction1.SelectedIndex(NouvelleFaction.Id);
                            // Maintenant que la faction est ajouté on récupere son id pour construire la nouvelle sous faction attaché à cette faction
                            SousFaction NouvelleSousFaction = new SousFaction();
                            NouvelleSousFaction.Faction = NouvelleFaction;
                            NouvelleSousFaction.Name = ficheSousFaction1.TexteDuFiltre;
                            if (NouvelleSousFaction.EstValide)
                            {
                                if(Program.GMBD.AjouterSousFaction(NouvelleSousFaction))
                                {
                                    Program.GMBD.MettreAJourFicheSousFaction(ficheSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
                                }
                            }
                        }
                    }
                }
            }
        }

        private void buttonAjoutFaction_Click(object sender, EventArgs e)
        {

        }
    }
}
