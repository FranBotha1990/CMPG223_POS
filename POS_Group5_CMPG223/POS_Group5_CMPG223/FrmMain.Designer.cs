
namespace POS_Group5_CMPG223
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnReporting = new FontAwesome.Sharp.IconButton();
            this.btnSuppliers = new FontAwesome.Sharp.IconButton();
            this.btnPurchaseOrders = new FontAwesome.Sharp.IconButton();
            this.btnOrder = new FontAwesome.Sharp.IconButton();
            this.btnInventory = new FontAwesome.Sharp.IconButton();
            this.btnSalesOrders = new FontAwesome.Sharp.IconButton();
            this.btnSales = new FontAwesome.Sharp.IconButton();
            this.pnlName = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblHeader = new System.Windows.Forms.Label();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.toolTipSales = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSalesOrders = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipInventory = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipOrder = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipPurchaseOrder = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSupplier = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipReporting = new System.Windows.Forms.ToolTip(this.components);
            this.toolTipSettings = new System.Windows.Forms.ToolTip(this.components);
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.pnlMenu.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnHelp);
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnReporting);
            this.pnlMenu.Controls.Add(this.btnSuppliers);
            this.pnlMenu.Controls.Add(this.btnPurchaseOrders);
            this.pnlMenu.Controls.Add(this.btnOrder);
            this.pnlMenu.Controls.Add(this.btnInventory);
            this.pnlMenu.Controls.Add(this.btnSalesOrders);
            this.pnlMenu.Controls.Add(this.btnSales);
            this.pnlMenu.Controls.Add(this.pnlName);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(200, 661);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.ScrewdriverWrench;
            this.btnSettings.IconColor = System.Drawing.Color.Black;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 30;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 410);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSettings.Size = new System.Drawing.Size(200, 50);
            this.btnSettings.TabIndex = 7;
            this.btnSettings.TabStop = false;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            this.btnSettings.MouseLeave += new System.EventHandler(this.btnSettings_MouseLeave);
            this.btnSettings.MouseHover += new System.EventHandler(this.btnSettings_MouseHover);
            // 
            // btnReporting
            // 
            this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.IconChar = FontAwesome.Sharp.IconChar.LineChart;
            this.btnReporting.IconColor = System.Drawing.Color.Black;
            this.btnReporting.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnReporting.IconSize = 30;
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(0, 360);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnReporting.Size = new System.Drawing.Size(200, 50);
            this.btnReporting.TabIndex = 6;
            this.btnReporting.TabStop = false;
            this.btnReporting.Text = "Reporting";
            this.btnReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            this.btnReporting.MouseLeave += new System.EventHandler(this.btnReporting_MouseLeave);
            this.btnReporting.MouseHover += new System.EventHandler(this.btnReporting_MouseHover);
            // 
            // btnSuppliers
            // 
            this.btnSuppliers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSuppliers.FlatAppearance.BorderSize = 0;
            this.btnSuppliers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuppliers.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnSuppliers.IconColor = System.Drawing.Color.Black;
            this.btnSuppliers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSuppliers.IconSize = 30;
            this.btnSuppliers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.Location = new System.Drawing.Point(0, 310);
            this.btnSuppliers.Name = "btnSuppliers";
            this.btnSuppliers.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSuppliers.Size = new System.Drawing.Size(200, 50);
            this.btnSuppliers.TabIndex = 5;
            this.btnSuppliers.TabStop = false;
            this.btnSuppliers.Text = "Suppliers";
            this.btnSuppliers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSuppliers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuppliers.UseVisualStyleBackColor = true;
            this.btnSuppliers.Click += new System.EventHandler(this.btnSuppliers_Click);
            this.btnSuppliers.MouseLeave += new System.EventHandler(this.btnSuppliers_MouseLeave);
            this.btnSuppliers.MouseHover += new System.EventHandler(this.btnSuppliers_MouseHover);
            // 
            // btnPurchaseOrders
            // 
            this.btnPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchaseOrders.FlatAppearance.BorderSize = 0;
            this.btnPurchaseOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchaseOrders.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnPurchaseOrders.IconColor = System.Drawing.Color.Black;
            this.btnPurchaseOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPurchaseOrders.IconSize = 30;
            this.btnPurchaseOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrders.Location = new System.Drawing.Point(0, 260);
            this.btnPurchaseOrders.Name = "btnPurchaseOrders";
            this.btnPurchaseOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnPurchaseOrders.Size = new System.Drawing.Size(200, 50);
            this.btnPurchaseOrders.TabIndex = 4;
            this.btnPurchaseOrders.TabStop = false;
            this.btnPurchaseOrders.Text = "Purchase Orders";
            this.btnPurchaseOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchaseOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPurchaseOrders.UseVisualStyleBackColor = true;
            this.btnPurchaseOrders.Click += new System.EventHandler(this.btnPurchaseOrders_Click);
            this.btnPurchaseOrders.MouseLeave += new System.EventHandler(this.btnPurchaseOrders_MouseLeave);
            this.btnPurchaseOrders.MouseHover += new System.EventHandler(this.btnPurchaseOrders_MouseHover);
            // 
            // btnOrder
            // 
            this.btnOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOrder.FlatAppearance.BorderSize = 0;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrder.IconChar = FontAwesome.Sharp.IconChar.Truck;
            this.btnOrder.IconColor = System.Drawing.Color.Black;
            this.btnOrder.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOrder.IconSize = 30;
            this.btnOrder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.Location = new System.Drawing.Point(0, 210);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnOrder.Size = new System.Drawing.Size(200, 50);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.TabStop = false;
            this.btnOrder.Text = "Order";
            this.btnOrder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            this.btnOrder.MouseLeave += new System.EventHandler(this.btnOrder_MouseLeave);
            this.btnOrder.MouseHover += new System.EventHandler(this.btnOrder_MouseHover);
            // 
            // btnInventory
            // 
            this.btnInventory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInventory.FlatAppearance.BorderSize = 0;
            this.btnInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInventory.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.btnInventory.IconColor = System.Drawing.Color.Black;
            this.btnInventory.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInventory.IconSize = 30;
            this.btnInventory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.Location = new System.Drawing.Point(0, 160);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInventory.Size = new System.Drawing.Size(200, 50);
            this.btnInventory.TabIndex = 2;
            this.btnInventory.TabStop = false;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            this.btnInventory.MouseLeave += new System.EventHandler(this.btnInventory_MouseLeave);
            this.btnInventory.MouseHover += new System.EventHandler(this.btnInventory_MouseHover);
            // 
            // btnSalesOrders
            // 
            this.btnSalesOrders.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSalesOrders.FlatAppearance.BorderSize = 0;
            this.btnSalesOrders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesOrders.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnSalesOrders.IconColor = System.Drawing.Color.Black;
            this.btnSalesOrders.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalesOrders.IconSize = 30;
            this.btnSalesOrders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesOrders.Location = new System.Drawing.Point(0, 110);
            this.btnSalesOrders.Name = "btnSalesOrders";
            this.btnSalesOrders.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSalesOrders.Size = new System.Drawing.Size(200, 50);
            this.btnSalesOrders.TabIndex = 8;
            this.btnSalesOrders.TabStop = false;
            this.btnSalesOrders.Text = "Sales Orders";
            this.btnSalesOrders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalesOrders.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSalesOrders.UseVisualStyleBackColor = true;
            this.btnSalesOrders.Click += new System.EventHandler(this.btnSalesOrders_Click);
            this.btnSalesOrders.MouseLeave += new System.EventHandler(this.btnSalesOrders_MouseLeave);
            this.btnSalesOrders.MouseHover += new System.EventHandler(this.btnSalesOrders_MouseHover);
            // 
            // btnSales
            // 
            this.btnSales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSales.FlatAppearance.BorderSize = 0;
            this.btnSales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSales.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.btnSales.IconColor = System.Drawing.Color.Black;
            this.btnSales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSales.IconSize = 30;
            this.btnSales.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.Location = new System.Drawing.Point(0, 60);
            this.btnSales.Name = "btnSales";
            this.btnSales.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnSales.Size = new System.Drawing.Size(200, 50);
            this.btnSales.TabIndex = 1;
            this.btnSales.TabStop = false;
            this.btnSales.Text = "Sales";
            this.btnSales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSales.UseVisualStyleBackColor = true;
            this.btnSales.Click += new System.EventHandler(this.btnSales_Click);
            this.btnSales.MouseLeave += new System.EventHandler(this.btnSales_MouseLeave);
            this.btnSales.MouseHover += new System.EventHandler(this.btnSales_MouseHover);
            // 
            // pnlName
            // 
            this.pnlName.Controls.Add(this.lblName);
            this.pnlName.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlName.Location = new System.Drawing.Point(0, 0);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(200, 60);
            this.pnlName.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(200, 60);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "[Business Name]";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblName.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblName_MouseDown);
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.pnlControl);
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(200, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(899, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.Controls.Add(this.btnMin);
            this.pnlControl.Controls.Add(this.btnMax);
            this.pnlControl.Controls.Add(this.btnClose);
            this.pnlControl.Location = new System.Drawing.Point(764, 0);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(135, 32);
            this.pnlControl.TabIndex = 1;
            // 
            // btnMin
            // 
            this.btnMin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(0, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Padding = new System.Windows.Forms.Padding(8, 5, 0, 0);
            this.btnMin.Size = new System.Drawing.Size(45, 32);
            this.btnMin.TabIndex = 3;
            this.btnMin.TabStop = false;
            this.btnMin.Text = "▔ ";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnMax
            // 
            this.btnMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMax.FlatAppearance.BorderSize = 0;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.Location = new System.Drawing.Point(45, 0);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(45, 32);
            this.btnMax.TabIndex = 2;
            this.btnMax.TabStop = false;
            this.btnMax.Text = "☐";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(90, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(45, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblHeader
            // 
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(899, 60);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Home";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblHeader_MouseDown);
            // 
            // pnlForm
            // 
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(200, 60);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Size = new System.Drawing.Size(899, 601);
            this.pnlForm.TabIndex = 2;
            // 
            // btnHelp
            // 
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Question;
            this.btnHelp.IconColor = System.Drawing.Color.Black;
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHelp.IconSize = 30;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 611);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnHelp.Size = new System.Drawing.Size(200, 50);
            this.btnHelp.TabIndex = 9;
            this.btnHelp.TabStop = false;
            this.btnHelp.Text = "Help";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 661);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(772, 646);
            this.Name = "frmMain";
            this.Text = "Main";
            this.pnlMenu.ResumeLayout(false);
            this.pnlName.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.Panel pnlHeader;
        private FontAwesome.Sharp.IconButton btnSales;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Panel pnlForm;
        private FontAwesome.Sharp.IconButton btnInventory;
        private FontAwesome.Sharp.IconButton btnSalesOrders;
        private FontAwesome.Sharp.IconButton btnOrder;
        private FontAwesome.Sharp.IconButton btnPurchaseOrders;
        public FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnReporting;
        private FontAwesome.Sharp.IconButton btnSuppliers;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolTip toolTipSales;
        private System.Windows.Forms.ToolTip toolTipSalesOrders;
        private System.Windows.Forms.ToolTip toolTipInventory;
        private System.Windows.Forms.ToolTip toolTipOrder;
        private System.Windows.Forms.ToolTip toolTipPurchaseOrder;
        private System.Windows.Forms.ToolTip toolTipSupplier;
        private System.Windows.Forms.ToolTip toolTipReporting;
        private System.Windows.Forms.ToolTip toolTipSettings;
        public FontAwesome.Sharp.IconButton btnHelp;
    }
}

