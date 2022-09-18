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
            btnOk.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
        }

        public FrmOrderQuantity(bool bPrior)
        {
            InitializeComponent();
            if (bPrior)
            {
                txtQuantity.Top = 12;
                txtQuantity.Left = 12;
                txtPrice.Visible = false;
                lblPrice.Visible = false;
                lblQuantity.Visible = false;
                this.Width = 266;
                this.Height = 132;
                this.Text = "Quantity";
                this.bPrior = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantity.Text, out int quant))
            {
                quantity = int.Parse(txtQuantity.Text);
                if (!bPrior)
                {
                    if (double.TryParse(txtPrice.Text, out double pri))
                    {
                        price = double.Parse(txtPrice.Text);
                        bOk = true;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Price is invalid", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    bOk = true;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Quantity is invalid", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
