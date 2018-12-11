using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class ArmyUnityFigurineStuff : Entite<ArmyUnityFigurineStuff, ArmyUnityFigurineStuff.Champ>
    {
        /// <summary>
        /// Champs décrivant cette ArmyUnityFigurineStuff
        /// </summary>
        public enum Champ
        {
            Id,
            FigurineStuff,
            ArmyUnity,
            Rank,
        }

        #region Membres privés
        /// <summary>
        /// Membre stockant la référence de FigurineStuff
        /// </summary>
        private FigurineStuff m_FigurineStuff;

        /// <summary>
        /// Membre stockant la référence de Army
        /// </summary>
        private ArmyUnity m_ArmyUnity;

        /// <summary>
        /// Membre stockant la référence Rank
        /// </summary>
        private Rank m_Rank;

        #endregion

        #region Membres publics

        /// <summary>
        /// Membre public permettant d'accéder à l'id de la Figurine
        /// </summary>
        public FigurineStuff FigurineStuff
        {
            get
            {
                return m_FigurineStuff;
            }

            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.FigurineStuff, "Figurine non définie");
                }
                else
                {
                    if ((m_FigurineStuff == null) || !int.Equals(value.Id, m_FigurineStuff.Id))
                    {
                        ModifierChamp(Champ.FigurineStuff, ref m_FigurineStuff, value);
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
        public Rank Rank
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
        public ArmyUnityFigurineStuff()
        : base()
        {
            m_FigurineStuff = null;
            m_ArmyUnity = null;
            m_Rank= null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du ArmyUnityFigurineStuff</param>
        /// <param name="Army">Army de ce ArmyUnityFigurineStuff</param>
        /// <param name="FigurineStuff">FigurineStuff de ce ArmyUnityFigurineStuff</param>
        /// <param name="Rank">Rank de ce ArmyUnityFigurineStuff</param>
        public ArmyUnityFigurineStuff(int Id, ArmyUnity ArmyUnity, FigurineStuff FigurineStuff, Rank Rank)
        : this()
        {
            DefinirId(Id);
            this.FigurineStuff = FigurineStuff;
            this.ArmyUnity = ArmyUnity;
            this.Rank = Rank;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public ArmyUnityFigurineStuff(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "aufs_id"));
                this.ArmyUnity = new ArmyUnity(Connexion, Enregistrement);
                this.FigurineStuff = new FigurineStuff(Connexion, Enregistrement);
                this.Rank = new Rank(Connexion, Enregistrement);
            }
        }

        #endregion

        #region Membres relatifs à la base de données

        /// <summary>
        /// Méthode retournant le nom de la table principale de ArmyUnityFigurineStuff
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "army_unity_figurine_stuff";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table ArmyUnityFigurineStuff
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "aufs_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("fs_fk_figurine_stuff_id = {0}, fs_fk_rank_id = {1}, fs_fk_army_unity_id = {2}", m_FigurineStuff.Id, m_Rank.Id, m_ArmyUnity.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM ArmyUnityFigurineStuff WHERE aufs_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<ArmyUnityFigurineStuff> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new ArmyUnityFigurineStuff(Connexion, Enregistrement));
        }

        #endregion

    }
}
