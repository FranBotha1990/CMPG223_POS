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
            this.btnBuyProduct = new System.Windows.Forms.Button();
            this.btnStockTake = new System.Windows.Forms.Button();
            this.btnDiscard = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.lblScroll = new System.Windows.Forms.Label();
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlForm = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnlItems.SuspendLayout();
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(530, 430);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBuyProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuyProduct.Location = new System.Drawing.Point(0, 0);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Size = new System.Drawing.Size(250, 50);
            this.btnBuyProduct.TabIndex = 2;
            this.btnBuyProduct.Text = "Buy Product";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            // 
            // btnStockTake
            // 
            this.btnStockTake.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnStockTake.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStockTake.Location = new System.Drawing.Point(0, 150);
            this.btnStockTake.Name = "btnStockTake";
            this.btnStockTake.Size = new System.Drawing.Size(250, 50);
            this.btnStockTake.TabIndex = 3;
            this.btnStockTake.Text = "Stock Take";
            this.btnStockTake.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDiscard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscard.Location = new System.Drawing.Point(0, 100);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(250, 50);
            this.btnDiscard.TabIndex = 4;
            this.btnDiscard.Text = "Discard Stock";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(72, 37);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(2);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(112, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(75, 18);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(108, 13);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search As You Type:";
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(72, 135);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(110, 34);
            this.hScrollBar.TabIndex = 6;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // lblScroll
            // 
            this.lblScroll.AutoSize = true;
            this.lblScroll.Location = new System.Drawing.Point(84, 88);
            this.lblScroll.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(87, 13);
            this.lblScroll.TabIndex = 7;
            this.lblScroll.Text = "Search by value:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(103, 111);
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
            this.btnAddProduct.Location = new System.Drawing.Point(0, 50);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(250, 50);
            this.btnAddProduct.TabIndex = 1;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.lblSearch);
            this.pnlItems.Controls.Add(this.lblScroll);
            this.pnlItems.Controls.Add(this.txtSearch);
            this.pnlItems.Controls.Add(this.lblDisplay);
            this.pnlItems.Controls.Add(this.pnlButtons);
            this.pnlItems.Controls.Add(this.hScrollBar);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlItems.Location = new System.Drawing.Point(550, 0);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(250, 450);
            this.pnlItems.TabIndex = 10;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAddProduct);
            this.pnlButtons.Controls.Add(this.btnDiscard);
            this.pnlButtons.Controls.Add(this.btnStockTake);
            this.pnlButtons.Controls.Add(this.btnBuyProduct);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 250);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(250, 200);
            this.pnlButtons.TabIndex = 0;
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.dataGridView1);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(550, 450);
            this.pnlForm.TabIndex = 11;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlItems);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnlItems.ResumeLayout(false);
            this.pnlItems.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBuyProduct;
        private System.Windows.Forms.Button btnStockTake;
        private System.Windows.Forms.Button btnDiscard;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Label lblScroll;
        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Panel pnlForm;
    }
}