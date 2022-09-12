
namespace POS_Group5_CMPG223
{
    partial class FrmSales
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
            this.pnlBill = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalAmnt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbxBill = new System.Windows.Forms.ListBox();
            this.pnlBillButtons = new System.Windows.Forms.Panel();
            this.btnConfirmBill = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlBill.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlBillButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.pnlTotal);
            this.pnlBill.Controls.Add(this.lbxBill);
            this.pnlBill.Controls.Add(this.pnlBillButtons);
            this.pnlBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBill.Location = new System.Drawing.Point(1100, 0);
            this.pnlBill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(500, 865);
            this.pnlBill.TabIndex = 0;
            // 
            // pnlTotal
            // 
            this.pnlTotal.Controls.Add(this.lblTotalAmnt);
            this.pnlTotal.Controls.Add(this.lblTotal);
            this.pnlTotal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlTotal.Location = new System.Drawing.Point(0, 635);
            this.pnlTotal.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlTotal.Name = "pnlTotal";
            this.pnlTotal.Size = new System.Drawing.Size(500, 38);
            this.pnlTotal.TabIndex = 2;
            // 
            // lblTotalAmnt
            // 
            this.lblTotalAmnt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalAmnt.Location = new System.Drawing.Point(70, 0);
            this.lblTotalAmnt.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalAmnt.Name = "lblTotalAmnt";
            this.lblTotalAmnt.Size = new System.Drawing.Size(430, 38);
            this.lblTotalAmnt.TabIndex = 1;
            this.lblTotalAmnt.Text = "R00.00";
            this.lblTotalAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 38);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxBill
            // 
            this.lbxBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxBill.FormattingEnabled = true;
            this.lbxBill.ItemHeight = 25;
            this.lbxBill.Location = new System.Drawing.Point(0, 0);
            this.lbxBill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.lbxBill.Name = "lbxBill";
            this.lbxBill.Size = new System.Drawing.Size(500, 673);
            this.lbxBill.TabIndex = 1;
            // 
            // pnlBillButtons
            // 
            this.pnlBillButtons.Controls.Add(this.btnConfirmBill);
            this.pnlBillButtons.Controls.Add(this.btnDeleteItem);
            this.pnlBillButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBillButtons.Location = new System.Drawing.Point(0, 673);
            this.pnlBillButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlBillButtons.Name = "pnlBillButtons";
            this.pnlBillButtons.Size = new System.Drawing.Size(500, 192);
            this.pnlBillButtons.TabIndex = 0;
            // 
            // btnConfirmBill
            // 
            this.btnConfirmBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfirmBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmBill.Location = new System.Drawing.Point(0, 96);
            this.btnConfirmBill.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConfirmBill.Name = "btnConfirmBill";
            this.btnConfirmBill.Size = new System.Drawing.Size(500, 96);
            this.btnConfirmBill.TabIndex = 2;
            this.btnConfirmBill.Text = "Confirm Bill";
            this.btnConfirmBill.UseVisualStyleBackColor = true;
            this.btnConfirmBill.Click += new System.EventHandler(this.btnConfirmBill_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteItem.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(500, 96);
            this.btnDeleteItem.TabIndex = 1;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoScroll = true;
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(1100, 865);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.SizeChanged += new System.EventHandler(this.pnlButtons_SizeChanged);
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 865);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlBill);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FrmSales";
            this.Text = "FrmSales";
            this.pnlBill.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlBillButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Panel pnlBillButtons;
        private System.Windows.Forms.ListBox lbxBill;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnConfirmBill;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalAmnt;
        private System.Windows.Forms.Label lblTotal;
    }
}