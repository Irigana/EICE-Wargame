using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Condi_Camp : Entite<Condi_Camp, Condi_Camp.Champ>
    {
        // Champ décrivant la table Condi_Camp
        public enum Champ
        {
            Id,
            Scenario_Camp,
            Unity,
            Min,
            Max
        }

        #region Membres privés
        /// <summary>
        /// Membre stockant la ref vers la table Scenario_Camp
        /// </summary>
        private Scenario_Camp m_Scenario_Camp;
        /// <summary>
        /// Membre sotckant la ref vers la table Unity
        /// </summary>
        private Unity m_Unity;
        /// <summary>
        /// Membre stockant la valeur de min
        /// </summary>
        private int m_Min;
        /// <summary>
        /// Membre stockant la valeur de max
        /// </summary>
        private int m_Max;
        #endregion

        #region Membres publics
        /// <summary>
        /// Membre public permettant d'accéder à l'id du scenario_camp
        /// </summary>
        public Scenario_Camp Scenario_Camp
        {
            get
            {
                return m_Scenario_Camp;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Scenario_Camp, "Scenario_Camp non défini");
                }
                else
                {
                    if ((m_Scenario_Camp == null) || !int.Equals(value.Id, m_Scenario_Camp.Id))
                    {
                        ModifierChamp(Champ.Scenario_Camp, ref m_Scenario_Camp, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id du scenario_camp
        /// </summary>
        public Unity Unity
        {
            get
            {
                return m_Unity;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Scenario_Camp, "Unity non défini");
                }
                else
                {
                    if ((m_Unity == null) || !int.Equals(value.Id, m_Unity.Id))
                    {
                        ModifierChamp(Champ.Unity, ref m_Unity, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à Min
        /// </summary>
        public int Min
        {
            get
            {
                return m_Min;
            }

            set
            {
                if (value <= 0)
                {
                    Declencher_SurErreur(this, Champ.Min, "La valeur \"Min\" doit être strictement supérieur à 0");
                }
                else if (value >= 100)
                {
                    Declencher_SurErreur(this, Champ.Min, "La valeur \"Min\" doit être inférieur à 100");
                }
                else
                {
                    ModifierChamp(Champ.Min, ref m_Min, value);
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à Max
        /// </summary>
        public int Max
        {
            get
            {
                return m_Max;
            }

            set
            {
                if (value < 0)
                {
                    Declencher_SurErreur(this, Champ.Max, "La valeur \"Max\" doit être strictement supérieur à 0");
                }
                else if (value >= 100)
                {
                    Declencher_SurErreur(this, Champ.Max, "La valeur \"Max\" doit être inférieur à 100");
                }
                else
                {
                    ModifierChamp(Champ.Max, ref m_Max, value);
                }
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Condi_Camp() : base()
        {
            m_Scenario_Camp = null;
            m_Unity = null;
            m_Min = -1;
            m_Max = -1;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        public Condi_Camp(int Id, Scenario_Camp Scenario_Camp, Unity Unity, int Min, int Max) : this()
        {
            DefinirId(Id);
            this.Scenario_Camp = Scenario_Camp;
            this.Unity = Unity;
            this.Min = Min;
            this.Max = Max;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Condi_Camp(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cc_id"));
                this.Scenario_Camp = new Scenario_Camp(Connexion, Enregistrement);
                this.Unity = new Unity(Connexion, Enregistrement);
                this.Min = Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cc_min");
                this.Max = Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cc_max");
            }
        }

        public static IEnumerable<Condi_Camp> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Condi_Camp(Connexion, Enregistrement));
        }
        #endregion

        #region Membres relatifs à DB
        /// <summary>
        /// Méthode retournant le nom de la table principale de condi_camp
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "condi_camp";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table condi_camp
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "cc_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("cc_fk_scenario_camp_id = {0}, cc_fk_unity_id = {1}, cc_min = {2}, cc_max = {3}", m_Scenario_Camp.Id, m_Unity.Id, m_Min, m_Max);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM condi_camp WHERE cc_fk_scenario_camp_id = {0}", Scenario_Camp.Id);
        }

        #endregion
        
    }
}
