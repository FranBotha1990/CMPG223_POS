
namespace POS_Group5_CMPG223
{
    partial class FrmSalesOrders
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
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalAmnt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pnlForm = new System.Windows.Forms.Panel();
            this.dgvSalesOrders = new System.Windows.Forms.DataGridView();
            this.pnlItems.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.pnlTotal);
            this.pnlItems.Controls.Add(this.lbxItems);
            this.pnlItems.Controls.Add(this.pnlButtons);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlItems.Location = new System.Drawing.Point(550, 0);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(250, 450);
            this.pnlItems.TabIndex = 0;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotalAmnt);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 330);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(250, 20);
            this.pnlTotal.TabIndex = 2;
            // 
            // lblTotalAmnt
            // 
            this.lblTotalAmnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmnt.Location = new System.Drawing.Point(35, 0);
            this.lblTotalAmnt.Name = "lblTotalAmnt";
            this.lblTotalAmnt.Size = new System.Drawing.Size(215, 20);
            this.lblTotalAmnt.TabIndex = 3;
            this.lblTotalAmnt.Text = "R 0";
            this.lblTotalAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 20);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxItems
            // 
            this.lbxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(0, 0);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(250, 350);
            this.lbxItems.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 350);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(250, 100);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 50);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(250, 50);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete Order";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(250, 50);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Remove Item";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.dgvSalesOrders);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(550, 450);
            this.pnlForm.TabIndex = 1;
            // 
            // dgvSalesOrders
            // 
            this.dgvSalesOrders.AllowUserToAddRows = false;
            this.dgvSalesOrders.AllowUserToDeleteRows = false;
            this.dgvSalesOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSalesOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesOrders.Location = new System.Drawing.Point(10, 10);
            this.dgvSalesOrders.MultiSelect = false;
            this.dgvSalesOrders.Name = "dgvSalesOrders";
            this.dgvSalesOrders.ReadOnly = true;
            this.dgvSalesOrders.RowHeadersVisible = false;
            this.dgvSalesOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalesOrders.Size = new System.Drawing.Size(530, 430);
            this.dgvSalesOrders.TabIndex = 0;
            this.dgvSalesOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesOrders_CellClick);
            // 
            // FrmSalesOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlItems);
            this.Name = "FrmSalesOrders";
            this.Text = "FrmSalesOrders";
            this.pnlItems.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.DataGridView dgvSalesOrders;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalAmnt;
        private System.Windows.Forms.Label lblTotal;
    }
}