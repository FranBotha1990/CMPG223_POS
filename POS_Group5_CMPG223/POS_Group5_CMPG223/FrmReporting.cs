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
                commandReport = new SqlCommand(@"SELECT Sales_ID AS 'SalesID' 
                                                FROM SALES_ORDER AS SO"
                                                , Methods.SQLCon);

                DataSet dataSetReport = new DataSet();
                adapterReport.SelectCommand = commandReport;
                adapterReport.Fill(dataSetReport, "SALES_ORDER");
                dataGridViewReports.DataSource = dataSetReport;
                dataGridViewReports.DataMember = "SALES_ORDER";

                listBoxReports.DataSource = dataSetReport;
                listBoxReports.DisplayMember = "Sales_ID";


                
                

                

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
