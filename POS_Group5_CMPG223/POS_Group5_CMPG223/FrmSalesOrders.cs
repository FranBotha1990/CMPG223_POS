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
using System.Windows.Controls;

namespace POS_Group5_CMPG223
{
    public partial class FrmSalesOrders : Form
    {
        #region Variables
        SqlCommand command, commandDelete;
        SqlDataAdapter adapter = new SqlDataAdapter();
        #endregion
        #region Constructor
        public FrmSalesOrders()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            //Fore Colors
            btnDelete.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnUpdate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotal.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotalAmnt.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlItems.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);

            //Fill Purhcase Orders form with all SO's.
            try
            {
                Methods.SQLCon.Open();

                command = new SqlCommand(@"SELECT Sales_ID AS 'SO Number', 
                                           Sales_date AS 'Date of Sale' 
                                           FROM SALES_ORDER",
                                           Methods.SQLCon);
                DataSet dataSet = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "SALES_ORDER");
                dgvSalesOrders.DataSource = dataSet;
                dgvSalesOrders.DataMember = "SALES_ORDER";

                Methods.SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion

        #region Delete SO Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSalesOrders.SelectedRows == null)
            {
                MessageBox.Show("There are no sale orders to delete.");
            }
            else
            {
                try
                {
                    //Use the selected row, first cell
                    int selector = (int)dgvSalesOrders.CurrentRow.Cells[0].Value;

                    //Remove the SO Items first
                    Methods.SQLCon.Open();
                    commandDelete = new SqlCommand($"DELETE FROM SALES_ORDER_ITEM " +
                                           $"WHERE Sales_ID LIKE '{selector}'",
                                           Methods.SQLCon);
                    adapter.DeleteCommand = commandDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Methods.SQLCon.Close();

                    //Clear the listbox and total label
                    lbxItems.Items.Clear();
                    lblTotalAmnt.Text = " ";

                    //Remove the SO
                    Methods.SQLCon.Open();
                    commandDelete = new SqlCommand($"DELETE FROM SALES_ORDER " +
                                           $"WHERE Sales_ID LIKE '{selector}'",
                                           Methods.SQLCon);
                    adapter.DeleteCommand = commandDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    //Refresh the data grid
                    Methods.SQLCon.Close();
                    //Join SO and Supplier tables by Supplier_ID
                    command = new SqlCommand(@"SELECT Sales_ID AS 'SO Number', 
                                           Sales_date AS 'Date of Sale' 
                                           FROM SALES_ORDER",
                                               Methods.SQLCon);
                    DataSet dataSet = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "SALES_ORDER");
                    dgvSalesOrders.DataSource = dataSet;
                    dgvSalesOrders.DataMember = "SALES_ORDER";
                    Methods.SQLCon.Close();

                    MessageBox.Show("Sales Order deleted successfully!");
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        #endregion
        #region SO Click Action
        private void dgvSalesOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbxItems.Items.Clear();
                //Use the selected row, first cell
                int selector = (int)dgvSalesOrders.CurrentRow.Cells[0].Value;
                double total = 0;

                Methods.SQLCon.Open();

                SqlDataReader dataReader;
                //Join the SOItems and Product tables by Product_ID
                command = new SqlCommand($"SELECT SOI.Sales_ID, " +
                                           "SOI.Product_ID, " +
                                           "SOI.Quantity_sold, " +
                                           "PR.Sell_price, " +
                                           "PR.Description " +
                                           "FROM SALES_ORDER_ITEM AS SOI " +
                                           "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = SOI.Product_ID " +
                                           $"WHERE SOI.Sales_ID LIKE '{selector}'",
                                           Methods.SQLCon);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    string str = string.Format("{0} {1} {2} {3} {4}", dataReader.GetValue(2), " * ", dataReader.GetValue(4), " @ R", Convert.ToDouble(dataReader.GetValue(3)));
                    lbxItems.Items.Add(str);
                    total += (Convert.ToDouble(dataReader.GetValue(3)) * Convert.ToDouble(dataReader.GetValue(2)));
                }

                lblTotalAmnt.Text = string.Format("{0} {1:0.00}", "R", Convert.ToDouble(total)); ;

                Methods.SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion
        #region Remove Items Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (lbxItems.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the items list.");
            }
            else
            {
                try
                {
                    //Use the selected row, first cell
                    int selector = (int)dgvSalesOrders.CurrentRow.Cells[0].Value;
                    string validator = (string)lbxItems.SelectedItem;
                    int product = 0;
                    double total = 0;

                    Methods.SQLCon.Open();
                    SqlDataReader dataReader;
                    //Join the SOItems and Product tables by Product_ID
                    command = new SqlCommand($"SELECT SOI.Sales_ID, " +
                                               "SOI.Product_ID, " +
                                               "SOI.Quantity_sold, " +
                                               "PR.Sell_price, " +
                                               "PR.Description " +
                                               "FROM SALES_ORDER_ITEM AS SOI " +
                                               "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = SOI.Product_ID " +
                                               $"WHERE SOI.Sales_ID LIKE '{selector}'",
                                               Methods.SQLCon);
                    dataReader = command.ExecuteReader();
                    //Find the product ID of the selected item
                    while (dataReader.Read())
                    {
                        if (validator.Contains(Convert.ToString(dataReader.GetValue(4))))
                        {
                            product = Convert.ToInt32(dataReader.GetValue(1));
                        }
                    }
                    Methods.SQLCon.Close();

                    //Remove the record based on SO ID and Product ID
                    Methods.SQLCon.Open();
                    commandDelete = new SqlCommand($"DELETE FROM SALES_ORDER_ITEM " +
                                           $"WHERE Sales_ID LIKE '{selector}' " +
                                           $"AND Product_ID LIKE '{product}'",
                                           Methods.SQLCon);
                    adapter.DeleteCommand = commandDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Methods.SQLCon.Close();

                    lbxItems.Items.Clear();

                    Methods.SQLCon.Open();
                    SqlDataReader dataReader2;
                    //Join the POItems and Product tables by Product_ID
                    command = new SqlCommand($"SELECT SOI.Sales_ID, " +
                                               "SOI.Product_ID, " +
                                               "SOI.Quantity_sold, " +
                                               "PR.Sell_price, " +
                                               "PR.Description " +
                                               "FROM SALES_ORDER_ITEM AS SOI " +
                                               "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = SOI.Product_ID " +
                                               $"WHERE SOI.Sales_ID LIKE '{selector}'",
                                               Methods.SQLCon);
                    dataReader2 = command.ExecuteReader();
                    //Add all items remaining in the PO
                    while (dataReader2.Read())
                    {
                        string str = string.Format("{0} {1} {2} {3} {4}", dataReader2.GetValue(2), " * ", dataReader2.GetValue(4), " @ R", Convert.ToDouble(dataReader2.GetValue(3)));
                        lbxItems.Items.Add(str);
                        total += (Convert.ToDouble(dataReader2.GetValue(3)) * Convert.ToDouble(dataReader2.GetValue(2)));
                    }
                    Methods.SQLCon.Close();

                    lblTotalAmnt.Text = string.Format("{0} {1:0.00}", "R", Convert.ToDouble(total));

                    MessageBox.Show("Sales Order Item deleted successfully!");
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }
        #endregion
    }
}
