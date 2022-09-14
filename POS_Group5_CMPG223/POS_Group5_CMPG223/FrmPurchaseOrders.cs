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
    public partial class FrmPurchaseOrders : Form
    {
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();

        public FrmPurchaseOrders()
        {
            InitializeComponent();
        }
        public void LoadGUI()
        {
            //Fore Colors
            btnDelete.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnUpdate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotal.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotalAmnt.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlItems.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);

            try
            {
                Methods.SQLCon.Open();

                command = new SqlCommand(@"SELECT Purchase_ID AS 'PO Number', 
                                           Supplier_name AS 'Supplier Name', 
                                           Purchase_date AS 'Purchase Date'
                                           FROM PURCHASE_ORDER AS T
                                           LEFT JOIN Supplier AS S ON S.Supplier_ID = T.Supplier_ID", 
                                           Methods.SQLCon);
                DataSet dataSet = new DataSet();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet, "PURCHASE_ORDER");
                dgvPurchaseOrders.DataSource = dataSet;
                dgvPurchaseOrders.DataMember = "PURCHASE_ORDER";

                lbxItems.Items.Add("Test");

                Methods.SQLCon.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void dgvPurchaseOrders_SelectionChanged(object sender, EventArgs e)
        {
            lbxItems.Items.Add("Test");
        }
    }
}
