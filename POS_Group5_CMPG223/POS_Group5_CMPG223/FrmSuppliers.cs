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
    public partial class FrmSuppliers : Form
    {
        #region Constructor
        public FrmSuppliers()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            //Fore Colors
            btnDelete.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnUpdate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnAdd.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            gbxFilter.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblFilter.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblFilterCell.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblFilterEmail.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlSidebar.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);

            txtFilter.Focus();
        }
        #endregion

        #region Update Supplier
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvSuppliers.SelectedRows.Count < 0)
            {
                MessageBox.Show("Please select a supplier to update");
            }
            else if (dgvSuppliers.SelectedRows.Count > 1)
            {
                MessageBox.Show("Please select only one supplier to update");
            }
            else
            {
                int id = (int)dgvSuppliers.CurrentRow.Cells[0].Value;

                FrmSuppliersUpdate frmSuppliersUpdate = new FrmSuppliersUpdate(id);
                frmSuppliersUpdate.LoadGUI();
                frmSuppliersUpdate.ShowDialog();
                DisplayData($"SELECT * from SUPPLIER");
            }
        }
        #endregion
        #region Delete Supplier
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Methods.SQLCon.Open();

                int id = (int)dgvSuppliers.CurrentRow.Cells[0].Value;
                string name = dgvSuppliers.CurrentRow.Cells[1].Value.ToString();

                string sqlSelect = $"SELECT * from PURCHASE_ORDER where Supplier_ID = '{id}'";
                SqlCommand command = new SqlCommand(sqlSelect, Methods.SQLCon);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Supplier cannot be deleted as it is referenced in a purchase order");
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete the record of '" + name + "'?", "Delete Supplier", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        string sqlDelete = $"DELETE from SUPPLIER where Supplier_ID = {id}";

                        Methods.SQLCon.Close();
                        Methods.SQLCon.Open();
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        SqlCommand delCommand = new SqlCommand(sqlDelete, Methods.SQLCon);
                        adapter.DeleteCommand = delCommand;
                        delCommand.ExecuteNonQuery();

                        MessageBox.Show("Supplier successfully deleted");
                    }
                }
                reader.Close();
                Methods.SQLCon.Close();
                DisplayData($"SELECT * from SUPPLIER");
            }
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Database Error: Unable to delete supplier.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Methods.SQLCon.Close();
            }
        }
        #endregion
        #region Add Supplier
        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSuppliersAdd frmSuppliersAdd = new FrmSuppliersAdd();
            frmSuppliersAdd.LoadGUI();
            frmSuppliersAdd.ShowDialog();
            DisplayData($"SELECT * from SUPPLIER");
        }
        #endregion

        #region Load Suppliers
        private void FrmSuppliers_Load(object sender, EventArgs e)
        {
            DisplayData($"SELECT Supplier_ID AS 'Supplier ID', Supplier_name AS 'Supplier Name', Supplier_cell AS 'Supplier Cell', Supplier_email AS 'Supplier Email' from SUPPLIER");
        }
        #endregion
        #region Display Data
        private void DisplayData(string sql)
        {
            try
            {
                DataSet ds = new DataSet();
                SqlDataAdapter adapter = new SqlDataAdapter();

                Methods.SQLCon.Open();

                SqlCommand command = new SqlCommand(sql, Methods.SQLCon);
                adapter.SelectCommand = command;
                adapter.Fill(ds, "SUPPLIER");
                dgvSuppliers.DataSource = ds;
                dgvSuppliers.DataMember = "SUPPLIER";

            }
            catch (SqlException ex)
            {
                //Error message
                MessageBox.Show(ex.Message, "Database Error: Unable to display data.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Methods.SQLCon.Close();
            }
        }
        #endregion

        #region Filter Name
        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (!txtFilterCell.Focused)
            {
                txtFilterCell.Text = "";
            }
            if (!txtFilterEmail.Focused)
            {
                txtFilterEmail.Text = "";
            }
            string name = txtFilter.Text;
            DisplayData($"SELECT * from SUPPLIER where Supplier_Name LIKE '%{name}%'");
        }
        #endregion
        #region Filter Email
        private void txtFilterEmail_TextChanged(object sender, EventArgs e)
        {
            if (!txtFilterCell.Focused)
            {
                txtFilterCell.Text = "";
            }
            if (!txtFilter.Focused)
            {
                txtFilter.Text = "";
            }
            string email = txtFilterEmail.Text;
            DisplayData($"SELECT * from SUPPLIER where Supplier_Email LIKE '%{email}%'");
        }
        #endregion
        #region Filter Cell
        private void txtFilterCell_TextChanged(object sender, EventArgs e)
        {
            if (!txtFilter.Focused)
            {
                txtFilter.Text = "";
            }
            if (!txtFilterEmail.Focused)
            {
                txtFilterEmail.Text = "";
            }
            string cell = txtFilterCell.Text;
            DisplayData($"SELECT * from SUPPLIER where Supplier_Cell LIKE '%{cell}%'");
        }
        #endregion
    }
}
