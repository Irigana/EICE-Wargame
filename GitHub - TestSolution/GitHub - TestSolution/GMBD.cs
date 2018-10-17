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
        {   // TODO : Ajouter les données de l'utilisateur permettant la connexion à la base de données 
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



        // TODO Vérifier si les champs corresponde bien   
        public Utilisateur ConnexionApplication(string Pseudo, string MotDePasse)
        {
            return EnumererUtilisateur(null,
                                       new MyDB.CodeSql(@"JOIN role ON utilisateur.ref_role = id_role"),
                                       new MyDB.CodeSql("WHERE pseudo = {0} AND mot_de_passe = SHA1({1})", Pseudo, MotDePasse),
                                       null).FirstOrDefault();
        }



        //+==================+
        //| Les énumerations |
        //+==================+


        public IEnumerable<Utilisateur> EnumererUtilisateur(MyDB.CodeSql ValeurSouhaitee, MyDB.CodeSql ClauseJoin, MyDB.CodeSql ClauseWhere, MyDB.CodeSql ClauseOrderBy)
        {
            if (ClauseWhere == null) ClauseWhere = MyDB.CodeSql.Vide;
            if (ClauseOrderBy == null) ClauseOrderBy = MyDB.CodeSql.Vide;
            if (ClauseJoin == null) ClauseJoin = MyDB.CodeSql.Vide;
            if (ValeurSouhaitee == null) ValeurSouhaitee = new MyDB.CodeSql("*");
            return Utilisateur.Enumerer(m_BD, m_BD.Enumerer("SELECT {0} FROM  {1} {2} {3} {4}", ValeurSouhaitee, c_NomTable_Utilisateur, ClauseJoin, ClauseWhere, ClauseOrderBy));
        }


    }
}
