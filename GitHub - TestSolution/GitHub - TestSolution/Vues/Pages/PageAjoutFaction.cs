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
    public partial class PageAjoutFaction : UserControl
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

        public PageAjoutFaction()
        {
            InitializeComponent();
            m_Utilisateur = null;            
            //-------------------------
            buttonAnnulerSF.Enabled = false;
            buttonModifierSF.Enabled = false;
            buttonSupprimerSF.Enabled = false;
            buttonAjouterSF.Enabled = false;
            ficheSousFaction1.m_ActiverTextBox = false;
            //-------------------------

            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);
            listeDeroulanteFaction1.SurChangementSelection += ListeFactionSurSelectionFaction;      

            
            
        }

        private void ListeFactionSurSelectionFaction(object sender, EventArgs e)
        {
            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                m_FactionEnEdition = listeDeroulanteFaction1.FactionSelectionnee;
                ficheSousFaction1.m_ActiverTextBox = true;
                buttonAjouterSF.Enabled = true;
            }
            else if(listeDeroulanteFaction1.m_PerteFaction)
            {
                ficheSousFaction1.NettoyerListView();
                ficheSousFaction1.m_ActiverTextBox = false;
                buttonAjouterSF.Enabled = false;
                buttonAnnulerSF.Enabled = false;
                buttonModifierSF.Enabled = false;
                buttonSupprimerSF.Enabled = false;
            }

            //Charge mes sous factions en fonction du choix de faction de l'utilisateur
            
            ChargerSousFaction();
            

            //Partie sur les sous factions et son filtre
            ficheSousFaction1.ReactionEnDirectSurChangementFiltre = true;
            ficheSousFaction1.SurChangementFiltre += (s, ev) =>
            {
                if ((ficheSousFaction1.TexteDuFiltre != "")&&(listeDeroulanteFaction1.FactionSelectionnee != null))
                {
                    ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                        null,
                        null,
                        new MyDB.CodeSql("WHERE subfaction.sf_name LIKE {0} AND subfaction.sf_fk_faction_id = {1}",
                                         string.Format(c_CritereQuiContient, ficheSousFaction1.TexteDuFiltre), listeDeroulanteFaction1.FactionSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY sf_name"));
                    // Permet de récuperer le nombre d'enregistrement après le filtre
                    ficheSousFaction1.NombreDeSousFactionFiltre = ficheSousFaction1.SousFaction.Count();
                }
                else if (listeDeroulanteFaction1.FactionSelectionnee != null)
                {
                    ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                        null,null, 
                        new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY sf_name"));
                }
                
                /*
                if (ficheSousFaction1.NombreDeSousFactionFiltre == 0)
                {                    
                    buttonAjouterSF.Enabled = true;
                    buttonAnnulerSF.Enabled = true;
                    buttonModifierSF.Enabled = false;
                    buttonSupprimerSF.Enabled = false;
                }*/
            };
            ficheSousFaction1.SurChangementSelection += ficheSousFaction_SurChangementSelection;
            ficheSousFaction_SurChangementSelection(ficheSousFaction1, EventArgs.Empty);

        }

       

        private void ChargerSousFaction()
        {            
                ficheSousFaction1.SousFaction = Program.GMBD.EnumererSousFaction(
                 null,
                 null,
                 new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}", m_FactionEnEdition.Id),
                 new MyDB.CodeSql("ORDER BY sf_name"));
                   
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
            
            Faction FactionExiste = null;
            SousFaction NouvelleSousFaction = null;

            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                FactionExiste = Program.GMBD.EnumererFaction(null,
                                                             null,
                                                             new MyDB.CodeSql("WHERE faction.fa_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                                                             null).FirstOrDefault();
                // Si la faction n'existe pas, crée on une nouvelle faction
                if (FactionExiste != null)
                {
                    NouvelleSousFaction = new SousFaction();
                    NouvelleSousFaction.Faction = listeDeroulanteFaction1.FactionSelectionnee;
                    NouvelleSousFaction.Name = ficheSousFaction1.TexteDuFiltre;

                    if ((NouvelleSousFaction.EstValide) && (Program.GMBD.AjouterSousFaction(NouvelleSousFaction)))
                    {                                
                        Program.GMBD.MettreAJourFicheSousFaction(ficheSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);                                
                    }
                        
                }
            }
            ficheSousFaction1.TexteDuFiltre = "";
            buttonAnnulerSF.Enabled = false;
        }
     
        

        private void buttonAnnulerSF_Click(object sender, EventArgs e)
        {            
            //Pourquoi? - J'expliquerais Samedi , ça me semble inutile 
            ficheSousFaction1.TexteDuFiltre = "";
            buttonAjouterSF.Enabled = true;
            buttonAnnulerSF.Enabled = false;
            buttonModifierSF.Enabled = false;
            buttonSupprimerSF.Enabled = false;     
        }

        private void buttonModifierSF_Click(object sender, EventArgs e)
        {
            if(listeDeroulanteFaction1.FactionSelectionnee != null)
            {

                SousFaction SousFactionExistant = Program.GMBD.EnumererSousFaction(null, null, new PDSGBD.MyDB.CodeSql("WHERE sf_name = {0}", ficheSousFaction1.SousFactionSelectionne.Name), null).FirstOrDefault();
                if (SousFactionExistant == null)
                {
                    ficheSousFaction1.SetTextBoxErrorModification("Cette sous faction n'existe pas");
                }                
                else
                {
                    SousFaction m_SousFactionEnEdition = SousFactionExistant;
                    m_SousFactionEnEdition.Faction = m_FactionEnEdition;
                    if (string.Compare(ficheSousFaction1.TexteDuFiltre.ToString(), SousFactionExistant.Name.ToString()) != 0)
                    {
                        m_SousFactionEnEdition.Name = ficheSousFaction1.TexteDuFiltre;
                        if (!(Program.GMBD.ModifierSousFaction(m_SousFactionEnEdition)))
                        {
                            ficheSousFaction1.SetTextBoxErrorModification("Une erreur est survenue veuillez recommencer votre modification");
                        }
                        else
                        {
                            Program.GMBD.MettreAJourFicheSousFaction(ficheSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
                        }
                    }
                }
            }
        }        
    }
}
