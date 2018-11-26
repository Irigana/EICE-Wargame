using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class Subunity : Entite<Subunity, Subunity.Champ>
    {
        /// <summary>
        /// Champ décrivant cette SousFaction
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de cette SousFaction
            /// </summary>
            Id,
            /// <summary>
            /// name de ce SousFaction
            /// </summary>
            Name,
            /// <summary>
            /// Faction de cette SousFaction
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
        private List<Sub_Sub> m_Sub_Sub;
        #endregion

        #region Membres publics
        /// <summary>
        /// Nom de la sous faction
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

        public IEnumerable<Sub_Sub> Sub_Sub
        {
            get
            {
                return EnumererSub_Sub();
            }
        }

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
        public Subunity() : base()
        {
            m_Name = string.Empty;
            m_Sub_Sub = new List<Sub_Sub>();
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce SousFaction</param>
        /// <param name="Name">Nom de la sous unité</param>
        public Subunity(int Id, string Name) : this()
        {
            DefinirId(Id);
            this.Name = Name;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Subunity(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
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
        public static IEnumerable<Subunity> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Subunity(Connexion, Enregistrement));
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
        /// Méthode retournant le nom du champs id de la table sousfaction
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
