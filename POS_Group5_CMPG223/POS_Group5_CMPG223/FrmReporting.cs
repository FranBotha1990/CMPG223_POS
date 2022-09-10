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
    public partial class FrmReporting : Form
    {
        public FrmReporting()
        {
            InitializeComponent();
        }
        public void LoadGUI()
        {
            this.BackColor = Methods.clrForms;
        }
    }
}
