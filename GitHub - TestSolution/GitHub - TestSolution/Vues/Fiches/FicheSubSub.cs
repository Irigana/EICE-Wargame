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
    public partial class FicheSubSub : UserControl
    {
       
        public FicheSubSub()
        {
            InitializeComponent();
            listViewSubSub.View = View.Details;
            listViewSubSub.FullRowSelect = true;
            listViewSubSub.LabelEdit = false;
            listViewSubSub.Scrollable = true;
            listViewSubSub.AllowColumnReorder = false;
            listViewSubSub.MultiSelect = false;
            listViewSubSub.GridLines = true;
            listViewSubSub.HideSelection = false;
            listViewSubSub.Items.Clear();
            listViewSubSub.Columns.Clear();
            listViewSubSub.SelectedIndexChanged += listViewSubSub_SelectedIndexChanged;
        }


        /// <summary>
        /// Texte du filtre
        /// </summary>
        public string TexteFiltreSubSub
        {
            get
            {
                return textBoxRecherche.Text;
            }
            set
            {
                if (value == null) value = string.Empty;
                if (value != textBoxRecherche.Text)
                {
                    textBoxRecherche.Text = value;
                }
            }
        }

        /// <summary>
        /// Evénement déclenché lorsque le filtre change
        /// </summary>
        public event EventHandler SurChangementFiltre = null;

        public IEnumerable<SubSub> SubSub
        {
            get
            {
                return listViewSubSub.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is SubSub)
                    .Select(Element => Element.Tag as SubSub);
            }
            set
            {
                MettreAJourListe(value);
            }
        }


        /// <summary>
        /// Type de SubSub sélectionné
        /// </summary>
        public SubSub SubSubSelectionne
        {
            get
            {
                return (listViewSubSub.SelectedItems.Count == 1) && (listViewSubSub.SelectedItems[0].Tag is SubSub)
                    ? listViewSubSub.SelectedItems[0].Tag as SubSub
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewSubSub.Items)
                    {
                        if ((Element.Tag is SubSub) && (Element.Tag as SubSub).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewSubSub.SelectedItems.Clear();
            }
        }


        /// <summary>
        /// Evénement déclenché quand il y a un changement de sélection de SubSub
        /// </summary>
        public event EventHandler SurChangementSelection = null;

        /// <summary>
        /// Met à jour la listview des SubSubs et y insére les elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entites"></param>
        /// <returns></returns>
        private bool MettreAJourListe<T>(IEnumerable<T> Entites)
            where T : class, IEntiteMySQL
        {
            bool EstSubSub = typeof(T).Equals(typeof(SubSub));
            if (!EstSubSub) return false;
            listViewSubSub.Items.Clear();
            if (Entites == null) return false;
            if (EstSubSub && (listViewSubSub.Columns.Count != 2))
            {
                listViewSubSub.Columns.Clear();

                listViewSubSub.Columns.Add(new ColumnHeader()
                {
                    Name = "Master",
                    Text = "Master",
                    TextAlign = HorizontalAlignment.Center,                              
                });
                listViewSubSub.Columns.Add(new ColumnHeader()
                {
                    Name = "Slave",
                    Text = "Slave",
                    TextAlign = HorizontalAlignment.Center,
                });
            }

            foreach (T Entite in Entites)
            {
                ListViewItem NouvelElement = new ListViewItem()
                {
                    Tag = Entite
                };
                NouvelElement.SubItems.Clear();
                if (EstSubSub)
                {
                    SubSub SubSub = Entite as SubSub;
                    NouvelElement.Text = SubSub.Master.Name;
                    NouvelElement.SubItems.Add(SubSub.Slave.Name);
                }
                listViewSubSub.Items.Add(NouvelElement);
                

            }

            listViewSubSub.Visible = false;
            foreach (ColumnHeader Colonne in listViewSubSub.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewSubSub.Visible = true;
            listViewSubSub_SelectedIndexChanged(listViewSubSub, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de SubSub
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewSubSub_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SurChangementSelection != null)
            {
                SurChangementSelection(this, EventArgs.Empty);

            }
        }

        /// <summary>
        /// Evénement déclenché en cas de changement de contenu de la zone de texte pour le filtrage
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void textFiltre_TextChanged(object sender, EventArgs e)
        {
            if (SurChangementFiltre != null)
            {
                SurChangementFiltre(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Evénement déclenché en cas d'appui sur une touche quand la zone de texte pour le filtrage a le focus
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void textFiltre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                if (SurChangementFiltre != null)
                {
                    SurChangementFiltre(this, EventArgs.Empty);
                }
            }
        }

        /// <summary>
        /// Nettoie la listview des elements s'y trouvant
        /// </summary>
        public void NettoyerListView()
        {
            listViewSubSub.Clear();
        }
        
    }
}

