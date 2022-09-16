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
    public partial class FrmSalesQuantity : Form
    {
        public bool bOk = false;
        public int quantity = 0;

        public FrmSalesQuantity()
        {
            InitializeComponent();
        }

        public void LoadGUI()
        {
            this.BackColor = Methods.clrForms;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bOk = true;
            quantity = int.Parse(txtQuantity.Text);
            this.Close();
        }
    }
}
