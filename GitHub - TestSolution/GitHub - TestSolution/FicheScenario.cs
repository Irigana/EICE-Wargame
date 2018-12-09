using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EICE_WARGAME
{
    public partial class FicheScenario : UserControl
    {
        #region Propriété Obligatoire
        
        public int QG
        {
            get { return Convert.ToInt32(numericUpDownQG.Value); }
            set { numericUpDownQG.Value = Convert.ToDecimal(value); }
        }
        
        public int Troupes
        {
            get { return Convert.ToInt32(numericUpDownTroupes.Value); }
            set { numericUpDownTroupes.Value = Convert.ToDecimal(value); }
        }
        
        public int AttaqueRapide
        {
            get { return Convert.ToInt32(numericUpDownAtqRapide.Value); }
            set { numericUpDownAtqRapide.Value = Convert.ToDecimal(value); }
        }

        public int Soutien
        {
            get { return Convert.ToInt32(numericUpDownSoutien.Value); }
            set { numericUpDownSoutien.Value = Convert.ToDecimal(value); }
        }
        
        public int Elite
        {
            get { return Convert.ToInt32(numericUpDownElite.Value); }
            set { numericUpDownElite.Value = Convert.ToDecimal(value); }
        }
        #endregion


        #region Propriété Obligatoire       
        public int MQG
        {
            get { return Convert.ToInt32(numericUpDownMQG.Value); }
            set { numericUpDownMQG.Value = Convert.ToDecimal(value); }
        }
        
        public int MTroupes
        {
            get { return Convert.ToInt32(numericUpDownMTroupes.Value); }
            set { numericUpDownTroupes.Value = Convert.ToDecimal(value); }
        }
        
        public int MAttaqueRapide
        {
            get { return Convert.ToInt32(numericUpDownMATQRapide.Value); }
            set { numericUpDownMATQRapide.Value = Convert.ToDecimal(value); }
        }        

        public int MSoutien
        {
            get { return Convert.ToInt32(numericUpDownMSoutien.Value); }
            set { numericUpDownMSoutien.Value = Convert.ToDecimal(value); }
        }        

        public int MElite
        {
            get { return Convert.ToInt32(numericUpDownMElite.Value); }
            set { numericUpDownMElite.Value = Convert.ToDecimal(value); }
        }
        #endregion

        public FicheScenario()
        {
            InitializeComponent();
        }

        
    }
}
