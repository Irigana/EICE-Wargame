using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Feature : Entite<Feature, Feature.Champ>
    {
       
        /// <summary>
        /// Champ décrivant cette Feature
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette Feature
            /// </summary>
            Id,
            /// <summary>
            /// Nom de cette Feature
            /// </summary>
            Name,
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;  
        #endregion

        #region Membres publics
        /// <summary>
        /// Nom de cette Feature
        /// </summary>
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
                    if(!string.Equals(value, m_Name))
                    {
                        ModifierChamp(Champ.Name, ref m_Name, value);
                    }
                }
            }
        }
        #endregion
		        
        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Feature()
            : base()
        {
            m_Name = string.Empty;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de cette Feature</param>
        /// <param name="Name">Nom de cette Feature</param>
        /// <param name="Value">Valeur de cette Feature</param>
        public Feature(int Id, string Name, int Value)
            : this()
        {
            DefinirId(Id);
            this.Name = Name;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Feature(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "fe_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "fe_name");
			}
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Feature> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Feature(Connexion, Enregistrement));
         }
        
        #endregion

        #region Méthodes relatives au gestionnaire d'entités pour base de données MySQL
        
        /// <summary>
        /// Méthode retournant le nom de la table principale de ce type d'entités
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "feature";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table feature
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "fe_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
				return new PDSGBD.MyDB.CodeSql("fe_name = {0}", m_Name);
            }
        }
        
		/// <summary>
        /// Permet de supprimer tous les changements de Featureus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM feature WHERE fe_id = {0}", Id);
        }
        #endregion

    }
}
