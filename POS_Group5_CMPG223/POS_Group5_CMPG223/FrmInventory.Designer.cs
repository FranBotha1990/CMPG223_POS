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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(1158, 726);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBuyProduct
            // 
            this.btnBuyProduct.Location = new System.Drawing.Point(1234, 456);
            this.btnBuyProduct.Name = "btnBuyProduct";
            this.btnBuyProduct.Size = new System.Drawing.Size(219, 79);
            this.btnBuyProduct.TabIndex = 1;
            this.btnBuyProduct.Text = "Buy Product";
            this.btnBuyProduct.UseVisualStyleBackColor = true;
            // 
            // btnStockTake
            // 
            this.btnStockTake.Location = new System.Drawing.Point(1234, 557);
            this.btnStockTake.Name = "btnStockTake";
            this.btnStockTake.Size = new System.Drawing.Size(219, 79);
            this.btnStockTake.TabIndex = 2;
            this.btnStockTake.Text = "Stock Take";
            this.btnStockTake.UseVisualStyleBackColor = true;
            // 
            // btnDiscard
            // 
            this.btnDiscard.Location = new System.Drawing.Point(1234, 659);
            this.btnDiscard.Name = "btnDiscard";
            this.btnDiscard.Size = new System.Drawing.Size(219, 79);
            this.btnDiscard.TabIndex = 3;
            this.btnDiscard.Text = "Discard Stock";
            this.btnDiscard.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(1234, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(219, 31);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(1229, 28);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(216, 25);
            this.lblSearch.TabIndex = 5;
            this.lblSearch.Text = "Search As You Type:";
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(1234, 216);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(219, 34);
            this.hScrollBar.TabIndex = 6;
            // 
            // lblScroll
            // 
            this.lblScroll.AutoSize = true;
            this.lblScroll.Location = new System.Drawing.Point(1234, 136);
            this.lblScroll.Name = "lblScroll";
            this.lblScroll.Size = new System.Drawing.Size(173, 25);
            this.lblScroll.TabIndex = 7;
            this.lblScroll.Text = "Search by value:";
            // 
            // lblDisplay
            // 
            this.lblDisplay.AutoSize = true;
            this.lblDisplay.Location = new System.Drawing.Point(1239, 188);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(95, 25);
            this.lblDisplay.TabIndex = 8;
            this.lblDisplay.Text = "[Display]";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1234, 355);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(219, 79);
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "Add New Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // FrmInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 768);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.lblDisplay);
            this.Controls.Add(this.lblScroll);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnDiscard);
            this.Controls.Add(this.btnStockTake);
            this.Controls.Add(this.btnBuyProduct);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FrmInventory";
            this.Text = "FrmInventory";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}