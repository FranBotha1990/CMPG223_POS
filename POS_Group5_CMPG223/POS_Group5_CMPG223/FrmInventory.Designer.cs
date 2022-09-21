namespace POS_Group5_CMPG223
{
    partial class FrmInventory
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.lblScroll = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.groupBoxAdd = new System.Windows.Forms.GroupBox();
            this.btnAddToDB = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtSellPrice = new System.Windows.Forms.TextBox();
            this.lblSellPrice = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlItems.SuspendLayout();
            this.groupBoxAdd.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(10, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(357, 441);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(250, 50);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete Product";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(250, 50);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Product";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(8, 24);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(231, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(5, 9);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(44, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search:";
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(8, 59);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(231, 34);
            this.hScrollBar.TabIndex = 6;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // lblScroll
            // 
            this.lblScroll.AutoSize = true;
            this.lblScroll.Location = new System.Drawing.Point(5, 46);
            this.lblScroll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(84, 13);
            this.lblScroll.TabIndex = 7;
            this.lblScroll.Text = "Price more than:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(96, 46);
            this.lblDisplay.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(47, 13);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "[Display]";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Location = new System.Drawing.Point(0, 0);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(250, 50);
            this.btnAddProduct.TabIndex = 0;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.groupBoxAdd);
            this.pnlItems.Controls.Add(this.panel1);
            this.pnlItems.Controls.Add(this.pnlButtons);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlItems.Location = new System.Drawing.Point(377, 0);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(250, 461);
            this.pnlItems.TabIndex = 10;
            // 
            // groupBoxAdd
            // 
            this.groupBoxAdd.Controls.Add(this.btnAddToDB);
            this.groupBoxAdd.Controls.Add(this.btnBack);
            this.groupBoxAdd.Controls.Add(this.txtSellPrice);
            this.groupBoxAdd.Controls.Add(this.lblSellPrice);
            this.groupBoxAdd.Controls.Add(this.txtDescription);
            this.groupBoxAdd.Controls.Add(this.lblDescription);
            this.groupBoxAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxAdd.Location = new System.Drawing.Point(0, 101);
            this.groupBoxAdd.Name = "groupBoxAdd";
            this.groupBoxAdd.Size = new System.Drawing.Size(250, 132);
            this.groupBoxAdd.TabIndex = 10;
            this.groupBoxAdd.TabStop = false;
            this.groupBoxAdd.Text = "Add Product";
            // 
            // btnAddToDB
            // 
            this.btnAddToDB.Location = new System.Drawing.Point(9, 97);
            this.btnAddToDB.Name = "btnAddToDB";
            this.btnAddToDB.Size = new System.Drawing.Size(75, 23);
            this.btnAddToDB.TabIndex = 5;
            this.btnAddToDB.Text = "Add";
            this.btnAddToDB.UseVisualStyleBackColor = true;
            this.btnAddToDB.Click += new System.EventHandler(this.btnAddToDB_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(163, 97);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 6;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtSellPrice
            // 
            this.txtSellPrice.Location = new System.Drawing.Point(8, 71);
            this.txtSellPrice.Name = "txtSellPrice";
            this.txtSellPrice.Size = new System.Drawing.Size(230, 20);
            this.txtSellPrice.TabIndex = 4;
            // 
            // lblSellPrice
            // 
            this.lblSellPrice.AutoSize = true;
            this.lblSellPrice.Location = new System.Drawing.Point(6, 55);
            this.lblSellPrice.Name = "lblSellPrice";
            this.lblSellPrice.Size = new System.Drawing.Size(54, 13);
            this.lblSellPrice.TabIndex = 2;
            this.lblSellPrice.Text = "Sell Price:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(8, 32);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(231, 20);
            this.txtDescription.TabIndex = 3;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(5, 16);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(63, 13);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.hScrollBar);
            this.panel1.Controls.Add(this.lblDisplay);
            this.panel1.Controls.Add(this.lblSearch);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.lblScroll);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 101);
            this.panel1.TabIndex = 9;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAddProduct);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 311);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(250, 150);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.dataGridView1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(377, 461);
            this.pnlForm.TabIndex = 11;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 461);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlItems.ResumeLayout(false);
            this.groupBoxAdd.ResumeLayout(false);
            this.groupBoxAdd.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.GroupBox groupBoxAdd;
        private System.Windows.Forms.Button btnAddToDB;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtSellPrice;
        private System.Windows.Forms.Label lblSellPrice;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Panel panel1;
    }
}