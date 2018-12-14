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
    public partial class ListeDeroulanteRank : UserControl
    {
        private class Element
        {

            public Rank Rank { get; private set; }

            public Element(Rank Rank)
            {
                this.Rank = Rank;
            }

            public override string ToString()
            {
                return Rank.Name;
            }


            public override bool Equals(object obj)
            {
                return (obj is Element) ? Rank.Equals((obj as Element).Rank) : base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return Rank.GetHashCode();
            }

        }        


        public ListeDeroulanteRank()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteRank_SizeChanged;
            comboBoxRank.SelectedIndexChanged += ComboRank_SelectedIndexChanged;

            comboBoxRank.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxRank.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public IEnumerable<Rank> Rank
        {
            get
            {
                return comboBoxRank.Items.OfType<Element>().Select(Element => Element.Rank);
            }
            set
            {
                if (value != null)
                {
                    comboBoxRank.Items.Clear();
                    foreach (Rank Rank in value)
                    {
                        comboBoxRank.Items.Add(new Element(Rank));
                    }
                }
            }
        }

        public Rank RankSelectionnee
        {
            get
            {
                return (comboBoxRank.SelectedItem is Element) ? (comboBoxRank.SelectedItem as Element).Rank : null;
            }
            set
            {
                comboBoxRank.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteRank_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxRank.Height);
        }

        public void ResetTextRank()
        {
            comboBoxRank.Text = "";
        }
    }

}
