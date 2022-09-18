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
            this.tabPageDataSelection = new System.Windows.Forms.TabPage();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.dataGridViewReports = new System.Windows.Forms.DataGridView();
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
            this.panelDataGridViewSummarizedReports = new System.Windows.Forms.Panel();
            this.dataGridViewSummarizedReport = new System.Windows.Forms.DataGridView();
            this.lblSummary = new System.Windows.Forms.Label();
            this.tabControlReporting = new System.Windows.Forms.TabControl();
            this.pnlMainReport = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tabPageDataSelection.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).BeginInit();
            this.gbxReportOptions.SuspendLayout();
            this.pnlReportOptions.SuspendLayout();
            this.panelDataGridViewSummarizedReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummarizedReport)).BeginInit();
            this.tabControlReporting.SuspendLayout();
            this.pnlMainReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageDataSelection
            // 
            this.tabPageDataSelection.Controls.Add(this.pnlMainReport);
            this.tabPageDataSelection.Controls.Add(this.gbxReportOptions);
            this.tabPageDataSelection.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataSelection.Name = "tabPageDataSelection";
            this.tabPageDataSelection.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataSelection.Size = new System.Drawing.Size(1097, 675);
            this.tabPageDataSelection.TabIndex = 0;
            this.tabPageDataSelection.Text = "Data Selection";
            this.tabPageDataSelection.UseVisualStyleBackColor = true;
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.MaximumSize = new System.Drawing.Size(0, 80);
            this.pnlHeader.MinimumSize = new System.Drawing.Size(0, 80);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(741, 80);
            this.pnlHeader.TabIndex = 0;
            // 
            // dataGridViewReports
            // 
            this.dataGridViewReports.AllowUserToAddRows = false;
            this.dataGridViewReports.AllowUserToDeleteRows = false;
            this.dataGridViewReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewReports.Location = new System.Drawing.Point(0, 80);
            this.dataGridViewReports.Name = "dataGridViewReports";
            this.dataGridViewReports.RowHeadersWidth = 51;
            this.dataGridViewReports.RowTemplate.Height = 24;
            this.dataGridViewReports.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewReports.Size = new System.Drawing.Size(741, 489);
            this.dataGridViewReports.TabIndex = 11;
            // 
            // gbxReportOptions
            // 
            this.gbxReportOptions.Controls.Add(this.buttonGenerateReport);
            this.gbxReportOptions.Controls.Add(this.pnlReportOptions);
            this.gbxReportOptions.Dock = System.Windows.Forms.DockStyle.Left;
            this.gbxReportOptions.Location = new System.Drawing.Point(3, 3);
            this.gbxReportOptions.MaximumSize = new System.Drawing.Size(350, 0);
            this.gbxReportOptions.MinimumSize = new System.Drawing.Size(350, 0);
            this.gbxReportOptions.Name = "gbxReportOptions";
            this.gbxReportOptions.Size = new System.Drawing.Size(350, 669);
            this.gbxReportOptions.TabIndex = 2;
            this.gbxReportOptions.TabStop = false;
            this.gbxReportOptions.Text = "Report Options";
            // 
            // buttonGenerateReport
            // 
            this.buttonGenerateReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonGenerateReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateReport.Location = new System.Drawing.Point(3, 286);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(344, 79);
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
            this.pnlReportOptions.Location = new System.Drawing.Point(3, 18);
            this.pnlReportOptions.Name = "pnlReportOptions";
            this.pnlReportOptions.Size = new System.Drawing.Size(344, 268);
            this.pnlReportOptions.TabIndex = 14;
            // 
            // lblWhichReport
            // 
            this.lblWhichReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWhichReport.Location = new System.Drawing.Point(6, 21);
            this.lblWhichReport.Name = "lblWhichReport";
            this.lblWhichReport.Size = new System.Drawing.Size(285, 25);
            this.lblWhichReport.TabIndex = 3;
            this.lblWhichReport.Text = "Which report do you want to generate?";
            // 
            // dateTimePickerStartDate
            // 
            this.dateTimePickerStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStartDate.Location = new System.Drawing.Point(9, 151);
            this.dateTimePickerStartDate.Name = "dateTimePickerStartDate";
            this.dateTimePickerStartDate.Size = new System.Drawing.Size(282, 27);
            this.dateTimePickerStartDate.TabIndex = 7;
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboBoxReports.Location = new System.Drawing.Point(9, 49);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(195, 28);
            this.comboBoxReports.TabIndex = 4;
            // 
            // labelEndDate
            // 
            this.labelEndDate.AutoSize = true;
            this.labelEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEndDate.Location = new System.Drawing.Point(6, 186);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(38, 20);
            this.labelEndDate.TabIndex = 8;
            this.labelEndDate.Text = "End";
            // 
            // labelDateRange
            // 
            this.labelDateRange.AutoSize = true;
            this.labelDateRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateRange.Location = new System.Drawing.Point(6, 96);
            this.labelDateRange.Name = "labelDateRange";
            this.labelDateRange.Size = new System.Drawing.Size(183, 20);
            this.labelDateRange.TabIndex = 5;
            this.labelDateRange.Text = "Date Range for Report:";
            this.labelDateRange.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelStartDate
            // 
            this.labelStartDate.AutoSize = true;
            this.labelStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartDate.Location = new System.Drawing.Point(6, 122);
            this.labelStartDate.Name = "labelStartDate";
            this.labelStartDate.Size = new System.Drawing.Size(45, 20);
            this.labelStartDate.TabIndex = 6;
            this.labelStartDate.Text = "Start";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(9, 215);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(282, 27);
            this.dateTimePickerEndDate.TabIndex = 9;
            // 
            // panelDataGridViewSummarizedReports
            // 
            this.panelDataGridViewSummarizedReports.Controls.Add(this.lblSummary);
            this.panelDataGridViewSummarizedReports.Controls.Add(this.dataGridViewSummarizedReport);
            this.panelDataGridViewSummarizedReports.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDataGridViewSummarizedReports.Location = new System.Drawing.Point(0, 569);
            this.panelDataGridViewSummarizedReports.MaximumSize = new System.Drawing.Size(0, 100);
            this.panelDataGridViewSummarizedReports.MinimumSize = new System.Drawing.Size(0, 100);
            this.panelDataGridViewSummarizedReports.Name = "panelDataGridViewSummarizedReports";
            this.panelDataGridViewSummarizedReports.Size = new System.Drawing.Size(741, 100);
            this.panelDataGridViewSummarizedReports.TabIndex = 0;
            // 
            // dataGridViewSummarizedReport
            // 
            this.dataGridViewSummarizedReport.AllowUserToAddRows = false;
            this.dataGridViewSummarizedReport.AllowUserToDeleteRows = false;
            this.dataGridViewSummarizedReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSummarizedReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSummarizedReport.Location = new System.Drawing.Point(326, 3);
            this.dataGridViewSummarizedReport.Name = "dataGridViewSummarizedReport";
            this.dataGridViewSummarizedReport.ReadOnly = true;
            this.dataGridViewSummarizedReport.RowHeadersWidth = 51;
            this.dataGridViewSummarizedReport.RowTemplate.Height = 24;
            this.dataGridViewSummarizedReport.Size = new System.Drawing.Size(411, 94);
            this.dataGridViewSummarizedReport.TabIndex = 13;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummary.Location = new System.Drawing.Point(14, 13);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(306, 45);
            this.lblSummary.TabIndex = 12;
            this.lblSummary.Text = "Report Summary:";
            this.lblSummary.Click += new System.EventHandler(this.labelListBox_Click);
            // 
            // tabControlReporting
            // 
            this.tabControlReporting.Controls.Add(this.tabPageDataSelection);
            this.tabControlReporting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReporting.Location = new System.Drawing.Point(0, 0);
            this.tabControlReporting.Name = "tabControlReporting";
            this.tabControlReporting.SelectedIndex = 0;
            this.tabControlReporting.Size = new System.Drawing.Size(1105, 704);
            this.tabControlReporting.TabIndex = 0;
            // 
            // pnlMainReport
            // 
            this.pnlMainReport.Controls.Add(this.dataGridViewReports);
            this.pnlMainReport.Controls.Add(this.pnlHeader);
            this.pnlMainReport.Controls.Add(this.panelDataGridViewSummarizedReports);
            this.pnlMainReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainReport.Location = new System.Drawing.Point(353, 3);
            this.pnlMainReport.Name = "pnlMainReport";
            this.pnlMainReport.Size = new System.Drawing.Size(741, 669);
            this.pnlMainReport.TabIndex = 14;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(0, 0);
            this.lblHeader.Margin = new System.Windows.Forms.Padding(5);
            this.lblHeader.MinimumSize = new System.Drawing.Size(50, 50);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Padding = new System.Windows.Forms.Padding(10);
            this.lblHeader.Size = new System.Drawing.Size(117, 66);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Test";
            this.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 563);
            this.Controls.Add(this.tabControlReporting);
            this.Name = "FrmReporting";
            this.Text = "FrmReporting";
            this.tabPageDataSelection.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReports)).EndInit();
            this.gbxReportOptions.ResumeLayout(false);
            this.pnlReportOptions.ResumeLayout(false);
            this.pnlReportOptions.PerformLayout();
            this.panelDataGridViewSummarizedReports.ResumeLayout(false);
            this.panelDataGridViewSummarizedReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSummarizedReport)).EndInit();
            this.tabControlReporting.ResumeLayout(false);
            this.pnlMainReport.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage tabPageDataSelection;
        private System.Windows.Forms.Label lblSummary;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
        private System.Windows.Forms.Label labelDateRange;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label lblWhichReport;
        private System.Windows.Forms.TabControl tabControlReporting;
        private System.Windows.Forms.Panel panelDataGridViewSummarizedReports;
        private System.Windows.Forms.DataGridView dataGridViewSummarizedReport;
        private System.Windows.Forms.GroupBox gbxReportOptions;
        private System.Windows.Forms.Panel pnlReportOptions;
        private System.Windows.Forms.DataGridView dataGridViewReports;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlMainReport;
        private System.Windows.Forms.Label lblHeader;
    }
}