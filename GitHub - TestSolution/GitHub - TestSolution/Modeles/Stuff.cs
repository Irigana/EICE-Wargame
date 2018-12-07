using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Stuff : Entite<Stuff, Stuff.Champ>
    {
       
        /// <summary>
        /// Champ décrivant cette Stuff
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette Stuff
            /// </summary>
            Id,
            /// <summary>
            /// Nom de cette Stuff
            /// </summary>
            Name,
            /// <summary>
            /// Type de cette Stuff
            /// </summary>
            Type,
            /// <summary>
            /// Visibilité de cette Stuff
            /// </summary>
            Visibility,

        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;
        /// <summary>
        /// Stocke la visibilité du champ Cost
        /// </summary>
        private byte m_Visibility;
        /// <summary>
        /// Stocke le type de cette Stuff
        /// </summary>
        private Type m_Type;

        /// <summary>
        /// Stocke les caractéristiques de cette Stuff
        /// </summary>
        private List<StuffFeature> m_Features;
        
		#endregion

		#region Membres publics
		/// <summary>
		/// Nom de cette Stuff
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
        /// Visibilité de cette Stuff
        /// </summary>
        public byte Visibility
        {
            get
            {
                return m_Visibility;
            }

            set
            {
                ModifierChamp(Champ.Visibility, ref m_Visibility, value);
            }
        }


        /// <summary>
        /// Id du type de stuff
        /// </summary>
        public Type Type
        {
            get
            {
                return m_Type;
            }
            set
            {
                if (!int.Equals(value, Type))
                {
                    ModifierChamp(Champ.Type, ref m_Type, value);
                }
            }
        }

        /// <summary>
        /// Liste des Types de Stuff
        /// </summary>
        public IEnumerable<StuffFeature> Features
        {
            get
            {
                return EnumererStuffFeature();
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Stuff()
            : base()
        {
            m_Name = string.Empty;
            m_Features = new List<StuffFeature>();
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de cette Stuff</param>
        /// <param name="Name">Nom de cette Stuff</param>
        /// <param name="Cost">Visibilité de cette Stuff</param>
        public Stuff(int Id, string Name, byte Visibility)
            : this()
        {
            DefinirId(Id);
            this.Name = Name;
            this.Visibility = Visibility;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Stuff(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "st_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "st_name");
                
                this.Visibility = Enregistrement.ValeurChampComplet<byte>(NomDeLaTablePrincipale, "st_visibility");
			}
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Stuff> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Stuff(Connexion, Enregistrement));
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
                return "stuff";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table type
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "st_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
				return new PDSGBD.MyDB.CodeSql("st_name = {0}, st_fk_type_id = {1}, st_visibility = {2}", m_Name, m_Type.Id, m_Visibility);
            }
        }

        /// <summary>
        /// Permet d'énumrer les stuff_features liés à cette stuff
        /// </summary>
        /// <returns></returns>
        public IEnumerable<StuffFeature> EnumererStuffFeature()
        {
            if (base.Connexion == null) return new StuffFeature[0];
            return StuffFeature.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT st_id, st_name,
                         stf_id, stf_value,
                         fe_id, fe_name
                FROM stuff
                INNER JOIN stuff_feature on st_id = stf_fk_stuff_id
                INNER JOIN feature on fe_id = stf_fk_feature_id
                WHERE st_id = {0}",
                Id));
        }

           
        /// <summary>
        /// Permet de supprimer tous les changements de Stuffus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM stuff WHERE st_id = {0}", Id);
            Connexion.Executer("DELETE FROM stuff_feature WHERE stf_fk_stuff_id = {0}", Id);
        }
        #endregion

    }
}
