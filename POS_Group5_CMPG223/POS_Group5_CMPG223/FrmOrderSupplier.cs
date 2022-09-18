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
    public partial class FrmOrderSupplier : Form
    {
        String[,] arrSuppliers;
        public int suppliers;
        public int supplierID;
        public bool bOk = false;

        public FrmOrderSupplier()
        {
            InitializeComponent();
        }

        public void LoadGUI()
        {
            //Back Color
            this.BackColor = Methods.clrForms;
            //Fore Color
            btnOk.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Count Suppliers
            try
            {
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM SUPPLIER", Methods.SQLCon);
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                suppliers = (int)command.ExecuteScalar();
                arrSuppliers = new String[suppliers, 2];
                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM SUPPLIER", Methods.SQLCon);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                for (int i = 0; i < suppliers; i++)
                {
                    reader.Read();
                    arrSuppliers[i, 0] = reader.GetValue(0).ToString();
                    arrSuppliers[i, 1] = reader.GetValue(1).ToString();
                    cbxSupplier.Items.Add(arrSuppliers[i, 1]);
                }
                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (cbxSupplier.SelectedIndex != -1)
            {
                supplierID = int.Parse(arrSuppliers[cbxSupplier.SelectedIndex, 0]);
                bOk = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("No supplier was selected", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Received
        }
    }
}
