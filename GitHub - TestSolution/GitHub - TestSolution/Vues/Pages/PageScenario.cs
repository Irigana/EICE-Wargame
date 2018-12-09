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
    public partial class PageScenario : UserControl
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

        private Scenario_Camp m_ScenarioCampUn;
        private bool m_ScenarioValide = false;

        public PageScenario()
        {
            InitializeComponent();
            menuAdmin1.MaPageActive = 1;
            buttonAjouter.Enabled = true;
            buttonModifier.Enabled = false;

            listeDeroulanteScenario1.Scenario = Program.GMBD.EnumererScenario(null, null, null, null);

            listeDeroulanteScenario1.SurChangementSelection += ListeDeroulanteScenario_SurChangementSelection;

        }

        private void ListeDeroulanteScenario_SurChangementSelection(object sender, EventArgs e)
        {
            if (listeDeroulanteScenario1.ScenarioSelectionnee != null)
            {
                int i = -1;
                buttonAjouter.Enabled = false;
                buttonModifier.Enabled = true;
                Scenario ScenarioEnEdition = listeDeroulanteScenario1.ScenarioSelectionnee;


                m_ScenarioCampUn = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                      new MyDB.CodeSql("WHERE scenario.sc_id = {0} ", listeDeroulanteScenario1.ScenarioSelectionnee.Id), null).FirstOrDefault();

                Scenario_Camp ScenarioSecondCamp = null;
                // Si il existe 2 camp
                if (m_ScenarioCampUn.Camp.Id != 3)
                {
                    textBox1.Text = m_ScenarioCampUn.Scenario.Name;
                    ficheScenarioCamp2.Enabled = true;
                    // Si le camp déjà chargé correspond au camp 1 alors je charge le camp 2
                    if (m_ScenarioCampUn.Camp.Id == 1)
                    {
                        i = 0;
                        ScenarioSecondCamp = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                          new MyDB.CodeSql("WHERE scenario.sc_id = {0} AND camp.ca_id = {1}", listeDeroulanteScenario1.ScenarioSelectionnee.Id, 2), null).FirstOrDefault();
                        #region Assignation des valeurs du camp 1
                        foreach (Condi_Camp CC in m_ScenarioCampUn.CondiCamp)
                        {
                            if (i == 0)
                            {
                                ficheScenarioCamp1.QG = CC.Min;
                            }
                            else if (i == 1)
                            {
                                ficheScenarioCamp1.Troupes = CC.Min;
                            }
                            else if (i == 2)
                            {
                                ficheScenarioCamp1.AttaqueRapide = CC.Min;
                            }
                            else if (i == 3)
                            {
                                ficheScenarioCamp1.Soutien = CC.Min;
                            }
                            else if (i == 4)
                            {
                                ficheScenarioCamp1.Elite = CC.Min;
                            }
                            else if (i == 5)
                            {
                                ficheScenarioCamp1.MQG = CC.Max;
                            }
                            else if (i == 6)
                            {
                                ficheScenarioCamp1.MTroupes = CC.Max;
                            }
                            else if (i == 7)
                            {
                                ficheScenarioCamp1.MAttaqueRapide = CC.Max;
                            }
                            else if (i == 8)
                            {
                                ficheScenarioCamp1.MSoutien = CC.Max;
                            }
                            else if (i == 9)
                            {
                                ficheScenarioCamp1.MElite = CC.Max;
                            }
                        }
                        #endregion

                        #region Assignation des valeurs du camp 2
                        foreach (Condi_Camp CC in ScenarioSecondCamp.CondiCamp)
                        {
                            if (i == 0)
                            {
                                ficheScenarioCamp2.QG = CC.Min;
                            }
                            else if (i == 1)
                            {
                                ficheScenarioCamp2.Troupes = CC.Min;
                            }
                            else if (i == 2)
                            {
                                ficheScenarioCamp2.AttaqueRapide = CC.Min;
                            }
                            else if (i == 3)
                            {
                                ficheScenarioCamp2.Soutien = CC.Min;
                            }
                            else if (i == 4)
                            {
                                ficheScenarioCamp2.Elite = CC.Min;
                            }
                            else if (i == 5)
                            {
                                ficheScenarioCamp2.MQG = CC.Max;
                            }
                            else if (i == 6)
                            {
                                ficheScenarioCamp2.MTroupes = CC.Max;
                            }
                            else if (i == 7)
                            {
                                ficheScenarioCamp2.MAttaqueRapide = CC.Max;
                            }
                            else if (i == 8)
                            {
                                ficheScenarioCamp2.MSoutien = CC.Max;
                            }
                            else if (i == 9)
                            {
                                ficheScenarioCamp2.MElite = CC.Max;
                            }
                        }
                        #endregion
                    }
                    // Si le camp déjà chargé correspond au camp 2 alors je charge le camp 1
                    else if (m_ScenarioCampUn.Camp.Id == 2)
                    {
                        i = 0;
                        ficheScenarioCamp2.Enabled = true;
                        ScenarioSecondCamp = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                          new MyDB.CodeSql("WHERE scenario.sc_id = {0} AND camp.ca_id = {1}", listeDeroulanteScenario1.ScenarioSelectionnee.Id, 1), null).FirstOrDefault();

                        #region Assignation des valeurs du camp 1
                        foreach (Condi_Camp CC in m_ScenarioCampUn.CondiCamp)
                        {
                            if (i == 0)
                            {
                                ficheScenarioCamp1.QG = CC.Min;
                            }
                            else if (i == 1)
                            {
                                ficheScenarioCamp1.Troupes = CC.Min;
                            }
                            else if (i == 2)
                            {
                                ficheScenarioCamp1.AttaqueRapide = CC.Min;
                            }
                            else if (i == 3)
                            {
                                ficheScenarioCamp1.Soutien = CC.Min;
                            }
                            else if (i == 4)
                            {
                                ficheScenarioCamp1.Elite = CC.Min;
                            }
                            else if (i == 5)
                            {
                                ficheScenarioCamp1.MQG = CC.Max;
                            }
                            else if (i == 6)
                            {
                                ficheScenarioCamp1.MTroupes = CC.Max;
                            }
                            else if (i == 7)
                            {
                                ficheScenarioCamp1.MAttaqueRapide = CC.Max;
                            }
                            else if (i == 8)
                            {
                                ficheScenarioCamp1.MSoutien = CC.Max;
                            }
                            else if (i == 9)
                            {
                                ficheScenarioCamp1.MElite = CC.Max;
                            }
                        }
                        #endregion

                        #region Assignation des valeurs du camp 2
                        foreach (Condi_Camp CC in ScenarioSecondCamp.CondiCamp)
                        {
                            if (i == 0)
                            {
                                ficheScenarioCamp2.QG = CC.Min;
                            }
                            else if (i == 1)
                            {
                                ficheScenarioCamp2.Troupes = CC.Min;
                            }
                            else if (i == 2)
                            {
                                ficheScenarioCamp2.AttaqueRapide = CC.Min;
                            }
                            else if (i == 3)
                            {
                                ficheScenarioCamp2.Soutien = CC.Min;
                            }
                            else if (i == 4)
                            {
                                ficheScenarioCamp2.Elite = CC.Min;
                            }
                            else if (i == 5)
                            {
                                ficheScenarioCamp2.MQG = CC.Max;
                            }
                            else if (i == 6)
                            {
                                ficheScenarioCamp2.MTroupes = CC.Max;
                            }
                            else if (i == 7)
                            {
                                ficheScenarioCamp2.MAttaqueRapide = CC.Max;
                            }
                            else if (i == 8)
                            {
                                ficheScenarioCamp2.MSoutien = CC.Max;
                            }
                            else if (i == 9)
                            {
                                ficheScenarioCamp2.MElite = CC.Max;
                            }
                        }
                        #endregion
                    }
                }
                // Sinon c'est un camp neutre donc 1 seul camp
                else
                {
                    labelCampNeutreOuAttaque.Text = "Camp neutre";
                    ficheScenarioCamp2.Enabled = false;
                    textBox1.Text = m_ScenarioCampUn.Scenario.Name;
                    i = 0;
                    foreach (Condi_Camp CC in m_ScenarioCampUn.CondiCamp)
                    {
                        if (i == 0)
                        {
                            ficheScenarioCamp1.QG = CC.Min;
                        }
                        else if (i == 1)
                        {
                            ficheScenarioCamp1.Troupes = CC.Min;
                        }
                        else if (i == 2)
                        {
                            ficheScenarioCamp1.AttaqueRapide = CC.Min;
                        }
                        else if (i == 3)
                        {
                            ficheScenarioCamp1.Soutien = CC.Min;
                        }
                        else if (i == 4)
                        {
                            ficheScenarioCamp1.Elite = CC.Min;
                        }
                        else if (i == 5)
                        {
                            ficheScenarioCamp1.MQG = CC.Max;
                        }
                        else if (i == 6)
                        {
                            ficheScenarioCamp1.MTroupes = CC.Max;
                        }
                        else if (i == 7)
                        {
                            ficheScenarioCamp1.MAttaqueRapide = CC.Max;
                        }
                        else if (i == 8)
                        {
                            ficheScenarioCamp1.MSoutien = CC.Max;
                        }
                        else if (i == 9)
                        {
                            ficheScenarioCamp1.MElite = CC.Max;
                        }
                    }
                }
            }
        }


        private void PageScenario_Load(object sender, EventArgs e)
        {
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;

            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié            
            if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;
        }

        private void buttonNouveauCamp_Click(object sender, EventArgs e)
        {
            labelCampNeutreOuAttaque.Text = "Attaque";
            labelCampDefense.Text = "Défense";
            ficheScenarioCamp2.Enabled = true;
            int test = ficheScenarioCamp1.QG;
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Scenario_Camp NouveauScenario = new Scenario_Camp();
            NouveauScenario.Scenario = new Scenario();
            NouveauScenario.Scenario.SurErreur += Scenario_SurErreur;
            NouveauScenario.Scenario.AvantChangement += Scenario_AvantChangement;
            NouveauScenario.Camp = Program.GMBD.EnumererCamp(null, null, new MyDB.CodeSql("WHERE ca_id = 3"), null).FirstOrDefault();
            if (ficheScenarioCamp2.Enabled == true)
            {
                if (Program.GMBD.AjouterScenario(NouveauScenario))
                {
                    Condi_Camp NouvelleSpecificite = new Condi_Camp();

                }
            }
        }



        private void Scenario_SurErreur(Scenario Entite, Scenario.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Scenario.Champ.Name:
                    m_ScenarioValide = false;
                    errorProvider.SetError(textBox1, MessageErreur);
                    break;
            }
            buttonAjouter.Enabled = false;
        }


        private void Scenario_AvantChangement(Scenario Entite, Scenario.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case Scenario.Champ.Name:
                    {
                        Scenario ScenarioExiste = Program.GMBD.EnumererScenario(null, null, new MyDB.CodeSql("WHERE sc_name = {0}", textBox1.Text), null).FirstOrDefault();
                        if (ScenarioExiste != null)
                        {
                            m_ScenarioValide = false;
                            AccumulateurErreur.NotifierErreur("Ce nom de scénario existe déjà, veuillez en choisir une autre !");
                        }
                        break;
                    }
            }
        }
        private void PersonnageEnEdition_AvantChangement(CharactRank Entite, CharactRank.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case CharactRank.Champ.Cost:
                    {
                        if ((Entite.Cost > int.MaxValue) || (Entite.Cost < 0))
                        {
                            AccumulateurErreur.NotifierErreur("Ce coût n'est pas correct, veuillez en choisir une autre !");
                        }
                        break;
                    }
            }
        }
    }
}
