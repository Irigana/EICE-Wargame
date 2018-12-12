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

        private Scenario_Camp m_ScenarioSecondCamp = null;

        private Scenario_Camp m_ScenarioEnEdition;
        

        public PageScenario()
        {
            InitializeComponent();
            menuAdmin1.MaPageActive = 1;
            buttonAjouter.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonUnCamp.Enabled = false;
            buttonDeuxCamp.Enabled = false;

            listeDeroulanteScenario1.Scenario = Program.GMBD.EnumererScenario(null, null, null, null);

            listeDeroulanteScenario1.SurChangementSelection += ListeDeroulanteScenario_SurChangementSelection;

            ficheScenarioCamp1.SurClickAjout += FicheScenarioCamp_SurClickAjout;
            ficheScenarioCamp2.SurClickAjout += FicheScenarioCamp_SurClickAjout;

            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            errorProviderValidation.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }

        private void FicheScenarioCamp_SurClickAjout(object sender, EventArgs e)
        {
            buttonUnCamp.Enabled = false;
            buttonDeuxCamp.Enabled = false;
            ficheScenarioCamp1.ValidationActive = true;
            ficheScenarioCamp2.ValidationActive = true;            
        }
        

        private void ListeDeroulanteScenario_SurChangementSelection(object sender, EventArgs e)
        {
            if (listeDeroulanteScenario1.ScenarioSelectionnee != null)
            {
                
                ficheScenarioCamp1.Enabled = true;
                ficheScenarioCamp1.DesactiverButtonSurSelection();
                ficheScenarioCamp2.DesactiverButtonSurSelection();
                buttonAjouter.Enabled = false;
                buttonSupprimer.Enabled = true;
                Scenario ScenarioEnEdition = listeDeroulanteScenario1.ScenarioSelectionnee;


                m_ScenarioCampUn = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id "),
                                                                                      new MyDB.CodeSql("WHERE scenario.sc_id = {0} ", listeDeroulanteScenario1.ScenarioSelectionnee.Id), null).FirstOrDefault();

               
                
                // Si il existe 2 camp
                if ((m_ScenarioCampUn.Camp.Id != 3))
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
                        ficheScenarioCamp1.Scenario = m_ScenarioCampUn;
                        ficheScenarioCamp1.ChargerFiches(1);

                        m_ScenarioSecondCamp = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                          new MyDB.CodeSql("WHERE scenario.sc_id = {0} AND camp.ca_id = {1}", listeDeroulanteScenario1.ScenarioSelectionnee.Id, 2), null).FirstOrDefault();

                        ficheScenarioCamp2.Scenario = m_ScenarioCampUn;
                        ficheScenarioCamp2.ChargerFiches(2);

                    }
                    // Si le camp déjà chargé correspond au camp 2 alors je charge le camp 1
                    else if (m_ScenarioCampUn.Camp.Id == 2)
                    {
                         ficheScenarioCamp1.Scenario = m_ScenarioCampUn;
                        ficheScenarioCamp1.ChargerFiches(2);
                        ficheScenarioCamp2.Enabled = true;
                        m_ScenarioSecondCamp = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                        JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id 
                                                                                                        JOIN condi_camp ON scenario_camp.sca_id = condi_camp.cc_fk_scenario_camp_id"),
                                                                                          new MyDB.CodeSql("WHERE scenario.sc_id = {0} AND camp.ca_id = {1}", listeDeroulanteScenario1.ScenarioSelectionnee.Id, 1), null).FirstOrDefault();

                        ficheScenarioCamp2.Scenario = m_ScenarioSecondCamp;
                        ficheScenarioCamp2.ChargerFiches(1);
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
                    ficheScenarioCamp1.Scenario = m_ScenarioCampUn;
                    ficheScenarioCamp1.ChargerFiches(3);
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
        
        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (ficheScenarioCamp2.Enabled == false)
            {
                buttonUnCamp.Enabled = true;
                buttonDeuxCamp.Enabled = true;
                m_ScenarioEnEdition = new Scenario_Camp();
                m_ScenarioEnEdition.Scenario = new Scenario();
                m_ScenarioEnEdition.Scenario.SurErreur += Scenario_SurErreur;
                m_ScenarioEnEdition.Scenario.AvantChangement += Scenario_AvantChangement;
                m_ScenarioEnEdition.Scenario.Name = textBox1.Text;
                if ((m_ScenarioEnEdition.Scenario.EstValide) && (Program.GMBD.AjouterScenario(m_ScenarioEnEdition.Scenario)))
                {
                    ficheScenarioCamp1.Scenario = m_ScenarioEnEdition;
                    listeDeroulanteScenario1.ScenarioSelectionnee = m_ScenarioEnEdition.Scenario;
                    buttonAjouter.Enabled = false;
                    buttonSupprimer.Enabled = true;
                    buttonAnnuler.Enabled = true;

                    errorProviderValidation.SetError(textBox1, "Votre scénario a été correctement rajouté, veuillez rajouter ses spécificitées");
                    
                    listeDeroulanteScenario1.Scenario = Program.GMBD.EnumererScenario(null, null, null, null);
                    listeDeroulanteScenario1.SurChangementSelection -= ListeDeroulanteScenario_SurChangementSelection;
                    listeDeroulanteScenario1.ScenarioSelectionnee = m_ScenarioEnEdition.Scenario;
                    listeDeroulanteScenario1.SurChangementSelection += ListeDeroulanteScenario_SurChangementSelection;
                    ficheScenarioCamp1.Scenario = m_ScenarioEnEdition;
                    ficheScenarioCamp2.Scenario = m_ScenarioEnEdition;
                    
                        
                                            
                }
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
            ficheScenarioCamp1.ClearFiche();
            ficheScenarioCamp2.ClearFiche();
            ficheScenarioCamp1.Enabled = false;
            ficheScenarioCamp2.Enabled = false;
            errorProvider.Clear();
            errorProviderValidation.Clear();      
            textBox1.Text = "";
            buttonAjouter.Enabled = true;
            buttonSupprimer.Enabled = false;
            buttonAnnuler.Enabled = false;
        }        

        private void buttonUnCamp_Click(object sender, EventArgs e)
        {
            ficheScenarioCamp1.UnCampOuDeux = false;
            labelCampNeutreOuAttaque.Text = "Camp neutre";
            labelCampDefense.Text = "";
            ficheScenarioCamp2.Enabled = false;
            ficheScenarioCamp1.Enabled = true;
            ficheScenarioCamp1.ChargerFiches(3);
            ficheScenarioCamp1.Scenario = m_ScenarioEnEdition;
        }

        private void buttonDeuxCamp_Click(object sender, EventArgs e)
        {
            
            ficheScenarioCamp1.UnCampOuDeux = true;
            ficheScenarioCamp2.UnCampOuDeux = true;
            labelCampNeutreOuAttaque.Text = "Camp attaquant";
            labelCampDefense.Text = "Camp défenseur";
            ficheScenarioCamp1.Enabled = true;
            ficheScenarioCamp2.Enabled = true;
            buttonUnCamp.Enabled = true;
            ficheScenarioCamp1.ChargerFiches(1);
            ficheScenarioCamp1.Scenario = m_ScenarioEnEdition;
            ficheScenarioCamp2.ChargerFiches(2);
            ficheScenarioCamp2.Scenario = m_ScenarioEnEdition;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            PopUpConfirmation FormConfirmation = new PopUpConfirmation();
            
            Army ScenarioLie = Program.GMBD.EnumererArmy(null, null, new MyDB.CodeSql("WHERE ar_fk_scenario_camp_id = {0}", listeDeroulanteScenario1.ScenarioSelectionnee.Id), null).FirstOrDefault();
            if (ScenarioLie == null)
            {
                FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer cet enregistrement ?";

                FormConfirmation.ShowDialog();
                // S'il accepte
                if (FormConfirmation.Confirmation)
                {
                    if ((listeDeroulanteScenario1.ScenarioSelectionnee != null) && (Program.GMBD.SupprimerScenarioCamp(m_ScenarioCampUn) && Program.GMBD.SupprimerScenarioCamp(m_ScenarioCampUn)))
                    {

                        listeDeroulanteScenario1.Scenario = Program.GMBD.EnumererScenario(null, null, null, null);
                        buttonAjouter.Enabled = true;
                        buttonAnnuler.Enabled = false;                        
                        buttonSupprimer.Enabled = false;
                        ficheScenarioCamp1.Enabled = false;
                        ficheScenarioCamp2.Enabled = false;
                        errorProviderValidation.SetError(textBox1, "Suppresion correctement effectuée");
                        textBox1.Text = "";
                        ficheScenarioCamp1.ClearFiche();
                        ficheScenarioCamp2.ClearFiche();
                    }
                }
                // S'il refuse
                else if (FormConfirmation.Annulation)
                {
                    // ne rien faire
                }
            }
            else
            {
                errorProvider.SetError(textBox1, "Ce scénario est utilisée par armée, veuillez la supprimer avant de supprimer ce scénario");
            }
        }
    }
}
