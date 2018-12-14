using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class SubSub : Entite<SubSub, SubSub.Champ>
    {
        /// <summary>
        /// Champs décrivant cette SubSub
        /// </summary>
        public enum Champ
        {
            Id,
            Master,
            Slave,
        }

        #region Membres privés

        /// <summary>
        /// Membre stockant la référence du master
        /// </summary>
        private SubUnity m_Master;

        /// <summary>
        /// Membre stockant la référence du slave
        /// </summary>
        private SubUnity m_Slave;

       

        #endregion

        #region Membres publics

        /// <summary>
        /// Membre public permettant d'accéder à l'id du Master
        /// </summary>
        public SubUnity Master
        {
            get
            {
                return m_Master;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Master, "Master non défini");
                }
                else
                {
                    if ((m_Master == null) || !int.Equals(value.Id, m_Master.Id))
                    {
                        ModifierChamp(Champ.Master, ref m_Master, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id du Slave
        /// </summary>
        public SubUnity Slave
        {
            get
            {
                return m_Slave;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Slave, "Slave non défini");
                }
                else
                {
                    if ((m_Slave == null) || !int.Equals(value.Id, m_Slave.Id))
                    {
                        ModifierChamp(Champ.Slave, ref m_Slave, value);
                    }
                }
            }
        }

       

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public SubSub()
        : base()
        {
            m_Master = null;
            m_Slave = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du SubSub</param>
        /// <param name="Quantite">Quantite de ce SubSub</param>
        public SubSub(int Id,SubUnity Master,SubUnity Slave)
        : this()
        {
            DefinirId(Id);
            this.Master = Master;
            this.Slave = Slave;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public SubSub(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "ss_id"));
                this.Slave = new SubUnity(Connexion,Enregistrement);
                this.Master = new SubUnity(Connexion, Enregistrement);
            }
        }

        #endregion

        #region Membres relatifs à la base de données
        
        /// <summary>
        /// Permet de récupérer le master lié
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SubUnity> EnumererMaster()
        {
            if (base.Connexion == null) return new SubUnity[0];
            return EICE_WARGAME.SubUnity.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT su_id,su_name, su_fk_unity_id
                    FROM subunity
                    JOIN sub_sub on subunity.su_id = sub_sub.ss_fk_master_id
                    WHERE su_id = {0}",
                m_Master.Id));
        }

        /// <summary>
        /// Permet de récupérer le slave lié
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SubUnity> EnumererSlave()
        {
            if (base.Connexion == null) return new SubUnity[0];
            return EICE_WARGAME.SubUnity.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT su_id,su_name, su_fk_unity_id
                    FROM subunity
                    JOIN sub_sub on subunity.su_id = sub_sub.ss_fk_slave_id
                    WHERE su_id = {0}",
                m_Slave.Id));
        }

        /// <summary>
        /// Méthode retournant le nom de la table principale de SubSub
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "sub_sub";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table SubSub
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "ss_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("ss_fk_master_id = {0}, ss_fk_slave_id = {1}", Master.Id, Slave.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM sub_sub WHERE ss_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<SubSub> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new SubSub(Connexion, Enregistrement));
        }

        #endregion

    }
}