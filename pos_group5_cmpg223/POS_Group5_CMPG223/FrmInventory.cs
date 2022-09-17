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
        String[,] arrProducts;
        int size = 0;
        SqlDataAdapter adapter;
        DataSet dataset;

        public FrmInventory()
        {
            InitializeComponent();
        }

        public void LoadGUI()
        {
            //Fore Colors
            btnBuyProduct.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string txt = txtSearch.Text;
            string sql = $"SELECT * FROM PRODUCT WHERE Description LIKE '%" + txt + "%' ";
            try
            {
                Methods.SQLCon.Open();
                dataset = new DataSet();
                adapter = new SqlDataAdapter(sql, Methods.SQLCon);

                adapter.Fill(dataset, "PRODUCT");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";
                Methods.SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = true;
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                int priceScroll = hScrollBar.Value;
                lblDisplay.Text = priceScroll.ToString();
                Methods.SQLCon.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM PRODUCT WHERE Sell_price<=" + priceScroll, Methods.SQLCon);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(dataset, "PRODUCT");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";

                Methods.SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void refresh()
        {
            comboBox.Items.Clear();
            try
            {
                Methods.SQLCon.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT", Methods.SQLCon);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset, "PRODUCT");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";
                Methods.SQLCon.Close();
            }
            catch 
            {
                MessageBox.Show("SQL Error Occurred.");
            }
            
            //Populate combo box
            try
            {
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM PRODUCT", Methods.SQLCon);
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                size = (int)command.ExecuteScalar();
                arrProducts = new String[size, 2];
                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM PRODUCT", Methods.SQLCon);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                for (int i = 0; i < size; i++)
                {
                    reader.Read();
                    arrProducts[i, 0] = reader.GetValue(0).ToString();
                    arrProducts[i, 1] = reader.GetValue(1).ToString();
                    comboBox.Items.Add(arrProducts[i, 1]);
                }
                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAddToDB_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtSellPrice.Text, out double price))
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
                    MessageBox.Show("Entry successfully entered.");
                    refresh();
                    txtSellPrice.Text = "";
                    txtDescription.Text = "";
                }

                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }                   
            }
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            groupBoxAdd.Visible = false;
            txtSellPrice.Text = "";
            txtDescription.Text = "";
        }

        private void btnBuyProduct_Click(object sender, EventArgs e)
        {
            //switch view to purchase orders
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                FrmSalesQuantity frmSalesQuantity = new FrmSalesQuantity();
                frmSalesQuantity.LoadGUI();
                frmSalesQuantity.ShowDialog();
                if (frmSalesQuantity.bOk)
                {
                    MessageBox.Show(comboBox.SelectedIndex.ToString());
                    int quantity = frmSalesQuantity.quantity;
                    string sqlUpdate = $"UPDATE PRODUCT SET Quantity_in_stock = {quantity} WHERE Product_ID = '{arrProducts[comboBox.SelectedIndex, 0]}'";
                    Methods.SQLCon.Open();
                    SqlCommand cmdDelete = new SqlCommand(sqlUpdate, Methods.SQLCon);
                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = cmdDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Methods.SQLCon.Close();
                    MessageBox.Show(comboBox.Text + ", was updated successfully");
                    refresh();
                }
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            bool flag = false;
            try
            {
                Methods.SQLCon.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM SALES_ORDER_ITEM", Methods.SQLCon);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                while(reader.Read() && !flag)
                {
                    if (reader.GetValue(1).ToString() == arrProducts[comboBox.SelectedIndex, 0])
                    {
                        flag = true;
                    }
                }
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                SqlCommand command2 = new SqlCommand($"SELECT * FROM PURCHASE_ORDER_ITEM", Methods.SQLCon);
                SqlDataReader reader2;
                reader2 = command2.ExecuteReader();
                while(reader2.Read() && !flag)
                {
                    if (reader2.GetValue(1).ToString() == arrProducts[comboBox.SelectedIndex, 0])
                    {
                        flag = true;
                    }
                }
                Methods.SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
            if (!flag)
            {
                try
                {
                    string sqlDelete = $"DELETE FROM PRODUCT WHERE Product_ID = '{arrProducts[comboBox.SelectedIndex, 0]}'";
                    Methods.SQLCon.Open();
                    SqlCommand cmdDelete = new SqlCommand(sqlDelete, Methods.SQLCon);
                    adapter = new SqlDataAdapter();
                    adapter.DeleteCommand = cmdDelete;
                    adapter.DeleteCommand.ExecuteNonQuery();
                    Methods.SQLCon.Close();
                    MessageBox.Show(comboBox.Text + ", was deleted successfully");
                    size--;
                }
                catch (SqlException error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("A sales order already contains this product, therefor it can not be deleted.");
            }
            refresh();
        }
    }
}
