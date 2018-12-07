using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class StuffSubUnity : Entite<StuffSubUnity, StuffSubUnity.Champ>
    {
        /// <summary>
        /// Champ décrivant la table StuffSubUnity
        /// </summary>
        public enum Champ
        {
            Id,
            SubUnity,
            Stuff,
        }

        #region Membre privé
        /// <summary>
        /// Membre stockant la référence du scénario
        /// </summary>
        private SubUnity m_SubUnity;

        /// <summary>
        /// Membr stockant la réf&rence du camp
        /// </summary>
        private Stuff m_Stuff;
        #endregion

        #region Membre public
        /// <summary>
        /// Membre public permettant d'accéder à l'id de ArmyUnity
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
                    Declencher_SurErreur(this, Champ.SubUnity, "SubUnity non défini");
                }
                else
                {
                    if ((m_SubUnity == null) || int.Equals(value.Id, m_SubUnity.Id))
                    {
                        ModifierChamp(Champ.SubUnity, ref m_SubUnity, value);
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
        public StuffSubUnity() 
            : base()
        {
            m_SubUnity = null;
            m_Stuff = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">ID de la table StuffSubUnity</param>
        /// <param name="Stuff">Stuff de ce StuffSubUnity</param>
        /// <param name="ArmyUnity">ArmyUnity de ce StuffSubUnity</param>
        public StuffSubUnity(int Id, Stuff Stuff, SubUnity SubUnity) 
            : this()
        {
            DefinirId(Id);
            this.Stuff = Stuff;
            this.SubUnity = SubUnity;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion"> Connexion au serveur MySQL</param>
        /// <param name="Enregistrement"> Enregistrement d'où extraire les valeurs des champs</param>
        public StuffSubUnity(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) 
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cfs_id"));
                this.SubUnity = new SubUnity(Connexion, Enregistrement);
                this.Stuff = new Stuff(Connexion, Enregistrement);
            }
        }
        #endregion

        #region Membres relatifs à la base de données
        /// <summary>
        /// Méthode retournant le nom de la table StuffSubUnity
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "stuff_subunity";
            }
        }

        /// <summary>
        /// Méthode retournant l'id principal de la table Scenarion_Camp
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "cfs_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("cfs_fk_stuff_id = {0}, cfs_fk_subunity_id = {1}", Stuff.Id, SubUnity.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Types liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(MyDB Connexion)
        {// TODO
            Connexion.Executer("DELETE from stuff_subunity WHERE cfs_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<StuffSubUnity> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new StuffSubUnity(Connexion, Enregistrement));
        }
        #endregion
    }
}
