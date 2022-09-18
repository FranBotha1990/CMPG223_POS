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
        SqlCommand commandReport,commandReportTotal;
        SqlDataAdapter adapterReport = new SqlDataAdapter();
        SqlDataReader readerReport = null;
        SqlDataReader readerReportTotal = null;
        public FrmReporting()
        {
            InitializeComponent();
        }
        public void LoadGUI()
        {
            //Default Date
            dateTimePickerStartDate.Value = DateTime.Today;
            dateTimePickerEndDate.Value = DateTime.Today;
            //Back Colours
            this.BackColor = Methods.clrForms;
            //buttonGenerateReport.BackColor = Methods.clrForms;
            //labelDateRange.BackColor = Methods.clrForms;
            //labelEndDate.BackColor = Methods.clrForms;
            //labelStartDate.BackColor = Methods.clrForms;

            //Fore Colours
            //buttonGenerateReport.ForeColor = Methods.clrForms;
            //labelDateRange.ForeColor = Methods.clrForms;
            //labelEndDate.ForeColor = Methods.clrForms;
            //labelStartDate.ForeColor = Methods.clrForms;

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
        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void buttonGenerateReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxReports.SelectedIndex == 0)
                {
                    //Sales Report
                    Methods.SQLCon.Open();

                    commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales (R)'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "'" ,Methods.SQLCon);
                    DataSet dataSetReportTotal = new DataSet();
                    adapterReport.SelectCommand = commandReportTotal;
                    adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                    dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                    dataGridViewSummarizedReport.DataMember = "PRODUCT";
                    
                    commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity', PRODUCT.Description AS 'Item sold', PRODUCT.Sell_price AS 'Sales Price (R)', SALES_ORDER.Sales_Date AS 'Date Sold'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "' ORDER BY SALES_ORDER.Sales_Date ASC", Methods.SQLCon);
                    DataSet dataSetReport = new DataSet();
                    adapterReport.SelectCommand = commandReport;
                    adapterReport.Fill(dataSetReport, "PRODUCT");
                    dataGridViewReports.DataSource = dataSetReport;
                    dataGridViewReports.DataMember = "PRODUCT";

                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 1)
                {
                    //Purchases Report
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PURCHASE_ORDER_ITEM.Cost_price) AS 'Total Cost Price (R)'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           WHERE PURCHASE_ORDER.Purchase_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "'", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        
                        commandReport = new SqlCommand(@"SELECT PURCHASE_ORDER_ITEM.Quantity_purchased AS 'Quantity', PRODUCT.Description AS 'Item purchased', PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price (R)', PURCHASE_ORDER.Purchase_date AS 'Date Purchased', PURCHASE_ORDER.Received AS 'Product Received', PURCHASE_ORDER.Receive_date AS 'Date Received'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           WHERE PURCHASE_ORDER.Purchase_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "' ORDER BY PURCHASE_ORDER.Purchase_date ASC", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 2)
                {
                    // Stock On Hand Report
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReport = new SqlCommand(@"SELECT PRODUCT.Description AS 'Stock Item', PRODUCT.Quantity_in_stock AS 'Stock on Hand', PRODUCT.Sell_price AS 'Sales Price (R)', PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price (R)' 
                                            FROM PRODUCT
                                            INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";

                        commandReportTotal = new SqlCommand(@"SELECT PRODUCT.Description AS 'Stock Item', PRODUCT.Quantity_in_stock AS 'Stock on Hand' 
                                            FROM PRODUCT", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 3)
                {
                    //All Sales
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PRODUCT.Sell_price) AS 'Total Sales (R)'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        
                        commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity', PRODUCT.Description AS 'Item sold', PRODUCT.Sell_price AS 'Sales Price (R)', SALES_ORDER.Sales_Date AS 'Date Sold'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           ORDER BY SALES_ORDER.Sales_Date" , Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 4)
                {
                    //All Purchases
                    Methods.SQLCon.Open();
                    try
                    {
                        commandReportTotal = new SqlCommand(@"SELECT SUM(PURCHASE_ORDER_ITEM.Cost_price) AS 'Total Cost Price (R)'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID", Methods.SQLCon);
                        DataSet dataSetReportTotal = new DataSet();
                        adapterReport.SelectCommand = commandReportTotal;
                        adapterReport.Fill(dataSetReportTotal, "PRODUCT");
                        dataGridViewSummarizedReport.DataSource = dataSetReportTotal;
                        dataGridViewSummarizedReport.DataMember = "PRODUCT";
                        
                        commandReport = new SqlCommand(@"SELECT PURCHASE_ORDER_ITEM.Quantity_purchased AS 'Quantity', PRODUCT.Description AS 'Item Purchased', PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price (R)', PURCHASE_ORDER.Purchase_date AS 'Date Purchased', PURCHASE_ORDER.Received AS 'Product Received', PURCHASE_ORDER.Receive_date AS 'Date Received'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           ORDER BY PURCHASE_ORDER.Purchase_date", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 5)
                {
                    //Day End Report
                    dateTimePickerStartDate.Value = DateTime.Today;
                    dateTimePickerEndDate.Value = DateTime.Today;
                    Methods.SQLCon.Open();
                    try
                    {
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 6)
                {
                    //Week End Report
                    dateTimePickerStartDate.Value = DateTime.Today.AddDays(-7);
                    dateTimePickerEndDate.Value = DateTime.Today;
                    Methods.SQLCon.Open();
                    try
                    {
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 7)
                {
                    //Month End Report
                    dateTimePickerStartDate.Value = DateTime.Today.AddMonths(-1);
                    dateTimePickerEndDate.Value = DateTime.Today;
                    Methods.SQLCon.Open();
                    try
                    {
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
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    Methods.SQLCon.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void labelListBox_Click(object sender, EventArgs e)
        {

        }
    }
}
