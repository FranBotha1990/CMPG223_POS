using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace POS_Group5_CMPG223
{
    public partial class FrmReporting : Form
    {
        #region Variables
        SqlCommand commandReport, commandReportTotal, commandStock;
        SqlDataAdapter adapterReport = new SqlDataAdapter();
        #endregion
        #region Constructor
        public FrmReporting()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            //Default Date
            dateTimePickerStartDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;
            //Back Colours
            this.BackColor = Methods.clrForms;
            gbxReportOptions.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
            panelDataGridViewSummarizedReports.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
            pnlHeader.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);

            //Fore Colours
            buttonGenerateReport.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            labelDateRange.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            labelEndDate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            labelStartDate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblWhichReport.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            gbxReportOptions.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            buttonGenerateReport.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblSummary.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblHeader.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);

            try
            {
                dateTimePickerStartDate.Value = DateTime.Today;
                dateTimePickerEndDate.Value = DateTime.Today;
                comboBoxReports.SelectedIndex = 5;
                try
                {
                    Methods.SQLCon.Open();

                    commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales Today (R)' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '"
                                       + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '"
                                       + dateTimePickerEndDate.Value.ToString("yyyyMMdd") +
                                       "'", Methods.SQLCon);
                    DataSet dataSetReportTotal = new DataSet();
                    adapterReport.SelectCommand = commandReportTotal;
                    adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                    dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                    dataGridViewSummarizedReport.DataMember = "PRODUCT";
                    
                    commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity Sold', 
                                           PRODUCT.Description AS 'Item Sold', PRODUCT.Sell_price AS 'Sales Price (R)' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '"
                                       + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '"
                                       + dateTimePickerEndDate.Value.ToString("yyyyMMdd") +
                                       "'ORDER BY SALES_ORDER.Sales_date", Methods.SQLCon);
                    DataSet dataSetReport = new DataSet();
                    adapterReport.SelectCommand = commandReport;
                    adapterReport.Fill(dataSetReport, "PRODUCT");
                    dataGridViewReports.DataSource = dataSetReport;
                    dataGridViewReports.DataMember = "PRODUCT";
                    Methods.SQLCon.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }       
        }
        #endregion

        #region Click
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion
        #region Generate Button
        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            dataGridViewSummarizedReport.Visible = false;

            try
            {
                if (comboBoxReports.SelectedIndex == 0)
                {
                    dataGridViewSummarizedReport.Visible = true;

                    //Sales Report
                    Methods.SQLCon.Open();

                    commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + 
                                           "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "'" ,Methods.SQLCon);
                    DataSet dataSetReportTotal = new DataSet();
                    adapterReport.SelectCommand = commandReportTotal;
                    adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                    dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                    dataGridViewSummarizedReport.DataMember = "PRODUCT";
                    dataGridViewSummarizedReport.Columns["Total Sales"].DefaultCellStyle.Format = "c";

                    commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity', PRODUCT.Description AS 'Item Sold', 
                                           PRODUCT.Sell_price AS 'Sales Price', SALES_ORDER.Sales_Date AS 'Date Sold'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + 
                                           "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "' ORDER BY SALES_ORDER.Sales_Date ASC", Methods.SQLCon);
                    DataSet dataSetReport = new DataSet();
                    adapterReport.SelectCommand = commandReport;
                    adapterReport.Fill(dataSetReport, "PRODUCT");
                    dataGridViewReports.DataSource = dataSetReport;
                    dataGridViewReports.DataMember = "PRODUCT";
                    dataGridViewReports.Columns["Sales Price"].DefaultCellStyle.Format = "c";
                    changeLabels();

                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 1)
                {
                    dataGridViewSummarizedReport.Visible = true;

                    //Purchases Report
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PURCHASE_ORDER_ITEM.Cost_price) AS 'Total Cost Price'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           WHERE PURCHASE_ORDER.Purchase_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + 
                                           "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "'", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        dataGridViewSummarizedReport.Columns["Total Cost Price"].DefaultCellStyle.Format = "c";

                        commandReport = new SqlCommand(@"SELECT PURCHASE_ORDER_ITEM.Quantity_purchased AS 'Quantity', PRODUCT.Description AS 'Item Purchased', 
                                           PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price', PURCHASE_ORDER.Purchase_date AS 'Date Purchased',
                                           PURCHASE_ORDER.Received AS 'Product Received', PURCHASE_ORDER.Receive_date AS 'Date Received'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           WHERE PURCHASE_ORDER.Purchase_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + 
                                           "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "' ORDER BY PURCHASE_ORDER.Purchase_date ASC", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                        dataGridViewReports.Columns["Cost Price"].DefaultCellStyle.Format = "c";

                        changeLabels();
                    }
                    catch (SqlException)
                    {
                        //Error message
                        MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 2)
                {
                    // Stock On Hand Report
                    Methods.SQLCon.Open();
                    try
                    {
                        double totalCost = 0, totalSell = 0;

                        commandReport = new SqlCommand(@"SELECT PRODUCT.Description AS 'Stock Item', PRODUCT.Quantity_in_stock AS 'Stock on Hand', 
                                            PRODUCT.Sell_price AS 'Sales Price', PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price' 
                                            FROM PRODUCT
                                            INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                        dataGridViewReports.Columns["Sales Price"].DefaultCellStyle.Format = "c";
                        dataGridViewReports.Columns["Cost Price"].DefaultCellStyle.Format = "c";

                        SqlDataReader dataReader;
                        commandStock = new SqlCommand(@"SELECT PRODUCT.Description, PRODUCT.Quantity_in_stock, 
                                            PRODUCT.Sell_price, PURCHASE_ORDER_ITEM.Cost_price  
                                            FROM PRODUCT
                                            INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID", Methods.SQLCon);
                        dataReader = commandStock.ExecuteReader();
                        while (dataReader.Read())
                        {
                            totalCost += Convert.ToDouble(dataReader.GetValue(1)) * Convert.ToDouble(dataReader.GetValue(3));
                            totalSell += Convert.ToDouble(dataReader.GetValue(1)) * Convert.ToDouble(dataReader.GetValue(2));
                        }

                        lblSummary.Text = "Total Value of Stock:\nCost Price: R " + totalCost.ToString() + "   |   Sell Price: R " + totalSell.ToString();

                        changeLabels();
                    }
                    catch (SqlException)
                    {
                        //Error message
                        MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 3)
                {
                    dataGridViewSummarizedReport.Visible = true;

                    //All Sales
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        dataGridViewSummarizedReport.Columns["Total Sales"].DefaultCellStyle.Format = "c";

                        commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity', PRODUCT.Description AS 'Item Sold', 
                                           PRODUCT.Sell_price AS 'Sales Price', SALES_ORDER.Sales_Date AS 'Date Sold'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           ORDER BY SALES_ORDER.Sales_Date" , Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                        dataGridViewReports.Columns["Sales Price"].DefaultCellStyle.Format = "c";
                        changeLabels();
                    }
                    catch (SqlException)
                    {
                        //Error message
                        MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 4)
                {
                    dataGridViewSummarizedReport.Visible = true;

                    //All Purchases
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PURCHASE_ORDER_ITEM.Cost_price) AS 'Total Cost Price'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        dataGridViewSummarizedReport.Columns["Total Cost Price"].DefaultCellStyle.Format = "c";

                        commandReport = new SqlCommand(@"SELECT PURCHASE_ORDER_ITEM.Quantity_purchased AS 'Quantity', 
                                           PRODUCT.Description AS 'Item Purchased', PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price', 
                                           PURCHASE_ORDER.Purchase_date AS 'Date Purchased', PURCHASE_ORDER.Received AS 'Product Received', 
                                           PURCHASE_ORDER.Receive_date AS 'Date Received'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           ORDER BY PURCHASE_ORDER.Purchase_date", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                        dataGridViewReports.Columns["Cost Price"].DefaultCellStyle.Format = "c";
                        changeLabels();
                    }
                    catch (SqlException)
                    {
                        //Error message
                        MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 5)
                {
                    dataGridViewSummarizedReport.Visible = true;

                    //Day End Report
                    dateTimePickerStartDate.Value = DateTime.Today;
                    dateTimePickerEndDate.Value = DateTime.Today;
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales Today' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '"
                                       + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '"
                                       + dateTimePickerEndDate.Value.ToString("yyyyMMdd") +
                                       "'", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        dataGridViewSummarizedReport.Columns["Total Sales Today"].DefaultCellStyle.Format = "c";

                        commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity Sold', 
                                           PRODUCT.Description AS 'Item Sold', PRODUCT.Sell_price AS 'Sales Price' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '" 
                                           + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '" 
                                           + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + 
                                           "'ORDER BY SALES_ORDER.Sales_date", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                        dataGridViewReports.Columns["Sales Price"].DefaultCellStyle.Format = "c";
                        changeLabels();
                    }
                    catch (SqlException)
                    {
                        //Error message
                        MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 6)
                {
                    dataGridViewSummarizedReport.Visible = true;

                    //Week End Report
                    dateTimePickerStartDate.Value = DateTime.Today.AddDays(-7);
                    dateTimePickerEndDate.Value = DateTime.Today;
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales This Week' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '"
                                       + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '"
                                       + dateTimePickerEndDate.Value.ToString("yyyyMMdd") +
                                       "'", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        dataGridViewSummarizedReport.Columns["Total Sales This Week"].DefaultCellStyle.Format = "c";

                        commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity Sold', 
                                           PRODUCT.Description AS 'Item Sold', PRODUCT.Sell_price AS 'Sales Price' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '"
                                           + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '"
                                           + dateTimePickerEndDate.Value.ToString("yyyyMMdd") +
                                           "'ORDER BY SALES_ORDER.Sales_date", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                        dataGridViewReports.Columns["Sales Price"].DefaultCellStyle.Format = "c";
                        changeLabels();
                    }
                    catch (SqlException)
                    {
                        //Error message
                        MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 7)
                {
                    dataGridViewSummarizedReport.Visible = true;

                    //Month End Report
                    dateTimePickerStartDate.Value = DateTime.Today.AddMonths(-1);
                    dateTimePickerEndDate.Value = DateTime.Today;
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales This Month' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '"
                                       + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '"
                                       + dateTimePickerEndDate.Value.ToString("yyyyMMdd") +
                                       "'", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        dataGridViewSummarizedReport.Columns["Total Sales This Month"].DefaultCellStyle.Format = "c";

                        commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity Sold', 
                                           PRODUCT.Description AS 'Item Sold', PRODUCT.Sell_price AS 'Sales Price' 
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '"
                                           + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '"
                                           + dateTimePickerEndDate.Value.ToString("yyyyMMdd") +
                                           "'ORDER BY SALES_ORDER.Sales_date", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                        dataGridViewReports.Columns["Sales Price"].DefaultCellStyle.Format = "c";
                        changeLabels();
                    }
                    catch (SqlException)
                    {
                        //Error message
                        MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Methods.SQLCon.Close();
                }
            }
            catch (SqlException)
            {
                //Error message
                MessageBox.Show("Could not generate report!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Listbox Click
        private void labelListBox_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region Change Labels
        private void changeLabels()
        {
            lblHeader.Text = "Report: " + comboBoxReports.SelectedItem.ToString();
        }
        #endregion
    }
}
