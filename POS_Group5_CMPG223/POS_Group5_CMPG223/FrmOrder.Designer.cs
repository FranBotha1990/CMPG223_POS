namespace POS_Group5_CMPG223
{
    partial class FrmOrder
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
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.pnlTotal = new System.Windows.Forms.Panel();
            this.lblTotalAmnt = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lbxOrder = new System.Windows.Forms.ListBox();
            this.pnlOrderButtons = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.pnlOrder.SuspendLayout();
            this.pnlTotal.SuspendLayout();
            this.pnlOrderButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(550, 450);
            this.pnlForm.TabIndex = 3;
            this.pnlForm.SizeChanged += new System.EventHandler(this.pnlForm_SizeChanged);
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.pnlTotal);
            this.pnlOrder.Controls.Add(this.lbxOrder);
            this.pnlOrder.Controls.Add(this.pnlOrderButtons);
            this.pnlOrder.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlOrder.Location = new System.Drawing.Point(550, 0);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(250, 450);
            this.pnlOrder.TabIndex = 2;
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
            this.lblTotalAmnt.TabIndex = 1;
            this.lblTotalAmnt.Text = "R 0";
            this.lblTotalAmnt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotal
            // 
            this.lblTotal.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotal.Location = new System.Drawing.Point(0, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(35, 20);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "Total:";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbxOrder
            // 
            this.lbxOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbxOrder.FormattingEnabled = true;
            this.lbxOrder.Location = new System.Drawing.Point(0, 0);
            this.lbxOrder.Name = "lbxOrder";
            this.lbxOrder.Size = new System.Drawing.Size(250, 350);
            this.lbxOrder.TabIndex = 1;
            // 
            // pnlOrderButtons
            // 
            this.pnlOrderButtons.Controls.Add(this.btnPlaceOrder);
            this.pnlOrderButtons.Controls.Add(this.btnDeleteItem);
            this.pnlOrderButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlOrderButtons.Location = new System.Drawing.Point(0, 350);
            this.pnlOrderButtons.Name = "pnlOrderButtons";
            this.pnlOrderButtons.Size = new System.Drawing.Size(250, 100);
            this.pnlOrderButtons.TabIndex = 0;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlaceOrder.Location = new System.Drawing.Point(0, 50);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(250, 50);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDeleteItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteItem.Location = new System.Drawing.Point(0, 0);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(250, 50);
            this.btnDeleteItem.TabIndex = 1;
            this.btnDeleteItem.Text = "Delete Item";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlOrder);
            this.Name = "FrmOrder";
            this.Text = "FrmOrder";
            this.pnlOrder.ResumeLayout(false);
            this.pnlTotal.ResumeLayout(false);
            this.pnlOrderButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.Panel pnlTotal;
        private System.Windows.Forms.Label lblTotalAmnt;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ListBox lbxOrder;
        private System.Windows.Forms.Panel pnlOrderButtons;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnDeleteItem;
    }
}