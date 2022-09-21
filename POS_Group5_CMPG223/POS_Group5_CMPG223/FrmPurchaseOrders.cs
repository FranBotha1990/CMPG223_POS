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
        SqlCommand command, commandDelete, commandUpdate;
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlDataAdapter adapterUpdate = new SqlDataAdapter();
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
            btnReceive.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotal.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotalAmnt.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlItems.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);

            btnReceive.Enabled = false;
            btnDelete.Enabled = false;
            btnRemove.Enabled = false;

            //Fill data grid with all PO's
            fillDataGrid();
            OnCellClick();
        }
        #endregion

        #region PO Click Action
        private void dgvPurchaseOrders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            OnCellClick();
        }
        #endregion
        #region Delete PO Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            int selector = (int)dgvPurchaseOrders.CurrentRow.Cells[0].Value;

            if (dgvPurchaseOrders.SelectedRows == null)
            {
                MessageBox.Show("There are no purchase orders to delete.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete Purchase Order number '" + selector + "'?", "Delete Purchase Order", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    //Clear the listbox and total label
                    lbxItems.Items.Clear();
                    lblTotalAmnt.Text = " ";

                    //Remove the PO Items
                    try
                    {
                        Methods.SQLCon.Open();

                        commandDelete = new SqlCommand($"DELETE FROM PURCHASE_ORDER_ITEM " +
                                                       $"WHERE Purchase_ID LIKE '{selector}'",
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

                    //Remove the PO
                    try
                    {
                        Methods.SQLCon.Open();

                        commandDelete = new SqlCommand($"DELETE FROM PURCHASE_ORDER " +
                                                $"WHERE Purchase_ID LIKE '{selector}'",
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

                    //Refresh the data grid
                    fillDataGrid();

                    MessageBox.Show("Purchase Order deleted successfully!");
                }
            }
        }
        #endregion
        #region Receive Button
        private void btnReceive_Click(object sender, EventArgs e)
        {
            int selector = (int)dgvPurchaseOrders.CurrentRow.Cells[0].Value;
            int product, current, quantity;
            bool itsTrue = true;

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to receive stock for Purchase Order number '" + selector + "'?", "Receive Purchase Order", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                lblTotalAmnt.Text = " ";

                //Adjust product quantity
                try
                {
                    Methods.SQLCon.Open();

                    SqlDataReader dataReader;
                    command = new SqlCommand($"SELECT POI.Purchase_ID, " +
                                                   "POI.Product_ID, " +
                                                   "POI.Quantity_purchased, " +
                                                   "POI.Cost_price, " +
                                                   "PR.Description, " +
                                                   "PR.Quantity_in_stock " +
                                                   "FROM PURCHASE_ORDER_ITEM AS POI " +
                                                   "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = POI.Product_ID " +
                                                   $"WHERE POI.Purchase_ID LIKE '{selector}'",
                                                   Methods.SQLCon);
                    dataReader = command.ExecuteReader();

                    while (dataReader.Read())
                    {
                        product = Convert.ToInt32(dataReader.GetValue(1));
                        quantity = Convert.ToInt32(dataReader.GetValue(2));
                        current = Convert.ToInt32(dataReader.GetValue(5));

                        Methods.SQLCon2.Open();

                        commandUpdate = new SqlCommand($"UPDATE PRODUCT SET Quantity_in_stock = '{current + quantity}' " +
                                                       $"WHERE Product_id LIKE '{product}'", Methods.SQLCon2);
                        adapter.UpdateCommand = commandUpdate;
                        adapter.UpdateCommand.ExecuteNonQuery();

                        Methods.SQLCon2.Close();
                    }
                    Methods.SQLCon.Close();

                    //Set PO to received = true
                    Methods.SQLCon.Open();

                    commandUpdate = new SqlCommand($"UPDATE PURCHASE_ORDER SET Received = '{itsTrue}', Receive_date = '{DateTime.Now.Date}' " +
                                                   $"WHERE Purchase_ID LIKE '{selector}'", Methods.SQLCon);
                    adapter.UpdateCommand = commandUpdate;
                    adapter.UpdateCommand.ExecuteNonQuery();

                    Methods.SQLCon.Close();
                }
                catch (SqlException ex)
                {
                    //Error message
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                LoadGUI();
            }
        }
        #endregion
        #region Remove Item Button
        private void btnRemove_Click(object sender, EventArgs e)
        {
            int selector = (int)dgvPurchaseOrders.CurrentRow.Cells[0].Value;
            string validator = (string)lbxItems.SelectedItem;
            int product = 0;
            int current = 0;
            int quantity = 0;

            if (lbxItems.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the items list.");
            }
            else
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this item from the Purchase Order?", "Remove Item from PO", MessageBoxButtons.YesNo);

                if (dialogResult == DialogResult.Yes)
                {
                    lbxItems.Items.Clear();

                    //Join the POItems and Product tables by Product_ID
                    try
                    {
                        Methods.SQLCon.Open();

                        SqlDataReader dataReader;
                        command = new SqlCommand($"SELECT POI.Purchase_ID, " +
                                                   "POI.Product_ID, " +
                                                   "POI.Quantity_purchased, " +
                                                   "POI.Cost_price, " +
                                                   "PR.Description, " +
                                                   "PR.Quantity_in_stock " +
                                                   "FROM PURCHASE_ORDER_ITEM AS POI " +
                                                   "LEFT JOIN PRODUCT AS PR ON PR.Product_ID = POI.Product_ID " +
                                                   $"WHERE POI.Purchase_ID LIKE '{selector}'",
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

                    //Remove the record based on PO ID and Product ID
                    try
                    {
                        Methods.SQLCon.Open();

                        commandDelete = new SqlCommand($"DELETE FROM PURCHASE_ORDER_ITEM " +
                                               $"WHERE Purchase_ID LIKE '{selector}' " +
                                               $"AND Product_ID LIKE '{product}'",
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

                    //Display all items remaining in the list
                    fillDataGrid();

                    MessageBox.Show("Purchase Order Item deleted successfully!");
                }
            }
        }
        #endregion

        #region PO Methods
        private void OnCellClick()
        {
            lbxItems.Items.Clear();
            int selector = (int)dgvPurchaseOrders.CurrentRow.Cells[0].Value;
            double total = 0;

            //Enable buttons based on receive value true/false
            try
            {
                Methods.SQLCon.Open();

                SqlDataReader dataReader;
                command = new SqlCommand($"SELECT Purchase_ID, " +
                                            "Received, " +
                                            "Receive_date " +
                                            "FROM PURCHASE_ORDER " +
                                            $"WHERE Purchase_ID LIKE '{selector}'",
                                            Methods.SQLCon);
                dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    if (Convert.ToBoolean(dataReader.GetValue(1)) == false)
                    {
                        btnReceive.Enabled = true;
                        btnDelete.Enabled = true;
                        btnRemove.Enabled = true;
                    }
                    else
                    {
                        btnReceive.Enabled = false;
                        btnDelete.Enabled = false;
                        btnRemove.Enabled = false;
                    }
                }

                Methods.SQLCon.Close();

            }
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Join the POItems and Product tables by Product_ID
            try
            {
                Methods.SQLCon.Open();

                SqlDataReader dataReader;
                command = new SqlCommand($"SELECT POI.Purchase_ID, " +
                                            "POI.Product_ID, " +
                                            "POI.Quantity_purchased, " +
                                            "POI.Cost_price, " +
                                            "PR.Description " +
                                            "FROM PURCHASE_ORDER_ITEM AS POI " +
                                            "INNER JOIN PRODUCT AS PR ON PR.Product_ID = POI.Product_ID " +
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
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void fillDataGrid()
        {
            //Fill data grid with all PO's
            try
            {
                Methods.SQLCon.Open();

                command = new SqlCommand(@"SELECT Purchase_ID AS 'PO Number', 
                                           SU.Supplier_ID AS 'Supplier ID', 
                                           Supplier_name AS 'Supplier Name', 
                                           Purchase_date AS 'Purchase Date',
                                           Received AS 'Recieved'
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
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
