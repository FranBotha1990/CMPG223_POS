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
        #region Variables
        public bool bOk = false;
        public int quantity = 0;
        #endregion
        #region Constructor
        public FrmSalesQuantity()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGUI()
        {
            this.BackColor = Methods.clrForms;
            btnOk.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
        }
        #endregion
        #region Ok Button
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quant))
            {
                bOk = true;
                quantity = int.Parse(txtQuantity.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Quantity should be an integer", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
