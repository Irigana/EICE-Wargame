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
    public partial class ListeDeroulanteFigurine : UserControl
    {

        private class Element
        {

            public Figurine Figurine { get; private set; }

            public Element(Figurine Figurine)
            {
                this.Figurine = Figurine;
            }

            public override string ToString()
            {
                return Figurine.Charact.Name;
            }

            public override bool Equals(object obj)
            {
                return (obj is Element) ? Figurine.Equals((obj as Element).Figurine) : base.Equals(obj);
            }

            public override int GetHashCode()
            {
                return Figurine.GetHashCode();
            }
        }

        public ListeDeroulanteFigurine()
        {
            InitializeComponent();
            this.SizeChanged += ListeDeroulanteFigurine_SizeChanged;
            comboBoxFigurine.SelectedIndexChanged += ComboFigurine_SelectedIndexChanged;

            comboBoxFigurine.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBoxFigurine.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        public IEnumerable<Figurine> Figurine
        {
            get
            {
                return comboBoxFigurine.Items.OfType<Element>().Select(Element => Element.Figurine);
            }
            set
            {
                if (value != null)
                {
                    comboBoxFigurine.Items.Clear();
                    foreach (Figurine Figurine in value)
                    {
                        comboBoxFigurine.Items.Add(new Element(Figurine));
                    }
                    comboBoxFigurine.Sorted = true;
                }
            }
        }

        public bool m_PerteFigurine { get; private set; }

        public int SelectedIndexBystring(string FigurineRechercher)
        {
            int FigurineTrouve = 0;
            FigurineTrouve = comboBoxFigurine.FindStringExact(FigurineRechercher);
            return comboBoxFigurine.SelectedIndex = FigurineTrouve;
        }

        public void ClearText()
        {
            comboBoxFigurine.Text = "";
        }

        public Figurine FigurineSelectionnee
        {
            get
            {
                return (comboBoxFigurine.SelectedItem is Element) ? (comboBoxFigurine.SelectedItem as Element).Figurine : null;
            }
            set
            {
                comboBoxFigurine.SelectedItem = (value != null) ? new Element(value) : null;
            }
        }

        public EventHandler SurChangementSelection = null;

        private void ComboFigurine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);
            }
        }

        private void ListeDeroulanteFigurine_SizeChanged(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, comboBoxFigurine.Height);
        }

       

    }

}

