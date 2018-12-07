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
    public partial class ListeDeroulanteStuff : UserControl
    {
        public ListeDeroulanteStuff()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteStuff_SizeChanged;
            comboBoxStuff.SelectedIndexChanged += ComboStuff_SelectedIndexChanged;
        }

        private class Element
        {

            public Stuff Stuff { get; private set; }

            public Element(Stuff Stuff)
            {
                this.Stuff = Stuff;
            }

            public override string ToString()
            {
                return Stuff.Name;
            }

            public override bool Equals(object obj)
            {
                return (obj is Element) ? Stuff.Equals((obj as Element).Stuff) : base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return Stuff.GetHashCode();
            }
        }

        public IEnumerable<Stuff> Stuff
        {
            get
            {
                return comboBoxStuff.Items.OfType<Element>().Select(Element => Element.Stuff);
            }
            set
            {
                if (value != null)
                {
                    comboBoxStuff.Items.Clear();
                    foreach (Stuff Stuff in value)
                    {
                        comboBoxStuff.Items.Add(new Element(Stuff));
                    }
                }
            }
        }

        public int SelectedIndex(int Index)
        {
            return comboBoxStuff.SelectedIndex = Index - 1;
        }

        public Stuff StuffSelectionnee
        {
            get
            {
                return (comboBoxStuff.SelectedItem is Element) ? (comboBoxStuff.SelectedItem as Element).Stuff : null;
            }
            set
            {
                comboBoxStuff.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboStuff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteStuff_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxStuff.Height);
        }
    }
}
