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
    public partial class ListeDeroulanteFaction : UserControl
    {

        private class Element
        {

            public Faction Faction { get; private set; }

            public Element(Faction Faction)
            {
                this.Faction = Faction;
            }

            public override string ToString()
            {
                return Faction.Name;
            }

        }

        public ListeDeroulanteFaction()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteFaction_SizeChanged;
            comboBoxListeFaction.SelectedIndexChanged += ComboFaction_SelectedIndexChanged;
        }        

        public IEnumerable<Faction> Faction
        {
            get
            {
                return comboBoxListeFaction.Items.OfType<Element>().Select(Element => Element.Faction);
            }
            set
            {
                if (value != null)
                {
                    comboBoxListeFaction.Items.Clear();
                    foreach (Faction Faction in value)
                    {
                        comboBoxListeFaction.Items.Add(new Element(Faction));
                    }
                    comboBoxListeFaction.Sorted = true;
                }
            }
        }

        public int SelectedIndexBystring(string FactionRechercher)
        {
            int FactionTrouve = 0;
            FactionTrouve = comboBoxListeFaction.FindStringExact(FactionRechercher);
            return comboBoxListeFaction.SelectedIndex = FactionTrouve;
        }

        public Faction FactionSelectionnee
        {
            get
            {
                return (comboBoxListeFaction.SelectedItem is Element) ? (comboBoxListeFaction.SelectedItem as Element).Faction : null;
            }
            set
            {
                comboBoxListeFaction.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboFaction_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteFaction_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxListeFaction.Height);
        }
    }

}

