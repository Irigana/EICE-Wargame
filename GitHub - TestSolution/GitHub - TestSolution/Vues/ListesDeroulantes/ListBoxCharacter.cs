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
    public partial class ListBoxCharacter : UserControl
    {
        public ListBoxCharacter()
        {
            InitializeComponent();
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
                return Charact.Name;
            }

        }

        public IEnumerable<Charact> Charact
        {
            get
            {
                return checkedListBoxCharacter.Items.OfType<Element>().Select(Element => Element.Charact);
            }
            set
            {
                if (value != null)
                {
                    checkedListBoxCharacter.Items.Clear();
                    foreach (Charact Charact in value)
                    {
                        checkedListBoxCharacter.Items.Add(new Element(Charact));
                    }
                }
            }
        }
        
        public IEnumerable<Charact> CharactSelectionnes
        {
            get
            {
                return checkedListBoxCharacter.CheckedItems.OfType<Element>().Select(Element => Element.Charact);
            }
        }

        public int SelectedIndex(int Index)
        {
            return checkedListBoxCharacter.SelectedIndex = Index - 1;
        }

        public Charact CharactSelectionnee
        {
            get
            {
                return (checkedListBoxCharacter.SelectedItem is Element) ? (checkedListBoxCharacter.SelectedItem as Element).Charact : null;
            }
            set
            {
                checkedListBoxCharacter.SelectedItem = (value != null) ? new Element(value) : null;
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

        private void ListeDeroulanteType_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, checkedListBoxCharacter.Height);
        }
    }
}
