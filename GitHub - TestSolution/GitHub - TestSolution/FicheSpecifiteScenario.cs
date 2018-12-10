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
    public partial class FicheSpecifiteScenario : UserControl
    {

        private List<Condi_Camp> m_ListeCondiCamp = new List<Condi_Camp>();       

        public FicheSpecifiteScenario()
        {

            InitializeComponent();

            listViewSpecificite.View = View.Details;
            listViewSpecificite.FullRowSelect = true;
            listViewSpecificite.LabelEdit = false;
            listViewSpecificite.Scrollable = true;
            listViewSpecificite.AllowColumnReorder = false;
            listViewSpecificite.MultiSelect = false;
            listViewSpecificite.GridLines = true;
            listViewSpecificite.HideSelection = false;
            listViewSpecificite.Items.Clear();
            listViewSpecificite.Columns.Clear();
            listViewSpecificite.SelectedIndexChanged += listViewCaractere_SelectedIndexChanged;
        }


        public IEnumerable<Condi_Camp> SpecifiteScenario
        {
            get
            {
                return listViewSpecificite.Items
                    .OfType<ListViewItem>()
                    .Where(Element => Element.Tag is Condi_Camp)
                    .Select(Element => Element.Tag as Condi_Camp);
            }
            set
            {
                MettreAJourListe(value);
            }
        }

        public List<Condi_Camp> ListeCondiCamp
        {
            get
            {
                return m_ListeCondiCamp;
            }          
        }

        /// <summary>
        /// Type de Feature sélectionné
        /// </summary>
        public Condi_Camp SpecificiteSelectionne
        {
            get
            {
                return (listViewSpecificite.SelectedItems.Count == 1) && (listViewSpecificite.SelectedItems[0].Tag is Condi_Camp)
                    ? listViewSpecificite.SelectedItems[0].Tag as Condi_Camp
                    : null;
            }
            set
            {
                if (value != null)
                {
                    foreach (ListViewItem Element in listViewSpecificite.Items)
                    {
                        if ((Element.Tag is Condi_Camp) && (Element.Tag as Condi_Camp).Id.Equals(value.Id))
                        {
                            m_ListeCondiCamp.Add(value);
                            Element.Selected = true;
                            return;
                        }
                    }
                }
                listViewSpecificite.SelectedItems.Clear();
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
            bool EstSpecifiteScenario = typeof(T).Equals(typeof(Condi_Camp));
            if (!EstSpecifiteScenario) return false;
            listViewSpecificite.Items.Clear();
            if (Entites == null) return false;
            if (EstSpecifiteScenario && (listViewSpecificite.Columns.Count != 2))
            {
                listViewSpecificite.Columns.Clear();


                listViewSpecificite.Columns.Add(new ColumnHeader()
                {
                    Name = "NomUnity",
                    Text = "Nom de l'unité",
                    TextAlign = HorizontalAlignment.Center,
                });

                listViewSpecificite.Columns.Add(new ColumnHeader()
                {
                    Name = "Min",
                    Text = "Min",
                    TextAlign = HorizontalAlignment.Center,
                });
                listViewSpecificite.Columns.Add(new ColumnHeader()
                {
                    Name = "Max",
                    Text = "Max",
                    TextAlign = HorizontalAlignment.Center,
                });

            }

            foreach (T Entite in Entites)
            {

                Condi_Camp SpecificiteScenario = Entite as Condi_Camp;

                if (EstSpecifiteScenario)
                {
                    ListViewItem NouvelElement = new ListViewItem()
                    {
                        Tag = Entite,
                        Text = SpecificiteScenario.Unity.Name,
                    };
                    NouvelElement.SubItems.Add(SpecificiteScenario.Min.ToString());
                    NouvelElement.SubItems.Add(SpecificiteScenario.Max.ToString());
                    listViewSpecificite.Items.Add(NouvelElement);

                }
            }

            listViewSpecificite.Visible = false;
            foreach (ColumnHeader Colonne in listViewSpecificite.Columns)
            {
                Colonne.AutoResize(ColumnHeaderAutoResizeStyle.HeaderSize);
            }

            listViewSpecificite.Visible = true;
            listViewCaractere_SelectedIndexChanged(listViewSpecificite, EventArgs.Empty);
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
            listViewSpecificite.Clear();
        }

    }
}