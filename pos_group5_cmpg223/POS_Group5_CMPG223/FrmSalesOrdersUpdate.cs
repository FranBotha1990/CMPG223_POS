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
    public partial class FrmSalesOrdersUpdate : Form
    {
        public FrmSalesOrdersUpdate()
        {
            InitializeComponent();
        }

        public void LoadGUI()
        {
            //Fore Color
            btnDeleteItem.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnUpdateBill.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnUpdateItem.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblDate.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Color
            this.BackColor = Methods.clrForms;
        }
    }
}
