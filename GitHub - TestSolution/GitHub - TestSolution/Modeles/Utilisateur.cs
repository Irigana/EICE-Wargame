﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EICE_WARGAME
{
    class Utilisateur : Entite<Utilisateur,Utilisateur.Champs>
    {
        public enum Champs
        {
            /// <summary>
            /// Identifiant de l'utilisateur
            /// </summary>
            Id,
            /// <summary>
            /// Pseudo de l'utilisateur
            /// </summary>
            Pseudo,
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
        private string m_Pseudo;

        private string m_MotDePasse;

        private Role m_Role;

        /// <summary>
        /// Pseudo de l'utilisateur
        /// </summary>
        public string Pseudo
        {
            get
            {
                return m_Pseudo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Declencher_SurErreur(this, Champs.Pseudo, "Le pseudo ne peut pas être null, vide ou avec seulement des espaces");
                }
                else
                {
                    value = value.Trim();
                    if ((value.Length >= 100) || (value.Length <= 1))
                    {
                        Declencher_SurErreur(this, Champs.Pseudo, "Le pseudo doit être compris entre 1 et 100 caractères");
                    }
                    else if (!string.Equals(value, m_Pseudo))
                    {
                        ModifierChamp(Champs.Pseudo, ref m_Pseudo, value);
                    }
                }
            }
        }

        /// <summary>
        /// Pseudo de l'utilisateur
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
                {// TODO : Vérifier la longueur de mot de passe pour voir la cohérence
                    if ((value.Length >= 100) || (value.Length <= 1))
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
            m_Pseudo = string.Empty;            
            m_MotDePasse = string.Empty;
            m_Role = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Id de l'utilisateur</param>
        /// <param name="Pseudo">Pseudo de l'utilisateur</param>
        /// <param name="Age">Age de l'utilisateur</param>
        /// <param name="Region">Region de l'utilisateur</param>
        /// <param name="Email">Email de l'utilisateur</param>
        /// <param name="Role">Role de l'utilisateur</param>
        public Utilisateur(int Id, string Pseudo, string MotDePasse, Role Role)
        {
            DefinirId(Id);
            this.Pseudo = Pseudo;
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
            {// TODO : Vérifier si le nom des champs est correct par rapport aux champ de la base de donnée
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "id_utilisateur"));
                this.Pseudo = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "pseudo");
                this.MotDePasse = Enregistrement.ValeurChampComplet<string>(NomDeLaTablePrincipale, "mot_de_passe");                
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
            {// TODO : Vérifier si le nom de la table est la bonne
                return "utilisateur";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {// TODO : Vérifier si les champs sont les mêmes que dans la base de donnée
                return new PDSGBD.MyDB.CodeSql("pseudo = {0}, mot_de_passe = TODO,  ref_role = {1}", m_Pseudo, m_MotDePasse, m_Role.Id);
            }
        }


    }
}
