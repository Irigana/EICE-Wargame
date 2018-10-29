using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EICE_WARGAME
{
    public class StuffFeature : Entite<StuffFeature, StuffFeature.Champ>
    {
        /// <summary>
        /// Champs décrivant cette stuff_feature
        /// </summary>
        public enum Champ
        {
            Id,
            Stuff,
            Feature,
            Value
        }

        #region Membres privés

        /// <summary>
        /// Membre stockant la référence de stuff
        /// </summary>
        private Stuff m_Stuff;

        /// <summary>
        /// Membre stockant la référence de feature
        /// </summary>
        private Feature m_Feature;

        /// <summary>
        /// Membre stockant la value 
        /// </summary>
        private int m_Value;

        #endregion

        #region Membres publics

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
                    if ((m_Stuff == null) || int.Equals(value.Id, m_Stuff.Id))
                    {
                        ModifierChamp(Champ.Stuff, ref m_Stuff, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à l'id de la feature
        /// </summary>
        public Feature Feature
        {
            get
            {
                return m_Feature;
            }

            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.Feature, "Feature non définie");
                }
                else
                {
                    if ((m_Feature == null) || int.Equals(value.Id, m_Feature.Id))
                    {
                        ModifierChamp(Champ.Feature, ref m_Feature, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder à la value
        /// </summary>
        public int Value
        {
            get
            {
                return m_Value;
            }

            set
            {
                if (value <= 0)
                {
                    Declencher_SurErreur(this, Champ.Value, "Valeur négative ou nulle !");
                }
                else
                {
                    if (!int.Equals(value, m_Value))
                    {
                        ModifierChamp(Champ.Value, ref m_Value, value);
                    }
                }
            }
        }

        #endregion

        #region Constructeurs

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public StuffFeature()
        :base()
        {
            m_Stuff = null;
            m_Feature = null;
            m_Value = 0;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">Identifiant du stuff_feature</param>
        /// <param name="Stuff">Stuff de ce stuff_feature</param>
        /// <param name="Feature">Feature de ce stuff_feature</param>
        /// <param name="Value">Value de ce stuff_feature</param>
        public StuffFeature(int Id, Stuff Stuff, Feature Feature, int Value)
        : this()
        {
            DefinirId(Id);
            this.Stuff = Stuff;
            this.Feature = Feature;
            this.Value = Value;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrement">Enregistrement d'où extraire les valeurs de champs</param>
        public StuffFeature(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement)
            : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "stf_id"));
                this.Stuff = new Stuff(Connexion, Enregistrement);
                this.Feature = new Feature(Connexion, Enregistrement);
                this.Value = Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "stf_value");
            }
        }

        #endregion

        #region Membres relatifs à la base de données

        /// <summary>
        /// Méthode retournant le nom de la table principale de stuff_feature
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "stuff_feature";
            }
        }

        /// <summary>
        /// Méthode retournant l'id de cette table table stuff_feature
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "stf_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("stf_fk_stuff_id = {0}, stf_fk_feature_id = {1}, stf_value = {2}", m_Stuff.Id, m_Feature.Id, m_Value);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Typeus liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(PDSGBD.MyDB Connexion)
        {
            Connexion.Executer("DELETE FROM stuff_feature WHERE stf_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<StuffFeature> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new StuffFeature(Connexion, Enregistrement));
        }

        #endregion

    }
}
