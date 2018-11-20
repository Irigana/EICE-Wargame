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
    public partial class FicheFaction : UserControl
    {
       
        public FicheFaction()
        {
            InitializeComponent();
            listViewFaction.View = View.Details;
            listViewFaction.FullRowSelect = true;
            listViewFaction.LabelEdit = false;
            listViewFaction.Scrollable = true;
            listViewFaction.AllowColumnReorder = false;
            listViewFaction.MultiSelect = false;
            listViewFaction.GridLines = true;
            listViewFaction.HideSelection = false;
            listViewFaction.Items.Clear();
            listViewFaction.Columns.Clear();
            listViewFaction.SelectedIndexChanged += listViewFaction_SelectedIndexChanged;
        }


        /// <summary>
        /// Texte du filtre
        /// </summary>
        public string TexteFiltreFaction
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

        public IEnumerable<Faction> Faction
        {
            get
            {
                return listViewFaction.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is Faction)
                    .Select(Element => Element.Tag as Faction);
            }
            set
            {
                MettreAJourListe(value);
            }
        }


        /// <summary>
        /// Type de faction sélectionné
        /// </summary>
        public Faction FactionSelectionne
        {
            get
            {
                return (listViewFaction.SelectedItems.Count == 1) && (listViewFaction.SelectedItems[0].Tag is Faction)
                    ? listViewFaction.SelectedItems[0].Tag as Faction
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewFaction.Items)
                    {
                        if ((Element.Tag is Faction) && (Element.Tag as Faction).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewFaction.SelectedItems.Clear();
            }
        }


        /// <summary>
        /// Evénement déclenché quand il y a un changement de sélection de sous faction
        /// </summary>
        public event EventHandler SurChangementSelection = null;

        /// <summary>
        /// Met à jour la listview des sous factions et y insére les elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entites"></param>
        /// <returns></returns>
        private bool MettreAJourListe<T>(IEnumerable<T> Entites)
            where T : class, IEntiteMySQL
        {
            bool EstFaction = typeof(T).Equals(typeof(Faction));
            if (!EstFaction) return false;
            listViewFaction.Items.Clear();
            if (Entites == null) return false;
            if (EstFaction && (listViewFaction.Columns.Count != 2))
            {
                listViewFaction.Columns.Clear();

                listViewFaction.Columns.Add(new ColumnHeader()
                {
                    Name = "Faction",
                    Text = "faction",
                    TextAlign = HorizontalAlignment.Left
                });

            }

            foreach (T Entite in Entites)
            {
                ListViewItem NouvelElement = new ListViewItem()
                {
                    Tag = Entite
                };
                NouvelElement.SubItems.Clear();
                if (EstFaction)
                {
                    Faction Faction = Entite as Faction;
                    NouvelElement.Text = Faction.Name;
                    NouvelElement.SubItems.Add(Faction.Name);
                }
                listViewFaction.Items.Add(NouvelElement);

            }

            listViewFaction.Visible = false;
            foreach (ColumnHeader Colonne in listViewFaction.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewFaction.Visible = true;
            listViewFaction_SelectedIndexChanged(listViewFaction, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de faction
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewFaction_SelectedIndexChanged(object sender, EventArgs e)
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
            listViewFaction.Clear();
        }

    }
}

