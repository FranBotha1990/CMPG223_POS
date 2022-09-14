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
        public FrmSuppliers()
        {
            InitializeComponent();
        }
        public void LoadGUI()
        {
            //Fore Colors
            btnDelete.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnUpdate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnAdd.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlSidebar.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FrmSuppliersUpdate frmSuppliersUpdate = new FrmSuppliersUpdate();
            frmSuppliersUpdate.LoadGUI();
            frmSuppliersUpdate.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Methods.SQLCon.Open();

                if (dgvSuppliers.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Please select a supplier to delete");
                }
                else if (dgvSuppliers.SelectedRows.Count > 1)
                {
                    MessageBox.Show("Please select only one supplier to delete");
                }
                else
                {
                    int id = Convert.ToInt32(dgvSuppliers.SelectedRows[0].Cells[0].Value);

                    string sql = $"DELETE from SUPPLIER where Supplier_ID = {id}";

                    MessageBox.Show("Supplier successfully deleted");
                }
            }
            catch
            {
                MessageBox.Show("Database cannot be found");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
        }
    }
}
