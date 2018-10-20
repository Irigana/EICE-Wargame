using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class Role : Entite<Role,Role.Champs>
    {

        public enum Champs
        {
            /// <summary>
            /// Id du role
            /// </summary>
            Id,
            /// <summary>
            /// Role de l'utilisateur
            /// </summary>
            NomRole
        }

        // Membre privé
        private string m_Role;

        /// <summary>
        /// Role de l'utilisateur
        /// </summary>
        public string NomRole
        {
            get
            {
                return m_Role;
            }
            set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    Declencher_SurErreur(this, Champs.NomRole, "Le role ne peut pas être null, vide ou avec seulement des espaces");
                }
                else
                {
                    value = value.Trim();
                    if ((value.Length >= 10) || (value.Length <= 1))
                    {
                        Declencher_SurErreur(this, Champs.NomRole, "Le role doit être compris entre 1 et 10 caractères");
                    }
                    else if (!string.Equals(value, m_Role))
                    {
                        ModifierChamp(Champs.NomRole, ref m_Role, value);
                    }
                }
            }
        }
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Role()
            :base()
        {
            this.m_Role = string.Empty;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Id du role</param>
        /// <param name="Role">Role de l'utilisateur</param>
        public Role(int Id, string Role)
            : this()
        {
            DefinirId(Id);
            this.NomRole = Role;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Role(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            :this()
        {
            DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "r_id"));
            this.NomRole = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale,  "r_name");
        }


        public static IEnumerable<Role> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Role(Connexion ,Enregistrement));
        }


        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "role";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("r_name = {0}", m_Role);
            }
        }
       
    }

}

