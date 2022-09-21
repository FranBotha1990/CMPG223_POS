
namespace POS_Group5_CMPG223
{
    partial class FrmPurchaseOrders
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
            this.pnlForm = new System.Windows.Forms.Panel();
            this.dgvPurchaseOrders = new System.Windows.Forms.DataGridView();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalAmnt = new System.Windows.Forms.Label();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnReceive = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).BeginInit();
            this.pnlItems.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.Controls.Add(this.dgvPurchaseOrders);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(550, 450);
            this.pnlForm.TabIndex = 3;
            // 
            // dgvPurchaseOrders
            // 
            this.dgvPurchaseOrders.AllowUserToAddRows = false;
            this.dgvPurchaseOrders.AllowUserToDeleteRows = false;
            this.dgvPurchaseOrders.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPurchaseOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseOrders.Location = new System.Drawing.Point(10, 10);
            this.dgvPurchaseOrders.MultiSelect = false;
            this.dgvPurchaseOrders.Name = "dgvPurchaseOrders";
            this.dgvPurchaseOrders.ReadOnly = true;
            this.dgvPurchaseOrders.RowHeadersVisible = false;
            this.dgvPurchaseOrders.RowHeadersWidth = 51;
            this.dgvPurchaseOrders.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPurchaseOrders.Size = new System.Drawing.Size(530, 430);
            this.dgvPurchaseOrders.TabIndex = 0;
            this.dgvPurchaseOrders.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseOrders_CellClick);
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
            this.pnlItems.TabIndex = 2;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Controls.Add(this.lblTotalAmnt);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 280);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(250, 20);
            this.pnlTotal.TabIndex = 2;
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
            // lblTotalAmnt
            // 
            this.lblTotalAmnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmnt.Location = new System.Drawing.Point(0, 0);
            this.lblTotalAmnt.Name = "lblTotalAmnt";
            this.lblTotalAmnt.Size = new System.Drawing.Size(250, 20);
            this.lblTotalAmnt.TabIndex = 3;
            this.lblTotalAmnt.Text = "R 0";
            this.lblTotalAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbxItems
            // 
            this.lbxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.Location = new System.Drawing.Point(0, 0);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(250, 300);
            this.lbxItems.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnReceive);
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnRemove);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 300);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(250, 150);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnReceive
            // 
            this.btnReceive.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnReceive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceive.Location = new System.Drawing.Point(0, 100);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(250, 50);
            this.btnReceive.TabIndex = 4;
            this.btnReceive.Text = "Receive Order";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
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
            // btnRemove
            // 
            this.btnRemove.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemove.Location = new System.Drawing.Point(0, 0);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(250, 50);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove Item";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // FrmPurchaseOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlItems);
            this.Name = "FrmPurchaseOrders";
            this.Text = "FrmPurchaseOrders";
            this.pnlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseOrders)).EndInit();
            this.pnlItems.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.DataGridView dgvPurchaseOrders;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalAmnt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbxItems;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnReceive;
    }
}