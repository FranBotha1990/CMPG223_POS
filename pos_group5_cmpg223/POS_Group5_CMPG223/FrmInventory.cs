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
                Methods.SQLCon.Open();
                SqlCommand cmd2 = new SqlCommand(@"SELECT DISTINCT Description from PRODUCT", Methods.SQLCon);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = cmd2;
                adapter.Fill(dataset, "PRODUCT");
                comboBox.DisplayMember = "PRODUCT";
                comboBox.ValueMember = "PRODUCT";
                comboBox.DataSource = dataset.Tables["PRODUCT"];
                Methods.SQLCon.Close();
            }
            catch
            {
                MessageBox.Show("SQL Error Occurred.");
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
                int quantity = 0;
                string sqlUpdate = $"UPDATE PRODUCT SET Quantity_in_stock = "+quantity+" WHERE Description = '{comboBox.Text}'";
                Methods.SQLCon.Open();
                SqlCommand cmdDelete = new SqlCommand(sqlUpdate, Methods.SQLCon);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmdDelete;
                adapter.DeleteCommand.ExecuteNonQuery();
                Methods.SQLCon.Close();
                MessageBox.Show(comboBox.Text + ", was updated successfully");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlDelete = $"DELETE FROM PRODUCT WHERE Description = '{comboBox.Text}'";
                Methods.SQLCon.Open();
                SqlCommand cmdDelete = new SqlCommand(sqlDelete, Methods.SQLCon);
                adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmdDelete;
                adapter.DeleteCommand.ExecuteNonQuery();
                Methods.SQLCon.Close();
                MessageBox.Show(comboBox.Text + ", was deleted successfully");
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
