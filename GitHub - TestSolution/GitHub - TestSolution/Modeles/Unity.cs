using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
	public class Unity : Entite<Unity, Unity.Champ>
	{
        /// <summary>
        /// Champ décrivant cette Unity
        /// </summary>
        public enum Champ
		{
            /// <summary>
            /// Identifiant de cette Unity
            /// </summary>
            Id,
            /// <summary>
            /// name de ce Unity
            /// </summary>
            Name
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;

        /// <summary>
        /// Stocke les SubUnity liées à cette unity
        /// </summary>
        private List<SubUnity> m_Subunity;

        #endregion

        #region Membres publics
        /// <summary>
        /// Name de ce Unity
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
                else if(value.Trim().Length >20)
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

		public IEnumerable<SubUnity> Subunity
        {
            get
            {
                return EnumererSubUnity();
            }
        }
		#endregion

		#region Constructeur
		/// <summary>
		/// Constructeur par défaut
		/// </summary>
		public Unity() 
            : base()
        {
			m_Name = string.Empty;
            m_Subunity = new List<SubUnity>();
		}

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce Unity</param>
        /// <param name="Name">Nom de l'unité</param>
        public Unity(int Id, string Name) 
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
		public Unity(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
			base.Connexion = Connexion;
			if (Enregistrement != null)
			{
				DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "un_id"));
				this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "un_name");                
			}
		}

		#endregion

		/// <summary>
		/// Permet d'énumérer les entités correspondant aux enregistrements énumérés
		/// </summary>
		/// <param name="Connexion">Connexion au serveur MySQL</param>
		/// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
		/// <returns>Enumération des entités issues des enregistrements énumérés</returns>
		public static IEnumerable<Unity> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
		{
			return Enumerer(Enregistrements, Enregistrement => new Unity(Connexion, Enregistrement));
		}

		
		#region Méthodes relatives au gestionnaire d'entités pour base de données MySQL
		/// <summary>
		/// Méthode retournant le name de la table principale de ce type d'entités
		/// </summary>
		/// <returns>name de la table principale de ce type d'entités</returns>
		public override string NomDeLaTablePrincipale
		{
			get
			{
				return "unity";
			}
		}

        /// <summary>
        /// Méthode retournant le nom du champs id de la table Unity
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "un_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
		{
			get
			{
				return new PDSGBD.MyDB.CodeSql("un_name = {0}", m_Name);
			}
		}

        private IEnumerable<SubUnity> EnumererSubUnity()
        {
            if (base.Connexion == null) return new SubUnity[0];
            return SubUnity.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT su_id, su_name, su_fk_unity_id
                    FROM subunity
                    WHERE (su_fk_unity_id = {0})",
                Id));
        }

        public override void SupprimerEnCascade(MyDB Connexion)
        {
            Connexion.Executer(@"DELETE FROM unity WHERE un_id = {0};
                                 "
                                , Id);
        }
        

        #endregion

    }
}
