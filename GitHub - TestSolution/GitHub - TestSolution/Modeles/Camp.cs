using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Camp : Entite<Camp, Camp.Champ>
    {
        /// <summary>
        /// Champ décrivant cette faction
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant du scénario
            /// </summary>
            Id,
            /// <summary>
            /// nom de la faction
            /// </summary>
            Name
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ name
        /// </summary>
        private string m_Name;

        #endregion

        #region Membres public
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Declencher_SurErreur(this, Champ.Name, "Nom vide ou ne contient que des espaces");
                }
                else if (value.Trim().Length > 20)
                {
                    Declencher_SurErreur(this, Champ.Name, "Ce champ peut contenir au maximum 20 caractères");
                }
                else
                {
                    value = value.Trim();
                    if (!string.Equals(value, m_Name))
                    {
                        ModifierChamp(Champ.Name, ref m_Name, value);
                    }
                }
            }
        }
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Camp() : base()
        {
            m_Name = string.Empty;
            //m_Scenario_Camp = new List<Scenario_Camp>();
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du scénario</param>
        /// <param name="name">Nom du scénario</param>
        public Camp(int Id, string name) : this()
        {
            DefinirId(Id);
            this.Name = Name;
        }


        public Camp(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "ca_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "ca_name");
            }
        }
        #endregion

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Camp> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Camp(Connexion, Enregistrement));
        }

        #region Méthodes relatives au gestionnaire d'entités pour base de données MySQL
        /// <summary>
        /// Méthode retournant le name de la table principale de ce type d'entités
        /// </summary>
        /// <return>name de la table principale de ce type d'entités</return>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "camp";
            }
        }

        /// <summary>
        /// Méthode retournant le nom du champs id de la table scenario
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "ca_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("ca_name = {0}", m_Name);
            }
        }

        /* private IEnumerable<Scenario_Camp> EnumererScenario_Camp()
         {
             if (base.Connexion == null) return new Scenario_Camp[0];
             return Scenario_Camp.Enumerer(Connexion, Connexion.Enumerer(
                 @"SELECT sca_id,
                     FROM scenario_camp
                     WHERE (ca_id = {0})",
                 Id)); 
         } */
        #endregion
    }
}
