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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlReporting = new System.Windows.Forms.TabControl();
            this.tabPageDataSelection = new System.Windows.Forms.TabPage();
            this.tabPageDataGridView = new System.Windows.Forms.TabPage();
            this.tabPageGraphs = new System.Windows.Forms.TabPage();
            this.chartCollumnChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart5 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart6 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonGenerateReport = new System.Windows.Forms.Button();
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.dateTimePickerStartDate = new System.Windows.Forms.DateTimePicker();
            this.labelDateRange = new System.Windows.Forms.Label();
            this.labelStartDate = new System.Windows.Forms.Label();
            this.labelEndDate = new System.Windows.Forms.Label();
            this.dateTimePickerEndDate = new System.Windows.Forms.DateTimePicker();
            this.tabControlReporting.SuspendLayout();
            this.tabPageDataSelection.SuspendLayout();
            this.tabPageDataGridView.SuspendLayout();
            this.tabPageGraphs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartCollumnChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReporting
            // 
            this.tabControlReporting.Controls.Add(this.tabPageDataSelection);
            this.tabControlReporting.Controls.Add(this.tabPageDataGridView);
            this.tabControlReporting.Controls.Add(this.tabPageGraphs);
            this.tabControlReporting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReporting.Location = new System.Drawing.Point(0, 0);
            this.tabControlReporting.Name = "tabControlReporting";
            this.tabControlReporting.SelectedIndex = 0;
            this.tabControlReporting.Size = new System.Drawing.Size(1106, 704);
            this.tabControlReporting.TabIndex = 0;
            // 
            // tabPageDataSelection
            // 
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
            // tabPageDataGridView
            // 
            this.tabPageDataGridView.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageDataGridView.Controls.Add(this.dataGridView1);
            this.tabPageDataGridView.Location = new System.Drawing.Point(4, 25);
            this.tabPageDataGridView.Name = "tabPageDataGridView";
            this.tabPageDataGridView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDataGridView.Size = new System.Drawing.Size(1098, 675);
            this.tabPageDataGridView.TabIndex = 1;
            this.tabPageDataGridView.Text = "Grid View";
            // 
            // tabPageGraphs
            // 
            this.tabPageGraphs.BackColor = System.Drawing.Color.DarkGray;
            this.tabPageGraphs.Controls.Add(this.chart6);
            this.tabPageGraphs.Controls.Add(this.chart5);
            this.tabPageGraphs.Controls.Add(this.chart4);
            this.tabPageGraphs.Controls.Add(this.chart3);
            this.tabPageGraphs.Controls.Add(this.chart2);
            this.tabPageGraphs.Controls.Add(this.chartCollumnChart);
            this.tabPageGraphs.Location = new System.Drawing.Point(4, 25);
            this.tabPageGraphs.Name = "tabPageGraphs";
            this.tabPageGraphs.Size = new System.Drawing.Size(1098, 675);
            this.tabPageGraphs.TabIndex = 2;
            this.tabPageGraphs.Text = "Dashboard";
            // 
            // chartCollumnChart
            // 
            chartArea6.Name = "ChartArea1";
            this.chartCollumnChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartCollumnChart.Legends.Add(legend6);
            this.chartCollumnChart.Location = new System.Drawing.Point(3, 3);
            this.chartCollumnChart.Name = "chartCollumnChart";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.chartCollumnChart.Series.Add(series6);
            this.chartCollumnChart.Size = new System.Drawing.Size(354, 300);
            this.chartCollumnChart.TabIndex = 0;
            this.chartCollumnChart.Text = "Bar Graph";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart2.Legends.Add(legend5);
            this.chart2.Location = new System.Drawing.Point(363, 0);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(354, 300);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.chart3.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart3.Legends.Add(legend4);
            this.chart3.Location = new System.Drawing.Point(723, 0);
            this.chart3.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart3.Series.Add(series4);
            this.chart3.Size = new System.Drawing.Size(367, 300);
            this.chart3.TabIndex = 2;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            chartArea3.Name = "ChartArea1";
            this.chart4.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart4.Legends.Add(legend3);
            this.chart4.Location = new System.Drawing.Point(3, 309);
            this.chart4.Name = "chart4";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 2;
            this.chart4.Series.Add(series3);
            this.chart4.Size = new System.Drawing.Size(354, 300);
            this.chart4.TabIndex = 3;
            this.chart4.Text = "chart4";
            // 
            // chart5
            // 
            chartArea2.Name = "ChartArea1";
            this.chart5.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart5.Legends.Add(legend2);
            this.chart5.Location = new System.Drawing.Point(363, 306);
            this.chart5.Name = "chart5";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedBar;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart5.Series.Add(series2);
            this.chart5.Size = new System.Drawing.Size(354, 300);
            this.chart5.TabIndex = 4;
            this.chart5.Text = "chart5";
            // 
            // chart6
            // 
            chartArea1.Name = "ChartArea1";
            this.chart6.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart6.Legends.Add(legend1);
            this.chart6.Location = new System.Drawing.Point(723, 306);
            this.chart6.Name = "chart6";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.BoxPlot;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            series1.YValuesPerPoint = 6;
            this.chart6.Series.Add(series1);
            this.chart6.Size = new System.Drawing.Size(367, 300);
            this.chart6.TabIndex = 5;
            this.chart6.Text = "chart6";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1021, 666);
            this.dataGridView1.TabIndex = 0;
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
            this.buttonGenerateReport.Location = new System.Drawing.Point(22, 139);
            this.buttonGenerateReport.Name = "buttonGenerateReport";
            this.buttonGenerateReport.Size = new System.Drawing.Size(224, 33);
            this.buttonGenerateReport.TabIndex = 1;
            this.buttonGenerateReport.Text = "Generate Report";
            this.buttonGenerateReport.UseVisualStyleBackColor = true;
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
            this.labelEndDate.Location = new System.Drawing.Point(599, 59);
            this.labelEndDate.Name = "labelEndDate";
            this.labelEndDate.Size = new System.Drawing.Size(31, 16);
            this.labelEndDate.TabIndex = 9;
            this.labelEndDate.Text = "End";
            // 
            // dateTimePickerEndDate
            // 
            this.dateTimePickerEndDate.Location = new System.Drawing.Point(602, 78);
            this.dateTimePickerEndDate.Name = "dateTimePickerEndDate";
            this.dateTimePickerEndDate.Size = new System.Drawing.Size(292, 22);
            this.dateTimePickerEndDate.TabIndex = 10;
            // 
            // FrmReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 704);
            this.Controls.Add(this.tabControlReporting);
            this.Name = "FrmReporting";
            this.Text = "FrmReporting";
            this.tabControlReporting.ResumeLayout(false);
            this.tabPageDataSelection.ResumeLayout(false);
            this.tabPageDataSelection.PerformLayout();
            this.tabPageDataGridView.ResumeLayout(false);
            this.tabPageGraphs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartCollumnChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlReporting;
        private System.Windows.Forms.TabPage tabPageDataSelection;
        private System.Windows.Forms.Label labelDateRange;
        private System.Windows.Forms.DateTimePicker dateTimePickerStartDate;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Button buttonGenerateReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageDataGridView;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPageGraphs;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartCollumnChart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEndDate;
        private System.Windows.Forms.Label labelEndDate;
        private System.Windows.Forms.Label labelStartDate;
    }
}