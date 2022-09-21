
namespace POS_Group5_CMPG223
{
    partial class FrmSuppliers
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
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.gbxFilter = new System.Windows.Forms.GroupBox();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilterEmail = new System.Windows.Forms.TextBox();
            this.txtFilterCell = new System.Windows.Forms.TextBox();
            this.lblFilterEmail = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.lblFilterCell = new System.Windows.Forms.Label();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.pnlSidebar.SuspendLayout();
            this.gbxFilter.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlForm
            // 
            this.pnlForm.AutoScroll = true;
            this.pnlForm.Controls.Add(this.dgvSuppliers);
            this.pnlForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlForm.Location = new System.Drawing.Point(0, 0);
            this.pnlForm.Name = "pnlForm";
            this.pnlForm.Padding = new System.Windows.Forms.Padding(10);
            this.pnlForm.Size = new System.Drawing.Size(550, 450);
            this.pnlForm.TabIndex = 2;
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuppliers.Location = new System.Drawing.Point(10, 10);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.RowHeadersVisible = false;
            this.dgvSuppliers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSuppliers.Size = new System.Drawing.Size(530, 430);
            this.dgvSuppliers.TabIndex = 0;
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.Controls.Add(this.gbxFilter);
            this.pnlSidebar.Controls.Add(this.pnlButtons);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlSidebar.Location = new System.Drawing.Point(550, 0);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(250, 450);
            this.pnlSidebar.TabIndex = 0;
            // 
            // gbxFilter
            // 
            this.gbxFilter.Controls.Add(this.lblFilter);
            this.gbxFilter.Controls.Add(this.txtFilterEmail);
            this.gbxFilter.Controls.Add(this.txtFilterCell);
            this.gbxFilter.Controls.Add(this.lblFilterEmail);
            this.gbxFilter.Controls.Add(this.txtFilter);
            this.gbxFilter.Controls.Add(this.lblFilterCell);
            this.gbxFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbxFilter.Location = new System.Drawing.Point(0, 0);
            this.gbxFilter.Name = "gbxFilter";
            this.gbxFilter.Size = new System.Drawing.Size(250, 118);
            this.gbxFilter.TabIndex = 0;
            this.gbxFilter.TabStop = false;
            this.gbxFilter.Text = "Filter by:";
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(6, 26);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(79, 13);
            this.lblFilter.TabIndex = 1;
            this.lblFilter.Text = "Supplier Name:";
            // 
            // txtFilterEmail
            // 
            this.txtFilterEmail.Location = new System.Drawing.Point(127, 79);
            this.txtFilterEmail.Name = "txtFilterEmail";
            this.txtFilterEmail.Size = new System.Drawing.Size(97, 20);
            this.txtFilterEmail.TabIndex = 6;
            this.txtFilterEmail.TextChanged += new System.EventHandler(this.txtFilterEmail_TextChanged);
            // 
            // txtFilterCell
            // 
            this.txtFilterCell.Location = new System.Drawing.Point(127, 51);
            this.txtFilterCell.Name = "txtFilterCell";
            this.txtFilterCell.Size = new System.Drawing.Size(97, 20);
            this.txtFilterCell.TabIndex = 4;
            this.txtFilterCell.TextChanged += new System.EventHandler(this.txtFilterCell_TextChanged);
            // 
            // lblFilterEmail
            // 
            this.lblFilterEmail.AutoSize = true;
            this.lblFilterEmail.Location = new System.Drawing.Point(6, 82);
            this.lblFilterEmail.Name = "lblFilterEmail";
            this.lblFilterEmail.Size = new System.Drawing.Size(76, 13);
            this.lblFilterEmail.TabIndex = 5;
            this.lblFilterEmail.Text = "Supplier Email:";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(127, 23);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(97, 20);
            this.txtFilter.TabIndex = 2;
            this.txtFilter.TextChanged += new System.EventHandler(this.txtFilter_TextChanged);
            // 
            // lblFilterCell
            // 
            this.lblFilterCell.AutoSize = true;
            this.lblFilterCell.Location = new System.Drawing.Point(6, 54);
            this.lblFilterCell.Name = "lblFilterCell";
            this.lblFilterCell.Size = new System.Drawing.Size(68, 13);
            this.lblFilterCell.TabIndex = 3;
            this.lblFilterCell.Text = "Supplier Cell:";
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnDelete);
            this.pnlButtons.Controls.Add(this.btnUpdate);
            this.pnlButtons.Controls.Add(this.btnAdd);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 300);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(250, 150);
            this.pnlButtons.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Location = new System.Drawing.Point(0, 100);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(250, 50);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Delete Supplier";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Location = new System.Drawing.Point(0, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(250, 50);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update Supplier";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Location = new System.Drawing.Point(0, 0);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(250, 50);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add Supplier";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // FrmSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlForm);
            this.Controls.Add(this.pnlSidebar);
            this.Name = "FrmSuppliers";
            this.Text = "FrmSuppliers";
            this.Load += new System.EventHandler(this.FrmSuppliers_Load);
            this.pnlForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.pnlSidebar.ResumeLayout(false);
            this.gbxFilter.ResumeLayout(false);
            this.gbxFilter.PerformLayout();
            this.pnlButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlForm;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilterEmail;
        private System.Windows.Forms.Label lblFilterEmail;
        private System.Windows.Forms.TextBox txtFilterCell;
        private System.Windows.Forms.Label lblFilterCell;
        private System.Windows.Forms.GroupBox gbxFilter;
    }
}