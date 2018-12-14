using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSGBD;

namespace EICE_WARGAME
{
    public partial class ListeDeroulanteCamp : UserControl
    {

        private class Element
        {

            public Camp Camp { get; private set; }

            public Element(Camp Camp)
            {
                this.Camp = Camp;
            }

            public override string ToString()
            {
                return Camp.Name;
            }

            public override bool Equals(object obj)
            {
                return (obj is Element) ? Camp.Equals((obj as Element).Camp) : base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return Camp.GetHashCode();
            }
        }

        public ListeDeroulanteCamp()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteCamp_SizeChanged;
            comboBoxCamp.SelectedIndexChanged += ComboCamp_SelectedIndexChanged;

            comboBoxCamp.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxCamp.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public IEnumerable<Camp> Camp
        {
            get
            {
                return comboBoxCamp.Items.OfType<Element>().Select(Element => Element.Camp);
            }
            set
            {
                if (value != null)
                {
                    comboBoxCamp.Items.Clear();
                    foreach (Camp Camp in value)
                    {
                        comboBoxCamp.Items.Add(new Element(Camp));
                    }
                    comboBoxCamp.Sorted = true;
                }
            }
        }

        public bool m_PerteCamp { get; private set; }

        public int SelectedIndexBystring(string CampRechercher)
        {
            int CampTrouve = 0;
            CampTrouve = comboBoxCamp.FindStringExact(CampRechercher);
            return comboBoxCamp.SelectedIndex = CampTrouve;
        }

        public void ClearText()
        {
            comboBoxCamp.Text = "";
        }

        public Camp CampSelectionnee
        {
            get
            {
                return (comboBoxCamp.SelectedItem is Element) ? (comboBoxCamp.SelectedItem as Element).Camp : null;
            }
            set
            {
                comboBoxCamp.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboCamp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteCamp_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxCamp.Height);
        }

       

    }

}

