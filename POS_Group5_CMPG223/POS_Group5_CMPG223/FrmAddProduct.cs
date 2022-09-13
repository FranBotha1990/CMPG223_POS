using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_Group5_CMPG223
{
    public partial class FrmAddProduct : Form
    {
        public FrmAddProduct()
        {
            InitializeComponent();
        }

        public string Product_ID = "";
        public string Description = "";
        public double Sell_price = 0.00;
        public int Quantity_in_stock = 0;

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product_ID = txtProductID.Text;
            Description = txtDescription.Text;
            Sell_price = double.Parse(txtSellingPrice.Text);
            this.Close();
        }
    }
}
