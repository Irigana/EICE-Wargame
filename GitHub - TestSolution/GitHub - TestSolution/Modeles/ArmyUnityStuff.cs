using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class ArmyUnityStuff : Entite<ArmyUnityStuff, ArmyUnityStuff.Champ>
    {
        /// <summary>
        /// Champ décrivant la table ArmyUnityStuff
        /// </summary>
        public enum Champ
        {
            Id,
            ArmyUnity,
            Stuff,
        }

        #region Membre privé
        /// <summary>
        /// Membre stockant la référence de l'armée
        /// </summary>
        private ArmyUnity m_ArmyUnity;

        /// <summary>
        /// Membr stockant la réf&rence du stuff
        /// </summary>
        private Stuff m_Stuff;
        #endregion

        #region Membre public
        /// <summary>
        /// Membre public permettant d'accéder à l'id de ArmyUnity
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
                    Declencher_SurErreur(this, Champ.ArmyUnity, "Armée non défini");
                }
                else
                {
                    if ((m_ArmyUnity == null) || int.Equals(value.Id, m_ArmyUnity.Id))
                    {
                        ModifierChamp(Champ.ArmyUnity, ref m_ArmyUnity, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre permettant d'accéder à l'id du Stuff
        /// </summary>
        public Stuff Stuff
        {
            get
            {
                return m_Stuff;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Stuff, "Stuff non défini");
                }
                else
                {
                    if ((m_Stuff == null) || int.Equals(value.Id, m_Stuff.Id))
                    {
                        ModifierChamp(Champ.Stuff, ref m_Stuff, value);
                    }
                }
            }
        }
        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public ArmyUnityStuff() : base()
        {
            m_ArmyUnity = null;
            m_Stuff = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">ID de la table ArmyUnityStuff</param>
        /// <param name="Stuff">Stuff de ce ArmyUnityStuff</param>
        /// <param name="ArmyUnity">ArmyUnity de ce ArmyUnityStuff</param>
        public ArmyUnityStuff(int Id, Stuff Stuff, ArmyUnity ArmyUnity) : this()
        {
            DefinirId(Id);
            this.Stuff = Stuff;
            this.ArmyUnity = ArmyUnity;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion"> Connexion au serveur MySQL</param>
        /// <param name="Enregistrement"> Enregistrement d'où extraire les valeurs des champs</param>
        public ArmyUnityStuff(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "ars_id"));
                this.ArmyUnity = new ArmyUnity(Connexion, Enregistrement);
                this.Stuff = new Stuff(Connexion, Enregistrement);
            }
        }
        #endregion

        #region Membres relatifs à la base de données
        /// <summary>
        /// Méthode retournant le nom de la table ArmyUnityStuff
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "armyunitystuff";
            }
        }

        /// <summary>
        /// Méthode retournant l'id principal de la table Scenarion_Camp
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "ars_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("ars_fk_stuff_id = {0}, ars_fk_army_unity_id = {1}", Stuff.Id, ArmyUnity.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Types liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(MyDB Connexion)
        {// TODO
            Connexion.Executer("DELETE from armyunitystuff WHERE ars_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<ArmyUnityStuff> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new ArmyUnityStuff(Connexion, Enregistrement));
        }
        #endregion
    }
}
