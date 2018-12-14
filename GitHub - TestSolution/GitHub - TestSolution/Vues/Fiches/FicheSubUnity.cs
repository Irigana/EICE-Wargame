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
    public partial class FicheSubUnity : UserControl
    {
       
        public FicheSubUnity()
        {
            InitializeComponent();
            listViewSubUnity.View = View.Details;
            listViewSubUnity.FullRowSelect = true;
            listViewSubUnity.LabelEdit = false;
            listViewSubUnity.Scrollable = true;
            listViewSubUnity.AllowColumnReorder = false;
            listViewSubUnity.MultiSelect = false;
            listViewSubUnity.GridLines = true;
            listViewSubUnity.HideSelection = false;
            listViewSubUnity.Items.Clear();
            listViewSubUnity.Columns.Clear();
            listViewSubUnity.SelectedIndexChanged += listViewSubUnity_SelectedIndexChanged;
        }


        /// <summary>
        /// Texte du filtre
        /// </summary>
        public string TexteFiltreSubUnity
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

        public IEnumerable<SubUnity> SubUnity
        {
            get
            {
                return listViewSubUnity.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is SubUnity)
                    .Select(Element => Element.Tag as SubUnity);
            }
            set
            {
                MettreAJourListe(value);
            }
        }


        /// <summary>
        /// Type de SubUnity sélectionné
        /// </summary>
        public SubUnity SubUnitySelectionne
        {
            get
            {
                return (listViewSubUnity.SelectedItems.Count == 1) && (listViewSubUnity.SelectedItems[0].Tag is SubUnity)
                    ? listViewSubUnity.SelectedItems[0].Tag as SubUnity
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewSubUnity.Items)
                    {
                        if ((Element.Tag is SubUnity) && (Element.Tag as SubUnity).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewSubUnity.SelectedItems.Clear();
            }
        }


        /// <summary>
        /// Evénement déclenché quand il y a un changement de sélection de SubUnity
        /// </summary>
        public event EventHandler SurChangementSelection = null;

        /// <summary>
        /// Met à jour la listview des SubUnitys et y insére les elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entites"></param>
        /// <returns></returns>
        private bool MettreAJourListe<T>(IEnumerable<T> Entites)
            where T : class, IEntiteMySQL
        {
            bool EstSubUnity = typeof(T).Equals(typeof(SubUnity));
            if (!EstSubUnity) return false;
            listViewSubUnity.Items.Clear();
            if (Entites == null) return false;
            if (EstSubUnity && (listViewSubUnity.Columns.Count != 2))
            {
                listViewSubUnity.Columns.Clear();

                listViewSubUnity.Columns.Add(new ColumnHeader()
                {
                    Name = "SubUnitys",
                    Text = "Sous unités",
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
                if (EstSubUnity)
                {
                    SubUnity SubUnity = Entite as SubUnity;
                    NouvelElement.Text = SubUnity.Name;
                    NouvelElement.SubItems.Add(SubUnity.Name);
                }
                listViewSubUnity.Items.Add(NouvelElement);
                

            }

            listViewSubUnity.Visible = false;
            foreach (ColumnHeader Colonne in listViewSubUnity.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewSubUnity.Visible = true;
            listViewSubUnity_SelectedIndexChanged(listViewSubUnity, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de SubUnity
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewSubUnity_SelectedIndexChanged(object sender, EventArgs e)
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
            listViewSubUnity.Clear();
        }
        
    }
}

