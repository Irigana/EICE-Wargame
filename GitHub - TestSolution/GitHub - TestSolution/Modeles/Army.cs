using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Army : Entite<Army, Army.Champ>
    {

        /// <summary>
        /// Champ décrivant cette Army
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette Army
            /// </summary>
            Id,
            /// <summary>
            /// Nom de cette Army
            /// </summary>
            Name,
            /// <summary>
            /// Scénario et le camp prévu pour cette armée
            /// </summary>
            ScenarioCamp,
            /// <summary>
            /// Utilisateur dispostant de cette armée
            /// </summary>
            Utilisateur,
            /// <summary>
            /// Maximum de point de cette armée
            /// </summary>
            PointsMaximum,
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private Scenario_Camp m_ScenarioCamp;
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private Utilisateur m_Utilisateur;
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private int m_PointsMaximum;
        #endregion

        #region Membres publics
        /// <summary>
        /// Nom de cette Army
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
                    if (!string.Equals(value, m_Name))
                    {
                        ModifierChamp(Champ.Name, ref m_Name, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id du scénario
        /// </summary>
        public Scenario_Camp ScenarioCamp
        {
            get
            {
                return m_ScenarioCamp;
            }

            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.ScenarioCamp, "Scénario et camp non défini");
                }
                else
                {
                    if ((m_ScenarioCamp == null) || int.Equals(value.Id, m_ScenarioCamp.Id))
                    {
                        ModifierChamp(Champ.ScenarioCamp, ref m_ScenarioCamp, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id de l'utilisateur
        /// </summary>
        public Utilisateur Utilisateur
        {
            get
            {
                return m_Utilisateur;
            }

            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Utilisateur, "Utilisateur non défini");
                }
                else
                {
                    if ((m_Utilisateur == null) || int.Equals(value.Id, m_Utilisateur.Id))
                    {
                        ModifierChamp(Champ.Utilisateur, ref m_Utilisateur, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder au nombre de point maximum pour cette armée
        /// </summary>
        public int PointsMaximum
        {
            get
            {
                return m_PointsMaximum;
            }

            set
            {
                if (value < int.MinValue)
                {
                    Declencher_SurErreur(this, Champ.PointsMaximum, "Nombre de points inférieur au minimum autorisé");
                }
                else if (value > int.MaxValue)
                {
                    Declencher_SurErreur(this, Champ.PointsMaximum, "Nombre de points supérieur au maximum autoriser");
                }
                else
                {
                    if (!int.Equals(value, m_PointsMaximum))
                    {
                        ModifierChamp(Champ.PointsMaximum, ref m_PointsMaximum, value);
                    }
                }
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Army()
            : base()
        {
            m_Name = string.Empty;
            m_PointsMaximum = -1;
            m_ScenarioCamp = null;
            m_Utilisateur = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de cette Army</param>
        /// <param name="Name">Nom de cette Army</param>
        /// <param name="PointsMaximum">Points maximum de cette Army</param>
        /// <param name="Utilisateur">Utilisateur de cette Army</param>
        /// <param name="Scenario">Scenario de cette Army</param>
        public Army(int Id, string Name, int PointsMaximum,Utilisateur Utilisateur,Scenario_Camp ScenarioCamp)
            : this()
        {
            DefinirId(Id);
            this.Name = Name;
            this.Utilisateur = Utilisateur;
            this.ScenarioCamp = ScenarioCamp;
            this.PointsMaximum = PointsMaximum;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Army(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "ar_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "ar_name");
                this.ScenarioCamp = new Scenario_Camp(Connexion, Enregistrement);
                this.Utilisateur = new Utilisateur(Connexion, Enregistrement);
                this.PointsMaximum = PointsMaximum;
            }
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Army> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Army(Connexion, Enregistrement));
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
                return "Army";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table Army
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "ar_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("ar_name = {0}, ar_fk_scenario_camp_id = {1}, ar_fk_user_id = {3}, ar_max_point = {4}", Name,ScenarioCamp.Id, Utilisateur.Id,PointsMaximum);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Armyus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM Army WHERE fe_id = {0}", Id);
        }
        #endregion

    }
}
