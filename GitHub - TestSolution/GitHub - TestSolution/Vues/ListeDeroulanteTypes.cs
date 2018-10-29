using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen_Michel_Maxime_PDSGBD
{
    public partial class ListeDeroulanteTypes : UserControl
    {
        private class Element
        {

            public Type Type { get; private set; }

            public Element(Type Type)
            {
                this.Type = Type;
            }

            public override string ToString()
            {
                return Type.TypeParcour;
            }

        }

        public IEnumerable<Type> Type
        {
            get
            {
                return comboBoxTypes.Items.OfType<Element>().Select(Element => Element.Type);
            }
            set
            {
                if (value != null)
                {
                    comboBoxTypes.Items.Clear();
                    foreach (Type Type in value)
                    {
                        comboBoxTypes.Items.Add(new Element(Type));
                    }
                }
            }
        }

        public int SelectedIndex(int Index)
        {
            return comboBoxTypes.SelectedIndex = Index - 1;
        }

        public Type TypeSelectionne
        {
            get
            {
                return (comboBoxTypes.SelectedItem is Element) ? (comboBoxTypes.SelectedItem as Element).Type : null;
            }
            set
            {
                comboBoxTypes.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        public ListeDeroulanteTypes()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteType_SizeChanged;
            comboBoxTypes.SelectedIndexChanged += ComboUser_SelectedIndexChanged;
        }


        private void ComboUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteType_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxTypes.Height);
        }
    }
}
