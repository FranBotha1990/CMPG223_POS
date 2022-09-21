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
    public partial class FrmHelp : Form
    {
        #region Constructor
        public FrmHelp()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
        public void LoadGui()
        {
            //Fore Colors

            //Back Colors
            this.BackColor = Methods.clrForms;

        }
        #endregion
    }
}
