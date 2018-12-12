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
    public partial class FicheFigurineStuff : UserControl
    {
       
        public FicheFigurineStuff()
        {
            InitializeComponent();
            listViewFigurineStuff.View = View.Details;
            listViewFigurineStuff.FullRowSelect = true;
            listViewFigurineStuff.LabelEdit = false;
            listViewFigurineStuff.Scrollable = true;
            listViewFigurineStuff.AllowColumnReorder = false;
            listViewFigurineStuff.MultiSelect = false;
            listViewFigurineStuff.GridLines = true;
            listViewFigurineStuff.HideSelection = false;
            listViewFigurineStuff.Items.Clear();
            listViewFigurineStuff.Columns.Clear();
            listViewFigurineStuff.SelectedIndexChanged += listViewFigurineStuff_SelectedIndexChanged;
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

        public IEnumerable<Figurine> FigurineStuff
        {
            get
            {
                return listViewFigurineStuff.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is Figurine)
                    .Select(Element => Element.Tag as Figurine);
            }
            set
            {
                MettreAJourListe(value);
            }
        }


        /// <summary>
        /// Type de FigurineStuff sélectionné
        /// </summary>
        public Figurine FactionSelectionne
        {
            get
            {
                return (listViewFigurineStuff.SelectedItems.Count == 1) && (listViewFigurineStuff.SelectedItems[0].Tag is Figurine)
                    ? listViewFigurineStuff.SelectedItems[0].Tag as Figurine
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewFigurineStuff.Items)
                    {
                        if ((Element.Tag is FigurineStuff) && (Element.Tag as FigurineStuff).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewFigurineStuff.SelectedItems.Clear();
            }
        }


        /// <summary>
        /// Evénement déclenché quand il y a un changement de sélection de FigurineStuff
        /// </summary>
        public event EventHandler SurChangementSelection = null;

        /// <summary>
        /// Met à jour la listview des FigurineStuff et y insére les elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entites"></param>
        /// <returns></returns>
        private bool MettreAJourListe<T>(IEnumerable<T> Entites)
            where T : class, IEntiteMySQL
        {
            bool EstFigurineStuff = typeof(T).Equals(typeof(FigurineStuff));
            if (!EstFigurineStuff) return false;
            listViewFigurineStuff.Items.Clear();
            if (Entites == null) return false;
            if (EstFigurineStuff && (listViewFigurineStuff.Columns.Count != 2))
            {
                listViewFigurineStuff.Columns.Clear();

                listViewFigurineStuff.Columns.Add(new ColumnHeader()
                {
                    Name = "Figurines",
                    Text = "Figurines",
                    TextAlign = HorizontalAlignment.Center,                              
                });

            }

            foreach (T Entite in Entites)
            {

                FigurineStuff FigurineStuff = Entite as FigurineStuff;

                if (EstFigurineStuff)
                {
                    ListViewItem NouvelElement = new ListViewItem()
                    {
                        Tag = Entite,
                        Text = FigurineStuff.Figurine.Charact.Name,
                    };
                    NouvelElement.SubItems.Add(FigurineStuff.Figurine.Charact.Name);

                    listViewFigurineStuff.Items.Add(NouvelElement);

                }
            }

            listViewFigurineStuff.Visible = false;
            foreach (ColumnHeader Colonne in listViewFigurineStuff.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewFigurineStuff.Visible = true;
            listViewFigurineStuff_SelectedIndexChanged(listViewFigurineStuff, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de FigurineStuff
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewFigurineStuff_SelectedIndexChanged(object sender, EventArgs e)
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
            listViewFigurineStuff.Clear();
        }
        
    }
}

