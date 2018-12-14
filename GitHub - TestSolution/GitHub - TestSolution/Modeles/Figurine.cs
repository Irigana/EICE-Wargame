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
            /// <summary>
            /// Utilisateur à qui appartient cette figurine
            /// </summary>
            User
        }

        #region Membres privés
        
        /// <summary>
        /// Stocke le character de cette figurine
        /// </summary>
        private Charact m_Charact;


        /// <summary>
        /// Membre stockant la référence d'utilisateur
        /// </summary>
        private Utilisateur m_Utilisateur;

        /// <summary>
        /// Stocke les Stuffs de cette figurine
        /// </summary>
        private List<FigurineStuff> m_Stuffs;
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
                    Declencher_SurErreur(this, Champ.User, "Utilisateur non défini");
                }
                else
                {
                    if ((m_Utilisateur == null) || !int.Equals(value.Id, m_Utilisateur.Id))
                    {
                        ModifierChamp(Champ.User, ref m_Utilisateur, value);
                    }
                }
            }
        }

        /// <summary>
        /// Liste des Types de Stuff
        /// </summary>
        public IEnumerable<FigurineStuff> Stuffs
        {
            get
            {
                return EnumererFigurineStuff();
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
            m_Charact = null;
            m_Utilisateur = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce Figurine</param>
        public Figurine(int Id,Charact Character,Utilisateur Utilisateur)
            : this()
        {
            DefinirId(Id);
            m_Charact = Character;
            m_Utilisateur = Utilisateur;
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
                this.Charact = new Charact(Connexion, Enregistrement);
                this.Utilisateur = new Utilisateur(Connexion, Enregistrement);
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
                return new PDSGBD.MyDB.CodeSql("fi_fk_character_id = {0}, fi_fk_user_id = {1}", Charact.Id,Utilisateur.Id);
            }
        }

        /// <summary>
        /// Permet d'énumrer les figurines_stuff liés à cette figurine
        /// </summary>
        /// <returns></returns>
        public IEnumerable<FigurineStuff> EnumererFigurineStuff()
        {
            if (base.Connexion == null) return new FigurineStuff[0];
            return FigurineStuff.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT fi_id, fi_name,
                         fs_id,
                         st_id, st_name
                FROM figurine
                INNER JOIN figurine_stuff on fi_id = fs_fk_figurine_id
                INNER JOIN stuff on st_id = fs_fk_stuff_id
                WHERE fi_id = {0}",
                Id));
        }

        #endregion

    }
}
