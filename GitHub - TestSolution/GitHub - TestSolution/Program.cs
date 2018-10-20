using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSGBD;

namespace EICE_WARGAME
{
    static class Program
    {
        //bonjour iiiiiii
        private static GMBD s_GMBD;

        public static GMBD GMBD
        {
            get
            {
                return s_GMBD;
            }
        }

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            


            s_GMBD = new GMBD();
            s_GMBD.BD.SurChangementEtatConnexion += BD_SurChangementEtatConnexion;


            if (!s_GMBD.Initialiser())
            {
                MessageBox.Show("Erreur d'accès à la base de données !", "EICE_WARGAME", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            else
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Form_Principal());
            }
        
            

        }
        
    
        /// <summary>
        /// Méthode appelée lorsqu'un changement d'état de la connexion au serveur MySQL se produit
        /// </summary>
        /// <param name="ConnexionEmetrice">Connexion concernée par le changement d'état</param>
        /// <param name="EtatPrecedent">Etat précédant ce changement</param>
        /// <param name="NouvelEtat">Nouvel état résultant de ce changement</param>
        private static void BD_SurChangementEtatConnexion(MyDB ConnexionEmetrice, MyDB.EtatConnexion EtatPrecedent, MyDB.EtatConnexion NouvelEtat)
        {
            System.Diagnostics.Debug.WriteLine(string.Format("\nCONNEXION BD :\nChangement d'état : {0} ==>> {1}\n", EtatPrecedent, NouvelEtat));
        }
        
    }
}
