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
        SqlCommand commandReport;
        SqlDataAdapter adapterReport = new SqlDataAdapter();
        SqlDataReader readerReport = null;

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
                //listBoxReports.Items.Add("Test SALES ORDERS");
                //listBoxReports.Items.Add("Sales ID\tProduct ID\tQuantity sold");
                //listBoxReports.Items.Add("Date-Time Test");
                //listBoxReports.Items.Add("Start Date = " + dateTimePickerStartDate.Value.ToString("yyyy/MM/dd"));
                //listBoxReports.Items.Add("End Date = "+ dateTimePickerEndDate.Value.ToString("yyyy/MM/dd"));
                
                Methods.SQLCon.Open();

                //SQL for daily Sales report
                /*commandReport = new SqlCommand(@"SELECT Sales_ID AS 'SalesID'
                                           FROM SALES_ORDER AS SO
                                           WHERE Sales_Date BETWEEN "+dateTimePickerStartDate.Value.ToString()+"AND"+dateTimePickerEndDate.Value.ToString()+"",Methods.SQLCon);
                DataSet dataSetReportTodaySales = new DataSet();
                adapterReport.SelectCommand = commandReportTodaySales;
                adapterReport.Fill(datasetReportTodaySales, "SALES_ORDER");
                dataGridViewReports.DataSource = datasetReportTodaySales;
                dataGridViewReports.DataMember = "SALES_ORDER";
                 */

                //SQL for All Sales
                /*commandReportAllSales = new SqlCommand(@"SELECT Sales_ID AS 'Sales ID', 
                                           Product_ID AS 'Product ID',
                                           Quantity_sold AS 'Quantity'
                                           FROM SALES_ORDER_ITEM AS SOI"
                                           , Methods.SQLCon);
                DataSet dataSetReportAllSales = new DataSet();
                adapterReport.SelectCommand = commandReportAllSales;
                adapterReport.Fill(datasetReportAllSales, "SALES_ORDER_ITEM");
                dataGridViewReports.DataSource = datasetReportAllSales;
                dataGridViewReports.DataMember = "SALES_ORDER_ITEM";
                */

                //Populating Values into ListBox
                /*commandReport = new SqlCommand(@"SELECT SALES_ORDER.Sales_ID, SALES_ORDER_ITEM.Product_ID, SALES_ORDER_ITEM.Quantity_sold
                                                FROM SALES_ORDER
                                                INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID"
                                                , Methods.SQLCon);
                */
                //Sales by product
                /*
                commandReportSalesByProduct = new SqlCommand(@"SELECT PRODUCT.Description AS 'Product Description', PRODUCT.Sell_price AS 'Selling Price', SALES_ORDER_ITEM.Quantity_sold AS 'Quantity sold', SALES_ORDER.Sales_date AS 'Sales Date'
                                                FROM ((PRODUCT
                                                INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID)
                                                INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID)"
                                                , Methods.SQLCon);
                */
                //Stock on Hand Report
                /*
                commandReport = new SqlCommand(@"SELECT Description AS 'Stock Item', Quantity_in_stock AS 'Stock on Hand', Sell_price AS 'Sales Price' 
                                            FROM PRODUCT", Methods.SQLCon);
                */
                //Sales between two dates
                /*
                commandReport = new SqlCommand(@"SELECT SALES_ORDER_ITEM.Quantity_sold AS 'Quantity', PRODUCT.Description AS 'Item sold', PRODUCT.Sell_price AS 'Sales Price', SALES_ORDER.Sales_Date AS 'Date Sold'
                                           FROM PRODUCT
                                           INNER JOIN SALES_ORDER_ITEM ON SALES_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN SALES_ORDER ON SALES_ORDER.Sales_ID = SALES_ORDER_ITEM.Sales_ID
                                           WHERE SALES_ORDER.Sales_Date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "'", Methods.SQLCon);
                */
                //Purchases between two dates
                //commandReport = new SqlCommand(@"SELECT ");
                /*
                DataSet dataSetReport = new DataSet();
                adapterReport.SelectCommand = commandReport;
                adapterReport.Fill(dataSetReport, "PRODUCT");
                dataGridViewReports.DataSource = dataSetReport;
                dataGridViewReports.DataMember = "PRODUCT";

                readerReport1 = commandReport.ExecuteReader();

                while(readerReport1.Read())
                {
                    listBoxReports.Items.Add(readerReport1["Quantity"] +"\t"+ readerReport1["Item sold"]+"\t"+ readerReport1["Sales Price"]+"\t"+ readerReport1["Date Sold"]);
                }
                
                //listBoxReports.DataSource = dataSetReport;
                //listBoxReports.
                //listBoxReports.ValueMember = "Sales_ID";


                
                

                
                */
                Methods.SQLCon.Close();

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
                listBoxReports.Items.Clear();
                if (comboBoxReports.SelectedIndex == 0)
                {
                    //Sales Report
                    Methods.SQLCon.Open();
                    listBoxReports.Items.Add("Sales between yyyyMMdd and yyyyMMdd");
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

                    readerReport = commandReport.ExecuteReader();

                    while (readerReport.Read())
                    {
                        listBoxReports.Items.Add(readerReport["Quantity"] + "\t" + readerReport["Item sold"] + "\t" + readerReport["Sales Price (R)"] + "\t" + readerReport["Date Sold"]);
                    }
                    Methods.SQLCon.Close();
                }
                else if(comboBoxReports.SelectedIndex == 1)
                {
                    //Purchases Report
                    Methods.SQLCon.Open();
                    listBoxReports.Items.Add("Purchases between yyyyMMdd and yyyyMMdd");
                    try
                    {
                        commandReport = new SqlCommand(@"SELECT PURCHASE_ORDER_ITEM.Quantity_purchased AS 'Quantity', PRODUCT.Description AS 'Item purchased', PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price (R)', PURCHASE_ORDER.Purchase_date AS 'Date Purchased'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           WHERE PURCHASE_ORDER.Purchase_date BETWEEN '" + dateTimePickerStartDate.Value.ToString("yyyyMMdd") + "' AND '" + dateTimePickerEndDate.Value.ToString("yyyyMMdd") + "' ORDER BY PURCHASE_ORDER.Purchase_date ASC", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";

                        readerReport = commandReport.ExecuteReader();

                        while (readerReport.Read())
                        {
                            listBoxReports.Items.Add(readerReport["Quantity"] + "\t" + readerReport["Item purchased"] + "\t" + readerReport["Cost Price (R)"] + "\t" + readerReport["Date Purchased"]);
                        }
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
                    listBoxReports.Items.Add("Stock on Hand Report");
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

                        readerReport = commandReport.ExecuteReader();

                        while (readerReport.Read())
                        {
                            listBoxReports.Items.Add(string.Format("{0,-40}{1,5}{2,30}{3,20}",readerReport["Stock Item"], readerReport["Stock on Hand"], readerReport["Sales Price (R)"], readerReport["Cost Price (R)"]));
                        }
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
                    listBoxReports.Items.Add("All Sales Report");
                    try
                    {
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

                        readerReport = commandReport.ExecuteReader();

                        while (readerReport.Read())
                        {
                            listBoxReports.Items.Add(string.Format("{0,-10}{1,-50}{2,30}", readerReport["Quantity"], readerReport["Item sold"], readerReport["Sales Price (R)"], readerReport["Date Sold"]));
                        }
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
                    listBoxReports.Items.Add("All Purchases Report");
                    try
                    {
                        commandReport = new SqlCommand(@"SELECT PURCHASE_ORDER_ITEM.Quantity_purchased AS 'Quantity', PRODUCT.Description AS 'Item Purchased', PURCHASE_ORDER_ITEM.Cost_price AS 'Cost Price (R)', PURCHASE_ORDER.Purchase_date AS 'Date Purchased'
                                           FROM PRODUCT
                                           INNER JOIN PURCHASE_ORDER_ITEM ON PURCHASE_ORDER_ITEM.Product_ID = PRODUCT.Product_ID
                                           INNER JOIN PURCHASE_ORDER ON PURCHASE_ORDER.Purchase_ID = PURCHASE_ORDER_ITEM.Purchase_ID
                                           ORDER BY PURCHASE_ORDER.Purchase_date", Methods.SQLCon);
                        DataSet dataSetReport = new DataSet();
                        adapterReport.SelectCommand = commandReport;
                        adapterReport.Fill(dataSetReport, "PRODUCT");
                        dataGridViewReports.DataSource = dataSetReport;
                        dataGridViewReports.DataMember = "PRODUCT";

                        readerReport = commandReport.ExecuteReader();

                        while (readerReport.Read())
                        {
                            listBoxReports.Items.Add(string.Format("{0,-10}{1,-50}{2,30}", readerReport["Quantity"], readerReport["Item Purchased"], readerReport["Cost Price (R)"], readerReport["Date Purchased"]));
                        }
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
                    listBoxReports.Items.Add("Day End Report");
                    try
                    {
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

                        readerReport = commandReport.ExecuteReader();

                        while (readerReport.Read())
                        {
                            listBoxReports.Items.Add(string.Format("{0,-10}{1,-50}{2,30}", readerReport["Quantity Sold"], readerReport["Item Sold"], readerReport["Sales Price (R)"]));
                        }
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
                    listBoxReports.Items.Add("Week End Report");
                    try
                    {
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

                        readerReport = commandReport.ExecuteReader();

                        while (readerReport.Read())
                        {
                            listBoxReports.Items.Add(string.Format("{0,-10}{1,-50}{2,30}", readerReport["Quantity Sold"], readerReport["Item Sold"], readerReport["Sales Price (R)"]));
                        }
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
                    listBoxReports.Items.Add("Month End Report");
                    try
                    {
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

                        readerReport = commandReport.ExecuteReader();

                        while (readerReport.Read())
                        {
                            listBoxReports.Items.Add(string.Format("{0,-10}{1,-50}{2,30}", readerReport["Quantity Sold"], readerReport["Item Sold"], readerReport["Sales Price (R)"]));
                        }
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
    }
}
