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
    public partial class FicheScenario : UserControl
    {
        private bool m_ValidationActive;

        private Scenario_Camp m_ScenarioLie;
        
        private bool m_UnCampOudeux;     

        public bool ValidationActive
        {
            get
            {
                return m_ValidationActive;
            }
            set
            {
                if(m_ValidationActive != value)
                {
                    m_ValidationActive = value;
                }
            }
        }

        /// <summary>
        /// False == 1 camp, true == 2
        /// </summary>
        public bool UnCampOuDeux
        {
            private get
            {
                return m_UnCampOudeux;
            }
            set
            {
                m_UnCampOudeux = value;
            }
        }
        
        public Scenario_Camp Scenario
        {
            get
            {
                return m_ScenarioLie;
            }
            set
            {
                m_ScenarioLie = value;
            }
        }
        
        

        public FicheScenario()
        {
            InitializeComponent();
            buttonAjouter.Enabled = true;
            buttonAnnuler.Enabled = false;
            buttonSupprimer.Enabled = false;
            listeDeroulanteUnity1.SurChangementSelection += ListeUnity_SurChangementSelection;

            ficheSpecifiteScenario1.SurChangementSelection += Specificite_SurChangementSelection;

            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            ValidationProvider.Icon = Icon.FromHandle(ImageRessource.GetHicon());            
        }

        public void Specificite_SurChangementSelection(object sender, EventArgs e)
        {
            buttonAjouter.Enabled = false;
            buttonSupprimer.Enabled = true;
            buttonAnnuler.Enabled = true;
            if (ficheSpecifiteScenario1.SpecificiteSelectionne != null)
            {
                listeDeroulanteUnity1.UnitySelectionnee = ficheSpecifiteScenario1.SpecificiteSelectionne.Unity;
                numericUpDownObligatoire.Value = ficheSpecifiteScenario1.SpecificiteSelectionne.Min;
                numericUpDown2.Value = ficheSpecifiteScenario1.SpecificiteSelectionne.Max;
            }
        }

        public void ChargerFiches(int NumeroDuCamp)
        {
            listeDeroulanteUnity1.Unity = Program.GMBD.EnumererUnity(null, null, null, new MyDB.CodeSql("ORDER BY un_name"));
            ficheSpecifiteScenario1.SpecifiteScenario = Program.GMBD.EnumererCondiCamp(null, new MyDB.CodeSql("JOIN scenario_camp ON cc_fk_scenario_camp_id = sca_id JOIN unity on cc_fk_unity_id = un_id"), new MyDB.CodeSql("WHERE scenario_camp.sca_fk_camp_id = {0} AND scenario_camp.sca_fk_scenario_id =  {1}", NumeroDuCamp, Scenario.Scenario.Id), null);

        }

        public void ChargerSpecificite(int NumeroDuCamp)
        {
            ficheSpecifiteScenario1.SpecifiteScenario = Program.GMBD.EnumererCondiCamp(null, new MyDB.CodeSql("JOIN scenario_camp ON cc_fk_scenario_camp_id = sca_id JOIN unity on cc_fk_unity_id = un_id"), new MyDB.CodeSql("WHERE scenario_camp.sca_fk_camp_id = {0} AND scenario_camp.sca_fk_scenario_id = {1}", NumeroDuCamp, Scenario.Scenario.Id), null);

        }

        public void ClearFiche()
        {
            ficheSpecifiteScenario1.NettoyerListView();
            numericUpDownObligatoire.Value = 0;
            numericUpDown2.Value = 0;
            listeDeroulanteUnity1.UnitySelectionnee = null;
            errorProvider1.Clear();
            ValidationProvider.Clear();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une armée n'est pas lié au scénario pour empêcher des erreurs dans une armée
            Army ScenarioLie = Program.GMBD.EnumererArmy(null, null, new MyDB.CodeSql("WHERE ar_fk_scenario_camp_id = {0}", Scenario.Id), null).FirstOrDefault();
            if (ScenarioLie == null)
            {
                Scenario_Camp ScenarioCompletExiste = null;
                if (UnCampOuDeux == false)
                {
                    ScenarioCompletExiste = Program.GMBD.EnumererScenarioCamp(null, null, new MyDB.CodeSql("WHERE sca_fk_scenario_id = {0} AND sca_fk_camp_id = {1}", Scenario.Scenario.Id, 3), null).FirstOrDefault();

                    if (ScenarioCompletExiste == null)
                    {
                        Scenario.Camp = Program.GMBD.EnumererCamp(null, null, new MyDB.CodeSql("WHERE ca_id = 3"), null).FirstOrDefault();
                        if ((Scenario.EstValide) && (Program.GMBD.AjouterScenarioCamp(Scenario)))
                        {
                            if (!m_ValidationActive)
                            {
                                buttonAjouter.Click -= buttonAjouter_Click;
                                SurClickAjout_Click(this, null);
                            }
                            RajouterNouvelleSpecificite(3);
                        }
                        else
                        {

                            // Supprime le scénario initialement crée, étant donné qu'un scénario ne peut être construit sans scénario camp
                            Program.GMBD.SupprimerScenario(Scenario.Scenario);
                        }
                    }
                    else if (this.Name.ToString() == "ficheScenarioCamp1")
                    {
                        RajouterNouvelleSpecificite(3);
                    }

                    ScenarioCompletExiste = null;
                }
                else if (UnCampOuDeux == true)
                {
                    ScenarioCompletExiste = Program.GMBD.EnumererScenarioCamp(null, null, new MyDB.CodeSql("WHERE sca_fk_scenario_id = {0} AND sca_fk_camp_id = {1}", Scenario.Scenario.Id, 1), null).FirstOrDefault();

                    if (ScenarioCompletExiste == null)
                    {
                        //Rajoute le premier camp
                        Scenario.Camp = Program.GMBD.EnumererCamp(null, null, new MyDB.CodeSql("WHERE ca_id = 1"), null).FirstOrDefault();
                        if ((Scenario.EstValide) && (Program.GMBD.AjouterScenarioCamp(Scenario)))
                        {
                            ScenarioCompletExiste = Program.GMBD.EnumererScenarioCamp(null, null, new MyDB.CodeSql("WHERE sca_fk_scenario_id = {0} AND sca_fk_camp_id = {1}", Scenario.Scenario.Id, 2), null).FirstOrDefault();
                            if (ScenarioCompletExiste == null)
                            {
                                Scenario_Camp ScenarioCampDefense = new Scenario_Camp();
                                ScenarioCampDefense.Scenario = Scenario.Scenario;
                                ScenarioCampDefense.Camp = Program.GMBD.EnumererCamp(null, null, new MyDB.CodeSql("WHERE ca_id = 2"), null).FirstOrDefault();
                                // Rajoute le deuxième camp
                                if ((ScenarioCampDefense.EstValide) && (Program.GMBD.AjouterScenarioCamp(ScenarioCampDefense)))
                                {
                                    if (this.Name.ToString() == "ficheScenarioCamp1")
                                    {
                                        RajouterNouvelleSpecificite(2);
                                    }
                                    else if (this.Name.ToString() == "ficheScenarioCamp2")
                                    {
                                        RajouterNouvelleSpecificite(1);
                                    }

                                    if (!m_ValidationActive)
                                    {
                                        buttonAjouter.Click -= buttonAjouter_Click;
                                        SurClickAjout_Click(this, null);
                                    }

                                }
                                else
                                {
                                    // Supprime le scénario camp d'avant si celui ci ne fonctionne pas et que l'autre a été ajouté
                                    Program.GMBD.SupprimerScenarioCamp(Scenario);
                                }
                            }
                            else
                            {
                                Program.GMBD.SupprimerScenarioCamp(Scenario);
                            }
                        }
                        else
                        {
                            // Supprime le scénario initialement crée, étant donné qu'un scénario ne peut être construit sans scénario camp
                            Program.GMBD.SupprimerScenario(Scenario.Scenario);
                        }
                    }
                    else if (this.Name.ToString() == "ficheScenarioCamp1")
                    {
                        RajouterNouvelleSpecificite(2);
                    }
                    else if (this.Name.ToString() == "ficheScenarioCamp2")
                    {
                        RajouterNouvelleSpecificite(1);
                    }
                }



               
            }     
        }

        private void RajouterNouvelleSpecificite(int NumeroDuCamp)
        {
            Condi_Camp NouvelleSpecificite = new Condi_Camp();
            NouvelleSpecificite.SurErreur += Specificite_SurErreur;
            NouvelleSpecificite.AvantChangement += Specificite_AvantChangement;
            NouvelleSpecificite.Unity = listeDeroulanteUnity1.UnitySelectionnee;            
            NouvelleSpecificite.Scenario_Camp = Program.GMBD.EnumererScenarioCamp(null, new MyDB.CodeSql(@"JOIN scenario ON scenario.sc_id = scenario_camp.sca_fk_scenario_id 
                                                                                                            JOIN camp ON camp.ca_id = scenario_camp.sca_fk_camp_id "),
                                                                                      new MyDB.CodeSql("WHERE scenario.sc_id = {0} AND camp.ca_id = {1}", Scenario.Scenario.Id, NumeroDuCamp), null).FirstOrDefault();
            NouvelleSpecificite.Min = Convert.ToInt32(numericUpDownObligatoire.Value);
            NouvelleSpecificite.Max = Convert.ToInt32(numericUpDown2.Value);
            Condi_Camp SpecificiteExiste = Program.GMBD.EnumererCondiCamp(null, null, new MyDB.CodeSql("WHERE cc_fk_scenario_camp_id = {0} AND cc_fk_unity_id = {1}", NouvelleSpecificite.Scenario_Camp.Id, NouvelleSpecificite.Unity.Id),null).FirstOrDefault();
            if (SpecificiteExiste == null)
            {
                if (NouvelleSpecificite.EstValide && Program.GMBD.AjouterSpecificite(NouvelleSpecificite))
                {
                    ChargerSpecificite(NumeroDuCamp);
                    ValidationProvider.SetError(ficheSpecifiteScenario1, "Spécificité correctement rajoutée");
                }
            }
            else
            {
                errorProvider1.SetError(listeDeroulanteUnity1, "Cette spécificté existe déjà pour ce camp");
            }
        }

        private void ListeUnity_SurChangementSelection(object sender, EventArgs e)
        {
            buttonAjouter.Enabled = true;
        }

        public void DesactiverButtonSurSelection()
        {
            buttonAjouter.Enabled = false;
            buttonSupprimer.Enabled = false;
        }

        private void Specificite_SurErreur(Condi_Camp Entite, Condi_Camp.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Condi_Camp.Champ.Min:
                    errorProvider1.SetError(numericUpDownObligatoire, MessageErreur);
                    break;
                case Condi_Camp.Champ.Max:
                    errorProvider1.SetError(numericUpDown2, MessageErreur);
                    break;
                case Condi_Camp.Champ.Unity:
                    errorProvider1.SetError(listeDeroulanteUnity1, MessageErreur);
                    break;
            }
            buttonAjouter.Enabled = false;
        }

        private void Specificite_AvantChangement(Condi_Camp Specificite, Condi_Camp.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case Condi_Camp.Champ.Unity:
                    {
                        Condi_Camp SpecificiteExiste = Program.GMBD.EnumererCondiCamp(null, null,
                                                                                      new MyDB.CodeSql("WHERE cc_fk_scenario_camp_id = {0} AND cc_fk_unity_id = {1}", Scenario.Id, listeDeroulanteUnity1.UnitySelectionnee.Id), null).FirstOrDefault();
                        if (SpecificiteExiste != null)
                        {
                            ValidationProvider.Clear();
                            AccumulateurErreur.NotifierErreur("Cette spécificité existe déjà, veuillez en choisir une autre ou modifier l'existante !");
                        }
                        break;
                    }
            }
        }

        private void numericUpDownObligatoire_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ValidationProvider.Clear();
        }

        private void numericUpDown2_Enter(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            ValidationProvider.Clear();
        }

        public event EventHandler SurClickAjout = null;

        private void SurClickAjout_Click(object sender, EventArgs e)
        {
            
            m_ValidationActive = true;
            SurClickAjout(this, EventArgs.Empty);
            buttonAjouter.Click -= SurClickAjout_Click;
            buttonAjouter.Click += buttonAjouter_Click;
        }

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {
            PopUpConfirmation FormConfirmation = new PopUpConfirmation();

            Army ScenarioLie = Program.GMBD.EnumererArmy(null, null, new MyDB.CodeSql("WHERE ar_fk_scenario_camp_id = {0}", Scenario.Id), null).FirstOrDefault();
            if (ScenarioLie == null)
            {
                FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer cet enregistrement ?";

                FormConfirmation.ShowDialog();
                // S'il accepte
                if (FormConfirmation.Confirmation)
                {
                    if ((ficheSpecifiteScenario1.SpecificiteSelectionne != null) && (Program.GMBD.SupprimerSpecificite(ficheSpecifiteScenario1.SpecificiteSelectionne)))
                    {
                        ChargerSpecificite(Scenario.Camp.Id);
                        buttonAjouter.Enabled = true;
                        buttonSupprimer.Enabled = false;                        
                        ValidationProvider.SetError(ficheSpecifiteScenario1, "Suppresion correctement effectuée");                        
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
                errorProvider1.SetError(ficheSpecifiteScenario1, "Ce scénario est utilisée par armée, veuillez la supprimer avant de supprimer une spécifitée");
            }
        }

        private void buttonModifier_Click(object sender, EventArgs e)
        {

        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            ficheSpecifiteScenario1.SpecificiteSelectionne = null;
            buttonAnnuler.Enabled = false;
            buttonAjouter.Enabled = true;
            buttonSupprimer.Enabled = false;
        }
        
    }
}
