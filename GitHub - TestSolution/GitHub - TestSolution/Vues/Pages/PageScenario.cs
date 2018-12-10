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

        public PageScenario()
        {
            InitializeComponent();
            menuAdmin1.MaPageActive = 1;
            buttonAjouter.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonNouveauCamp.Enabled = false;
            buttonRetirerCamp.Enabled = false;

            listeDeroulanteScenario1.Scenario = Program.GMBD.EnumererScenario(null, null, null, null);

            listeDeroulanteScenario1.SurChangementSelection += ListeDeroulanteScenario_SurChangementSelection;

        }

        private void ListeDeroulanteScenario_SurChangementSelection(object sender, EventArgs e)
        {
            if (listeDeroulanteScenario1.ScenarioSelectionnee != null)
            {
                ficheScenarioCamp1.Enabled = true;
                ficheScenarioCamp1.DesactiverButtonSurSelection();
                ficheScenarioCamp2.DesactiverButtonSurSelection();
                buttonNouveauCamp.Enabled = false;
                buttonAjouter.Enabled = false;
                buttonSupprimer.Enabled = true;
                Scenario ScenarioEnEdition = listeDeroulanteScenario1.ScenarioSelectionnee;


                m_ScenarioCampUn = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenareio ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                      new MyDB.CodeSql("WHERE scenario.sc_id = {0} ", listeDeroulanteScenario1.ScenarioSelectionnee.Id), null).FirstOrDefault();



                Scenario_Camp ScenarioSecondCamp = null;
                // Si il existe 2 camp
                if (m_ScenarioCampUn.Camp.Id != 3)
                {

                    labelCampNeutreOuAttaque.Text = "Camp attaquant";

                    labelCampDefense.Text = "Camp défenseur";
                    ficheScenarioCamp2.ClearFiche();
                    ficheScenarioCamp1.ClearFiche();
                    textBox1.Text = m_ScenarioCampUn.Scenario.Name;
                    ficheScenarioCamp2.Enabled = true;
                    // Si le camp déjà chargé correspond au camp 1 alors je charge le camp 2
                    if (m_ScenarioCampUn.Camp.Id == 1)
                    {
                        ficheScenarioCamp1.NumeroDeCamp = 1;
                        ficheScenarioCamp1.Scenario = m_ScenarioCampUn.Scenario;
                        ficheScenarioCamp1.ChargerFiches();

                        ScenarioSecondCamp = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                          new MyDB.CodeSql("WHERE scenario.sc_id = {0} AND camp.ca_id = {1}", listeDeroulanteScenario1.ScenarioSelectionnee.Id, 2), null).FirstOrDefault();

                        ficheScenarioCamp2.NumeroDeCamp = 2;
                        ficheScenarioCamp2.Scenario = m_ScenarioCampUn.Scenario;
                        ficheScenarioCamp2.ChargerFiches();

                    }
                    // Si le camp déjà chargé correspond au camp 2 alors je charge le camp 1
                    else if (m_ScenarioCampUn.Camp.Id == 2)
                    {
                        ficheScenarioCamp1.NumeroDeCamp = 1;
                        ficheScenarioCamp1.Scenario = m_ScenarioCampUn.Scenario;
                        ficheScenarioCamp1.ChargerFiches();
                        ficheScenarioCamp2.Enabled = true;
                        ScenarioSecondCamp = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                          new MyDB.CodeSql("WHERE scenario.sc_id = {0} AND camp.ca_id = {1}", listeDeroulanteScenario1.ScenarioSelectionnee.Id, 1), null).FirstOrDefault();

                        ficheScenarioCamp2.NumeroDeCamp = 2;
                        ficheScenarioCamp2.Scenario = ScenarioSecondCamp.Scenario;
                        ficheScenarioCamp2.ChargerFiches();
                    }
                }
                // Sinon c'est un camp neutre donc 1 seul camp
                else
                {
                    labelCampDefense.Text = "";
                    labelCampNeutreOuAttaque.Text = "Camp neutre";
                    ficheScenarioCamp2.Enabled = false;
                    textBox1.Text = m_ScenarioCampUn.Scenario.Name;
                    ficheScenarioCamp2.ClearFiche();
                    ficheScenarioCamp1.NumeroDeCamp = 3;
                    ficheScenarioCamp1.Scenario = m_ScenarioCampUn.Scenario;
                    ficheScenarioCamp1.ChargerFiches();
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
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (ficheScenarioCamp1.AuMoinsUneSpecificite == true)
            {
                ficheScenarioCamp1.Enabled = true;
                Scenario_Camp NouveauScenario = new Scenario_Camp();
                NouveauScenario.Scenario = new Scenario();
                NouveauScenario.Scenario.SurErreur += Scenario_SurErreur;
                NouveauScenario.Scenario.AvantChangement += Scenario_AvantChangement;
                NouveauScenario.Scenario.Name = textBox1.Text;
                NouveauScenario.Camp = Program.GMBD.EnumererCamp(null, null, new MyDB.CodeSql("WHERE ca_id = 3"), null).FirstOrDefault();
                if (NouveauScenario.Scenario.EstValide && Program.GMBD.AjouterScenario(NouveauScenario.Scenario))
                {
                    if ((NouveauScenario.EstValide) && (Program.GMBD.AjouterScenarioCamp(NouveauScenario)))
                    {
                        ficheScenarioCamp1.Scenario = NouveauScenario.Scenario;
                        ficheScenarioCamp2.Scenario = NouveauScenario.Scenario;
                        if (ficheScenarioCamp2.Enabled == false)
                        {
                            ficheScenarioCamp1.NumeroDeCamp = 3;
                        }
                        else
                        {
                            ficheScenarioCamp1.NumeroDeCamp = 1;
                            ficheScenarioCamp2.NumeroDeCamp = 2;
                        }
                        //if(NouvelleSpecificite.EstValide && Program.GMBD.AjouterSpecificite(NouvelleSpecificite))
                        {

                        }
                    }
                }
            }
            else
            {
                errorProvider.SetError(textBox1, "Vous devez au moins ajouter une spécificité à ce scénario avant de pouvoir l'ajouter");
            }            
        }



        private void Scenario_SurErreur(Scenario Entite, Scenario.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Scenario.Champ.Name:
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

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            listeDeroulanteScenario1.ScenarioSelectionnee = null;
            textBox1.Text = "";
            buttonAjouter.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonAnnuler.Enabled = false;
        }

        private void buttonRetirerCamp_Click(object sender, EventArgs e)
        {
            labelCampNeutreOuAttaque.Text = "Camp neutre";
            labelCampDefense.Text = "";
            ficheScenarioCamp2.Enabled = false;
            ficheScenarioCamp2.ClearFiche();
        }
    }
}
