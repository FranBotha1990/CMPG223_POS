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
        SqlConnection con = new SqlConnection(@"connection string copy paste");
        SqlDataAdapter adapter;
        DataSet dataset;

        public FrmInventory()
        {
            InitializeComponent();
        }

        public void LoadGUI()
        {
            this.BackColor = Methods.clrForms;
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
                con.Open();
                dataset = new DataSet();
                adapter = new SqlDataAdapter(sql, con);

                adapter.Fill(dataset, "PRODUCT");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmAddProduct myForm = new FrmAddProduct();
            myForm.ShowDialog();

            try
            {
                string sql = $"INSERT INTO PRODUCT VALUES('{myForm.Product_ID}','{myForm.Description}',{myForm.Sell_price},{myForm.Quantity_in_stock}) ";
                con.Open();
                adapter = new SqlDataAdapter();
                SqlCommand cmd = new SqlCommand(sql, con);
                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Entry successfully entered.");
                refresh();
            }

            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void hScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            try
            {
                int priceScroll = hScrollBar.Value;
                lblDisplay.Text = priceScroll.ToString();
                con.Open();
                SqlCommand cmd = new SqlCommand($"SELECT * FROM PRODUCT WHERE Age<=" + priceScroll, con);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();

                adapter.SelectCommand = cmd;
                adapter.Fill(dataset, "PRODUCT");

                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";

                con.Close();
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
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM PRODUCT", con);
                adapter = new SqlDataAdapter();
                dataset = new DataSet();
                adapter.SelectCommand = cmd;
                adapter.Fill(dataset, "PRODUCT");
                dataGridView1.DataSource = dataset;
                dataGridView1.DataMember = "PRODUCT";
                con.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show("SQL Error Occurred.");
            }
        }
    }
}
