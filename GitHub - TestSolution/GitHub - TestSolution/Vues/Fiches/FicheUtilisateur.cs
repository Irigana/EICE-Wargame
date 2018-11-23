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
    public partial class FicheUtilisateur : UserControl
    {
        public FicheUtilisateur()
        {
            InitializeComponent();
            listViewUsers.View = View.Details;
            listViewUsers.FullRowSelect = true;
            listViewUsers.LabelEdit = false;
            listViewUsers.Scrollable = true;
            listViewUsers.AllowColumnReorder = false;
            listViewUsers.MultiSelect = false;
            listViewUsers.GridLines = true;
            listViewUsers.HideSelection = false;
            listViewUsers.Items.Clear();
            listViewUsers.Columns.Clear();
            listViewUsers.SelectedIndexChanged += listViewUsers_SelectedIndexChanged;
        }

        /// <summary>
        /// Texte de la recherche
        /// </summary>
        public string TexteRechercheUser
        {
            get
            {
                return textBoxRechercheUser.Text;
            }
            set
            {
                if (value == null) value = string.Empty;
                if (value != textBoxRechercheUser.Text)
                {
                    textBoxRechercheUser.Text = value;
                }
            }
        }


        /// <summary>
        /// Evénement déclenché lorsque le filtre change
        /// </summary>
        public event EventHandler SurChangementFiltre = null;

        public IEnumerable<Utilisateur> Utilisateur
        {
            get
            {
                return listViewUsers.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is Utilisateur)
                    .Select(Element => Element.Tag as Utilisateur);
            }
            set
            {
                MettreAJourListe(value);
            }
        }

        /// <summary>
        /// Type de Utilisateur sélectionné
        /// </summary>
        public Utilisateur UtilisateurSelectionne
        {
            get
            {
                return (listViewUsers.SelectedItems.Count == 1) && (listViewUsers.SelectedItems[0].Tag is Utilisateur)
                    ? listViewUsers.SelectedItems[0].Tag as Utilisateur
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewUsers.Items)
                    {
                        if ((Element.Tag is Utilisateur) && (Element.Tag as Utilisateur).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewUsers.SelectedItems.Clear();
            }
        }


        /// <summary>
        /// Evénement déclenché quand il y a un changement de sélection d'utilisateur
        /// </summary>
        public event EventHandler SurChangementSelection = null;

        /// <summary>
        /// Met à jour la listview des utilisateurs et y insére les elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entites"></param>
        /// <returns></returns>
        private bool MettreAJourListe<T>(IEnumerable<T> Entites)
            where T : class, IEntiteMySQL
        {
            bool EstUtilisateur = typeof(T).Equals(typeof(Utilisateur));
            if (!EstUtilisateur) return false;
            listViewUsers.Items.Clear();
            if (Entites == null) return false;
            if (EstUtilisateur && (listViewUsers.Columns.Count != 2))
            {
                listViewUsers.Columns.Clear();

                listViewUsers.Columns.Add(new ColumnHeader()
                {
                    Name = "Utilisateurs",
                    Text = "Utilisateurs",
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
                if (EstUtilisateur)
                {
                    Utilisateur Utilisateur = Entite as Utilisateur;
                    NouvelElement.Text = Utilisateur.Login;
                    NouvelElement.SubItems.Add(Utilisateur.Login);
                }
                listViewUsers.Items.Add(NouvelElement);

            }

            listViewUsers.Visible = false;
            foreach (ColumnHeader Colonne in listViewUsers.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewUsers.Visible = true;
            listViewUsers_SelectedIndexChanged(listViewUsers, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection d'un utilisateur
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewUsers_SelectedIndexChanged(object sender, EventArgs e)
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
        private void textRecherche_TextChanged(object sender, EventArgs e)
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
            listViewUsers.Clear();
        }

    }
}
