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
    public partial class FicheCaracteristique : UserControl
    {        

        public FicheCaracteristique()
        {
            
            InitializeComponent();
            
            listviewCaracteristique.View = View.Details;
            listviewCaracteristique.FullRowSelect = true;
            listviewCaracteristique.LabelEdit = false;
            listviewCaracteristique.Scrollable = true;
            listviewCaracteristique.AllowColumnReorder = false;
            listviewCaracteristique.MultiSelect = false;
            listviewCaracteristique.GridLines = true;
            listviewCaracteristique.HideSelection = false;
            listviewCaracteristique.Items.Clear();
            listviewCaracteristique.Columns.Clear();
            listviewCaracteristique.SelectedIndexChanged += listViewCaractere_SelectedIndexChanged;            
        }

        
        public IEnumerable<CharactFeature> Caracteristique
        {
            get
            {
                return listviewCaracteristique.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is CharactFeature)
                    .Select(Element => Element.Tag as CharactFeature);
            }
            set
            {
                MettreAJourListe(value);
            }
        }
        
        /// <summary>
        /// Type de sous Feature sélectionné
        /// </summary>
        public Feature FeatureSelectionne
        {
            get
            {
                return (listviewCaracteristique.SelectedItems.Count == 1) && (listviewCaracteristique.SelectedItems[0].Tag is Charact)
                    ? listviewCaracteristique.SelectedItems[0].Tag as Feature
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listviewCaracteristique.Items)
                    {
                        if ((Element.Tag is Feature) && (Element.Tag as Feature).Id.Equals(value.Id))
                        {
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listviewCaracteristique.SelectedItems.Clear();
            }
        }


        /// <summary>
        /// Evénement déclenché quand il y a un changement de sélection de sous Feature
        /// </summary>
        public event EventHandler SurChangementSelection = null;

        /// <summary>
        /// Met à jour la listview des sous Features et y insére les elements
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Entites"></param>
        /// <returns></returns>
        private bool MettreAJourListe<T>(IEnumerable<T> Entites)
            where T : class, IEntiteMySQL
        {
            bool EstCaracteristique = typeof(T).Equals(typeof(CharactFeature));
            if (!EstCaracteristique) return false;
            listviewCaracteristique.Items.Clear();
            if (Entites == null) return false;
            if (EstCaracteristique && (listviewCaracteristique.Columns.Count != 2))
            {
                listviewCaracteristique.Columns.Clear();


                listviewCaracteristique.Columns.Add(new ColumnHeader()
                {
                    Name = "Caracteristique",
                    Text = "Caracteristiques",
                    TextAlign = HorizontalAlignment.Center,
                });

                listviewCaracteristique.Columns.Add(new ColumnHeader()
                {
                    Name = "Valeur",
                    Text = "Valeurs",
                    TextAlign = HorizontalAlignment.Center,
                });

            }

            foreach (T Entite in Entites)
            {
                
                CharactFeature Caracteristique = Entite as CharactFeature;

                if (EstCaracteristique)
                {
                    ListViewItem NouvelElement = new ListViewItem()
                    {
                        Tag = Entite,
                        Text = Caracteristique.Feature.Name,
                    };
                    NouvelElement.SubItems.Add(Caracteristique.Value.ToString());

                    listviewCaracteristique.Items.Add(NouvelElement);

                }
            }

            listviewCaracteristique.Visible = false;
            foreach (ColumnHeader Colonne in listviewCaracteristique.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listviewCaracteristique.Visible = true;
            listViewCaractere_SelectedIndexChanged(listviewCaracteristique, EventArgs.Empty);
            return true;
        }



        /// <summary>
        /// Evénement déclenché en cas de changement de sélection de sous Feature
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
        /// Nettoie la listview des elements s'y trouvant
        /// </summary>
        public void NettoyerListView()
        {
            listviewCaracteristique.Clear();
        }

    }
}
