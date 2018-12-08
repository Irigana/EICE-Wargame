using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class Charact : Entite<Charact, Charact.Champ>
    {
        /// <summary>
        /// Champ décrivant cette Charact
        /// </summary>
        public enum Champ
        {
            /// <summary>
            /// Identifiant de ce charact
            /// </summary>
            Id,
            /// <summary>
            /// name de ce charact
            /// </summary>
            Name,
            /// <summary>
            /// Sous-faction de ce dharact
            /// </summary>
            SousFaction,
            
        }

        #region Membres privés
        /// <summary>
        /// Stocke la valeur du champ Name
        /// </summary>
        private string m_Name;

        /// <summary>
        /// Stocke la Sous-Faction de ce charact
        /// </summary>
        private SousFaction m_SousFaction;
        
        #endregion

        #region Membres publics
        /// <summary>
        /// Name de ce charact
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

        /// <summary>
        /// Id de cette Sous-Faction
        /// </summary>
        public SousFaction SousFaction
        {
            get
            {
                return m_SousFaction;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.SousFaction, "Sous faction non définie");
                }
                else
                {
                    if ((m_SousFaction == null) || int.Equals(value.Id, m_SousFaction.Id))
                    {
                        ModifierChamp(Champ.SousFaction, ref m_SousFaction, value);
                    }
                }
            }
        }        

        #endregion

        #region Constructeur
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Charact()
            : base()
        {
            m_Name = string.Empty;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant de ce Charact</param>
        /// <param name="Name">Nom de ce Charact</param>
        public Charact(int Id, string Name)
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
        public Charact(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "ch_id"));
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "ch_name");
            }
        }

        #endregion

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Charact> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Charact(Connexion, Enregistrement));
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
                return "charact";
            }
        }

        /// <summary>
        /// Méthode retournant le nom du champs id de la table charact
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "ch_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("ch_name = {0}, ch_fk_subfaction_id = {1}", m_Name, m_SousFaction.Id);
            }
        }



        public override void SupprimerEnCascade(MyDB Connexion)
        {            
            Connexion.Executer(@"DELETE FROM charact WHERE ch_id = {0};"
                                , Id);            
        }        
        

        #endregion

    }
}
