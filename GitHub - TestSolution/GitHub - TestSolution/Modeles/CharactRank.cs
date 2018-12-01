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
        }

        #region Membres privés

        /// <summary>
        /// Membre stockant la référence de caractère
        /// </summary>
        private Charact m_Charact;

        /// <summary>
        /// Membre stockant la référence de rank
        /// </summary>
        private Feature m_Rank;

        /// <summary>
        /// Membre stockant le cout 
        /// </summary>
        private int m_Cost;

        #endregion

        #region Membres publics

        /// <summary>
        /// Membre public permettant d'accéder à l'id du character
        /// </summary>
        public IEnumerable<Charact> Charact
        {
            get
            {
                return EnumererCharacts();
            }            
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id du rank
        /// </summary>
        public IEnumerable<Rank> Rank
        {
            get
            {
                return EnumererRank();
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
                if (value < int.MinValue)
                {
                    Declencher_SurErreur(this, Champ.Cost, "Cout inférieur au minimum autoriser");
                }
                else if (value > int.MaxValue)
                {
                    Declencher_SurErreur(this, Champ.Cost, "Ce champ peut contenir au maximum 20 caractères");
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
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du Charact_Rank</param>
        /// <param name="Cost">cout de ce Charact_Rank</param>
        public CharactRank(int Id, int Cost)
        : this()
        {
            DefinirId(Id);
            this.Cost = Cost;            
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
            }
        }

        #endregion

        #region Membres relatifs à la base de données
        /*
        /// <summary>
        /// Permet de récupérer le character lié
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Charact> EnumererCharacts()
        {
            if (base.Connexion == null) return new Charact[0];
            return EICE_WARGAME.Charact.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT ch_id, cr_fk_charact_id,cr_fk_rank_id, cr_cost
                    FROM charact
                    WHERE cr_fk_charact_id = {0}",
                Id));
        }*/

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
                Id));
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
                return new PDSGBD.MyDB.CodeSql("cr_fk_ch_id = {0}, cr_fk_ra_id = {1}, cr_cost = {2}", m_Charact.Id, m_Rank.Id, m_Cost);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM char_rank WHERE cr_id = {0}", Id);
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
