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
                listBoxReports.Items.Add("Test SALES ORDERS");
                listBoxReports.Items.Add("Sales ID\tProduct ID\tQuantity sold");
                listBoxReports.Items.Add("Date-Time Test");
                listBoxReports.Items.Add("Start Date = " + dateTimePickerStartDate.Value.ToString("yyyy/MM/dd"));
                listBoxReports.Items.Add("End Date = "+ dateTimePickerEndDate.Value.ToString("yyyy/MM/dd"));
                
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

                DataSet dataSetReport = new DataSet();
                adapterReport.SelectCommand = commandReport;
                adapterReport.Fill(dataSetReport, "PRODUCT");
                dataGridViewReports.DataSource = dataSetReport;
                dataGridViewReports.DataMember = "PRODUCT";

                readerReport = commandReport.ExecuteReader();

                while(readerReport.Read())
                {
                    listBoxReports.Items.Add(readerReport["Quantity"] +"\t"+ readerReport["Item sold"]+"\t"+ readerReport["Sales Price"]+"\t"+ readerReport["Date Sold"]);
                }
                //listBoxReports.DataSource = dataSetReport;
                //listBoxReports.
                //listBoxReports.ValueMember = "Sales_ID";


                
                

                

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
            Methods.SQLCon.Open();

        }
    }
}
