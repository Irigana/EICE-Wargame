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
    public partial class ListeDeroulanteSubUnity : UserControl
    {
        private class Element
        {

            public SubUnity SubUnity { get; private set; }

            public Element(SubUnity SubUnity)
            {
                this.SubUnity = SubUnity;
            }

            public override string ToString()
            {
                return SubUnity.Name;
            }

        }


        public ListeDeroulanteSubUnity()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteSubUnity_SizeChanged;
            comboBoxSubUnity.SelectedIndexChanged += ComboSubUnity_SelectedIndexChanged;

            comboBoxSubUnity.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxSubUnity.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public IEnumerable<SubUnity> SubUnity
        {
            get
            {
                return comboBoxSubUnity.Items.OfType<Element>().Select(Element => Element.SubUnity);
            }
            set
            {
                if (value != null)
                {
                    comboBoxSubUnity.Items.Clear();
                    foreach (SubUnity SubUnity in value)
                    {
                        comboBoxSubUnity.Items.Add(new Element(SubUnity));
                    }
                }
            }
        }

        public SubUnity SubUnitySelectionnee
        {
            get
            {
                return (comboBoxSubUnity.SelectedItem is Element) ? (comboBoxSubUnity.SelectedItem as Element).SubUnity : null;
            }
            set
            {
                comboBoxSubUnity.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboSubUnity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteSubUnity_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxSubUnity.Height);
        }

    }

}
