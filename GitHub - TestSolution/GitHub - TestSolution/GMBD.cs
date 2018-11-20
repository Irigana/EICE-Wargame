﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDSGBD;

namespace EICE_WARGAME
{
    class GMBD
    {
        // Permet un accès plus simple par variable
        private static readonly MyDB.CodeSql c_NomTable_Utilisateur = new MyDB.CodeSql(new Utilisateur().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Role = new MyDB.CodeSql(new Role().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Faction = new MyDB.CodeSql(new Faction().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_SousFaction = new MyDB.CodeSql(new SousFaction().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Type = new MyDB.CodeSql(new Type().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Feature = new MyDB.CodeSql(new Feature().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Stuff = new MyDB.CodeSql(new Stuff().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_StuffFeature = new MyDB.CodeSql(new StuffFeature().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Charact = new MyDB.CodeSql(new Charact().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_FigurineStuff = new MyDB.CodeSql(new FigurineStuff().NomDeLaTablePrincipale);

        /// <summary>
        /// Référence l'objet de connexion au serveur de base de données MySql
        /// </summary>
        private MyDB m_BD;

        /// <summary>
        /// Référence de l'objet de connexion au serveur MySQL
        /// </summary>
        public MyDB BD
        {
            get
            {
                return m_BD;
            }
        }

        /// <summary>
        /// Constructeur par défaut
        /// </summary>
        public GMBD()
        {    
            m_BD = new MyDB("iziel_connector", "wJ9VFDrH", "iziel_warhammer", "mysql-iziel.alwaysdata.net");
            m_BD.SurErreur += (ConnexionEmettrice, MethodeEmettrice, RequeteSql, Valeurs, MessageErreur) =>
            {
                System.Diagnostics.Debug.WriteLine(string.Format("\nERREUR SQL :\nMéthode : {0}\nRequête initiale : {1}\nValeurs des {2} parties variables : {3}\nRequête exécutée : {4}\nMessage d'erreur : {5}\n",
                    MethodeEmettrice,
                    RequeteSql,
                    (Valeurs != null) ? Valeurs.Length : 0,
                    ((Valeurs != null) && (Valeurs.Length >= 1)) ? "\n* " + string.Join("\n* ", Valeurs.Select((Valeur, Indice) => string.Format("Valeurs[{0}] : {1}", Indice, (Valeur != null) ? Valeur.ToString() : "NULL")).ToArray()) : string.Empty,
                    MyDB.FormaterEnSql(RequeteSql, Valeurs),
                    MessageErreur));
            };
        }

        /// <summary>
        /// Permet d'initialiser ce gestionnaire de modèles
        /// </summary>
        /// <returns></returns>
        public bool Initialiser()
        {
            return m_BD.SeConnecter();
        }

        #region Requetes de connexion
        //+=======================+
        //| Requetes de connexion |
        //+=======================+

        /// <summary>
        /// Permet la connexion d'un utilisateur à l'application
        /// </summary>
        /// <param name="Login">Login de l'utilisateur</param>
        /// <param name="MotDePasse">Mot de passe de l'utilisateur</param>
        /// <returns></returns>
        public Utilisateur ConnexionApplication(string Login, string MotDePasse)
        {
            return EnumererUtilisateur(null,
                                       new MyDB.CodeSql(@"JOIN role ON user.u_fk_role_id = role.r_id"),
                                       new MyDB.CodeSql("WHERE u_name = {0} AND u_password = {1}", Login, MotDePasse),
                                       null).FirstOrDefault();
        }

        #endregion

        #region Requetes utilisateurs
        //+=======================+
        //| Requetes utilisateurs |
        //+=======================+
        /// <summary>
        /// Permet l'ajout d'un utilisateur
        /// </summary>
        /// <param name="Utilisateur">Objet du modèle utilisateur construit au préalable</param>
        /// <returns></returns>
        public bool AjouterUtilisateur(Utilisateur Utilisateur)
        {
            return Utilisateur.Enregistrer(m_BD, Utilisateur,null, false);
        }

        /// <summary>
        /// Permet la modification d'un utilisateur
        /// </summary>
        /// <param name="Utilisateur">Objet du modèle utilisateur construit au préalable</param>
        /// <returns></returns>
        public bool ModifierUtilisateur(Utilisateur Utilisateur)
        {
            return Utilisateur.Enregistrer(m_BD, Utilisateur, Utilisateur.IdDeLaTablePrincipale, true);
        }
        #endregion

        #region Requetes Faction

        public bool AjouterFaction(Faction NouvelleFaction)
        {
            return NouvelleFaction.Enregistrer(m_BD, NouvelleFaction, null, false);
        }

        public bool ModifierFaction(Faction Faction)
        {
            return Faction.Enregistrer(m_BD, Faction, null, true);
        }

        public bool SupprimerFaction(Faction Faction)
        {
            if (!m_BD.EstConnecte) Initialiser();
            Faction.SupprimerEnCascade(m_BD);
            return true;
        }
        /*
        public long NombreDeSousFactionLiee(int IdFaction)
        {

            long Resultat = m_BD.ValeurDe<long>("SELECT COUNT(*) FROM subfaction WHERE sf_fk_faction_id = {0}", IdFaction);
            return Resultat;          
        }
        */
        public void MettreAJourListeFaction(ListeDeroulanteFaction Liste)
        {
            Liste.Faction = Program.GMBD.EnumererFaction(null, null, null, new MyDB.CodeSql("ORDER BY fa_name"));
        }

        #endregion

        #region Requetes Sous Faction
        public bool AjouterSousFaction(SousFaction NouvelleSousFaction)
        {
            return NouvelleSousFaction.Enregistrer(m_BD, NouvelleSousFaction, NouvelleSousFaction.IdDeLaTablePrincipale, false);
        }

        public bool ModifierSousFaction(SousFaction SousFaction)
        {
            return SousFaction.Enregistrer(m_BD, SousFaction,null, true);
        }

        public bool SupprimerSousFaction(SousFaction SousFaction)
        {
            if (!m_BD.EstConnecte) Initialiser();
            SousFaction.SupprimerEnCascade(m_BD);
            return true;
        }

        public void MettreAJourFicheSousFaction(FicheSousFaction Fiche,int IdFactionSelectionne)
        {
            Fiche.SousFaction = Fiche.SousFaction = Program.GMBD.EnumererSousFaction(
                        null, null,
                        new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}", IdFactionSelectionne),
                        new MyDB.CodeSql("ORDER BY subfaction.sf_name"));           
        }
        #endregion

        #region Toutes les énumérations
        //+==================+
        //| Les énumérations |
        //+==================+

        /// <summary>
        /// Permet l'enumeration d'un utilisateur en rajoutant les parties de la requête par paramètre
        /// </summary>
        /// <param name="ValeurSouhaitee">Les valeurs que l'ont souhaite avoir accès</param>
        /// <param name="ClauseJoin">Jointure</param>
        /// <param name="ClauseWhere">Where</param>
        /// <param name="ClauseOrderBy">Tri</param>
        /// <returns></returns>
        public IEnumerable<Utilisateur> EnumererUtilisateur(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Utilisateur.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Utilisateur, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Role> EnumererRole(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Role.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Role, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Faction> EnumererFaction(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Faction.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Faction, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<SousFaction> EnumererSousFaction(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return SousFaction.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_SousFaction, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Type> EnumererType(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Type.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Type, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Stuff> EnumererStuff(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Stuff.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Stuff, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<StuffFeature> EnumererStuffFeature(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return StuffFeature.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_StuffFeature, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Feature> EnumererFeature(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Feature.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Feature, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Charact> EnumererCharact(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Charact.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Charact, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<FigurineStuff> EnumererFigurineStuff(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return FigurineStuff.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_FigurineStuff, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }



        #endregion

    }
}
