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
    public partial class ListeDeroulanteUnity : UserControl
    {
        private class Element
        {

            public Unity Unity { get; private set; }

            public Element(Unity Unity)
            {
                this.Unity = Unity;
            }

            public override string ToString()
            {
                return Unity.Name;
            }

            public override bool Equals(object obj)
            {
                return (obj is Element) ? Unity.Equals((obj as Element).Unity) : base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return Unity.GetHashCode();
            }

        }


        public ListeDeroulanteUnity()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteUnity_SizeChanged;
            comboBoxUnity.SelectedIndexChanged += ComboUnity_SelectedIndexChanged;

            comboBoxUnity.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxUnity.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public IEnumerable<Unity> Unity
        {
            get
            {
                return comboBoxUnity.Items.OfType<Element>().Select(Element => Element.Unity);
            }
            set
            {
                if (value != null)
                {
                    comboBoxUnity.Items.Clear();
                    foreach (Unity Unity in value)
                    {
                        comboBoxUnity.Items.Add(new Element(Unity));
                    }
                }
            }
        }

        public Unity UnitySelectionnee
        {
            get
            {
                return (comboBoxUnity.SelectedItem is Element) ? (comboBoxUnity.SelectedItem as Element).Unity : null;
            }
            set
            {
                comboBoxUnity.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboUnity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteUnity_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxUnity.Height);
        }

        public void ResetTextUnity()
        {
            comboBoxUnity.Text = "";
        }

    }

}
