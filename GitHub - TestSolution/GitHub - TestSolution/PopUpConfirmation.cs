using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EICE_WARGAME
{
    public partial class PopUpConfirmation : Form
    {
        public PopUpConfirmation()
        {
            InitializeComponent();
        }

        private string m_LabelDuTexte = null;
        private bool m_Confirmation = false;
        private bool m_Annulation = false;


        public string LabelDuTexte
        {
            get
            {
                return m_LabelDuTexte;
            }
            set
            {
                value = value.Trim();
                if (!string.Equals(value, m_LabelDuTexte))
                {
                    string NouvelleValue = null;
                    // TODO (opti): à amélioré 
                    if ((value.Length > 60)&&(value.Length < 120))
                    {
                        NouvelleValue = value.ToString().Insert(50, "\n");
                        labelTexteAfficher.Text = NouvelleValue;
                    }
                    else
                    {
                        labelTexteAfficher.Text = value;
                    }
                    if (value.Length > 120)
                    {
                        NouvelleValue = value.ToString().Insert(55, "\n").Insert(110,"\n");
                        labelTexteAfficher.Text = NouvelleValue;
                    }
                    else if(value.Length > 140)
                    {
                        labelTexteAfficher.Text = "Texte trop long";
                    }
                    else
                    {
                        labelTexteAfficher.Text = value;
                    }
                }
            }
        }

        public bool Confirmation
        {
            get
            {
                return m_Confirmation;
            }
            private set
            {
                if(value != m_Confirmation)
                {
                    m_Confirmation = value;
                }
            }
        }

        public bool Annulation
        {
            get
            {
                return m_Annulation;
            }
            private set
            {
                if (value != m_Annulation)
                {
                    m_Annulation = value;
                }
            }
        }

        private void buttonConfirmer_Click(object sender, EventArgs e)
        {
            Confirmation = true;
            this.Close();
        }

        private void buttonAnnuler_Click(object sender, EventArgs e)
        {
            Annulation = true;
            this.Close();
        }
    }
}
