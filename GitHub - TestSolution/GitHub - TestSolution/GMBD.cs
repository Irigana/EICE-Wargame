using System;
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
        private static readonly MyDB.CodeSql c_NomTable_CharactRank = new MyDB.CodeSql(new CharactRank().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Figurine = new MyDB.CodeSql(new Figurine().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_FigurineStuff = new MyDB.CodeSql(new FigurineStuff().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_CharactFeature = new MyDB.CodeSql(new CharactFeature().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Unity = new MyDB.CodeSql(new Unity().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_SubUnity = new MyDB.CodeSql(new SubUnity().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Rank = new MyDB.CodeSql(new Rank().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_ScenarioCamp = new MyDB.CodeSql(new Scenario_Camp().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Scenario = new MyDB.CodeSql(new Scenario().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_CondiCamp = new MyDB.CodeSql(new Condi_Camp().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Camp = new MyDB.CodeSql(new Camp().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_ArmyUnityFigurineStuff = new MyDB.CodeSql(new ArmyUnityFigurine().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_Army = new MyDB.CodeSql(new Army().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_StuffCharactRank = new MyDB.CodeSql(new StuffCharactRank().NomDeLaTablePrincipale);
        private static readonly MyDB.CodeSql c_NomTable_SubSub = new MyDB.CodeSql(new SubSub().NomDeLaTablePrincipale);

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

        /// <summary>
        /// Permet la suppresion d'un utilisateur
        /// </summary>
        /// <param name="Faction"></param>
        /// <returns></returns>
        public bool SupprimerUtilisateur(Utilisateur Utilisateur)
        {
            if (!m_BD.EstConnecte) Initialiser();
            Utilisateur.SupprimerEnCascade(m_BD);
            return true;
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

        public void MettreAJourListeSousFaction(ListeDeroulanteSousFaction Liste, int IdFactionSelectionne)
        {
            Liste.SousFaction = Program.GMBD.EnumererSousFaction(null, null, new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0}",IdFactionSelectionne), new MyDB.CodeSql("ORDER BY sf_name"));
        }
        #endregion

        #region Requetes Sous Unité
        public bool AjouterSubUnity(SubUnity NouvelleSubUnity)
        {
            return NouvelleSubUnity.Enregistrer(m_BD, NouvelleSubUnity, NouvelleSubUnity.IdDeLaTablePrincipale, false);
        }

        public bool ModifierSubUnity(SubUnity SubUnity)
        {
            return SubUnity.Enregistrer(m_BD, SubUnity, null, true);
        }

        public bool SupprimerSubUnity(SubUnity SubUnity)
        {
            if (!m_BD.EstConnecte) Initialiser();
            SubUnity.SupprimerEnCascade(m_BD);
            return true;
        }        
        
        #endregion

        #region Requetes caractère
        //+====================+
        //| Requetes caractère |
        //+====================+

        public bool AjouterCaractere(Charact NouveauCaractere)
        {
            return NouveauCaractere.Enregistrer(m_BD, NouveauCaractere, null, false);
        }

        public void MettreAJourFicheCaractere(FicheCaractere Fiche, int IdFactionSelectionne, int IdSousFactionSelectionne,int IdUnity,int IdSubUnity)
        {
            Fiche.Caractere = Program.GMBD.EnumererPersonnage(null,
                new MyDB.CodeSql(@"JOIN charact ON charact.ch_id = char_rank.cr_fk_ch_id
                                    JOIN rank ON rank.ra_id = char_rank.cr_fk_ra_id
                                    JOIN subunity ON char_rank.cr_sub_id = subunity.su_id    
                                    JOIN unity ON subunity.su_fk_unity_id = unity.un_id                                                                   
                                    JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id
                                    JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id "),
                new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1} AND un_id = {2} AND su_id = {3}",
                IdFactionSelectionne,IdSousFactionSelectionne,IdUnity,IdSubUnity),
                new MyDB.CodeSql("ORDER BY su_name"));
        }

        public bool AjouterFeaturePersonnage(CharactFeature Feature)
        {
            return Feature.Enregistrer(m_BD, Feature, null, false);
        }

        public bool ModifierFeaturePersonnage(CharactFeature Feature)
        {
            return Feature.Enregistrer(m_BD, Feature, null, true);
        }

        public bool SupprimerFeaturePersonnage(CharactFeature Feature)
        {
            if (!m_BD.EstConnecte) Initialiser();
            Feature.SupprimerEnCascade(m_BD);
            return true;
        }

        public bool ModifierCaractere(Charact Caractere)
        {
            return Caractere.Enregistrer(m_BD, Caractere, null, false);
        }

        public bool SupprimerCaractere(Charact Caractere)
        {
            if (!m_BD.EstConnecte) Initialiser();
            Caractere.SupprimerEnCascade(m_BD);
            return true;
        }

        #endregion

        #region Requêtes scénario
        public bool AjouterScenarioCamp(Scenario_Camp NouveauScenario)
        {
            return NouveauScenario.Enregistrer(m_BD, NouveauScenario, null, false);
        }

        public bool AjouterScenario(Scenario NouveauScenario)
        {
            return NouveauScenario.Enregistrer(m_BD, NouveauScenario, null, false);
        }

        public bool AjouterSpecificite(Condi_Camp NouvelleSpecificite)
        {
            return NouvelleSpecificite.Enregistrer(m_BD, NouvelleSpecificite, null, false);
        }

        public bool SupprimerSpecificite(Condi_Camp SpecificiteCondiCamp)
        {
            if (!m_BD.EstConnecte) Initialiser();
            SpecificiteCondiCamp.SupprimerEnCascade(m_BD);
            return true;

        }

        public bool SupprimerScenarioCamp(Scenario_Camp ScenarioCamp)
        {
            if (!m_BD.EstConnecte) Initialiser();
            ScenarioCamp.SupprimerEnCascade(m_BD);
            return true;

        }

        public bool SupprimerScenario(Scenario Scenario)
        {
            if (!m_BD.EstConnecte) Initialiser();
            Scenario.SupprimerEnCascade(m_BD);
            return true;

        }
        #endregion

        #region Requetes personnage
        //+====================+
        //| Requetes personnage |
        //+====================+

        public bool AjouterPersonnage(CharactRank NouveauPersonnage)
        {
            return NouveauPersonnage.Enregistrer(m_BD, NouveauPersonnage, null, false);
        }        

        public bool ModifierPersonnage(CharactRank Personnage)
        {
            if (Personnage.Enregistrer(m_BD, Personnage, null, false) &&
                (Personnage.Caractere.Enregistrer(m_BD, Personnage.Caractere, null, false)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SupprimerPersonnage(CharactRank Personnage)
        {
            if (!m_BD.EstConnecte) Initialiser();
            Personnage.SupprimerEnCascade(m_BD);
            return true;
            
        }

        #endregion

        #region Requetes Figurine
        //+====================+
        //| Requetes figurine  |
        //+====================+
        public bool AjouterFigurine(Figurine NouvelleFigurine)
        {
            return NouvelleFigurine.Enregistrer(m_BD, NouvelleFigurine, null, false);
        }

        public void MettreAJourFicheFigurine(FicheFigurineStuff Fiche, int IdUser)
        {
            Fiche.FigurineStuff = Program.GMBD.EnumererFigurine(null,
                                                                     new MyDB.CodeSql("JOIN charact On figurine.fi_fk_character_id = charact.ch_id"),
                                                                     new MyDB.CodeSql("WHERE fi_fk_user_id = {0}", IdUser),
                                                                     new MyDB.CodeSql("ORDER BY fi_id"));
        }
        public bool SupprimerFigurine(Figurine FigurineASupprimer)
        {
            if (!m_BD.EstConnecte) Initialiser();
            FigurineASupprimer.Supprimer(m_BD, FigurineASupprimer, true);
            return true;

        }
        #endregion

        #region Requetes FigurineStuff
        //+=========================+
        //| Requetes Figurine Stuff |
        //+=========================+

        public bool AjouterFigurineStuff(FigurineStuff NouvelleFigurineStuff)
        {
            return NouvelleFigurineStuff.Enregistrer(m_BD, NouvelleFigurineStuff, null, false);
        }

        public void MettreAJourFicheEquipementSurFigurine(FicheEquipement Fiche, int FigurineSelectionne)
        {
            Fiche.Equipement = Program.GMBD.EnumererStuff(null,
                                                             new MyDB.CodeSql("JOIN figurine_stuff on fs_fk_stuff_id = st_id"),
                                                             new MyDB.CodeSql("WHERE fs_fk_figurine_id = {0}", FigurineSelectionne),
                                                             new MyDB.CodeSql("ORDER BY st_name"));
        }

        public bool ModifierFigurineStuff(FigurineStuff NouvelleFigurineStuff)
        {
            if (NouvelleFigurineStuff.Enregistrer(m_BD, NouvelleFigurineStuff, null, false) &&
                (NouvelleFigurineStuff.Figurine.Enregistrer(m_BD, NouvelleFigurineStuff.Figurine, null, false)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SupprimerFigurineStuff(FigurineStuff NouvelleFigurineStuff)
        {
            if (!m_BD.EstConnecte) Initialiser();
            NouvelleFigurineStuff.SupprimerEnCascade(m_BD);
            return true;

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

        public IEnumerable<ArmyUnityFigurine> EnumererArmyUnityFigurineStuff(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return ArmyUnityFigurine.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_ArmyUnityFigurineStuff, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<StuffCharactRank> EnumererStuffCharactRank(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return StuffCharactRank.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_StuffCharactRank, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Army> EnumererArmy(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Army.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Army, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<CharactFeature> EnumererCharactFeature(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return CharactFeature.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_CharactFeature, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }


        public IEnumerable<Scenario_Camp> EnumererScenarioCamp(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Scenario_Camp.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_ScenarioCamp, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<FigurineStuff> EnumererFigurineStuff(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return FigurineStuff.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_FigurineStuff, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Condi_Camp> EnumererCondiCamp(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Condi_Camp.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_CondiCamp, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Scenario> EnumererScenario(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Scenario.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Scenario, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Camp> EnumererCamp(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Camp.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Camp, ClauseJoin, ClauseWhere, ClauseOrderBy));
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

        public IEnumerable<Charact> EnumererCaractere(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Charact.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Charact, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<CharactRank> EnumererPersonnage(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return CharactRank.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_CharactRank, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Rank> EnumererRank(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Rank.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Rank, ClauseJoin, ClauseWhere, ClauseOrderBy));
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

        public IEnumerable<Figurine> EnumererFigurine(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Figurine.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Figurine, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<Unity> EnumererUnity(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Unity.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Unity, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<SubUnity> EnumererSubUnity(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return SubUnity.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_SubUnity, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        public IEnumerable<SubSub> EnumererSubSub(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return SubSub.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_SubSub, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }

        #endregion

    }
}
