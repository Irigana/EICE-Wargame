using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class CharactRank : Entite<CharactRank, CharactRank.Champ>
    {
        /// <summary>
        /// Champs décrivant cette Charact_Rank
        /// </summary>
        public enum Champ
        {
            Id,
            Caractere,
            Rank,           
            Cost,
            SubUnity,
        }

        #region Membres privés

        /// <summary>
        /// Membre stockant la référence de caractère
        /// </summary>
        private Charact m_Charact;

        /// <summary>
        /// Membre stockant la référence de rank
        /// </summary>
        private Rank m_Rank;

        /// <summary>
        /// Membre stockant les features
        /// </summary>
        private List<CharactFeature> m_CharactFeature;

        /// <summary>
        /// Membre stockant la référence de sa sous unité
        /// </summary>
        private SubUnity m_SubUnity;        

        /// <summary>
        /// Membre stockant le cout 
        /// </summary>
        private int m_Cost;

        #endregion

        #region Membres publics       
        
        /// <summary>
        /// Membre public permettant d'accéder à l'id du rank
        /// </summary>
        public Charact Caractere
        {
            get
            {
                return m_Charact;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Caractere, "Caractère non défini");
                }
                else
                {
                    if ((m_Charact == null) || !int.Equals(value.Id, m_Charact.Id))
                    {
                        ModifierChamp(Champ.Caractere, ref m_Charact, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id de la sub unité
        /// </summary>
        public SubUnity SubUnity
        {
            get
            {
                return m_SubUnity;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Rank, "SubUnity non défini");
                }
                else
                {
                    if ((m_SubUnity == null) || !int.Equals(value.Id, m_SubUnity.Id))
                    {
                        ModifierChamp(Champ.SubUnity, ref m_SubUnity, value);
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

        /// <summary>
        /// Membre public permettant d'accéder au coût
        /// </summary>
        public int Cost
        {
            get
            {
                return m_Cost;
            }

            set
            {
                if (value < 0)
                {
                    Declencher_SurErreur(this, Champ.Cost, "Votre coût doit être supérieur à 0");
                }
                else if (value > int.MaxValue)
                {
                    Declencher_SurErreur(this, Champ.Cost, "Cout supérieur au maximum autoriser");
                }
                else
                {                    
                    if (!int.Equals(value, m_Cost))
                    {
                        ModifierChamp(Champ.Cost, ref m_Cost, value);
                    }
                }
            }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public CharactRank()
        : base()
        {
            m_Cost = -1;
            m_Charact = null;
            m_Rank = null;
            m_CharactFeature = null;
            m_SubUnity = null;        
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du Charact_Rank</param>
        /// <param name="Cost">cout de ce Charact_Rank</param>
        public CharactRank(int Id, int Cost,Charact Caractere, Rank Rank, SubUnity SubUnity)
        : this()
        {
            DefinirId(Id);
            this.Cost = Cost;
            this.SubUnity = SubUnity;
            this.Caractere = Caractere;
            this.Rank = Rank;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public CharactRank(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cr_id"));                
                this.Cost = Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cr_cost");
                this.Rank = new Rank(Connexion,Enregistrement);
                this.SubUnity = new SubUnity(Connexion, Enregistrement);
                this.Caractere = new Charact(Connexion, Enregistrement);                
            }
        }

        #endregion

        #region Membres relatifs à la base de données        

        /// <summary>
        /// Permet de récupérer le character lié
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Charact> EnumererCharacts()
        {
            if (base.Connexion == null) return new Charact[0];
            return EICE_WARGAME.Charact.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT ch_id, ch_name
                    FROM charact
                    WHERE ch_id = {0}",
                m_Charact.Id));
        }

        /// <summary>
        /// Permet de récupérer les rank lié à ce caractère
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Rank> EnumererRank()
        {
            if (base.Connexion == null) return new Rank[0];
            return EICE_WARGAME.Rank.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT ra_id, ra_name, ra_fk_su_id
                    FROM rank
                    WHERE ra_id = {0}",
                m_Rank.Id));
        }

        private IEnumerable<CharactFeature> EnumererCharactFeatures()
        {
            if (base.Connexion == null) return new CharactFeature[0];
            return CharactFeature.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT *
                FROM char_rank_feature
                JOIN feature ON crf_fk_feature_id = fe_id                
                WHERE fe_id = {0}",
                Id));
        }

        /// <summary>
        /// Méthode retournant le nom de la table principale de Charact_Rank
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "char_rank";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table Charact_Rank
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "cr_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("cr_fk_ch_id = {0}, cr_fk_ra_id = {1}, cr_cost = {2}, cr_sub_id = {3}", Caractere.Id, Rank.Id, Cost,SubUnity.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer(@"DELETE FROM char_rank_feature WHERE crf_fk_char_rank_id = {0};
                                 DELETE FROM char_rank WHERE cr_id = {0};                         
                                  ", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<CharactRank> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new CharactRank(Connexion, Enregistrement));
        }

        #endregion

    }
}
