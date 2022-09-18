using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_Group5_CMPG223
{
    public partial class FrmSettings : Form
    {
        #region Constructor
        public FrmSettings()
        {
            InitializeComponent();
        }
        #endregion
        #region Load GUI
        public void LoadGUI()
        {
            //Back Colors
            this.BackColor = Methods.clrForms;
            //Fore Colors
            gbxBusinessSettings.ForeColor = Methods.DetermineFrontColor(gbxBusinessSettings.BackColor);
            gbxGUISettings.ForeColor = Methods.DetermineFrontColor(gbxGUISettings.BackColor);
            btnSaveSettings.ForeColor = Methods.DetermineFrontColor(btnSaveSettings.BackColor);
            btnClose.ForeColor = Methods.DetermineFrontColor(btnSaveSettings.BackColor);
            //Misc
            txtBusinessName.Text = Methods.businessName;
            cbxColorScheme.SelectedIndex = Methods.colorScheme;
        }
        #endregion

        #region Buttons
        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            Methods.businessName = txtBusinessName.Text;
            Methods.colorScheme = cbxColorScheme.SelectedIndex;
            Methods.SaveProperties();
            Methods.LoadProperties();
            Program.mainForm.LoadGUI();
            Program.mainForm.MenuSelect(Program.mainForm.btnSettings, "Settings");
            LoadGUI();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.mainForm.LoadGUI();
            Program.mainForm.pnlShow.Dispose();
            Program.mainForm.lblHeader.Text = "Home";
        }
        #endregion
    }
}
