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
    public partial class FrmSales : Form
    {
        #region Variables
        private int buttonsLoaded = 0;
        private Button[] posButtons = new Button[100];
        private Boolean bFirstLoad = true;
        #endregion
        #region Constructor
        public FrmSales()
        {
            InitializeComponent();
        }
        #endregion

        #region LoadGUI
        public void LoadGUI()
        {
            //Fore Colors
            btnDeleteItem.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnConfirmBill.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotal.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotalAmnt.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlBill.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
            pnlBillButtons.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
            //Misc
            LoadButtons(100);
            LocateButtons(buttonsLoaded);
        }
        #endregion

        #region POS Buttons
        public void LoadButtons(int ButtonAmnt)
        {
            for (int i = 1; i <= ButtonAmnt; i++)
            {
                buttonsLoaded++;
                posButtons[buttonsLoaded-1] = new Button();
                posButtons[buttonsLoaded-1].Height = 100;
                posButtons[buttonsLoaded-1].Width = 150;
                posButtons[buttonsLoaded-1].ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
                posButtons[buttonsLoaded-1].Text = "Item " + buttonsLoaded.ToString();
                posButtons[buttonsLoaded-1].Parent = pnlButtons;
                pnlButtons.Controls.Add(posButtons[buttonsLoaded-1]);
                posButtons[buttonsLoaded-1].Name = buttonsLoaded.ToString();
            }
        }

        public void LocateButtons(int ButtonAmnt)
        {
            pnlButtons.VerticalScroll.Value = 0;
            pnlButtons.HorizontalScroll.Value = 0;
            int buttonsLocated = 0;
            double verticleLines = 1.00 * ButtonAmnt / (pnlButtons.Size.Width / (150 + 6));
            double horisontalLines = 1.00 * pnlButtons.Size.Width / (150 + 6);
            for (int y = 1; y <= Math.Ceiling(verticleLines); y++)
            {
                for (int x = 1; x <= Math.Floor(horisontalLines); x++)
                {
                    if (buttonsLocated < ButtonAmnt)
                    {
                        buttonsLocated++;
                        posButtons[buttonsLocated - 1].Location = new Point((((x - 1) * 150) + (x) * 6), (((y - 1) * 100) + (y) * 6));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pnlButtons.AutoScroll = true;
        }
        #endregion
        #region Pannel Size Change
        private void pnlButtons_SizeChanged(object sender, EventArgs e)
        {
            if (!bFirstLoad)
            {
                LocateButtons(buttonsLoaded);
            }
            bFirstLoad = false;
        }
        #endregion
    }
}
