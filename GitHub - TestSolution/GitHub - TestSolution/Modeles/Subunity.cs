using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class SubUnity : Entite<SubUnity, SubUnity.Champ>
    {
        /// <summary>
        /// Champ décrivant cette SubUnity
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette SubUnity
            /// </summary>
            Id,
            /// <summary>
            /// name de ce SubUnity
            /// </summary>
            Name,
            /// <summary>
            /// Faction de cette SubUnity
            /// </summary>
            Unity,
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;

        /// <summary>
        /// Stock les unités 
        /// </summary>
        private Unity m_Unity;

        /// <summary>
        /// Stock dans une liste toutes les unités liées (unité maitre et "esclaves")
        /// </summary>
        //TODO : private List<Sub_Sub> m_Sub_Sub;
        #endregion

        #region Membres publics
        /// <summary>
        /// Nom de la SubUnity
        /// </summary>
        public string Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Declencher_SurErreur(this, Champ.Name, "Nom vide ou ne contient que des espaces");
                }
                else if (value.Trim().Length > 20)
                {
                    Declencher_SurErreur(this, Champ.Name, "Ce champ peut contenir au maximum 20 caractères");
                }
                else
                {
                    value = value.Trim();
                    if (!string.Equals(value, m_Name))
                    {
                        ModifierChamp(Champ.Name, ref m_Name, value);
                    }

                }
            }
        }
        //TODO :
        /*
        public IEnumerable<Sub_Sub> Sub_Sub
        {
            get
            {
                return EnumererSub_Sub();
            }
        }*/

        /// <summary>
        /// Id de de l'unity en question
        /// </summary>
        public Unity Unity
        {
            get
            {
                return m_Unity;
            }
            set
            {
                if ((value != null) && ((m_Unity == null) || !int.Equals(value.Id, Unity.Id)))
                {
                    ModifierChamp(Champ.Unity, ref m_Unity, value);
                }
            }
        }

        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public SubUnity() 
            : base()
        {
            m_Name = string.Empty;
            //TODO : m_Sub_Sub = new List<Sub_Sub>();
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce SubUnity</param>
        /// <param name="Name">Nom de la sous unité</param>
        public SubUnity(int Id, string Name) 
            : this()
        {
            DefinirId(Id);
            this.Name = Name;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public SubUnity(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "su_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "su_name");
            }
        }

        #endregion

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<SubUnity> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new SubUnity(Connexion, Enregistrement));
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
                return "subunity";
            }
        }

        /// <summary>
        /// Méthode retournant le nom du champs id de la table SubUnity
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "su_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("su_name = {0}, su_fk_unity_id = {1}", m_Name, m_Unity.Id);
            }
        }

        public override void SupprimerEnCascade(PDSGBD.MyDB connexion)
        {
            Connexion.Executer("DELETE FROM subunity WHERE su_id = {0}", Id);            
        }

        /// <summary>
        /// Permet de récupérer les listes des Sous unité appartenant à une meme unité
        /// </summary>
        /// <returns></returns>
        private IEnumerable<Unity> EnumererUnity()
        {
            if (base.Connexion == null) return new Unity[0];
            return Unity.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT un_id, un_name
                    FROM subunity
                    WHERE (un_fk_unity_id = {0})",
                Id));
        }

        #endregion

    }
}
