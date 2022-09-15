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
    public partial class FrmSuppliersUpdate : Form
    {
        int id;
        public FrmSuppliersUpdate()
        {
            InitializeComponent();
        }

        public FrmSuppliersUpdate(int oldID)
        {
            InitializeComponent();
            id = oldID;
        }

        public void LoadGUI()
        {
            //Fore Colors
            btnUpdate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnCancel.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            //pnlSidebar.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Methods.SQLCon.Open();

                if (txtName.Text == "")
                {
                    MessageBox.Show("Please enter a supplier name");
                }
                else
                {
                    string name = txtName.Text;

                    if (txtCell.Text.Length != 10 || !int.TryParse(txtCell.Text, out int age))
                    {
                        MessageBox.Show("Please enter a valid supplier cellphone number");
                    }
                    else
                    {
                        string cell = txtCell.Text;

                        if (txtEmail.Text == "")
                        {
                            MessageBox.Show("Please enter a supplier email");
                        }
                        else
                        {
                            string email = txtEmail.Text;
                            string sql = $"INSERT into SUPPLIER values('{name}', '{cell}', '{email}')";
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            SqlCommand command = new SqlCommand(sql, Methods.SQLCon);
                            adapter.InsertCommand = command;
                            command.ExecuteNonQuery();

                            MessageBox.Show("Supplier successfully updated");
                        }
                    }
                }

                Methods.SQLCon.Close();

                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database cannot be found");
            }
        }

        private void FrmSuppliersUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = $"SELECT * from SUPPLIER where Supplier_ID = {id}";

                Methods.SQLCon.Open();

                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand command = new SqlCommand(sql, Methods.SQLCon);
                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    txtName.Text = reader.GetValue(1).ToString();
                    txtCell.Text = reader.GetValue(2).ToString();
                    txtEmail.Text = reader.GetValue(3).ToString();
                }
                reader.Close();

                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database cannot be found");
            }
        }
    }
}
