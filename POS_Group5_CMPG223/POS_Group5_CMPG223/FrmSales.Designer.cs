
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
            this.pnlBillButtons = new System.Windows.Forms.Panel();
            this.lbxBill = new System.Windows.Forms.ListBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.pnlDiscount = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnDiscItem = new System.Windows.Forms.Button();
            this.btnDiscBill = new System.Windows.Forms.Button();
            this.pnlBill.SuspendLayout();
            this.pnlBillButtons.SuspendLayout();
            this.pnlDiscount.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBill
            // 
            this.pnlBill.Controls.Add(this.lbxBill);
            this.pnlBill.Controls.Add(this.pnlBillButtons);
            this.pnlBill.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBill.Location = new System.Drawing.Point(550, 0);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(250, 450);
            this.pnlBill.TabIndex = 0;
            // 
            // pnlBillButtons
            // 
            this.pnlBillButtons.Controls.Add(this.btnPay);
            this.pnlBillButtons.Controls.Add(this.btnDelete);
            this.pnlBillButtons.Controls.Add(this.pnlDiscount);
            this.pnlBillButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBillButtons.Location = new System.Drawing.Point(0, 350);
            this.pnlBillButtons.Name = "pnlBillButtons";
            this.pnlBillButtons.Size = new System.Drawing.Size(250, 100);
            this.pnlBillButtons.TabIndex = 0;
            // 
            // lbxBill
            // 
            this.lbxBill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxBill.FormattingEnabled = true;
            this.lbxBill.Location = new System.Drawing.Point(0, 0);
            this.lbxBill.Name = "lbxBill";
            this.lbxBill.Size = new System.Drawing.Size(250, 350);
            this.lbxBill.TabIndex = 1;
            // 
            // pnlButtons
            // 
            this.pnlButtons.AutoScroll = true;
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlButtons.Location = new System.Drawing.Point(0, 0);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(550, 450);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.SizeChanged += new System.EventHandler(this.pnlButtons_SizeChanged);
            // 
            // pnlDiscount
            // 
            this.pnlDiscount.Controls.Add(this.btnDiscBill);
            this.pnlDiscount.Controls.Add(this.btnDiscItem);
            this.pnlDiscount.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDiscount.Location = new System.Drawing.Point(125, 0);
            this.pnlDiscount.Name = "pnlDiscount";
            this.pnlDiscount.Size = new System.Drawing.Size(125, 100);
            this.pnlDiscount.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 0);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 50);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Location = new System.Drawing.Point(0, 50);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(125, 50);
            this.btnPay.TabIndex = 2;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // btnDiscItem
            // 
            this.btnDiscItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscItem.Location = new System.Drawing.Point(0, 0);
            this.btnDiscItem.Name = "btnDiscItem";
            this.btnDiscItem.Size = new System.Drawing.Size(125, 50);
            this.btnDiscItem.TabIndex = 2;
            this.btnDiscItem.Text = "Discount Item";
            this.btnDiscItem.UseVisualStyleBackColor = true;
            // 
            // btnDiscBill
            // 
            this.btnDiscBill.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDiscBill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscBill.Location = new System.Drawing.Point(0, 50);
            this.btnDiscBill.Name = "btnDiscBill";
            this.btnDiscBill.Size = new System.Drawing.Size(125, 50);
            this.btnDiscBill.TabIndex = 3;
            this.btnDiscBill.Text = "Discount Bill";
            this.btnDiscBill.UseVisualStyleBackColor = true;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlBill);
            this.Name = "FrmSales";
            this.Text = "FrmSales";
            this.pnlBill.ResumeLayout(false);
            this.pnlBillButtons.ResumeLayout(false);
            this.pnlDiscount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Panel pnlBillButtons;
        private System.Windows.Forms.ListBox lbxBill;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel pnlDiscount;
        private System.Windows.Forms.Button btnDiscBill;
        private System.Windows.Forms.Button btnDiscItem;
    }
}