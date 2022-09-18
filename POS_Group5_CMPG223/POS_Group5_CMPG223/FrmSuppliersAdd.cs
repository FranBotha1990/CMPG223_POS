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
        #region Constructor
        public FrmSuppliersAdd()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            //Fore Colors
            btnInsert.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnCancel.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblCell.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblEmail.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblName.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            //pnlSidebar.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
        }
        #endregion

        #region Insert Button
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

                    if (txtCell.Text.Length != 10 || !int.TryParse(txtCell.Text, out int test))
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
                                reader.Close();
                                string title = "Are you sure you want to add a record for '" + name + "'?";

                                DialogResult dialogResult = MessageBox.Show(title, "Add Supplier", MessageBoxButtons.YesNo);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    string sqlInsert = $"INSERT into SUPPLIER values ('{name}', '{cell}', '{email}')";
                                    
                                    SqlDataAdapter adapter = new SqlDataAdapter();
                                    SqlCommand inCommand = new SqlCommand(sqlInsert, Methods.SQLCon);
                                    adapter.InsertCommand = inCommand;
                                    inCommand.ExecuteNonQuery();

                                    MessageBox.Show("Supplier successfully added");
                                    this.Close();
                                }
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Database Error: unable to add new supplier.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Methods.SQLCon.Close();
            }
        }
        #endregion
        #region Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
