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
        SqlCommand command, commandDelete, commandUpdate;
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
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            OnCellClick();

        }
        #endregion

        #region Delete SO Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selector = (int)dgvSalesOrders.CurrentRow.Cells[0].Value;

            if (dgvSalesOrders.SelectedRows == null)
            {
                MessageBox.Show("There are no sale orders to delete.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Sales Order number '" + selector + "'?", "Delete Sales Order", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //Clear the listbox and total label
                    lbxItems.Items.Clear();
                    lblTotalAmnt.Text = " ";

                    //Remove the SO Items first
                    try
                    {
                        Methods.SQLCon.Open();

                        commandDelete = new SqlCommand($"DELETE FROM SALES_ORDER_ITEM " +
                                                $"WHERE Sales_ID LIKE '{selector}'",
                                                Methods.SQLCon);
                        adapter.DeleteCommand = commandDelete;
                        adapter.DeleteCommand.ExecuteNonQuery();

                        Methods.SQLCon.Close();
                    }
                    catch (SqlException ex)
                    {
                        //Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Remove the SO
                    try
                    {
                        Methods.SQLCon.Open();

                        commandDelete = new SqlCommand($"DELETE FROM SALES_ORDER " +
                                                $"WHERE Sales_ID LIKE '{selector}'",
                                                Methods.SQLCon);
                        adapter.DeleteCommand = commandDelete;
                        adapter.DeleteCommand.ExecuteNonQuery();

                        Methods.SQLCon.Close();
                    }
                    catch (SqlException ex)
                    {
                        //Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Refresh the data grid with SO's
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
                    catch (SqlException ex)
                    {
                        //Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Sales Order deleted successfully!");
                }
            }
        }
        #endregion
        #region SO Click Action
        private void dgvSalesOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnCellClick();
        }
        #endregion
        #region Remove Items Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Use the selected row, first cell
            int selector = (int)dgvSalesOrders.CurrentRow.Cells[0].Value;
            string validator = (string)lbxItems.SelectedItem;
            int product = 0;
            int current = 0;
            int quantity = 0;
            double total = 0;

            if (lbxItems.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the items list.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item from the Sales Order?", "Remove Item from SO", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //Join the SOItems and Product tables by Product_ID
                    try
                    {
                        Methods.SQLCon.Open();
                        SqlDataReader dataReader;
                        command = new SqlCommand($"SELECT SOI.Sales_ID, " +
                                                    "SOI.Product_ID, " +
                                                    "SOI.Quantity_sold, " +
                                                    "PR.Sell_price, " +
                                                    "PR.Description, " +
                                                    "PR.Quantity_in_stock " +
                                                    "FROM SALES_ORDER_ITEM AS SOI " +
                                                    "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = SOI.Product_ID " +
                                                    $"WHERE SOI.Sales_ID LIKE '{selector}'",
                                                    Methods.SQLCon);
                        dataReader = command.ExecuteReader();

                        while (dataReader.Read())
                        {
                            if (validator.Contains(Convert.ToString(dataReader.GetValue(4))))
                            {
                                product = Convert.ToInt32(dataReader.GetValue(1));
                                quantity = Convert.ToInt32(dataReader.GetValue(2));
                                current = Convert.ToInt32(dataReader.GetValue(5));
                            }
                        }
                        Methods.SQLCon.Close();
                    }
                    catch (SqlException ex)
                    {
                        //Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Remove the record based on SO ID and Product ID
                    try
                    {
                        Methods.SQLCon.Open();

                        commandDelete = new SqlCommand($"DELETE FROM SALES_ORDER_ITEM " +
                                                $"WHERE Sales_ID LIKE '{selector}' " +
                                                $"AND Product_ID LIKE '{product}'",
                                                Methods.SQLCon);
                        adapter.DeleteCommand = commandDelete;
                        adapter.DeleteCommand.ExecuteNonQuery();

                        Methods.SQLCon.Close();

                        lbxItems.Items.Clear();
                    }
                    catch (SqlException ex)
                    {
                        //Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Update the Product with the new quantity
                    try
                    {
                        Methods.SQLCon.Open();

                        commandUpdate = new SqlCommand($"UPDATE PRODUCT SET Quantity_in_stock = '{current + quantity}' " +
                                                       $"WHERE Product_id LIKE '{product}'", Methods.SQLCon);
                        adapter.UpdateCommand = commandUpdate;
                        adapter.UpdateCommand.ExecuteNonQuery();

                        Methods.SQLCon.Close();

                        lbxItems.Items.Clear();
                    }
                    catch (SqlException ex)
                    {
                        //Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    //Add all items remaining in the SO
                    try
                    {
                        Methods.SQLCon.Open();

                        SqlDataReader dataReader2;
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

                        while (dataReader2.Read())
                        {
                            string str = string.Format("{0} {1} {2} {3} {4}", dataReader2.GetValue(2), " * ", dataReader2.GetValue(4), " @ R", Convert.ToDouble(dataReader2.GetValue(3)));
                            lbxItems.Items.Add(str);
                            total += (Convert.ToDouble(dataReader2.GetValue(3)) * Convert.ToDouble(dataReader2.GetValue(2)));
                        }

                        lblTotalAmnt.Text = string.Format("{0} {1:0.00}", "R", Convert.ToDouble(total));


                        Methods.SQLCon.Close();
                    }
                    catch (SqlException ex)
                    {
                        //Error message
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    MessageBox.Show("Sales Order Item deleted successfully!");
                }
            }
        }
        #endregion
        #region Cell Click Action
        private void OnCellClick()
        {
            lbxItems.Items.Clear();

            int selector = (int)dgvSalesOrders.CurrentRow.Cells[0].Value;
            double total = 0;

            //Fill data grid with Sales Orders
            try
            {
                Methods.SQLCon.Open();

                SqlDataReader dataReader;
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
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
