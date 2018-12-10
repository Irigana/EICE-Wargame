﻿using System;
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
    public partial class FichePersonnageEquipement : UserControl
    {
        public FichePersonnageEquipement()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Evénement déclenché lorsque le filtre change
        /// </summary>
        public event EventHandler SurChangementFiltre = null;

        public IEnumerable<CharactRank> Caractere
        {
            get
            {
                return listViewCaractere.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is CharactRank)
                    .Select(Element => Element.Tag as CharactRank);
            }
            set
            {
                MettreAJourListe(value);
            }
        }

        public void RefreshListViewCaract()
        {
            listViewCaractere.Refresh();
        }

        /// <summary>
        /// Type de sous faction sélectionné
        /// </summary>
        public CharactRank CaractereSelectionne
        {
            get
            {
                return (listViewCaractere.SelectedItems.Count == 1) && (listViewCaractere.SelectedItems[0].Tag is CharactRank)
                    ? listViewCaractere.SelectedItems[0].Tag as CharactRank
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewCaractere.Items)
                    {
                        if ((Element.Tag is CharactRank) && (Element.Tag as CharactRank).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewCaractere.SelectedItems.Clear();
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
            bool EstCaractere = typeof(T).Equals(typeof(CharactRank));
            if (!EstCaractere) return false;
            listViewCaractere.Items.Clear();
            if (Entites == null) return false;
            if (EstCaractere && (listViewCaractere.Columns.Count != 2))
            {
                listViewCaractere.Columns.Clear();

                listViewCaractere.Columns.Add(new ColumnHeader()
                {
                    Name = "Caracteres",
                    Text = "Caractères",
                    TextAlign = HorizontalAlignment.Center,
                });
                listViewCaractere.Columns.Add(new ColumnHeader()
                {
                    Name = "Rank",
                    Text = "Rank",
                    TextAlign = HorizontalAlignment.Center,
                });
                listViewCaractere.Columns.Add(new ColumnHeader()
                {
                    Name = "Cout",
                    Text = "Coût",
                    TextAlign = HorizontalAlignment.Center,
                });

            }

            foreach (T Entite in Entites)
            {

                CharactRank Caractere = Entite as CharactRank;

                if (EstCaractere)
                {
                    ListViewItem NouvelElement = new ListViewItem()
                    {
                        Tag = Entite,
                        Text = Caractere.Caractere.Name,
                    };
                    NouvelElement.SubItems.Add(Caractere.Rank.Name);
                    NouvelElement.SubItems.Add(Caractere.Cost.ToString());

                    listViewCaractere.Items.Add(NouvelElement);

                }
            }

            listViewCaractere.Visible = false;
            foreach (ColumnHeader Colonne in listViewCaractere.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewCaractere.Visible = true;
            listViewCaractere_SelectedIndexChanged(listViewCaractere, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de sous faction
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewCaractere_SelectedIndexChanged(object sender, EventArgs e)
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
            listViewCaractere.Clear();
        }

    }
}