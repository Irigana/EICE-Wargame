﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    public class StuffCharactRank : Entite<StuffCharactRank, StuffCharactRank.Champ>
    {
        /// <summary>
        /// Champ décrivant la table StuffCharactRank
        /// </summary>
        public enum Champ
        {
            Id,
            Stuff,
            CharactRank,
            Cout,
            Min,
            Max,
        }


        #region Membre privé

        /// <summary>
        /// Membre stockant le stuff
        /// </summary>
        private Stuff m_Stuff;

        /// <summary>
        /// Membre stockant CharactRank
        /// </summary>
        private CharactRank m_CharactRank;

        /// <summary>
        /// Valeur stockant le cout
        /// </summary>
        private int m_Cout;

        private int m_Min;

        private int m_Max;
                    
        #endregion

        #region Membre public
        /// <summary>
        /// Membre public permettant d'accéder au Rank de cette CharactRank
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
                    Declencher_SurErreur(this, Champ.CharactRank, "CharactRank non défini");
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
        /// Membre public permettant d'accéder au Feature de cette StuffCharactRank
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
        /// Membre public permettant d'accéder au cout
        /// </summary>
        public int Cout
        {
            get
            {
                return m_Cout;
            }

            set
            {
                if (value < int.MinValue)
                {
                    Declencher_SurErreur(this, Champ.Cout, "Cout inférieur au minimum autorisé");
                }
                else if (value > int.MaxValue)
                {
                    Declencher_SurErreur(this, Champ.Cout, "Cout supérieur au maximum autorisé");
                }
                else
                {
                    if (!int.Equals(value, m_Cout))
                    {
                        ModifierChamp(Champ.Cout, ref m_Cout, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder au Min
        /// </summary>
        public int Min
        {
            get
            {
                return m_Min;
            }

            set
            {
                if (value < int.MinValue)
                {
                    Declencher_SurErreur(this, Champ.Min, "Min inférieur au minimum autorisé");
                }
                else if (value > int.MaxValue)
                {
                    Declencher_SurErreur(this, Champ.Min, "Min supérieur au maximum autorisé");
                }
                else
                {
                    if (!int.Equals(value, m_Min))
                    {
                        ModifierChamp(Champ.Min, ref m_Min, value);
                    }
                }
            }
        }

        /// <summary>
        /// Membre public permettant d'accéder au Max
        /// </summary>
        public int Max
        {
            get
            {
                return m_Max;
            }

            set
            {
                if (value < int.MinValue)
                {
                    Declencher_SurErreur(this, Champ.Max, "Max inférieur au minimum autorisé");
                }
                else if (value > int.MaxValue)
                {
                    Declencher_SurErreur(this, Champ.Max, "Max supérieur au maximum autorisé");
                }
                else
                {
                    if (!int.Equals(value, m_Max))
                    {
                        ModifierChamp(Champ.Cout, ref m_Max, value);
                    }
                }
            }
        }

        #endregion

        #region Constructeurs
        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public StuffCharactRank()
            : base()
        {
            m_Feature = null;
            m_Rank = null;
            m_Value = -1;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Id">ID de la table StuffCharactRank</param>
        /// <param name="Stuff">Stuff de ce StuffCharactRank</param>
        /// <param name="ArmyUnity">ArmyUnity de ce StuffCharactRank</param>
        public StuffCharactRank(int Id, Rank Rank, Feature Feature)
            : this()
        {
            DefinirId(Id);
            this.Rank = Rank;
            this.Feature = Feature;
        }

        /// <summary>
        /// Constructeur spécifique
        /// </summary>
        /// <param name="Connexion"> Connexion au serveur MySQL</param>
        /// <param name="Enregistrement"> Enregistrement d'où extraire les valeurs des champs</param>
        public StuffCharactRank(PDSGBD.MyDB Connexion, PDSGBD.MyDB.IEnregistrement Enregistrement) : this()
        {
            base.Connexion = Connexion;
            if (Enregistrement != null)
            {
                DefinirId(Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cf_id"));
                this.Rank = new Rank(Connexion, Enregistrement);
                this.Feature = new Feature(Connexion, Enregistrement);
                this.Value = Enregistrement.ValeurChampComplet<int>(NomDeLaTablePrincipale, "cf_value");
            }
        }
        #endregion

        #region Membres relatifs à la base de données
        /// <summary>
        /// Méthode retournant le nom de la table StuffCharactRank
        /// </summary>
        /// <returns>Nom de la table principale de ce type d'entités</returns>
        public override string NomDeLaTablePrincipale
        {
            get
            {
                return "char_feature";
            }
        }

        /// <summary>
        /// Méthode retournant l'id principal de la table Scenarion_Camp
        /// </summary>
        public override string IdDeLaTablePrincipale
        {
            get
            {
                return "cf_id";
            }
        }

        /// <summary>
        /// Clause d'assignation utilisable dans une requête INSERT/UPDATE
        /// </summary>
        public override PDSGBD.MyDB.CodeSql ClauseAssignation
        {
            get
            {
                return new PDSGBD.MyDB.CodeSql("cf_fk_rank_id = {0}, cf_fk_feature_id = {1},cf_value = {2}", Rank.Id, Feature.Id, Value);
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
        public static IEnumerable<StuffCharactRank> Enumerer(PDSGBD.MyDB Connexion, IEnumerable<PDSGBD.MyDB.IEnregistrement> Enregistrements)
        {
            return Enumerer(Enregistrements, Enregistrement => new StuffCharactRank(Connexion, Enregistrement));
        }
        #endregion
    }
}