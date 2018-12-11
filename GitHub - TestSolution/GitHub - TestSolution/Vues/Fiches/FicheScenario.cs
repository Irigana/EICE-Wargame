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
        private Scenario_Camp m_ScenarioLie;

        private int m_NumeroDeCamp;

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

        public int NumeroDeCamp
        {
            get
            {
                return m_NumeroDeCamp;
            }
            set
            {
                m_NumeroDeCamp = value;
            }
        }

        public List<Condi_Camp> ListeCondiCamp
        {
            get
            {
                return ficheSpecifiteScenario1.ListeCondiCamp;
            }
        }
        

        public FicheScenario()
        {
            InitializeComponent();

            listeDeroulanteUnity1.SurChangementSelection += ListeUnity_SurChangementSelection;
            

            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            ValidationProvider.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }

        public void ChargerFiches()
        {
            listeDeroulanteUnity1.Unity = Program.GMBD.EnumererUnity(null, null, null, new MyDB.CodeSql("ORDER BY un_name"));
            ficheSpecifiteScenario1.SpecifiteScenario = Program.GMBD.EnumererCondiCamp(null, new MyDB.CodeSql("JOIN scenario_camp ON cc_fk_scenario_camp_id = sca_id JOIN unity on cc_fk_unity_id = un_id"), new MyDB.CodeSql("WHERE scenario_camp.sca_fk_camp_id = {0} AND condi_camp.cc_fk_scenario_camp_id = {1}", NumeroDeCamp, Scenario.Id), null);
        }

        public void ChargerSpecificite()
        {
            ficheSpecifiteScenario1.SpecifiteScenario = Program.GMBD.EnumererCondiCamp(null, new MyDB.CodeSql("JOIN sceanario_camp ON cc_fk_scenario_camp_id = sca_id JOIN unity on cc_fk_unity_id = un_id"), new MyDB.CodeSql("WHERE scenario_camp.sca_fk_camp_id = {0} AND condi_camp.cc_fk_scenario_camp_id = {1}", NumeroDeCamp, Scenario.Id), null);       
        }

        public void ClearFiche()
        {
            ficheSpecifiteScenario1.NettoyerListView();
        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            Condi_Camp NouvelleSpecificite = new Condi_Camp();
            NouvelleSpecificite.SurErreur += Scenario_SurErreur;
            NouvelleSpecificite.Unity = listeDeroulanteUnity1.UnitySelectionnee;
            NouvelleSpecificite.Scenario_Camp = Program.GMBD.EnumererScenarioCamp(null, null, new MyDB.CodeSql("WHERE sca_fk_camp_id = {0}",NumeroDeCamp), null).FirstOrDefault();
            NouvelleSpecificite.Min = Convert.ToInt32(numericUpDownObligatoire.Value);
            NouvelleSpecificite.Max = Convert.ToInt32(numericUpDown2.Value);
            if (NouvelleSpecificite.EstValide && Program.GMBD.AjouterSpecificite(NouvelleSpecificite))
            {
                ChargerSpecificite();
                ValidationProvider.SetError(ficheSpecifiteScenario1, "Spécificité correctement rajoutée");
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

        private void Scenario_SurErreur(Condi_Camp Entite, Condi_Camp.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Condi_Camp.Champ.Min:
                    errorProvider1.SetError(numericUpDownObligatoire, MessageErreur);
                    break;
                case Condi_Camp.Champ.Max:
                    errorProvider1.SetError(numericUpDown2, MessageErreur);
                    break;
            }
            buttonAjouter.Enabled = false;
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
    }
}
