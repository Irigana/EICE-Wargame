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
    public partial class ListeDeroulanteScenario : UserControl
    {

        private class Element
        {

            public Scenario Scenario { get; private set; }

            public Element(Scenario Scenario)
            {
                this.Scenario = Scenario;
            }

            public override string ToString()
            {
                return Scenario.Name;
            }

            public override bool Equals(object obj)
            {
                return (obj is Element) ? Scenario.Equals((obj as Element).Scenario) : base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return Scenario.GetHashCode();
            }
        }

        public ListeDeroulanteScenario()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteScenario_SizeChanged;
            comboBoxScenario.SelectedIndexChanged += ComboScenario_SelectedIndexChanged;

            comboBoxScenario.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxScenario.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public IEnumerable<Scenario> Scenario
        {
            get
            {
                return comboBoxScenario.Items.OfType<Element>().Select(Element => Element.Scenario);
            }
            set
            {
                if (value != null)
                {
                    comboBoxScenario.Items.Clear();
                    foreach (Scenario Scenario in value)
                    {
                        comboBoxScenario.Items.Add(new Element(Scenario));
                    }
                    comboBoxScenario.Sorted = true;
                }
            }
        }

        public bool m_PerteScenario { get; private set; }

        public int SelectedIndexBystring(string ScenarioRechercher)
        {
            int ScenarioTrouve = 0;
            ScenarioTrouve = comboBoxScenario.FindStringExact(ScenarioRechercher);
            return comboBoxScenario.SelectedIndex = ScenarioTrouve;
        }

        public Scenario ScenarioSelectionnee
        {
            get
            {
                return (comboBoxScenario.SelectedItem is Element) ? (comboBoxScenario.SelectedItem as Element).Scenario : null;
            }
            set
            {
                comboBoxScenario.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboScenario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteScenario_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxScenario.Height);
        }

       

    }

}

