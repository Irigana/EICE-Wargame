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

        public PageSubUnity()
        {
            InitializeComponent();
            buttonAjouterSubUnity.Enabled = false;
            buttonAnnulerSubUnity.Enabled = false;
            buttonSupprimerSubUnity.Enabled = false;
            listeDeroulanteFaction1.Faction = Program.GMBD.EnumererFaction(null, null, null, null);
            listeDeroulanteFaction1.SurChangementSelection += ListeFaction_SurChangementSelection;
            listeDeroulanteSousFaction1.SurChangementSelection += ListeSousFaction_SurChangementSelection;

            listeDeroulanteSousFaction1.Enabled = true;
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
        }

        private void ListeSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            ficheSubUnity1.Enabled = true;
            ChargerFicheSansFiltre(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);

            ficheSubUnity1.SurChangementFiltre += (s, ev) =>
            {
                if (ficheSubUnity1.TexteFiltreSubUnity != "")
                {
                    // TODO : corriger cette requete et vérifier que surchangementselection n'est pas le problème sur ma page personnage
                    ficheSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null,
                    new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id
                                        JOIN charact ON subfaction.sf_id = charact.ch_fk_subfaction_id"),
                    new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1} AND ch_name LIKE {2}",
                    listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id,
                    string.Format(c_CritereQuiContient, ficheSubUnity1.TexteFiltreSubUnity)),
                    new MyDB.CodeSql("ORDER BY su_name"));
                }
                else
                {
                    ChargerFicheSansFiltre(listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);     
                }
            };
        }

        private void ChargerFicheSansFiltre(int IdSousFaction, int IdFaction)
        {
            ficheSubUnity1.SubUnity = Program.GMBD.EnumererSubUnity(null,
                   new MyDB.CodeSql(@"JOIN subfaction ON subfaction.sf_id = subunity.su_fk_subfaction_id"),
                   new MyDB.CodeSql("WHERE sf_fk_faction_id = {0} AND sf_id = {1}",
                   IdSousFaction, IdFaction),
                   new MyDB.CodeSql("ORDER BY su_name"));
        }

        private void FicheSousUnity_SurChangementSelection(object sender,EventArgs e)
        {

        }
    }
    
}
