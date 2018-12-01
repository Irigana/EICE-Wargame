using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Rank : Entite<Rank, Rank.Champ>
    {
        /// <summary>
        /// Champs décrivant ce Rank
        /// </summary>
        public enum Champ
        {
            Id,
            Name,
            SubUnity,
        }

        #region Membres privés

        /// <summary>
        /// Membre stockant la référence subunity
        /// </summary>
        private SubUnity m_SubUnity;      

        /// <summary>
        /// Membre stockant le nom du rank 
        /// </summary>
        private string m_Name;

        #endregion

        #region Membres publics

        /// <summary>
        /// Membre public référent les SubUnity ayant ce rank
        /// </summary>
        public IEnumerable<SubUnity> SubUnity
        {
            get
            {
                return EnumererSubUnity();
            }            
        }
        
        /// <summary>
        /// Membre public permettant d'accéder à la value
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

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Rank()
        : base()
        {
            m_Name = string.Empty;
            m_SubUnity = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du Rank</param>
        /// <param name="Nom">Nom de ce Rank</param>
        public Rank(int Id, string Nom)
        : this()
        {
            DefinirId(Id);            
            this.Name = Nom;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Rank(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "ra_id"));                
                this.Name = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "ra_name");
            }
        }

        #endregion

        #region Membres relatifs à la base de données
        /// <summary>
        /// Permet de récupérer le character lié
        /// </summary>
        /// <returns></returns>
        private IEnumerable<SubUnity> EnumererSubUnity()
        {
            if (base.Connexion == null) return new SubUnity[0];
            return EICE_WARGAME.SubUnity.Enumerer(Connexion, Connexion.Enumerer(
                @"SELECT su_id, su_name, su_fk_unity_id
                    FROM subunity
                    JOIN rank ON ra_fk_su_id = rank.ra_id
                    WHERE ra_id = {0}",
                Id));
        }

        /// <summary>
        /// Méthode retournant le nom de la table principale de Rank
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "rank";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table Rank
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "ra_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("ra_id = {0}, ra_fk_su_id = {1}, ra_name = {2}", Id, m_SubUnity.Id, m_Name);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM rank WHERE ra_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<Rank> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Rank(Connexion, Enregistrement));
        }

        #endregion

    }
}
