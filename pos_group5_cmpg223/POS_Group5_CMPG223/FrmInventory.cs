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
using FontAwesome.Sharp;

namespace POS_Group5_CMPG223
{
    public partial class FrmInventory : Form
    {
        #region Variables
        int selector = -1;
        SqlDataAdapter adapter;
        DataSet dataset;
        #endregion
        #region Constructor
        public FrmInventory()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            //Fore Colors
            btnAddToDB.ForeColor = Color.Black;
            btnBack.ForeColor = Color.Black;
            lblSearch.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblScroll.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblDisplay.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            groupBoxAdd.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnAddProduct.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnUpdate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnDelete.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblDisplay.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlItems.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
            lblDisplay.Text = "";
            hScrollBar.Value = 0;
            hScrollBar.Minimum = 0;
            hScrollBar.Maximum = 1000;
            hScrollBar.LargeChange = 20;
            hScrollBar.SmallChange = 1;
            groupBoxAdd.Visible = false;
            refresh();
        }
        #endregion

        #region Search Box Text Change
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string sql = $"SELECT Product_ID AS 'Product ID', " +
                          "Description AS 'Name', " +
                          "Sell_price AS 'Sell Price', " +
                          "Quantity_in_stock AS 'Qty.' " +
                         $"FROM PRODUCT WHERE Description LIKE '%" + txt + "%' ";
            try
            {
                Methods.SQLCon.Open();
                dataset = new DataSet();
                adapter = new SqlDataAdapter(sql, Methods.SQLCon);

                adapter.Fill(dataset, "PRODUCT");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";
                dataGridView1.Columns["Sell Price"].DefaultCellStyle.Format = "c";
                Methods.SQLCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Add Product
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (groupBoxAdd.Visible)
            {
                groupBoxAdd.Visible = false;
                btnAddProduct.Focus();
            }
            else
            {
                txtDescription.Focus();
                groupBoxAdd.Visible = true;
            }
        }
        #endregion
        #region Search Scroll Bar Changed
        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                int priceScroll = hScrollBar.Value;
                lblDisplay.Text = priceScroll.ToString();
                Methods.SQLCon.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Product_ID AS 'Product ID', " +
                                                 "Description AS 'Name', " +
                                                 "Sell_price AS 'Sell Price', " +
                                                 "Quantity_in_stock AS 'Qty.' " +
                                                $"FROM PRODUCT WHERE Sell_price<=" + priceScroll, Methods.SQLCon);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(dataset, "PRODUCT");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";
                dataGridView1.Columns["Sell Price"].DefaultCellStyle.Format = "c";

                Methods.SQLCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Fill Method
        private void refresh()
        {
            try
            {
                Methods.SQLCon.Open();
                SqlCommand cmd = new SqlCommand($"SELECT Product_ID AS 'Product ID', " +
                                                 "Description AS 'Name', " +
                                                 "Sell_price AS 'Sell Price', " +
                                                 "Quantity_in_stock AS 'Qty.' " +
                                                $"FROM PRODUCT", Methods.SQLCon);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset, "PRODUCT");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";
                dataGridView1.Columns["Sell Price"].DefaultCellStyle.Format = "c";
                Methods.SQLCon.Close();
            }
            catch 
            {
                MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Add to Database
        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSellPrice.Text, out double price) && txtDescription.Text != "")
            {
                try
                {
                    string sql = $"INSERT INTO PRODUCT VALUES('{txtDescription.Text}',{price},{0}) ";
                    Methods.SQLCon.Open();
                    adapter = new SqlDataAdapter();
                    SqlCommand cmd = new SqlCommand(sql, Methods.SQLCon);
                    adapter.InsertCommand = cmd;
                    adapter.InsertCommand.ExecuteNonQuery();
                    Methods.SQLCon.Close();
                    MessageBox.Show("Entry successfully entered", "Product Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    refresh();
                    txtSellPrice.Text = "";
                    txtDescription.Text = "";
                }

                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }                   
            }
            else
            {
                MessageBox.Show("Name or price is invalid", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        #endregion
        #region Back Button
        private void btnBack_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            txtSellPrice.Text = "";
            txtDescription.Text = "";
            btnAddProduct.Focus();
        }
        #endregion
        #region Update Button
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            selector = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if (selector != -1)
            {
                try
                {
                    FrmSalesQuantity frmSalesQuantity = new FrmSalesQuantity();
                    frmSalesQuantity.LoadGUI();
                    frmSalesQuantity.ShowDialog();
                    if (frmSalesQuantity.bOk)
                    {
                        int quantity = frmSalesQuantity.quantity;
                        string sqlUpdate = $"UPDATE PRODUCT SET Quantity_in_stock = {quantity} WHERE Product_ID = '{selector}'";
                        Methods.SQLCon.Open();
                        SqlCommand cmdDelete = new SqlCommand(sqlUpdate, Methods.SQLCon);
                        adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = cmdDelete;
                        adapter.DeleteCommand.ExecuteNonQuery();
                        Methods.SQLCon.Close();
                        refresh();
                        MessageBox.Show("Entry successfully updated", "Product Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (SqlException)
                {
                    MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please select a product", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Delete Button
        private void btnDelete_Click(object sender, EventArgs e)
        {
            selector = (int)dataGridView1.CurrentRow.Cells[0].Value;
            if (selector != -1)
            {
                bool flag = false;
                try
                {
                    Methods.SQLCon.Open();
                    SqlCommand command = new SqlCommand($"SELECT * FROM SALES_ORDER_ITEM", Methods.SQLCon);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read() && !flag)
                    {
                        if (reader.GetValue(1).ToString() == selector.ToString())
                        {
                            flag = true;
                        }
                    }
                    Methods.SQLCon.Close();
                    Methods.SQLCon.Open();
                    SqlCommand command2 = new SqlCommand($"SELECT * FROM PURCHASE_ORDER_ITEM", Methods.SQLCon);
                    SqlDataReader reader2;
                    reader2 = command2.ExecuteReader();
                    while (reader2.Read() && !flag)
                    {
                        if (reader2.GetValue(1).ToString() == selector.ToString())
                        {
                            flag = true;
                        }
                    }
                    Methods.SQLCon.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (!flag)
                {
                    try
                    {
                        string sqlDelete = $"DELETE FROM PRODUCT WHERE Product_ID = '{selector}'";
                        Methods.SQLCon.Open();
                        SqlCommand cmdDelete = new SqlCommand(sqlDelete, Methods.SQLCon);
                        adapter = new SqlDataAdapter();
                        adapter.DeleteCommand = cmdDelete;
                        adapter.DeleteCommand.ExecuteNonQuery();
                        Methods.SQLCon.Close();
                        MessageBox.Show("Entry successfully deleted", "Record Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Product cannot be deleted as it is referenced in an order", "Reference Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                refresh();
            }
            else
            {
                MessageBox.Show("Please select a product", "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
