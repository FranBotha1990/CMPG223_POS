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
        #region Variables
        private int id;
        private string oldName;
        #endregion
        #region Constructor
        public FrmSuppliersUpdate()
        {
            InitializeComponent();
        }
        #endregion
        #region Update View
        public FrmSuppliersUpdate(int oldID)
        {
            InitializeComponent();
            id = oldID;
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            //Fore Colors
            btnUpdate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnCancel.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblCell.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblName.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblEmail.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            //pnlSidebar.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
        }
        #endregion

        #region Cancel Button
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
        #region Update Button
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

                            bool isValid = true;

                            while(reader.Read() && isValid)
                            {
                                oldName = reader.GetValue(1).ToString();

                                if (id != (int)reader.GetValue(0))
                                {
                                    if (name == reader.GetValue(1).ToString())
                                    {
                                        isValid = false;
                                        MessageBox.Show("Supplier name already exists");
                                    }
                                    else if (cell == reader.GetValue(2).ToString())
                                    {
                                        isValid = false;
                                        MessageBox.Show("Supplier cell number already exists");
                                    }
                                    else if (email == reader.GetValue(3).ToString())
                                    {
                                        isValid = false;
                                        MessageBox.Show("Supplier email already exists");
                                    }
                                }
                            }
                            if (isValid)
                            {
                                string title;

                                if (oldName == name)
                                {
                                    title = "Are you sure you want to update the record of '" + name + "'?";
                                }
                                else
                                {
                                    title = "Are you sure you want to update the record of '" + oldName + "' to that of '" + name + "'?";
                                }

                                DialogResult dialogResult = MessageBox.Show(title, "Update Supplier", MessageBoxButtons.YesNo);

                                if (dialogResult == DialogResult.Yes)
                                {
                                    string sqlUpdate = $"UPDATE SUPPLIER " +
                                        $"set Supplier_name = '{name}', Supplier_cell = '{cell}', Supplier_email = '{email}'" +
                                        $"where Supplier_ID = {id}";

                                    Methods.SQLCon.Close();
                                    Methods.SQLCon.Open();
                                    SqlDataAdapter adapter = new SqlDataAdapter();
                                    SqlCommand upCommand = new SqlCommand(sqlUpdate, Methods.SQLCon);
                                    adapter.UpdateCommand = upCommand;
                                    upCommand.ExecuteNonQuery();

                                    MessageBox.Show("Supplier successfully updated");
                                    this.Close();
                                }
                            }
                            reader.Close();
                        }
                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Database cannot be found");
            }
            finally
            {
                Methods.SQLCon.Close();
            }
        }
        #endregion
        #region Update Load
        private void FrmSuppliersUpdate_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = $"SELECT * from SUPPLIER where Supplier_ID = {id}";

                Methods.SQLCon.Open();
                SqlCommand command = new SqlCommand(sql, Methods.SQLCon);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    txtName.Text = reader.GetValue(1).ToString();
                    txtCell.Text = reader.GetValue(2).ToString();
                    txtEmail.Text = reader.GetValue(3).ToString();
                    oldName = reader.GetValue(1).ToString();
                }
                reader.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Database cannot be found");
            }
            finally
            {
                Methods.SQLCon.Close();
            }
        }
        #endregion
    }
}
