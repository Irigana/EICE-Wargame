using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PDSGBD;

namespace EICE_WARGAME
{
    public partial class PageCaractere : UserControl
    {

        #region Utilisateur
        private Utilisateur m_Utilisateur = null;

        public Utilisateur Utilisateur
        {
            get
            {
                return m_Utilisateur;
            }
            set
            {
                if ((m_Utilisateur == null) && (value != null))
                {
                    m_Utilisateur = value;
                    buttonOptionsUser1.Utilisateur = m_Utilisateur;
                }
            }
        }
        #endregion


        private const string c_CritereQuiContient = "%{0}%";

        private Charact m_CaractereEnEdition;

        public PageCaractere()
        {
            InitializeComponent();

            buttonAnnulerCaract.Enabled = false;
            buttonModifierCaract.Enabled = false;
            buttonSupprimerCaract.Enabled = false;
            buttonAjouterCaract.Enabled = false;
            textBoxCaractere.Enabled = false;            
            menuAdmin1.MaPageActive = 2;            

            Program.GMBD.MettreAJourListeFaction(listeDeroulanteFaction1);

            m_CaractereEnEdition = new Charact();
            /*
            m_CaractereEnEdition.SurErreur += CaractereEnEdition_SurErreur;
            m_CaractereEnEdition.AvantChangement += CaractereEnEdition_AvantChangement;
            m_CaractereEnEdition.ApresChangement += CaractereEnEdition_ApresChangement;
            */


            ficheCaractere1.SurChangementFiltre += ChargerCaractere; 

            listeDeroulanteFaction1.SurChangementSelection += ListeDeroulanteFaction_SurChangementSelection;
            ficheCaractere1.SurChangementSelection += ficheFaction_SurChangementSelection;
            Bitmap ImageRessource = new Bitmap(Properties.Resources.Validation25px);
            ValidationProvider.Icon = Icon.FromHandle(ImageRessource.GetHicon());
        }
        

        private void ChargerCaractere(object s,EventArgs ev)
        {
            ficheCaractere1.Caractere = Program.GMBD.EnumererCaractere(
                        null,
                        null,
                        new MyDB.CodeSql("WHERE charact.ch_name LIKE {0} AND charact.ch_fk_subfaction_id = {1}",
                                         string.Format(c_CritereQuiContient, ficheCaractere1.TexteDuFiltre),listeDeroulanteSousFaction1.SousFactionSelectionnee.Id),
                        new MyDB.CodeSql("ORDER BY charact.ch_name"));           
        }

        private void ListeDeroulanteFaction_SurChangementSelection(object sender, EventArgs e)
        {
            listeDeroulanteSousFaction1.Enabled = true;
            buttonAjouterCaract.Enabled = false;
            
            buttonAnnulerCaract.Enabled = false;
            buttonModifierCaract.Enabled = false;
            buttonSupprimerCaract.Enabled = false;
            
            listeDeroulanteSousFaction1.ResetTextSousFaction();
            ficheCaractere1.NettoyerListView();   
            Program.GMBD.MettreAJourListeSousFaction(listeDeroulanteSousFaction1, listeDeroulanteFaction1.FactionSelectionnee.Id);
            listeDeroulanteSousFaction1.SurChangementSelection += ListeDeroulanteSousFaction_SurChangementSelection;
        }

