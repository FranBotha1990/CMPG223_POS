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
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelDataGridViewSummarizedReports = new System.Windows.Forms.Panel();
            this.lblSummary = new System.Windows.Forms.Label();
            this.dataGridViewSummarizedReport = new System.Windows.Forms.DataGridView();
            this.gbxReportOptions = new System.Windows.Forms.GroupBox();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.pnlReportOptions = new System.Windows.Forms.Panel();
            this.lblWhichReport = new System.Windows.Forms.Label();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.labelDateRange = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.panelDataGridViewSummarizedReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummarizedReport)).BeginInit();
            this.gbxReportOptions.SuspendLayout();
            this.pnlReportOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToAddRows = false;
            this.dataGridViewReports.AllowUserToDeleteRows = false;
            this.dataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReports.Location = new System.Drawing.Point(262, 65);
            this.dataGridViewReports.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersVisible = false;
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.RowTemplate.Height = 24;
            this.dataGridViewReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReports.Size = new System.Drawing.Size(680, 311);
            this.dataGridViewReports.TabIndex = 15;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(262, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.MaximumSize = new System.Drawing.Size(0, 65);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(0, 65);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(680, 65);
            this.pnlHeader.TabIndex = 12;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(4);
            this.lblHeader.MinimumSize = new System.Drawing.Size(38, 41);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(8);
            this.lblHeader.Size = new System.Drawing.Size(128, 53);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Report";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelDataGridViewSummarizedReports
            // 
            this.panelDataGridViewSummarizedReports.Controls.Add(this.lblSummary);
            this.panelDataGridViewSummarizedReports.Controls.Add(this.dataGridViewSummarizedReport);
            this.panelDataGridViewSummarizedReports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGridViewSummarizedReports.Location = new System.Drawing.Point(262, 376);
            this.panelDataGridViewSummarizedReports.Margin = new System.Windows.Forms.Padding(2);
            this.panelDataGridViewSummarizedReports.MaximumSize = new System.Drawing.Size(0, 81);
            this.panelDataGridViewSummarizedReports.MinimumSize = new System.Drawing.Size(0, 81);
            this.panelDataGridViewSummarizedReports.Name = "panelDataGridViewSummarizedReports";
            this.panelDataGridViewSummarizedReports.Size = new System.Drawing.Size(680, 81);
            this.panelDataGridViewSummarizedReports.TabIndex = 13;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(10, 11);
            this.lblSummary.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(199, 29);
            this.lblSummary.TabIndex = 12;
            this.lblSummary.Text = "Report Summary:";
            // 
            // dataGridViewSummarizedReport
            // 
            this.dataGridViewSummarizedReport.AllowUserToAddRows = false;
            this.dataGridViewSummarizedReport.AllowUserToDeleteRows = false;
            this.dataGridViewSummarizedReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSummarizedReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSummarizedReport.Location = new System.Drawing.Point(244, 2);
            this.dataGridViewSummarizedReport.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewSummarizedReport.Name = "dataGridViewSummarizedReport";
            this.dataGridViewSummarizedReport.ReadOnly = true;
            this.dataGridViewSummarizedReport.RowHeadersVisible = false;
            this.dataGridViewSummarizedReport.RowHeadersWidth = 51;
            this.dataGridViewSummarizedReport.RowTemplate.Height = 24;
            this.dataGridViewSummarizedReport.Size = new System.Drawing.Size(308, 76);
            this.dataGridViewSummarizedReport.TabIndex = 13;
            // 
            // gbxReportOptions
            // 
            this.gbxReportOptions.Controls.Add(this.buttonGenerateReport);
            this.gbxReportOptions.Controls.Add(this.pnlReportOptions);
            this.gbxReportOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxReportOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.gbxReportOptions.Location = new System.Drawing.Point(0, 0);
            this.gbxReportOptions.Margin = new System.Windows.Forms.Padding(2);
            this.gbxReportOptions.MaximumSize = new System.Drawing.Size(262, 0);
            this.gbxReportOptions.MinimumSize = new System.Drawing.Size(262, 0);
            this.gbxReportOptions.Name = "gbxReportOptions";
            this.gbxReportOptions.Padding = new System.Windows.Forms.Padding(2);
            this.gbxReportOptions.Size = new System.Drawing.Size(262, 457);
            this.gbxReportOptions.TabIndex = 14;
            this.gbxReportOptions.TabStop = false;
            this.gbxReportOptions.Text = "Report Options";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.buttonGenerateReport.Location = new System.Drawing.Point(2, 233);
            this.buttonGenerateReport.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(258, 64);
            this.buttonGenerateReport.TabIndex = 10;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
            this.buttonGenerateReport.Click += new System.EventHandler(this.buttonGenerateReport_Click);
            // 
            // pnlReportOptions
            // 
            this.pnlReportOptions.Controls.Add(this.lblWhichReport);
            this.pnlReportOptions.Controls.Add(this.dateTimePickerStartDate);
            this.pnlReportOptions.Controls.Add(this.comboBoxReports);
            this.pnlReportOptions.Controls.Add(this.labelEndDate);
            this.pnlReportOptions.Controls.Add(this.labelDateRange);
            this.pnlReportOptions.Controls.Add(this.labelStartDate);
            this.pnlReportOptions.Controls.Add(this.dateTimePickerEndDate);
            this.pnlReportOptions.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlReportOptions.Location = new System.Drawing.Point(2, 15);
            this.pnlReportOptions.Margin = new System.Windows.Forms.Padding(2);
            this.pnlReportOptions.Name = "pnlReportOptions";
            this.pnlReportOptions.Size = new System.Drawing.Size(258, 218);
            this.pnlReportOptions.TabIndex = 14;
            // 
            // lblWhichReport
            // 
            this.lblWhichReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.lblWhichReport.Location = new System.Drawing.Point(4, 17);
            this.lblWhichReport.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblWhichReport.Name = "lblWhichReport";
            this.lblWhichReport.Size = new System.Drawing.Size(214, 20);
            this.lblWhichReport.TabIndex = 3;
            this.lblWhichReport.Text = "Which report do you want to generate?";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(7, 123);
            this.dateTimePickerStartDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerStartDate.TabIndex = 7;
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
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
            this.comboBoxReports.Location = new System.Drawing.Point(7, 40);
            this.comboBoxReports.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(147, 21);
            this.comboBoxReports.TabIndex = 4;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelEndDate.Location = new System.Drawing.Point(4, 151);
            this.labelEndDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(26, 13);
            this.labelEndDate.TabIndex = 8;
            this.labelEndDate.Text = "End";
            // 
            // labelDateRange
            // 
            this.labelDateRange.AutoSize = true;
            this.labelDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelDateRange.Location = new System.Drawing.Point(4, 78);
            this.labelDateRange.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDateRange.Name = "labelDateRange";
            this.labelDateRange.Size = new System.Drawing.Size(118, 13);
            this.labelDateRange.TabIndex = 5;
            this.labelDateRange.Text = "Date Range for Report:";
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.labelStartDate.Location = new System.Drawing.Point(4, 99);
            this.labelStartDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(29, 13);
            this.labelStartDate.TabIndex = 6;
            this.labelStartDate.Text = "Start";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(7, 175);
            this.dateTimePickerEndDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(212, 20);
            this.dateTimePickerEndDate.TabIndex = 9;
            // 
            // FrmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 457);
            this.Controls.Add(this.dataGridViewReports);
            this.Controls.Add(this.pnlHeader);
            this.Controls.Add(this.panelDataGridViewSummarizedReports);
            this.Controls.Add(this.gbxReportOptions);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmReporting";
            this.Text = "FrmReporting";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.panelDataGridViewSummarizedReports.ResumeLayout(false);
            this.panelDataGridViewSummarizedReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummarizedReport)).EndInit();
            this.gbxReportOptions.ResumeLayout(false);
            this.pnlReportOptions.ResumeLayout(false);
            this.pnlReportOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelDataGridViewSummarizedReports;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.DataGridView dataGridViewSummarizedReport;
        private System.Windows.Forms.GroupBox gbxReportOptions;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Panel pnlReportOptions;
        private System.Windows.Forms.Label lblWhichReport;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelDateRange;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
    }
}