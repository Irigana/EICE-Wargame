using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class ArmyUnity : Entite<ArmyUnity, ArmyUnity.Champ>
    {
        /// <summary>
        /// Champ décrivant cette ArmyUnity
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette ArmyUnity
            /// </summary>
            Id,
            /// <summary>
            /// Id de l'armée
            /// </summary>
            Army,
        }

        #region Membres privés       

        /// <summary>
        /// Stocke les armées liées à cette ArmyUnity
        /// </summary>
        private Army m_Army;

        #endregion

        #region Membres publics
        /// <summary>
        /// Name de ce ArmyUnity
        /// </summary>
        public Army Army
        {
            get
            {
                return m_Army;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Army, "Figurine non définie");
                }
                else
                {
                    if ((m_Army == null) || !int.Equals(value.Id, m_Army.Id))
                    {
                        ModifierChamp(Champ.Army, ref m_Army, value);
                    }
                }

            }
        }

        
        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ArmyUnity()
            : base()
        {
            m_Army = new Army();
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce ArmyUnity</param>
        /// <param name="Name">Nom de ce ArmyUnity</param>
        public ArmyUnity(int Id, Army Army)
            : this()
        {
            DefinirId(Id);
            this.Army = Army;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public ArmyUnity(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "aru_id"));
                this.Army = new Army(Connexion, Enregistrement);
            }
        }

        #endregion

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<ArmyUnity> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new ArmyUnity(Connexion, Enregistrement));
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
                return "army_unity";
            }
        }

        /// <summary>
        /// Méthode retournant le nom du champs id de la table ArmyUnity
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "aru_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("aru_army_id = {0}", m_Army.Id);
            }
        }        

        public override void SupprimerEnCascade(MyDB Connexion)
        {// TODO : suppresion en cascade
            Connexion.Executer(@"DELETE FROM army_unity WHERE aru_id = {0}"
                                , Id);
        }


        #endregion

    }
}