        private void ListeDeroulanteSousFaction_SurChangementSelection(object sender, EventArgs e)
        {
            ficheCaractere1.ActiverTextBox = true;
            textBoxCaractere.Enabled = true;
            ficheCaractere1.Caractere = Program.GMBD.EnumererCaractere(new MyDB.CodeSql("*"),
                new MyDB.CodeSql("JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),
                new MyDB.CodeSql("WHERE fa_id = {0} AND sf_id = {1}", listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id)
                                                                        ,new MyDB.CodeSql("ORDER BY ch_name"));
            listeDeroulanteSousFaction1.SurChangementSelection += ficheFaction_SurChangementSelection;

        }

        private void ficheFaction_SurChangementSelection(object sender, EventArgs e)
        {
            if ((ficheCaractere1.CaractereSelectionne != null)&&(listeDeroulanteFaction1.FactionSelectionnee != null) &&(listeDeroulanteSousFaction1.SousFactionSelectionnee !=null))
            {
                
                buttonAjouterCaract.Enabled = false;
                buttonAnnulerCaract.Enabled = true;
                buttonModifierCaract.Enabled = true;
                buttonSupprimerCaract.Enabled = true;

                ficheCaractere1.ActiverTextBox = true;
                textBoxCaractere.Text = ficheCaractere1.CaractereSelectionne.Name;

                errorProviderErreurCaractere.Clear();
                ValidationProvider.Clear();
            }
            else if ((listeDeroulanteFaction1.FactionSelectionnee != null) && (listeDeroulanteSousFaction1.SousFactionSelectionnee != null))
            {
                buttonAjouterCaract.Enabled = true;
                buttonAnnulerCaract.Enabled = false;
                buttonModifierCaract.Enabled = false;
                buttonSupprimerCaract.Enabled = false;
            }
            else 
            {
                buttonAjouterCaract.Enabled = false;
                buttonAnnulerCaract.Enabled = false;
                buttonModifierCaract.Enabled = false;
                buttonSupprimerCaract.Enabled = false;
            }

        }
       
        private void PageCaractere_Load(object sender, EventArgs e)
        {
             // Permet de passer l'utilisateur par le controler MenuAdmin
            menuAdmin1.Utilisateur = Utilisateur;
            buttonRetourDashBoard1.Utilisateur = Utilisateur;

            // Permet d'obtenir l'option du menu admin utilisateur une fois l'admin identifié            
            if (Utilisateur.Role.Id == 2) menuAdmin1.EstAdmin = true;            
        }

        private void buttonAjouterCaract_Click(object sender, EventArgs e)
        {
            // Je met faction et sous faction pour vérifier qu'ils soient pas supprimer entre temps par un autre utilisateur et éviter un crash de requete
            Faction FactionExiste = null;
            SousFaction SousFactionExiste = null;

            if (listeDeroulanteFaction1.FactionSelectionnee != null)
            {
                FactionExiste = Program.GMBD.EnumererFaction(null,
                                                             null,
                                                             new MyDB.CodeSql("WHERE faction.fa_id = {0}", listeDeroulanteFaction1.FactionSelectionnee.Id),
                                                             null).FirstOrDefault();
                // Si la faction n'existe pas, on crée une nouvelle faction
                if (FactionExiste != null)
                {

                    if(listeDeroulanteSousFaction1.SousFactionSelectionnee != null)
                    {
                        SousFactionExiste = Program.GMBD.EnumererSousFaction(null,
                                                                             null,
                                                                             new MyDB.CodeSql("WHERE subfaction.sf_fk_faction_id = {0} AND subfaction.sf_id = {1}",listeDeroulanteFaction1.FactionSelectionnee.Id ,listeDeroulanteSousFaction1.SousFactionSelectionnee.Id),
                                                                             null).FirstOrDefault();
                        if (SousFactionExiste != null)
                        {
                            Charact NouveauCaractere = new Charact();
                            NouveauCaractere.SurErreur += CaractereEnEdition_SurErreur;
                            NouveauCaractere.AvantChangement += CaractereEnEdition_AvantChangement;
                            NouveauCaractere.ApresChangement += CaractereEnEdition_ApresChangement;
                            NouveauCaractere.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
                            NouveauCaractere.Name = textBoxCaractere.Text;




                            if ((NouveauCaractere.EstValide) && (Program.GMBD.AjouterCaractere(NouveauCaractere)))
                            {
                                ficheCaractere1.TexteDuFiltre = "";
                                Program.GMBD.MettreAJourFicheCaractere(ficheCaractere1, listeDeroulanteFaction1.FactionSelectionnee.Id,listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);
                                errorProviderErreurCaractere.Clear();
                                ValidationProvider.SetError(textBoxCaractere, "Caractère correctement ajouté");
                            }
                        }
                    }

                    

                }
            }
            textBoxCaractere.Text = "";
            buttonAjouterCaract.Enabled = true;
        }

        private void buttonModifierCaract_Click(object sender, EventArgs e)
        {
            if ((listeDeroulanteFaction1.FactionSelectionnee != null) &&(listeDeroulanteSousFaction1.SousFactionSelectionnee != null) && (ficheCaractere1.CaractereSelectionne != null))
            {

                m_CaractereEnEdition = ficheCaractere1.CaractereSelectionne;
                m_CaractereEnEdition.SurErreur += CaractereEnEdition_SurErreur;
                m_CaractereEnEdition.AvantChangement += CaractereEnEdition_AvantChangement;
                m_CaractereEnEdition.ApresChangement += CaractereEnEdition_ApresChangement;

                m_CaractereEnEdition.SousFaction = listeDeroulanteSousFaction1.SousFactionSelectionnee;
                m_CaractereEnEdition.Name = textBoxCaractere.Text;

                if ((m_CaractereEnEdition.EstValide) && (Program.GMBD.ModifierCaractere(m_CaractereEnEdition)))
                {
                    Program.GMBD.MettreAJourFicheCaractere(ficheCaractere1, listeDeroulanteFaction1.FactionSelectionnee.Id,listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);
                    ficheCaractere1.TexteDuFiltre = "";
                    textBoxCaractere.Text = "";
                }

            }
        }

        private void buttonAnnulerCaract_Click(object sender, EventArgs e)
        {
            ficheCaractere1.TexteDuFiltre = "";            
            textBoxCaractere.Text = "";
            ficheCaractere1.CaractereSelectionne = null;
        }

        private void buttonSupprimerCaract_Click(object sender, EventArgs e)
        {
            PopUpConfirmation FormConfirmation = new PopUpConfirmation();
            // TODO : Vérifier si il a des enregistrement pour modifier le texte en dessous et dire à l'utilisateur le nombre d'element qu'a ce caractère

            FormConfirmation.LabelDuTexte = "Êtes vous certain de vouloir supprimer ce caractère ?";
            FormConfirmation.ShowDialog();
            if (FormConfirmation.Confirmation)
            {
                if ((ficheCaractere1.CaractereSelectionne != null) && (Program.GMBD.SupprimerCaractere(ficheCaractere1.CaractereSelectionne)))
                {
                    Program.GMBD.MettreAJourFicheCaractere(ficheCaractere1, listeDeroulanteFaction1.FactionSelectionnee.Id,listeDeroulanteSousFaction1.SousFactionSelectionnee.Id);
                    buttonAjouterCaract.Enabled = true;
                    buttonAnnulerCaract.Enabled = false;
                    buttonModifierCaract.Enabled = false;
                    buttonSupprimerCaract.Enabled = false;
                    ValidationProvider.SetError(textBoxCaractere, "Suppression correctement effectuée");
                    textBoxCaractere.Text = "";
                }
            }
            else if (FormConfirmation.Annulation)
            {
                // ne rien faire
            }
        }


        /// <summary>
        /// Methode permettant de réagir sur l'erreur d'un ajout ou d'une édition de caractère
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="MessageErreur"></param>
        private void CaractereEnEdition_SurErreur(Charact Entite, Charact.Champ Champ, string MessageErreur)
        {
            switch (Champ)
            {
                case Charact.Champ.Name:
                    errorProviderErreurCaractere.SetError(textBoxCaractere, MessageErreur);
                    break;
            }
            buttonAjouterCaract.Enabled = false;
        }
        
        /// <summary>
        /// Methode permettant de vérifier si la sous faction existe avant le changement de celle ci dans la base de données
        /// </summary>
        /// <param name="Entite"></param>
        /// <param name="Champ"></param>
        /// <param name="ValeurActuelle"></param>
        /// <param name="NouvelleValeur"></param>
        /// <param name="AccumulateurErreur"></param>
        private void CaractereEnEdition_AvantChangement(Charact Entite, Charact.Champ Champ, object ValeurActuelle, object NouvelleValeur, AccumulateurErreur AccumulateurErreur)
        {
            switch (Champ)
            {
                case Charact.Champ.Name:
                    // Si il est en modification
                    if (ficheCaractere1.CaractereSelectionne != null)
                    {
                        Charact CaractereExiste = Program.GMBD.EnumererCaractere(null, 
                            new MyDB.CodeSql("JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),
                            new MyDB.CodeSql("WHERE faction.fa_id = {0} AND subfaction.sf_id = {1} AND charact.ch_name = {2} AND charact.ch_id <> {3}", 
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, textBoxCaractere.Text, ficheCaractere1.CaractereSelectionne.Id), null).FirstOrDefault();

                        if (CaractereExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Cette sous faction existe déjà, veuillez en choisir une autre !");
                        }
                    }
                    // Si il est en ajout
                    else if (ficheCaractere1.CaractereSelectionne == null)
                    {
                        Charact CaractereExiste = Program.GMBD.EnumererCaractere(null,
                            new MyDB.CodeSql("JOIN subfaction ON charact.ch_fk_subfaction_id = subfaction.sf_id JOIN faction ON subfaction.sf_fk_faction_id = faction.fa_id"),                        
                            new MyDB.CodeSql("WHERE faction.fa_id = {0} AND subfaction.sf_id = {1} AND charact.ch_name = {2}",
                            listeDeroulanteFaction1.FactionSelectionnee.Id, listeDeroulanteSousFaction1.SousFactionSelectionnee.Id, textBoxCaractere.Text), null).FirstOrDefault();

                        if (CaractereExiste != null)
                        {
                            AccumulateurErreur.NotifierErreur("Cette sous faction existe déjà, veuillez en choisir une autre !");
                        }
                    }
                    break;
            }
        }
        private void CaractereEnEdition_ApresChangement(Charact Entite, Charact.Champ Champ, object ValeurPrecedente, object ValeurActuelle)
        {
            switch (Champ)
            {
                case Charact.Champ.Name:
                    if (ficheCaractere1.CaractereSelectionne != null)
                    {
                        ValidationProvider.SetError(textBoxCaractere, "Votre caractère a bien été modifié");
                    }
                    else if(ficheCaractere1.CaractereSelectionne == null)
                    {
                        ValidationProvider.SetError(textBoxCaractere, "Votre caractère a bien été ajouté");
                    }

                    break;

            }
            buttonAjouterCaract.Enabled = m_CaractereEnEdition.EstValide;
        }

        private void textBoxCaractere_Enter(object sender, EventArgs e)
        {
            errorProviderErreurCaractere.Clear();
            ValidationProvider.Clear();
        }

      
        private void textBoxCaractere_KeyPress(object sender, KeyPressEventArgs e)
        {
            /*
            ficheCaractere1.CaractereSelectionne = null;
            buttonAjouterCaract.Enabled = true;
            buttonAnnulerCaract.Enabled = false;
            buttonModifierCaract.Enabled = false;
            buttonSupprimerCaract.Enabled = false;
            */
        }
    }   
}
