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
    public partial class FicheSousFaction : UserControl
    {
        //Membres privés
        private string m_MessageValidation = null;
        private string m_MessageErreur = null;
        private int m_NombreDEnregistrementFiltre = -1;

        /// <summary>
        /// Indique si il faut suivre instantanément tout changement réalisé dans la zône de texte du filtre, ou seulement lors de l'activation du filtre (ENTER/RETURN ou clic sur bouton)
        /// </summary>
        private bool m_ReactionEnDirectSurChangementFiltre;

        /// <summary>
        /// Permet de mettre un message de validation sur la textbox à l'extérieur de la fiche
        /// </summary>
        public string MessageValidation
        {
            get
            {
                return m_MessageValidation;
            }
            set
            {
                if (value != null)
                {
                    m_MessageValidation = value;
                    ActionValidee.SetError(textBoxSousFaction, value);
                }
            }
        }

        /// <summary>
        /// Permet de mettre un message d'erreur sur la textbox à l'extérieur de la fiche
        /// </summary>
        public string MessageErreur
        {
            get
            {
                return m_MessageErreur;
            }
            set
            {
                if (value != null)
                {
                    m_MessageErreur = value;
                    errorProviderSousFaction.SetError(textBoxSousFaction, value);
                }
            }
        }
        /// <summary>
        /// Mettre à true pour activer la textBox, sinon false
        /// </summary>
        public bool m_ActiverTextBox
        {
            set
            {
                textBoxSousFaction.Enabled = value;
            }
        }

        /// <summary>
        /// Nombre de sous faction filtré au moment de l'appel de cette propriété
        /// </summary>
        public int NombreDeSousFactionFiltre
        {
            get
            {
                return m_NombreDEnregistrementFiltre;
            }
            set
            {
                m_NombreDEnregistrementFiltre = value;

            }
        }

        public FicheSousFaction()
        {
            InitializeComponent();
            listViewSousFaction.View = View.Details;
            listViewSousFaction.FullRowSelect = true;
            listViewSousFaction.LabelEdit = false;
            listViewSousFaction.Scrollable = true;
            listViewSousFaction.AllowColumnReorder = false;
            listViewSousFaction.MultiSelect = false;
            listViewSousFaction.GridLines = true;
            listViewSousFaction.HideSelection = false;
            listViewSousFaction.Items.Clear();
            listViewSousFaction.Columns.Clear();
            listViewSousFaction.SelectedIndexChanged += listViewSousFaction_SelectedIndexChanged;
            textBoxSousFaction.Enabled = false;

            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);

            ActionValidee.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }

        /// <summary>
        /// Indique si il faut suivre instantanément tout changement réalisé dans la zône de texte du filtre, ou seulement lors de l'activation du filtre (ENTER/RETURN ou clic sur bouton)
        /// </summary>
        public bool ReactionEnDirectSurChangementFiltre
        {
            get
            {
                return m_ReactionEnDirectSurChangementFiltre;
            }
            set
            {
                m_ReactionEnDirectSurChangementFiltre = value;
            }
        }

        /// <summary>
        /// Texte du filtre
        /// </summary>
        public string TexteDuFiltre
        {
            get
            {
                return textBoxSousFaction.Text;
            }
            set
            {
                if (value == null) value = string.Empty;
                if (value != textBoxSousFaction.Text)
                {
                    textBoxSousFaction.Text = value;
                }
            }
        }

        /// <summary>
        /// Evénement déclenché lorsque le filtre change
        /// </summary>
        public event EventHandler SurChangementFiltre = null;

        public IEnumerable<SousFaction> SousFaction
        {
            get
            {
                return listViewSousFaction.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is SousFaction)
                    .Select(Element => Element.Tag as SousFaction);
            }
            set
            {
                MettreAJourListe(value);
            }
        }


        /// <summary>
        /// Type de sous faction sélectionné
        /// </summary>
        public SousFaction SousFactionSelectionne
        {
            get
            {
                return (listViewSousFaction.SelectedItems.Count == 1) && (listViewSousFaction.SelectedItems[0].Tag is SousFaction)
                    ? listViewSousFaction.SelectedItems[0].Tag as SousFaction
                    : null;
            }
            set
            {
                if (value != null)
                {
                    var ElementASelectionner = listViewSousFaction.Items.Cast<ListViewItem>()
                        .FirstOrDefault(Element => (Element.Tag is SousFaction) && (Element.Tag as SousFaction).Id.Equals(value.Id));
                    if ((ElementASelectionner != null)
                        && ((listViewSousFaction.SelectedItems.Count == 0) || !(listViewSousFaction.SelectedItems[0].Tag as SousFaction).Id.Equals(value.Id)))
                    {
                        listViewSousFaction.SelectedIndices.Clear();
                        listViewSousFaction.SelectedIndices.Add(ElementASelectionner.Index);
                    }
                    else
                    {
                        listViewSousFaction.SelectedIndices.Clear();
                    }
                }
                else
                {
                    listViewSousFaction.SelectedIndices.Clear();
                }
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
            bool EstSousFaction = typeof(T).Equals(typeof(SousFaction));
            if (!EstSousFaction) return false;
            int IdSelectionne = (listViewSousFaction.SelectedItems.Count == 1) ? (listViewSousFaction.SelectedItems[0].Tag as SousFaction).Id : 0;

            listViewSousFaction.Items.Clear();
            if (Entites == null) return false;
            if (EstSousFaction && (listViewSousFaction.Columns.Count != 2))
            {
                listViewSousFaction.Columns.Clear();

                listViewSousFaction.Columns.Add(new ColumnHeader()
                {
                    Name = "SousFaction",
                    Text = "Sous faction",
                    TextAlign = HorizontalAlignment.Left
                });

            }
            int Index = 0;
            int IndexASelectionner = -1;
            foreach (T Entite in Entites)
            {
                int IdEntite = (Entite as SousFaction).Id;
                ListViewItem NouvelElement = new ListViewItem()
                {
                    Tag = Entite
                };
                if (IdEntite == IdSelectionne) IndexASelectionner = Index;
                NouvelElement.SubItems.Clear();
                if (EstSousFaction)
                {
                    SousFaction SousFaction = Entite as SousFaction;
                    NouvelElement.Text = SousFaction.Name;
                    //NouvelElement.SubItems.Add(SousFaction.Name);
                }
                listViewSousFaction.Items.Add(NouvelElement);
                Index++;
            }

            listViewSousFaction.Visible = false;
            foreach (ColumnHeader Colonne in listViewSousFaction.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewSousFaction.Visible = true;
            if (IndexASelectionner == -1)
                listViewSousFaction_SelectedIndexChanged(listViewSousFaction, EventArgs.Empty);
            else
                listViewSousFaction.SelectedIndices.Add(IndexASelectionner);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de sous faction
        /// </summary>
        /// <param name="sender">Emetteur ayant déclenché l'événement</param>
        /// <param name="e">Descriptif de l'événement</param>
        private void listViewSousFaction_SelectedIndexChanged(object sender, EventArgs e)
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
            if (m_ReactionEnDirectSurChangementFiltre && (SurChangementFiltre != null))
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
            listViewSousFaction.Clear();
        }


        /// <summary>
        /// Permet de réagir sur l'entré dans la textBox : Utilisé pour virer le filtre et nettoyer les prodivers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSousFaction_Enter(object sender, EventArgs e)
        {
            //if (listViewSousFaction.SelectedItems != null) ReactionEnDirectSurChangementFiltre = true;
            errorProviderSousFaction.Clear();
            ActionValidee.Clear();
        }

        /// <summary>
        /// Permet la reprise du filtre après que l'utilisateur clique sur un bouton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxSousFaction_Leave(object sender, EventArgs e)
        {
            ReactionEnDirectSurChangementFiltre = true;
        }
    }
}
