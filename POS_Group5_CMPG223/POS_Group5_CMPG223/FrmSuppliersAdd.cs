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
    public partial class FrmSuppliersAdd : Form
    {
        public FrmSuppliersAdd()
        {
            InitializeComponent();
        }

        private void btnInsert_Click(object sender, EventArgs e)
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
                        MessageBox.Show("Please enter a valid supplier cell number");
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

                            string sqlSelect = $"SELECT * from SUPPLIER where Supplier_name = '{name}' " +
                                $"OR Supplier_cell = '{cell}' OR Supplier_email = '{email}'";
                            SqlCommand command = new SqlCommand(sqlSelect, Methods.SQLCon);
                            SqlDataReader reader = command.ExecuteReader();

                            if (reader.Read())
                            {
                                if (name == reader.GetValue(1).ToString())
                                {
                                    MessageBox.Show("Supplier name already exists");
                                }
                                else if (cell == reader.GetValue(2).ToString())
                                {
                                    MessageBox.Show("Supplier cell number already exists");
                                }
                                else if (email == reader.GetValue(3).ToString())
                                {
                                    MessageBox.Show("Supplier email already exists");
                                }
                            }
                            else
                            {
                                string title;

                                title = "Are you sure you want to add a record for '" + name + "'?";

                                DialogResult dialogResult = MessageBox.Show(title, "Add Supplier", MessageBoxButtons.YesNo);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    string sqlInsert = $"INSERT into SUPPLIERS values ('{name}', '{cell}', '{email}')";

                                    SqlDataAdapter adapter = new SqlDataAdapter();
                                    command = new SqlCommand(sqlInsert, Methods.SQLCon);
                                    adapter.InsertCommand = command;
                                    command.ExecuteNonQuery();

                                    MessageBox.Show("Supplier successfully added");
                                    this.Close();
                                }
                            }
                            reader.Close();
                        }
                    }
                }

                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error connecting to database");
            }
        }
    }
}
