/*Adriaan Pienaar(39399575)
Armin Pretorius(34739572)
Francois Hendrik Botha (34507965)
Michael van Niekerk (29580080)
Luigi Willemse(38887657)*/

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

            //Load Sales form as default
            loadSales();
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
            btnSales.ForeColor = Methods.DetermineFrontColor(btnSales.BackColor);
            btnSalesOrders.ForeColor = Methods.DetermineFrontColor(btnSalesOrders.BackColor);
            btnPurchaseOrders.ForeColor = Methods.DetermineFrontColor(btnPurchaseOrders.BackColor);
            btnReporting.ForeColor = Methods.DetermineFrontColor(btnReporting.BackColor);
            btnSettings.ForeColor = Methods.DetermineFrontColor(btnSettings.BackColor);
            btnSuppliers.ForeColor = Methods.DetermineFrontColor(btnSuppliers.BackColor);
            btnClose.ForeColor = Methods.DetermineFrontColor(btnClose.BackColor);
            btnMax.ForeColor = Methods.DetermineFrontColor(btnMax.BackColor);
            btnMin.ForeColor = Methods.DetermineFrontColor(btnMin.BackColor);
            btnHelp.ForeColor = Methods.DetermineFrontColor(btnHelp.BackColor);
            //Icon Colors
            btnInventory.IconColor = Methods.DetermineFrontColor(btnInventory.BackColor);
            btnOrder.IconColor = Methods.DetermineFrontColor(btnOrder.BackColor);
            btnSales.IconColor = Methods.DetermineFrontColor(btnSales.BackColor);
            btnReporting.IconColor = Methods.DetermineFrontColor(btnReporting.BackColor);
            btnSettings.IconColor = Methods.DetermineFrontColor(btnSettings.BackColor);
            btnSuppliers.IconColor = Methods.DetermineFrontColor(btnSuppliers.BackColor);
            btnPurchaseOrders.IconColor = Methods.DetermineFrontColor(btnPurchaseOrders.BackColor);
            btnSalesOrders.IconColor = Methods.DetermineFrontColor(btnSalesOrders.BackColor);
            btnHelp.IconColor = Methods.DetermineFrontColor(btnHelp.BackColor);
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
        private void btnSales_Click(object sender, EventArgs e)
        {
            loadSales();
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            MenuSelect(btnInventory, "Inventory");
            FrmInventory frmInventory;
            OpenChildForm(frmInventory = new FrmInventory());
            frmInventory.LoadGUI();
            activeForm = frmInventory;
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            MenuSelect(btnOrder, "Order");
            FrmOrder frmOrder;
            OpenChildForm(frmOrder = new FrmOrder());
            frmOrder.LoadGUI();
            activeForm = frmOrder;
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            MenuSelect(btnSuppliers, "Suppliers");
            FrmSuppliers frmSuppliers;
            OpenChildForm(frmSuppliers = new FrmSuppliers());
            frmSuppliers.LoadGUI();
            activeForm = frmSuppliers;
        }

        private void btnReporting_Click(object sender, EventArgs e)
        {
            MenuSelect(btnReporting, "Reporting");
            FrmReporting frmReporting;
            OpenChildForm(frmReporting = new FrmReporting());
            frmReporting.LoadGUI();
            activeForm = frmReporting;
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            MenuSelect(btnSettings, "Settings");
            FrmSettings frmSettings;
            OpenChildForm(frmSettings = new FrmSettings());
            frmSettings.LoadGUI();
            activeForm = frmSettings;
        }

        private void btnSalesOrders_Click(object sender, EventArgs e)
        {
            MenuSelect(btnSalesOrders, "Sales Orders");
            FrmSalesOrders frmSalesOrders;
            OpenChildForm(frmSalesOrders = new FrmSalesOrders());
            frmSalesOrders.LoadGUI();
            activeForm = frmSalesOrders;
        }

        private void btnPurchaseOrders_Click(object sender, EventArgs e)
        {
            MenuSelect(btnPurchaseOrders, "Purchase Orders");
            FrmPurchaseOrders frmPurchaseOrders;
            OpenChildForm(frmPurchaseOrders = new FrmPurchaseOrders());
            frmPurchaseOrders.LoadGUI();
            activeForm = frmPurchaseOrders;
        }
        #endregion
        #region Tooltips
        private void btnSales_MouseHover(object sender, EventArgs e)
        {
            toolTipSales.Show("Sell products", btnSales, btnSales.Left + btnSales.Width, btnSales.Bottom - btnSales.Top - btnSales.Height * 2 / 3);
        }

        private void btnSales_MouseLeave(object sender, EventArgs e)
        {
            toolTipSales.Hide(this);
        }

        private void btnSalesOrders_MouseHover(object sender, EventArgs e)
        {
            toolTipSalesOrders.Show("Update or delete sales orders", btnSalesOrders, btnSalesOrders.Left + btnSalesOrders.Width, btnSalesOrders.Bottom - btnSalesOrders.Top - btnSalesOrders.Height * 2 / 3);
        }

        private void btnSalesOrders_MouseLeave(object sender, EventArgs e)
        {
            toolTipSalesOrders.Hide(this);
        }

        private void btnInventory_MouseLeave(object sender, EventArgs e)
        {
            toolTipInventory.Hide(this);
        }

        private void btnInventory_MouseHover(object sender, EventArgs e)
        {
            toolTipInventory.Show("Add, update or delete inventory", btnInventory, btnInventory.Left + btnInventory.Width, btnInventory.Bottom - btnInventory.Top - btnInventory.Height * 2 / 3);
        }

        private void btnOrder_MouseLeave(object sender, EventArgs e)
        {
            toolTipOrder.Hide(this);
        }

        private void btnOrder_MouseHover(object sender, EventArgs e)
        {
            toolTipOrder.Show("Order products", btnOrder, btnOrder.Left + btnOrder.Width, btnOrder.Bottom - btnOrder.Top - btnOrder.Height * 2 / 3);
        }

        private void btnPurchaseOrders_MouseHover(object sender, EventArgs e)
        {
            toolTipPurchaseOrder.Show("Recieve, update or delete purchase orders", btnPurchaseOrders, btnPurchaseOrders.Left + btnPurchaseOrders.Width, btnPurchaseOrders.Bottom - btnPurchaseOrders.Top - btnPurchaseOrders.Height * 2 / 3);
        }

        private void btnPurchaseOrders_MouseLeave(object sender, EventArgs e)
        {
            toolTipPurchaseOrder.Hide(this);
        }

        private void btnSuppliers_MouseHover(object sender, EventArgs e)
        {
            toolTipSupplier.Show("Add, update or delete suppliers", btnSuppliers, btnSuppliers.Left + btnSuppliers.Width, btnSuppliers.Bottom - btnSuppliers.Top - btnSuppliers.Height * 2 / 3);
        }

        private void btnSuppliers_MouseLeave(object sender, EventArgs e)
        {
            toolTipSupplier.Hide(this);
        }

        private void btnReporting_MouseHover(object sender, EventArgs e)
        {
            toolTipReporting.Show("Generate reports", btnReporting, btnReporting.Left + btnReporting.Width, btnReporting.Bottom - btnReporting.Top - btnReporting.Height * 2 / 3);
        }

        private void btnReporting_MouseLeave(object sender, EventArgs e)
        {
            toolTipReporting.Hide(this);
        }

        private void btnSettings_MouseHover(object sender, EventArgs e)
        {
            toolTipSettings.Show("Manage app preferences", btnSettings, btnSettings.Left + btnSettings.Width, btnSettings.Bottom - btnSettings.Top - btnSettings.Height * 2 / 3);
        }

        private void btnSettings_MouseLeave(object sender, EventArgs e)
        {
            toolTipSettings.Hide(this);
        }
        #endregion

        #region Load Sales Method
        private void loadSales()
        {
            //Load Sales as default page
            MenuSelect(btnSales, "Sales");
            FrmSales frmSales;
            OpenChildForm(frmSales = new FrmSales());
            frmSales.LoadGUI();
            activeForm = frmSales;
        }
        #endregion
        #region Help Button
        private void btnHelp_Click(object sender, EventArgs e)
        {
            FrmHelp frmHelp = new FrmHelp();
            frmHelp.Show();
        }
        #endregion
    }
}
