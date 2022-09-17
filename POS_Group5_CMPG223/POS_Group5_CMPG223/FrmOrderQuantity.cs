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
    public partial class FrmOrderQuantity : Form
    {
        public int quantity = 0;
        public double price = 0;
        public bool bOk = false;
        bool bPrior = false;

        public void LoadGUI()
        {
            //Back Color
            this.BackColor = Methods.clrForms;
            //Fore Color
            lblPrice.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblQuantity.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
        }

        public FrmOrderQuantity(bool bPrior)
        {
            InitializeComponent();
            if (bPrior)
            {
                txtPrice.Visible = false;
                lblPrice.Visible = false;
                this.Width = 190;
                this.Height = 116;
                this.Text = "Quantity";
                btnOk.Left = 87;
                btnOk.Top = 50;
                this.bPrior = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            quantity = int.Parse(txtQuantity.Text);
            if (!bPrior)
                price = double.Parse(txtPrice.Text);
            bOk = true;
            this.Close();
        }
    }
}
