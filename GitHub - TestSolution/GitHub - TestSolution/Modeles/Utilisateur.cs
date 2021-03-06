﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;


namespace EICE_WARGAME
{
    public class Utilisateur : Entite<Utilisateur,Utilisateur.Champs>
    {
        public enum Champs
        {
            /// <summary>
            /// Identifiant de l'utilisateur
            /// </summary>
            Id,
            /// <summary>
            /// Login de l'utilisateur
            /// </summary>
            Login,
            /// <summary>
            /// Mot de passe de l'utilisateur
            /// </summary>
            MotDePasse,
            /// <summary>
            /// Role de l'utilisateur
            /// </summary>
            Role,

        }

        //Membres privé correspondant à l'utilisateur
        private string m_Login;

        private string m_MotDePasse;

        private Role m_Role;

        /// <summary>
        /// Login de l'utilisateur
        /// </summary>
        public string Login
        {
            get
            {
                return m_Login;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Declencher_SurErreur(this, Champs.Login, "Le login ne peut pas être null, vide ou avec seulement des espaces");
                }
                else
                {
                    value = value.Trim();
                    if ((value.Length > 20) || (value.Length <= 1))
                    {
                        Declencher_SurErreur(this, Champs.Login, "Le login doit être compris entre 1 et 20 caractères");
                    }
                    else if (!string.Equals(value, m_Login))
                    {
                        ModifierChamp(Champs.Login, ref m_Login, value);
                    }
                }
            }
        }

        /// <summary>
        /// Mot de passe de l'utilisateur
        /// </summary>
        public string MotDePasse
        {
            get
            {
                return m_MotDePasse;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Declencher_SurErreur(this, Champs.MotDePasse, "Le mot de passe ne peut pas être null, vide ou avec seulement des espaces");
                }
                else
                {
                    if ((value.Length >= 32) || (value.Length <= 1))
                    {
                        Declencher_SurErreur(this, Champs.MotDePasse, "Le mot de passe doit être compris entre 1 et 100 caractères");
                    }
                    if (!string.Equals(value, m_MotDePasse))
                    {
                        ModifierChamp(Champs.MotDePasse, ref m_MotDePasse, value);
                    }
                }
            }
        }

        /// <summary>
        /// Role de l'utilisteur
        /// </summary>
        public Role Role
        {
            get
            {
                return m_Role;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champs.Role, "Role non défini");
                }
                else
                {
                    if ((m_Role == null) || !int.Equals(value.Id, m_Role.Id))
                    {
                        ModifierChamp(Champs.Role, ref m_Role, value);
                    }
                }
            }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public Utilisateur()
            : base()
        {
            m_Login = string.Empty;            
            m_MotDePasse = string.Empty;
            m_Role = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Id de l'utilisateur</param>
        /// <param name="Login">Login de l'utilisateur</param>
        /// <param name="Age">Age de l'utilisateur</param>
        /// <param name="Region">Region de l'utilisateur</param>
        /// <param name="Email">Email de l'utilisateur</param>
        /// <param name="Role">Role de l'utilisateur</param>
        public Utilisateur(int Id, string Login, string MotDePasse, Role Role)
        {
            DefinirId(Id);
            this.Login = Login;
            this.MotDePasse = MotDePasse;
            this.Role = Role;
        }




        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public Utilisateur(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "u_id"));
                this.Login = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "u_name");
                this.MotDePasse = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "u_password");                
                this.Role = new Role(Connexion, Enregistrement);                
            }
        }

        public static IEnumerable<Utilisateur> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new Utilisateur(Connexion, Enregistrement));
        }

        

        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "user";
            }
        }

        public override void SupprimerEnCascade(MyDB Connexion)
        {
            // TODO : rajouter la suite du chemin de la cascade
            Connexion.Executer(@"DELETE FROM user WHERE u_id = {0};"
                                , Id);
        }

        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "u_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("u_name = {0}, u_password = {1},  u_fk_role_id = {2}", m_Login, m_MotDePasse, m_Role.Id);
            }
        }


        

    }
}
