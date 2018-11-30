using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
	public class Scenario : Entite<Scenario, Scenario.Champ>
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

		/// <summary>
		/// Référence de la table Scenario_Camp
		/// </summary>
		//private List<Scenario_Camp> m_Scenario_Camp;
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
				else if (value.Trim().Length > 30)
				{
					Declencher_SurErreur(this, Champ.Name, "Ce champ peut contenir au maximum 30 caractères");
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

		/*public IEnumerable<Scenario_Camp> Scenario_Camp
		{
			get
			{
				return EnumererScenario_Camp();
			}
		}*/
		#endregion

		#region Constructeur
		/// <summary>
		/// Constructeur par défaut
		/// </summary>
		public Scenario() : base()
		{
			m_Name = string.Empty;
			//m_Scenario_Camp = new List<Scenario_Camp>();
		}

		/// <summary>
		/// Constructeur spécifique
		/// </summary>
		/// <param name="Id">Identifiant du scénario</param>
		/// <param name="name">Nom du scénario</param>
		public Scenario(int Id, string name) : this()
		{
			DefinirId(Id);
			this.Name = Name;
		}


		public Scenario(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
		{
			base.Connexion = Connexion;
			if (Enregistrement != null)
			{
				DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "sc_id"));
				this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "sc_name");
			}
		}
		#endregion

		/// <summary>
		/// Permet d'énumérer les entités correspondant aux enregistrements énumérés
		/// </summary>
		/// <param name="Connexion">Connexion au serveur MySQL</param>
		/// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
		/// <returns>Enumération des entités issues des enregistrements énumérés</returns>
		public static IEnumerable<Scenario> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
		{
			return Enumerer(Enregistrements, Enregistrement => new Scenario(Connexion, Enregistrement));
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
				return "scenario";
			}
		}

		/// <summary>
		/// Méthode retournant le nom du champs id de la table scenario
		/// </summary>
		public override string IdDeLaTablePrincipale
		{
			get
			{
				return "sc_id";
			}
		}

		/// <summary>
		/// Clause d'assignation utilisable dans une requête INSERT/UPDATE
		/// </summary>
		public override PDSGBD.MyDB.CodeSql ClauseAssignation
		{
			get
			{
				return new PDSGBD.MyDB.CodeSql("sc_name = {0}", m_Name);
			}
		}

		/*private IEnumerable<Scenario_Camp> EnumererScenario_Camp()
		{
			if (base.Connexion == null) return new Scenario_Camp[0];
			return Scenario_Camp.Enumerer(Connexion, Connexion.Enumerer(
				@"SELECT sca_id,
					FROM scenario_camp
					WHERE (sc_id = {0})",
				Id));
		}*/
		#endregion
	}
}
