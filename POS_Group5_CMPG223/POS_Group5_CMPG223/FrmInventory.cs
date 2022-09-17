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
            btnDiscard.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnStockTake.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
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
            catch (SqlException error)
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
    }
}
