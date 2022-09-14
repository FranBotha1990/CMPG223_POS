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
        public FrmSuppliersUpdate()
        {
            InitializeComponent();
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

                    if (txtCell.Text.Length != 10)
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
                            string sql = $"INSERT into SUPPLIER values('{name}', '{cell}', '{email}')";
                            SqlDataAdapter adapter = new SqlDataAdapter();
                            SqlCommand command = new SqlCommand(sql, Methods.SQLCon);
                            adapter.InsertCommand = command;
                            command.ExecuteNonQuery();
                        }
                    }
                }

                Methods.SQLCon.Close();
            }
            catch
            {
                MessageBox.Show("Database cannot be found");
            }
        }
    }
}
