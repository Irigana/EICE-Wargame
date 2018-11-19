using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class SousFaction : Entite<SousFaction, SousFaction.Champ>
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
            Faction,
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;

        /// <summary>
        /// Stocke la faction de cette Sous-Faction
        /// </summary>
        private Faction m_Faction;

        /// <summary>
        /// Stocke les characts liés à cette Sous-Faction
        /// </summary>
        private List<Charact> m_Characts;
        #endregion

        #region Membres publics
        /// <summary>
        /// Name de ce SousFaction
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

        public IEnumerable<Charact> Characts
        {
            get
            {
                return EnumererCharacts();
            }
        }

        /// <summary>
        /// Id de cette faction
        /// </summary>
        public Faction Faction
        {
            get
            {
                return m_Faction;
            }
            set
            {
                if ((value != null) && ((m_Faction == null) || !int.Equals(value.Id, Faction.Id)))
                {
                    ModifierChamp(Champ.Faction, ref m_Faction, value);
                }
            }
        }

        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public SousFaction()
            : base()
        {
            m_Name = string.Empty;
            m_Characts = new List<Charact>();
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce SousFaction</param>
        /// <param name="Name">Nom de ce SousFaction</param>
        public SousFaction(int Id, string Name)
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
        public SousFaction(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "sf_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "sf_name");
            }
        }

        #endregion

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<SousFaction> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new SousFaction(Connexion, Enregistrement));
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
                return "subfaction";
            }
        }

        /// <summary>
        /// Méthode retournant le nom du champs id de la table sousfaction
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "sf_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("sf_name = {0}, sf_fk_faction_id = {1}", m_Name, m_Faction.Id);
            }
        }

        public override void SupprimerEnCascade(PDSGBD.MyDB connexion)
        {
            Connexion.Executer("DELETE FROM subfaction WHERE sf_id = {0}", Id);            
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
