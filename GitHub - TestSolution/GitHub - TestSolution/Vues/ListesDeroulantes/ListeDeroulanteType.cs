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
    public partial class ListeDeroulanteType : UserControl
    {
        public ListeDeroulanteType()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteType_SizeChanged;
            comboBoxType.SelectedIndexChanged += ComboType_SelectedIndexChanged;
        }
        

        private class Element
        {

            public Type Type { get; private set; }

            public Element(Type Type)
            {
                this.Type = Type;
            }

            public override string ToString()
            {
                return Type.Name;
            }

        }

        public IEnumerable<Type> Type
        {
            get
            {
                return comboBoxType.Items.OfType<Element>().Select(Element => Element.Type);
            }
            set
            {
                if (value != null)
                {
                    comboBoxType.Items.Clear();
                    foreach (Type Type in value)
                    {
                        comboBoxType.Items.Add(new Element(Type));
                    }
                }
            }
        }

        public int SelectedIndex(int Index)
        {
            return comboBoxType.SelectedIndex = Index - 1;
        }

        public Type TypeSelectionne
        {
            get
            {
                return (comboBoxType.SelectedItem is Element) ? (comboBoxType.SelectedItem as Element).Type : null;
            }
            set
            {
                comboBoxType.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        


        private void ComboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteType_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxType.Height);
        }
    }
}
