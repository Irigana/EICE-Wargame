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
    public partial class ListeDeroulanteChar : UserControl
    {
        public ListeDeroulanteChar()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteCharRank_SizeChanged;
            comboBoxChar.SelectedIndexChanged += ComboCharact_SelectedIndexChanged;
        }
        
        private class Element
        {

            public Charact Charact { get; private set; }

            public Element(Charact Charact)
            {
                this.Charact = Charact;
            }

            public override string ToString()
            {
                return string.Format("{0}",Charact.Name);
            }

        }

        public void ResetTextChar()
        {
            comboBoxChar.Text = "";
        }


        public IEnumerable<Charact> Charact
        {
            get
            {
                return comboBoxChar.Items.OfType<Element>().Select(Element => Element.Charact);
            }
            set
            {
                if (value != null)
                {
                    comboBoxChar.Items.Clear();
                    foreach (Charact Charact in value)
                    {
                        comboBoxChar.Items.Add(new Element(Charact));
                    }
                }
            }
        }
        
        public int SelectedIndex(int Index)
        {
            return comboBoxChar.SelectedIndex = Index - 1;
        }

        public Charact CharactSelectionnee
        {
            get
            {
                return (comboBoxChar.SelectedItem is Element) ? (comboBoxChar.SelectedItem as Element).Charact : null;
            }
            set
            {
                comboBoxChar.SelectedItem = (value != null) ? new Element(value) : null;
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
            this.Size = new Size(this.Size.Width, comboBoxChar.Height);
        }
    }
}
