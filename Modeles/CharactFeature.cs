using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class CharactFeature : Entite<CharactFeature, CharactFeature.Champ>
    {
        /// <summary>
        /// Champ décrivant la table CharactFeature
        /// </summary>
        public enum Champ
        {
            Id,
            CharactRank,
            Feature,
            Value,
        }

        #region Membre privé
        /// <summary>
        /// Membre stockant la référence du rank
        /// </summary>
        private CharactRank m_CharactRank;

        /// <summary>
        /// Membr stockant la référence de feature
        /// </summary>
        private Feature m_Feature;

        /// <summary>
        /// Valeur stockant la valeur
        /// </summary>
        private int m_Value;
        #endregion

        #region Membre public
        /// <summary>
        /// Membre public permettant d'accéder au Rank de cette CharactFeature
        /// </summary>
        public CharactRank CharactRank
        {
            get
            {
                return m_CharactRank;
            }
            set
            {
                if (value == null)
                {
                    Declencher_SurErreur(this, Champ.CharactRank, "Rank non défini");
                }
                else
                {
                    if ((m_CharactRank == null) || int.Equals(value.Id, m_CharactRank.Id))
                    {
                        ModifierChamp(Champ.CharactRank, ref m_CharactRank, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder au Feature de cette CharactFeature
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
                if (value < int.MinValue)
                {
                    Declencher_SurErreur(this, Champ.Value, "Valeur inférieur au minimum autorisé");
                }
                else if (value > int.MaxValue)
                {
                    Declencher_SurErreur(this, Champ.Value, "Valeur supérieur au maximum autorisé");
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
        public CharactFeature()
            : base()
        {
            m_Feature = null;
            m_CharactRank = null;
            m_Value = -1;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">ID de la table CharactFeature</param>
        /// <param name="Stuff">Stuff de ce CharactFeature</param>
        /// <param name="ArmyUnity">ArmyUnity de ce CharactFeature</param>
        public CharactFeature(int Id, CharactRank CharactRank, Feature Feature) 
            : this()
        {
            DefinirId(Id);
            this.CharactRank = CharactRank;
            this.Feature = Feature;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion"> Connexion au serveur MySQL</param>
        /// <param name="Enregistrement"> Enregistrement d'où extraire les valeurs des champs</param>
        public CharactFeature(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "crf_id"));
                this.CharactRank = new CharactRank(Connexion, Enregistrement);
                this.Feature = new Feature(Connexion, Enregistrement);
                this.Value = Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "crf_value");
            }
        }
        #endregion

        #region Membres relatifs à la base de données
        /// <summary>
        /// Méthode retournant le nom de la table CharactFeature
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "char_rank_feature";
            }
        }

        /// <summary>
        /// Méthode retournant l'id principal de la table Scenarion_Camp
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "crf_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("crf_fk_rank_id = {0}, crf_fk_feature_id = {1},crf_value = {2}", CharactRank.Id, Feature.Id, Value);
            }
        }

        /// <summary>
        /// Permet de supprimer tous les changements de Types liés à ce projet
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        public override void SupprimerEnCascade(MyDB Connexion)
        {// TODO
            Connexion.Executer("DELETE from char_feature WHERE cf_id = {0}", Id);
        }

        /// <summary>
        /// Permet d'énumérer les entités correspondant aux enregistrements énumérés
        /// </summary>
        /// <param name="Connexion">Connexion au serveur MySQL</param>
        /// <param name="Enregistrements">Enregistrements énumérés, sources des entités à créer</param>
        /// <returns>Enumération des entités issues des enregistrements énumérés</returns>
        public static IEnumerable<CharactFeature> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new CharactFeature(Connexion, Enregistrement));
        }
        #endregion
    }
}
