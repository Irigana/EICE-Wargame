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
    public partial class PageMenuPrincipal : UserControl
    {
        private Utilisateur m_Utilisateur = null;

        public Utilisateur Utilisateur
        {
            get
            {
                return m_Utilisateur;
            }
            set
            {
                if ((m_Utilisateur == null) && (value != null))
                {
                    m_Utilisateur = value;
                    buttonOptionsUser1.Utilisateur = m_Utilisateur;
                }
            }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public PageMenuPrincipal()
        {
            InitializeComponent();
            m_Utilisateur = null;
        }               

        private void PageMenuPrincipal_Load(object sender, EventArgs e)
        {
            if (Utilisateur != null)
            {
                buttonOptionsUser1.ButtonOptionsUserUpdate();
            }
            else
            {
                Form_Principal.Instance.CreerPageCourante<PageConnexion>();
            }
        }
    }
}
