using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class ArmyUnityFigurine : Entite<ArmyUnityFigurine, ArmyUnityFigurine.Champ>
    {
        /// <summary>
        /// Champs décrivant cette ArmyUnityFigurine
        /// </summary>
        public enum Champ
        {
            Id,
            Figurine,
            ArmyUnity,
            Rank,
        }

        #region Membres privés
        /// <summary>
        /// Membre stockant la référence de Figurine
        /// </summary>
        private Figurine m_Figurine;

        /// <summary>
        /// Membre stockant la référence de Army
        /// </summary>
        private ArmyUnity m_ArmyUnity;

        /// <summary>
        /// Membre stockant la référence Rank
        /// </summary>
        private CharactRank m_Rank;

        #endregion

        #region Membres publics

        /// <summary>
        /// Membre public permettant d'accéder à l'id de la Figurine
        /// </summary>
        public Figurine Figurine
        {
            get
            {
                return m_Figurine;
            }

            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Figurine, "Figurine non définie");
                }
                else
                {
                    if ((m_Figurine == null) || !int.Equals(value.Id, m_Figurine.Id))
                    {
                        ModifierChamp(Champ.Figurine, ref m_Figurine, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id de Army
        /// </summary>
        public ArmyUnity ArmyUnity
        {
            get
            {
                return m_ArmyUnity;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.ArmyUnity, "Armée non définie");
                }
                else
                {
                    if ((m_ArmyUnity == null) || !int.Equals(value.Id, m_ArmyUnity.Id))
                    {
                        ModifierChamp(Champ.ArmyUnity, ref m_ArmyUnity, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id du rank
        /// </summary>
        public CharactRank Rank
        {
            get
            {
                return m_Rank;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Rank, "Rank non défini");
                }
                else
                {
                    if ((m_Rank == null) || !int.Equals(value.Id, m_Rank.Id))
                    {
                        ModifierChamp(Champ.Rank, ref m_Rank, value);
                    }
                }
            }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ArmyUnityFigurine()
        : base()
        {
            m_Figurine = null;
            m_ArmyUnity = null;
            m_Rank= null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du ArmyUnityFigurine</param>
        /// <param name="Army">Army de ce ArmyUnityFigurine</param>
        /// <param name="Figurine">Figurine de ce ArmyUnityFigurine</param>
        /// <param name="Rank">Rank de ce ArmyUnityFigurine</param>
        public ArmyUnityFigurine(int Id, ArmyUnity ArmyUnity, Figurine Figurine, CharactRank Rank)
        : this()
        {
            DefinirId(Id);
            this.Figurine = Figurine;
            this.ArmyUnity = ArmyUnity;
            this.Rank = Rank;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public ArmyUnityFigurine(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "auf_id"));
                this.ArmyUnity = new ArmyUnity(Connexion, Enregistrement);
                this.Figurine = new Figurine(Connexion, Enregistrement);
                this.Rank = new CharactRank(Connexion, Enregistrement);
            }
        }

        #endregion

        #region Membres relatifs à la base de données

        /// <summary>
        /// Méthode retournant le nom de la table principale de ArmyUnityFigurine
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "army_unity_figurine";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table ArmyUnityFigurine
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "auf_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("auf_fk_figurine_id = {0}, auf_fk_rank_id = {1}, auf_fk_army_unity_id = {2}", m_Figurine.Id, m_Rank.Id, m_ArmyUnity.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM ArmyUnityFigurine WHERE auf_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<ArmyUnityFigurine> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new ArmyUnityFigurine(Connexion, Enregistrement));
        }

        #endregion

    }
}
