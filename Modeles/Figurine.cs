using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Figurine : Entite<Figurine, Figurine.Champ>
    {
        /// <summary>
        /// Champ décrivant cette figurine
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette figurine
            /// </summary>
            Id,
            /// <summary>
            /// Character de cette figurine
            /// </summary>
            Character,
        }

        #region Membres privés
        
        /// <summary>
        /// Stocke le character de cette figurine
        /// </summary>
        private Charact m_Charact;

       
        #endregion

        #region Membres publics
        
        /// <summary>
        /// Id du character de cette figurine
        /// </summary>
        public Charact Charact
        {
            get
            {
                return m_Charact;
            }
            set
            {
                if ((value != null) && ((m_Charact == null) || !int.Equals(value.Id, Charact.Id)))
                {
                    ModifierChamp(Champ.Character, ref m_Charact, value);
                }
            }
        }

        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Figurine()
            : base()
        {
            
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce Figurine</param>
        public Figurine(int Id)
            : this()
        {
            DefinirId(Id);
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Figurine(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "fi_id"));
            }
        }

        #endregion

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Figurine> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Figurine(Connexion, Enregistrement));
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
                return "figurine";
            }
        }

        /// <summary>
        /// Méthode retournant le nom du champs id de la table figurine
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "fi_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("fi_fk_character_id = {1}", m_Charact.Id);
            }
        }

        /// <summary>
        /// Permet de récupérer les characters liés à une sous-faction
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Charact> EnumererCharacts()
        {
            if (base.Connexion == null) return new Charact[0];
            return Charact.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT ch_id, ch_name
                    FROM subfaction
                    WHERE (ch_fk_subfaction_id = {0})",
                Id));
        }

        #endregion

    }
}
