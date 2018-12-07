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
    public partial class ListeDeroulanteSousFaction : UserControl
    {
        private class Element
        {

            public SousFaction SousFaction { get; private set; }

            public Element(SousFaction SousFaction)
            {
                this.SousFaction = SousFaction;
            }

            public override string ToString()
            {
                return SousFaction.Name;
            }

        }

        public void ResetTextSousFaction()
        {
            comboBoxListeSousFaction.Text = "";
        }


        public ListeDeroulanteSousFaction()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteSousFaction_SizeChanged;
            comboBoxListeSousFaction.SelectedIndexChanged += ComboFaction_SelectedIndexChanged;

            comboBoxListeSousFaction.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxListeSousFaction.AutoCompleteSource = AutoCompleteSource.ListItems;
        }                   

        public IEnumerable<SousFaction> SousFaction
        {
            get
            {
                return comboBoxListeSousFaction.Items.OfType<Element>().Select(Element => Element.SousFaction);
            }
            set
            {
                if (value != null)
                {
                    comboBoxListeSousFaction.Items.Clear();
                    foreach (SousFaction SousFaction in value)
                    {
                        comboBoxListeSousFaction.Items.Add(new Element(SousFaction));
                    }
                }
            }
        }        

        public SousFaction SousFactionSelectionnee
        {
            get
            {
                return (comboBoxListeSousFaction.SelectedItem is Element) ? (comboBoxListeSousFaction.SelectedItem as Element).SousFaction : null;
            }
            set
            {
                comboBoxListeSousFaction.SelectedItem = (value != null) ? new Element(value) : null;
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

        private void ListeDeroulanteSousFaction_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxListeSousFaction.Height);
        }

    }

}
