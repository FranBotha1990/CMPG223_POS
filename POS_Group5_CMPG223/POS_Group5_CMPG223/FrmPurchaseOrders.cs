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
    public partial class FrmPurchaseOrders : Form
    {
        #region Variables
        SqlCommand command, commandDelete;
        SqlDataAdapter adapter = new SqlDataAdapter();
        #endregion
        #region Constructor
        public FrmPurchaseOrders()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            //Fore Colors
            btnDelete.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnRemove.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotal.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotalAmnt.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlItems.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);

            //Fill Purhcase Orders form with all PO's.
            try
            {
                Methods.SQLCon.Open();

                //Join PO and Supplier tables by Supplier_ID
                command = new SqlCommand(@"SELECT Purchase_ID AS 'PO Number', 
                                           Supplier_name AS 'Supplier Name', 
                                           Purchase_date AS 'Purchase Date'
                                           FROM PURCHASE_ORDER AS PO
                                           LEFT JOIN SUPPLIER AS SU ON SU.Supplier_ID = PO.Supplier_ID", 
                                           Methods.SQLCon);
                DataSet dataSet = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "PURCHASE_ORDER");
                dgvPurchaseOrders.DataSource = dataSet;
                dgvPurchaseOrders.DataMember = "PURCHASE_ORDER";

                Methods.SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion

        #region PO Click Action
        private void dgvPurchaseOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbxItems.Items.Clear();
                //Use the selected row, first cell
                int selector = (int)dgvPurchaseOrders.CurrentRow.Cells[0].Value;
                double total = 0;

                Methods.SQLCon.Open();

                SqlDataReader dataReader;
                //Join the POItems and Product tables by Product_ID
                command = new SqlCommand($"SELECT POI.Purchase_ID, " + 
                                           "POI.Product_ID, " +
                                           "POI.Quantity_purchased, " +
                                           "POI.Cost_price, " +
                                           "PR.Description " +
                                           "FROM PURCHASE_ORDER_ITEM AS POI " +
                                           "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = POI.Product_ID " +
                                           $"WHERE POI.Purchase_ID LIKE '{selector}'",
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
        #region Delete PO Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvPurchaseOrders.SelectedRows == null)
            {
                MessageBox.Show("There are no purchase orders to delete.");
            }
            else
            {
                try
                {
                    //Use the selected row, first cell
                    int selector = (int)dgvPurchaseOrders.CurrentRow.Cells[0].Value;

                    //Remove the PO Items first
                    Methods.SQLCon.Open();
                    commandDelete = new SqlCommand($"DELETE FROM PURCHASE_ORDER_ITEM " +
                                           $"WHERE Purchase_ID LIKE '{selector}'",
                                           Methods.SQLCon);
                    adapter.DeleteCommand = commandDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Methods.SQLCon.Close();

                    //Clear the listbox and total label
                    lbxItems.Items.Clear();
                    lblTotalAmnt.Text = " ";

                    //Remove the PO
                    Methods.SQLCon.Open();
                    commandDelete = new SqlCommand($"DELETE FROM PURCHASE_ORDER " +
                                           $"WHERE Purchase_ID LIKE '{selector}'",
                                           Methods.SQLCon);
                    adapter.DeleteCommand = commandDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();

                    //Refresh the data grid
                    Methods.SQLCon.Close();
                    //Join PO and Supplier tables by Supplier_ID
                    command = new SqlCommand(@"SELECT Purchase_ID AS 'PO Number', 
                                           Supplier_name AS 'Supplier Name', 
                                           Purchase_date AS 'Purchase Date'
                                           FROM PURCHASE_ORDER AS PO
                                           LEFT JOIN SUPPLIER AS SU ON SU.Supplier_ID = PO.Supplier_ID",
                                               Methods.SQLCon);
                    DataSet dataSet = new DataSet();
                    adapter.SelectCommand = command;
                    adapter.Fill(dataSet, "PURCHASE_ORDER");
                    dgvPurchaseOrders.DataSource = dataSet;
                    dgvPurchaseOrders.DataMember = "PURCHASE_ORDER";
                    Methods.SQLCon.Close();

                    MessageBox.Show("Purchase Order deleted successfully!");
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }

        private void lbxItems_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion

        #region Remove Items Button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                //Use the selected row, first cell
                int selector = (int)dgvPurchaseOrders.CurrentRow.Cells[0].Value;
                string validator = (string)lbxItems.SelectedItem;
                int product = 0;
                double total = 0;

                if (lbxItems.SelectedItem == null)
                {
                    MessageBox.Show("Please select an item from the items list.");
                }
                else
                {
                    Methods.SQLCon.Open();
                    SqlDataReader dataReader;
                    //Join the POItems and Product tables by Product_ID
                    command = new SqlCommand($"SELECT POI.Purchase_ID, " +
                                               "POI.Product_ID, " +
                                               "POI.Quantity_purchased, " +
                                               "POI.Cost_price, " +
                                               "PR.Description " +
                                               "FROM PURCHASE_ORDER_ITEM AS POI " +
                                               "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = POI.Product_ID " +
                                               $"WHERE POI.Purchase_ID LIKE '{selector}'",
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

                    //Remove the record based on PO ID and Product ID
                    Methods.SQLCon.Open();
                    commandDelete = new SqlCommand($"DELETE FROM PURCHASE_ORDER_ITEM " +
                                           $"WHERE Purchase_ID LIKE '{selector}' " +
                                           $"AND Product_ID LIKE '{product}'",
                                           Methods.SQLCon);
                    adapter.DeleteCommand = commandDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Methods.SQLCon.Close();

                    lbxItems.Items.Clear();

                    Methods.SQLCon.Open();
                    SqlDataReader dataReader2;
                    //Join the POItems and Product tables by Product_ID
                    command = new SqlCommand($"SELECT POI.Purchase_ID, " +
                                               "POI.Product_ID, " +
                                               "POI.Quantity_purchased, " +
                                               "POI.Cost_price, " +
                                               "PR.Description " +
                                               "FROM PURCHASE_ORDER_ITEM AS POI " +
                                               "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = POI.Product_ID " +
                                               $"WHERE POI.Purchase_ID LIKE '{selector}'",
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

                    MessageBox.Show("Purchase Order Item deleted successfully!");
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
        #endregion
    }
}
