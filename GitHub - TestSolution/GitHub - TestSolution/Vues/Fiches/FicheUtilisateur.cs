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
            listViewCaractere.HeaderStyle = ColumnHeaderStyle.Nonclickable;
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

            /*
            listViewUsers.DrawItem += new
            DrawListViewItemEventHandler(listViewUsers_DrawItem);

            listViewUsers.DrawColumnHeader += new DrawListViewColumnHeaderEventHandler(listView1_DrawColumnHeader);
            */

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
                    Name = "utilisateur",
                    Text = "Utilisateurs",
                    TextAlign = HorizontalAlignment.Left,                    
                });
                listViewUsers.Columns.Add(new ColumnHeader()
                {
                    Name = "role",
                    Text = "Rôles",
                    TextAlign = HorizontalAlignment.Left
                });
            }

            foreach (T Entite in Entites)
            {
                
                Utilisateur Utilisateur = Entite as Utilisateur;
                if (EstUtilisateur)
                {
                    ListViewItem NouvelElement = new ListViewItem()
                    {
                        Tag = Entite,
                        Text = Utilisateur.Login,                                      
                    };
                
                    
                    NouvelElement.SubItems.Add(Utilisateur.Role.NomRole);

                    listViewUsers.Items.Add(NouvelElement);
                    
                }


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
        
        /*
        private void listViewUsers_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.LightBlue, e.Bounds);
            e.DrawText();
        }

        private void listViewUsers_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        // Draws column headers.
        private void listView1_DrawColumnHeader(object sender,
            DrawListViewColumnHeaderEventArgs e)
        {
            using (StringFormat sf = new StringFormat())
            {
                // Store the column text alignment, letting it default
                // to Left if it has not been set to Center or Right.
                switch (e.Header.TextAlign)
                {
                    case HorizontalAlignment.Center:
                        sf.Alignment = StringAlignment.Center;
                        break;
                    case HorizontalAlignment.Right:
                        sf.Alignment = StringAlignment.Far;
                        break;
                }

                // Draw the standard header background.
                e.DrawBackground();

                // Draw the header text.
                using (Font headerFont =
                            new Font("Helvetica", 10, FontStyle.Bold))
                {
                    e.Graphics.DrawString(e.Header.Text, headerFont,
                        Brushes.Black, e.Bounds, sf);
                }
            }
            return;
        }*/


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
