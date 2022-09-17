namespace POS_Group5_CMPG223
{
    partial class FrmReporting
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
            this.tabPageDataGridView = new System.Windows.Forms.TabPage();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.tabPageDataSelection = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateRange = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.labelListBox = new System.Windows.Forms.Label();
            this.listBoxReports = new System.Windows.Forms.ListBox();
            this.tabControlReporting = new System.Windows.Forms.TabControl();
            this.tabPageDataGridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.tabPageDataSelection.SuspendLayout();
            this.tabControlReporting.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDataGridView
            // 
            this.tabPageDataGridView.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageDataGridView.Controls.Add(this.dataGridViewReports);
            this.tabPageDataGridView.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataGridView.Name = "tabPageDataGridView";
            this.tabPageDataGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataGridView.Size = new System.Drawing.Size(1098, 675);
            this.tabPageDataGridView.TabIndex = 1;
            this.tabPageDataGridView.Text = "Grid View";
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReports.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.RowTemplate.Height = 24;
            this.dataGridViewReports.Size = new System.Drawing.Size(1092, 669);
            this.dataGridViewReports.TabIndex = 0;
            // 
            // tabPageDataSelection
            // 
            this.tabPageDataSelection.Controls.Add(this.listBoxReports);
            this.tabPageDataSelection.Controls.Add(this.labelListBox);
            this.tabPageDataSelection.Controls.Add(this.dateTimePickerEndDate);
            this.tabPageDataSelection.Controls.Add(this.labelEndDate);
            this.tabPageDataSelection.Controls.Add(this.labelStartDate);
            this.tabPageDataSelection.Controls.Add(this.labelDateRange);
            this.tabPageDataSelection.Controls.Add(this.dateTimePickerStartDate);
            this.tabPageDataSelection.Controls.Add(this.comboBoxReports);
            this.tabPageDataSelection.Controls.Add(this.buttonGenerateReport);
            this.tabPageDataSelection.Controls.Add(this.label1);
            this.tabPageDataSelection.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataSelection.Name = "tabPageDataSelection";
            this.tabPageDataSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataSelection.Size = new System.Drawing.Size(1098, 675);
            this.tabPageDataSelection.TabIndex = 0;
            this.tabPageDataSelection.Text = "Data Selection";
            this.tabPageDataSelection.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wich report do you want to generate?";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Location = new System.Drawing.Point(22, 212);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(224, 33);
            this.buttonGenerateReport.TabIndex = 1;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.FormattingEnabled = true;
            this.comboBoxReports.Items.AddRange(new object[] {
            "Sales",
            "Purchases",
            "Stock on Hand",
            "All Sales",
            "All Purchases",
            "Day End Report",
            "Weekly Report",
            "Monthly Report"});
            this.comboBoxReports.Location = new System.Drawing.Point(252, 10);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(183, 24);
            this.comboBoxReports.TabIndex = 5;
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(252, 78);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(322, 22);
            this.dateTimePickerStartDate.TabIndex = 6;
            // 
            // labelDateRange
            // 
            this.labelDateRange.AutoSize = true;
            this.labelDateRange.Location = new System.Drawing.Point(19, 59);
            this.labelDateRange.Name = "labelDateRange";
            this.labelDateRange.Size = new System.Drawing.Size(145, 16);
            this.labelDateRange.TabIndex = 7;
            this.labelDateRange.Text = "Date Range for Report:";
            this.labelDateRange.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Location = new System.Drawing.Point(249, 59);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(34, 16);
            this.labelStartDate.TabIndex = 8;
            this.labelStartDate.Text = "Start";
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Location = new System.Drawing.Point(249, 114);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(31, 16);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "End";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(252, 133);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(322, 22);
            this.dateTimePickerEndDate.TabIndex = 10;
            // 
            // labelListBox
            // 
            this.labelListBox.AutoSize = true;
            this.labelListBox.Location = new System.Drawing.Point(611, 34);
            this.labelListBox.Name = "labelListBox";
            this.labelListBox.Size = new System.Drawing.Size(89, 16);
            this.labelListBox.TabIndex = 11;
            this.labelListBox.Text = "Report Totals";
            this.labelListBox.Click += new System.EventHandler(this.labelListBox_Click);
            // 
            // listBoxReports
            // 
            this.listBoxReports.FormattingEnabled = true;
            this.listBoxReports.ItemHeight = 16;
            this.listBoxReports.Location = new System.Drawing.Point(614, 53);
            this.listBoxReports.Name = "listBoxReports";
            this.listBoxReports.Size = new System.Drawing.Size(476, 532);
            this.listBoxReports.TabIndex = 12;
            // 
            // tabControlReporting
            // 
            this.tabControlReporting.Controls.Add(this.tabPageDataSelection);
            this.tabControlReporting.Controls.Add(this.tabPageDataGridView);
            this.tabControlReporting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReporting.Location = new System.Drawing.Point(0, 0);
            this.tabControlReporting.Name = "tabControlReporting";
            this.tabControlReporting.SelectedIndex = 0;
            this.tabControlReporting.Size = new System.Drawing.Size(1106, 704);
            this.tabControlReporting.TabIndex = 0;
            // 
            // FrmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 704);
            this.Controls.Add(this.tabControlReporting);
            this.Name = "FrmReporting";
            this.Text = "FrmReporting";
            this.tabPageDataGridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.tabPageDataSelection.ResumeLayout(false);
            this.tabPageDataSelection.PerformLayout();
            this.tabControlReporting.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageDataGridView;
        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.TabPage tabPageDataSelection;
        private System.Windows.Forms.ListBox listBoxReports;
        private System.Windows.Forms.Label labelListBox;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelDateRange;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControlReporting;
    }
}