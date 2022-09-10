using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Group5_CMPG223
{
    public partial class frmMain : Form
    {
        #region Variables
        public Panel pnlShow;
        private Form activeForm;
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();

            //GUI Setup
            Methods.LoadProperties();
            LoadGUI();
            //Change border
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }
        #endregion
        #region Load GUI
        public void LoadGUI()
        {
            //Back Colors
            pnlForm.BackColor = Methods.clrForms;
            pnlMenu.BackColor = Methods.clrMenu;
            pnlHeader.BackColor = Methods.clrMenu;
            pnlName.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, -0.3);
            pnlControl.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, -0.3);
            //Fore Colors
            lblHeader.ForeColor = Methods.DetermineFrontColor(lblHeader.BackColor);
            lblName.ForeColor = Methods.DetermineFrontColor(lblName.BackColor);
            btnInventory.ForeColor = Methods.DetermineFrontColor(btnInventory.BackColor);
            btnOrder.ForeColor = Methods.DetermineFrontColor(btnOrder.BackColor);
            btnPOS.ForeColor = Methods.DetermineFrontColor(btnPOS.BackColor);
            btnReporting.ForeColor = Methods.DetermineFrontColor(btnReporting.BackColor);
            btnSettings.ForeColor = Methods.DetermineFrontColor(btnSettings.BackColor);
            btnSuppliers.ForeColor = Methods.DetermineFrontColor(btnSuppliers.BackColor);
            btnClose.ForeColor = Methods.DetermineFrontColor(btnClose.BackColor);
            btnMax.ForeColor = Methods.DetermineFrontColor(btnMax.BackColor);
            btnMin.ForeColor = Methods.DetermineFrontColor(btnMin.BackColor);
            //Icon Colors
            btnInventory.IconColor = Methods.DetermineFrontColor(btnInventory.BackColor);
            btnOrder.IconColor = Methods.DetermineFrontColor(btnOrder.BackColor);
            btnPOS.IconColor = Methods.DetermineFrontColor(btnPOS.BackColor);
            btnReporting.IconColor = Methods.DetermineFrontColor(btnReporting.BackColor);
            btnSettings.IconColor = Methods.DetermineFrontColor(btnSettings.BackColor);
            btnSuppliers.IconColor = Methods.DetermineFrontColor(btnSuppliers.BackColor);
            //Misc
            lblName.Text = Methods.businessName;
        }
        #endregion
        #region Drag Function
        private void lblHeader_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.DragCode(this);
        }

        private void lblName_MouseDown(object sender, MouseEventArgs e)
        {
            Methods.DragCode(this);
        }
        #endregion
        #region Control Box
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Open Screen
        public void MenuSelect(FontAwesome.Sharp.IconButton btnPressed, String screenName)
        {
            //Reload the GUI
            LoadGUI();
            //Check if a previous panel exists and disposes of it
            if (pnlShow != null)
            {
                pnlShow.Dispose();
            }
            //Set up panel
            pnlShow = new Panel();
            pnlShow.Parent = btnPressed;
            pnlShow.Dock = DockStyle.Left;
            pnlShow.Width = 7;
            pnlShow.BackColor = Methods.clrSelected;
            //Change color of icon
            btnPressed.IconColor = Methods.clrSelected;
            //Change Header
            lblHeader.Text = screenName;
        }
        #endregion
        #region Open Child Form
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlForm.Controls.Add(childForm);
            this.pnlForm.Tag = childForm;
            childForm.Show();
        }
        #endregion
        #region Menu Buttons
        private void btnPOS_Click(object sender, EventArgs e)
        {
            MenuSelect(btnPOS, "Point of Sale");
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MenuSelect(btnInventory, "Inventory");
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MenuSelect(btnOrder, "Order");
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            MenuSelect(btnSuppliers, "Suppliers");
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            MenuSelect(btnReporting, "Reporting");
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MenuSelect(btnSettings, "Settings");
            FrmSettings frmSettings;
            OpenChildForm(frmSettings = new FrmSettings());
            frmSettings.LoadGUI();
            activeForm = frmSettings;
        }
        #endregion
    }
}
