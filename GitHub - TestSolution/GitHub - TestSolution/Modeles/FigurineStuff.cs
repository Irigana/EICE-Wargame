using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class FigurineStuff : Entite<FigurineStuff, FigurineStuff.Champ>
    {
        /// <summary>
        /// Champs décrivant cette FigurineStuff
        /// </summary>
        public enum Champ
        {
            Id,
            Figurine,
            Stuff,
            User
        }

        #region Membres privés
        /// <summary>
        /// Membre stockant la référence de Figurine
        /// </summary>
        private Figurine m_Figurine;

        /// <summary>
        /// Membre stockant la référence de Stuff
        /// </summary>
        private Stuff m_Stuff;

        /// <summary>
        /// Membre stockant la référence d'utilisateur
        /// </summary>
        private Utilisateur m_Utilisateur;

        #endregion

        #region Membres publics

        /// <summary>
        /// Membre public permettant d'accéder à l'id de la Figurine
        /// </summary>
        public Figurine Figurine
        {
            get
            {
                return m_Figurine;
            }

            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Figurine, "Figurine non définie");
                }
                else
                {
                    if ((m_Figurine == null) || !int.Equals(value.Id, m_Figurine.Id))
                    {
                        ModifierChamp(Champ.Figurine, ref m_Figurine, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id du stuff
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
                    if ((m_Stuff == null) || !int.Equals(value.Id, m_Stuff.Id))
                    {
                        ModifierChamp(Champ.Stuff, ref m_Stuff, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id de l'utilisateur
        /// </summary>
        public Utilisateur Utilisateur
        {
            get
            {
                return m_Utilisateur;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Stuff, "Utilisateur non défini");
                }
                else
                {
                    if ((m_Utilisateur == null) || !int.Equals(value.Id, m_Utilisateur.Id))
                    {
                        ModifierChamp(Champ.User, ref m_Utilisateur, value);
                    }
                }
            }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public FigurineStuff()
        :base()
        {
            m_Figurine = null;
            m_Stuff = null;
            m_Utilisateur = null;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du FigurineStuff</param>
        /// <param name="Figurine">Figurine de ce FigurineStuff</param>
        /// <param name="Stuff">Stuff de ce FigurineStuff</param>
        /// <param name="Utilisateur">Value de ce FigurineStuff</param>
        public FigurineStuff(int Id, Figurine Figurine, Stuff Stuff, Utilisateur Utilisateur)
        : this()
        {
            DefinirId(Id);
            this.Figurine = Figurine;
            this.Stuff = Stuff;
            this.Utilisateur = Utilisateur;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public FigurineStuff(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "fs_id"));
                this.Figurine = new Figurine(Connexion, Enregistrement);
                this.Stuff = new Stuff(Connexion, Enregistrement);
                this.Utilisateur = new Utilisateur(Connexion, Enregistrement);
            }
        }

        #endregion

        #region Membres relatifs à la base de données

        /// <summary>
        /// Méthode retournant le nom de la table principale de FigurineStuff
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "figurine_stuff";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table FigurineStuff
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "fs_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("fs_fk_figutine_id = {0}, fs_fk_stuff_id = {1}, fs_fk_user_id = {2}", m_Figurine.Id,m_Stuff.Id, m_Utilisateur.Id);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM figurine_stuff WHERE fs_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<FigurineStuff> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new FigurineStuff(Connexion, Enregistrement));
        }

        #endregion

    }
}
