using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Type : Entite<Type, Type.Champ>
    {
       
        /// <summary>
        /// Champ décrivant cette Type
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette Type
            /// </summary>
            Id,
            /// <summary>
            /// Nom de cette Type
            /// </summary>
            Name,
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;

        /// <summary>
        /// Stocke les Stuffs liées à ce Type
        /// </summary>
        private List<Stuff> m_Stuff;
        #endregion

        #region Membres publics
        /// <summary>
        /// Nom de cette Type
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

        /// <summary>
        /// Liste des Types de Stuff
        /// </summary>
        public IEnumerable<Stuff> Stuffs
        {
            get
            {
                return EnumererStuffs();
            }
        }

        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Type()
            : base()
        {
            m_Name = string.Empty;
            m_Stuff = new List<Stuff>();
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de cette Type</param>
        /// <param name="Name">Nom de cette Type</param>
        /// <param name="Value">Valeur de cette Type</param>
        public Type(int Id, string Name, int Value)
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
        public Type(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "ty_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "ty_name");
			}
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Type> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Type(Connexion, Enregistrement));
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
                return "type";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table type
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "ty_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
				return new PDSGBD.MyDB.CodeSql("ty_name = {0}", m_Name);
            }
        }
        
		/// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM type WHERE ty_id = {0}", Id);
        }
        
        /// <summary>
        /// Permet d'énumrer les stuffs liés à ce type
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Stuff> EnumererStuffs()
        {
            if (base.Connexion == null) return new Stuff[0];
            return Stuff.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT st_id, st_name,
                    FROM stuff
                    WHERE (ty_id = {0}",
                Id));
        }

        #endregion

    }
}
