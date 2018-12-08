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
    public partial class FicheEquipement : UserControl
    {
       
        public FicheEquipement()
        {
            InitializeComponent();
            listViewEquipement.View = View.Details;
            listViewEquipement.FullRowSelect = true;
            listViewEquipement.LabelEdit = false;
            listViewEquipement.Scrollable = true;
            listViewEquipement.AllowColumnReorder = false;
            listViewEquipement.MultiSelect = false;
            listViewEquipement.GridLines = true;
            listViewEquipement.HideSelection = false;
            listViewEquipement.Items.Clear();
            listViewEquipement.Columns.Clear();
            listViewEquipement.SelectedIndexChanged += listViewEquipement_SelectedIndexChanged;
        }


        /// <summary>
        /// Texte du filtre
        /// </summary>
        public string TexteFiltreEquipement
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

        public IEnumerable<Stuff> Equipement
        {
            get
            {
                return listViewEquipement.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is Stuff)
                    .Select(Element => Element.Tag as Stuff);
            }
            set
            {
                MettreAJourListe(value);
            }
        }


        /// <summary>
        /// Type de Equipement sélectionné
        /// </summary>
        public Stuff EquipementSelectionne
        {
            get
            {
                return (listViewEquipement.SelectedItems.Count == 1) && (listViewEquipement.SelectedItems[0].Tag is Stuff)
                    ? listViewEquipement.SelectedItems[0].Tag as Stuff
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewEquipement.Items)
                    {
                        if ((Element.Tag is Stuff) && (Element.Tag as Stuff).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewEquipement.SelectedItems.Clear();
            }
        }


        /// <summary>
        /// Evénement déclenché quand il y a un changement de sélection de Equipement
        /// </summary>
        public event EventHandler SurChangementSelection = null;

        /// <summary>
        /// Met à jour la listview des Equipements et y insére les elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entites"></param>
        /// <returns></returns>
        private bool MettreAJourListe<T>(IEnumerable<T> Entites)
            where T : class, IEntiteMySQL
        {
            bool EstEquipement = typeof(T).Equals(typeof(Stuff));
            if (!EstEquipement) return false;
            listViewEquipement.Items.Clear();
            if (Entites == null) return false;
            if (EstEquipement && (listViewEquipement.Columns.Count != 2))
            {
                listViewEquipement.Columns.Clear();

                listViewEquipement.Columns.Add(new ColumnHeader()
                {
                    Name = "Equipements",
                    Text = "Equipements",
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
                if (EstEquipement)
                {
                    Stuff Equipement = Entite as Stuff;
                    NouvelElement.Text = Equipement.Name;
                    NouvelElement.SubItems.Add(Equipement.Name);
                }
                listViewEquipement.Items.Add(NouvelElement);
                

            }

            listViewEquipement.Visible = false;
            foreach (ColumnHeader Colonne in listViewEquipement.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewEquipement.Visible = true;
            listViewEquipement_SelectedIndexChanged(listViewEquipement, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de Equipement
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewEquipement_SelectedIndexChanged(object sender, EventArgs e)
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
            listViewEquipement.Clear();
        }
        
    }
}

