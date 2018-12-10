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
    public partial class ListeDeroulanteCharRank : UserControl
    {
        public ListeDeroulanteCharRank()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteCharRank_SizeChanged;
            comboBoxCharRank.SelectedIndexChanged += ComboCharact_SelectedIndexChanged;
        }
        
        private class Element
        {

            public CharactRank Charact { get; private set; }

            public Element(CharactRank Charact)
            {
                this.Charact = Charact;
            }

            public override string ToString()
            {
                return string.Format("{0} - {1}",Charact.Caractere.Name,Charact.Rank.Name);
            }

        }
        

        public IEnumerable<CharactRank> Charact
        {
            get
            {
                return comboBoxCharRank.Items.OfType<Element>().Select(Element => Element.Charact);
            }
            set
            {
                if (value != null)
                {
                    comboBoxCharRank.Items.Clear();
                    foreach (CharactRank Charact in value)
                    {
                        comboBoxCharRank.Items.Add(new Element(Charact));
                    }
                }
            }
        }
        
        public int SelectedIndex(int Index)
        {
            return comboBoxCharRank.SelectedIndex = Index - 1;
        }

        public CharactRank CharactSelectionnee
        {
            get
            {
                return (comboBoxCharRank.SelectedItem is Element) ? (comboBoxCharRank.SelectedItem as Element).Charact : null;
            }
            set
            {
                comboBoxCharRank.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboCharact_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteCharRank_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxCharRank.Height);
        }
    }
}
