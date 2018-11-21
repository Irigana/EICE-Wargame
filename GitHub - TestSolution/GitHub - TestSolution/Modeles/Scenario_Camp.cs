using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME.Modeles
{
    public class Scenario_Camp : Entite<Scenario_Camp, Scenario_Camp.Champ>
    {
        /// <summary>
        /// Champ décrivant la table scenario_camp
        /// </summary>
        public enum Champ
        {
            Id,
            Scenario,
            Camp
        }

        #region Membre privé
        /// <summary>
        /// Membre stockant la réf&rence du scénario
        /// </summary>
        private Scenario m_Scenario;

        /// <summary>
        /// Membr stockant la réf&rence du camp
        /// </summary>
        private Camp m_Camp;
        #endregion

        #region Membre public
        /// <summary>
        /// Membre public permettant d'accéder à l'id du Scénario
        /// </summary>
        public Scenario Scenario
        {
            get
            {
                return m_Scenario;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Scenario, "Scénario non défini");
                }
                else
                {
                    if ((m_Scenario == null) || int.Equals(value.Id, m_Scenario.Id))
                    {
                        ModifierChamp(Champ.Scenario, ref m_Scenario, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre permettant d'accéder à l'id du Camp
        /// </summary>
        public Camp Camp
        {
            get
            {
                return m_Camp;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Camp, "Camp non défini");
                }
                else
                {
                    if ((m_Camp == null) || int.Equals(value.Id, m_Camp.Id))
                    {
                        ModifierChamp(Champ.Camp, ref m_Camp, value);
                    }
                }
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Scenario_Camp() : base()
        {
            m_Camp = null;
            m_Scenario = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">ID de la table Scenario_Camp</param>
        /// <param name="Camp">Camp de ce Scenario_Camp</param>
        /// <param name="Scenario">Scenario de ce Scenario_Camp</param>
        public Scenario_Camp(int Id, Camp Camp, Scenario Scenario) : this()
        {
            DefinirId(Id);
            this.Camp = Camp;
            this.Scenario = Scenario;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion"> Connexion au serveur MySQL</param>
        /// <param name="Enregistrement"> Enregistrement d'où extraire les valeurs des champs</param>
        public Scenario_Camp(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "sca_id"));
                this.Camp = new Camp(Connexion, Enregistrement);
                this.Scenario = new Scenario(Connexion, Enregistrement);
            }
        }
        #endregion

        #region Membres relatifs à la base de données
        /// <summary>
        /// Méthode retournant le nom de la table Scenario_Camp
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "scenario_camp";
            }
        }

        /// <summary>
        /// Méthode retournant l'id principal de la table Scenarion_Camp
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "sca_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("sca_fk_camp_id = {0}, sca_fk_scenario_id = {1}", m_Camp.Id, m_Scenario.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Types liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(MyDB Connexion)
        {
            Connexion.Executer("DELETE from scenario_camp WHERE sca_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Scenario_Camp> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Scenario_Camp(Connexion, Enregistrement));
        }
        #endregion
    }
}
