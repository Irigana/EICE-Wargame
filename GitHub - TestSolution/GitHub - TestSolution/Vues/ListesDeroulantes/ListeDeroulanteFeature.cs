using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EICE_WARGAME
{
    public partial class ListeDeroulanteFeature : UserControl
    {
        public ListeDeroulanteFeature()
        {
            InitializeComponent();
        }

        private class Element
        {

            public Feature Feature { get; private set; }

            public Element(Feature Feature)
            {
                this.Feature = Feature;
            }

            public override string ToString()
            {
                return Feature.Name;
            }

        }

        public IEnumerable<Feature> Feature
        {
            get
            {
                return comboBoxFeature.Items.OfType<Element>().Select(Element => Element.Feature);
            }
            set
            {
                if (value != null)
                {
                    comboBoxFeature.Items.Clear();
                    foreach (Feature Feature in value)
                    {
                        comboBoxFeature.Items.Add(new Element(Feature));
                    }
                }
            }
        }

        public int SelectedIndex(int Index)
        {
            return comboBoxFeature.SelectedIndex = Index - 1;
        }

        public Feature FeatureSelectionnee
        {
            get
            {
                return (comboBoxFeature.SelectedItem is Element) ? (comboBoxFeature.SelectedItem as Element).Feature : null;
            }
            set
            {
                comboBoxFeature.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboFeature_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteType_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxFeature.Height);
        }

        public void ResetTextFeature()
        {
            comboBoxFeature.SelectedItem = null;
        }
    }
}

