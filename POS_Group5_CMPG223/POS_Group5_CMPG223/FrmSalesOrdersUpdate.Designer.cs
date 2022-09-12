
namespace POS_Group5_CMPG223
{
    partial class FrmSalesOrdersUpdate
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
            this.pnlSalesOrder = new System.Windows.Forms.Panel();
            this.btnUpdateBill = new System.Windows.Forms.Button();
            this.pnlDate = new System.Windows.Forms.Panel();
            this.dtpSaleDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.pnlItems = new System.Windows.Forms.Panel();
            this.lbxItems = new System.Windows.Forms.ListBox();
            this.pnlItemsEdit = new System.Windows.Forms.Panel();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.pnlItemUpdate = new System.Windows.Forms.Panel();
            this.txtUpdateItem = new System.Windows.Forms.TextBox();
            this.btnUpdateItem = new System.Windows.Forms.Button();
            this.pnlSalesOrder.SuspendLayout();
            this.pnlDate.SuspendLayout();
            this.pnlItems.SuspendLayout();
            this.pnlItemsEdit.SuspendLayout();
            this.pnlItemUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlSalesOrder
            // 
            this.pnlSalesOrder.Controls.Add(this.btnUpdateBill);
            this.pnlSalesOrder.Controls.Add(this.pnlDate);
            this.pnlSalesOrder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlSalesOrder.Location = new System.Drawing.Point(0, 811);
            this.pnlSalesOrder.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlSalesOrder.Name = "pnlSalesOrder";
            this.pnlSalesOrder.Size = new System.Drawing.Size(568, 135);
            this.pnlSalesOrder.TabIndex = 0;
            // 
            // btnUpdateBill
            // 
            this.btnUpdateBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdateBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateBill.Location = new System.Drawing.Point(0, 38);
            this.btnUpdateBill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateBill.Name = "btnUpdateBill";
            this.btnUpdateBill.Size = new System.Drawing.Size(568, 96);
            this.btnUpdateBill.TabIndex = 6;
            this.btnUpdateBill.Text = "Update Bill";
            this.btnUpdateBill.UseVisualStyleBackColor = true;
            // 
            // pnlDate
            // 
            this.pnlDate.Controls.Add(this.dtpSaleDate);
            this.pnlDate.Controls.Add(this.lblDate);
            this.pnlDate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDate.Location = new System.Drawing.Point(0, 0);
            this.pnlDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlDate.Name = "pnlDate";
            this.pnlDate.Size = new System.Drawing.Size(568, 38);
            this.pnlDate.TabIndex = 0;
            // 
            // dtpSaleDate
            // 
            this.dtpSaleDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtpSaleDate.Location = new System.Drawing.Point(100, 0);
            this.dtpSaleDate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtpSaleDate.Name = "dtpSaleDate";
            this.dtpSaleDate.Size = new System.Drawing.Size(468, 31);
            this.dtpSaleDate.TabIndex = 1;
            // 
            // lblDate
            // 
            this.lblDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDate.Location = new System.Drawing.Point(0, 0);
            this.lblDate.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(100, 38);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date:";
            this.lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlItems
            // 
            this.pnlItems.Controls.Add(this.lbxItems);
            this.pnlItems.Controls.Add(this.pnlItemsEdit);
            this.pnlItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlItems.Location = new System.Drawing.Point(0, 0);
            this.pnlItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlItems.Name = "pnlItems";
            this.pnlItems.Size = new System.Drawing.Size(568, 811);
            this.pnlItems.TabIndex = 1;
            // 
            // lbxItems
            // 
            this.lbxItems.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxItems.FormattingEnabled = true;
            this.lbxItems.ItemHeight = 25;
            this.lbxItems.Location = new System.Drawing.Point(0, 0);
            this.lbxItems.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbxItems.Name = "lbxItems";
            this.lbxItems.Size = new System.Drawing.Size(568, 619);
            this.lbxItems.TabIndex = 1;
            // 
            // pnlItemsEdit
            // 
            this.pnlItemsEdit.Controls.Add(this.btnDeleteItem);
            this.pnlItemsEdit.Controls.Add(this.pnlItemUpdate);
            this.pnlItemsEdit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlItemsEdit.Location = new System.Drawing.Point(0, 619);
            this.pnlItemsEdit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlItemsEdit.Name = "pnlItemsEdit";
            this.pnlItemsEdit.Size = new System.Drawing.Size(568, 192);
            this.pnlItemsEdit.TabIndex = 0;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Location = new System.Drawing.Point(0, 96);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(568, 96);
            this.btnDeleteItem.TabIndex = 5;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // pnlItemUpdate
            // 
            this.pnlItemUpdate.Controls.Add(this.txtUpdateItem);
            this.pnlItemUpdate.Controls.Add(this.btnUpdateItem);
            this.pnlItemUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlItemUpdate.Location = new System.Drawing.Point(0, 0);
            this.pnlItemUpdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlItemUpdate.Name = "pnlItemUpdate";
            this.pnlItemUpdate.Size = new System.Drawing.Size(568, 96);
            this.pnlItemUpdate.TabIndex = 0;
            // 
            // txtUpdateItem
            // 
            this.txtUpdateItem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUpdateItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUpdateItem.Location = new System.Drawing.Point(0, 0);
            this.txtUpdateItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtUpdateItem.Name = "txtUpdateItem";
            this.txtUpdateItem.Size = new System.Drawing.Size(284, 92);
            this.txtUpdateItem.TabIndex = 6;
            this.txtUpdateItem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpdateItem
            // 
            this.btnUpdateItem.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnUpdateItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateItem.Location = new System.Drawing.Point(284, 0);
            this.btnUpdateItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnUpdateItem.Name = "btnUpdateItem";
            this.btnUpdateItem.Size = new System.Drawing.Size(284, 96);
            this.btnUpdateItem.TabIndex = 5;
            this.btnUpdateItem.Text = "Update Item";
            this.btnUpdateItem.UseVisualStyleBackColor = true;
            // 
            // FrmSalesOrdersUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 946);
            this.Controls.Add(this.pnlItems);
            this.Controls.Add(this.pnlSalesOrder);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmSalesOrdersUpdate";
            this.Text = "FrmSalesOrdersMaintain";
            this.pnlSalesOrder.ResumeLayout(false);
            this.pnlDate.ResumeLayout(false);
            this.pnlItems.ResumeLayout(false);
            this.pnlItemsEdit.ResumeLayout(false);
            this.pnlItemUpdate.ResumeLayout(false);
            this.pnlItemUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSalesOrder;
        private System.Windows.Forms.Panel pnlItems;
        private System.Windows.Forms.Panel pnlItemsEdit;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Panel pnlItemUpdate;
        private System.Windows.Forms.TextBox txtUpdateItem;
        private System.Windows.Forms.Button btnUpdateItem;
        private System.Windows.Forms.Button btnUpdateBill;
        private System.Windows.Forms.Panel pnlDate;
        private System.Windows.Forms.DateTimePicker dtpSaleDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ListBox lbxItems;
    }
}