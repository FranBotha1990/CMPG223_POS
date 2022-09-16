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
    public partial class FrmOrder : Form
    {
        #region Variables
        private int buttonsToLoad = 0;
        private int buttonsLoaded = 0;
        private Button[] posButtons;
        private String[,] arrOrder;
        private Boolean bFirstLoad = true;
        private int orderItemCount = 0;
        private double orderTotal = 0;
        SqlDataAdapter adapter;
        DataSet dataset;
        #endregion

        public FrmOrder()
        {
            InitializeComponent();
        }
        public void LoadGUI()
        {
            //Fore Colors
            btnDeleteItem.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            btnPlaceOrder.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotal.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            lblTotalAmnt.ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
            //Back Colors
            this.BackColor = Methods.clrForms;
            pnlOrder.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
            pnlOrderButtons.BackColor = Methods.ChangeColorBrightness(Methods.clrMenu, 0.05);
            //Buttons
            try
            {
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM PRODUCT", Methods.SQLCon);
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                buttonsToLoad = (int)command.ExecuteScalar();
                posButtons = new Button[buttonsToLoad];
                arrOrder = new string[buttonsToLoad, 4];
                LoadButtons(buttonsToLoad);
                LocateButtons(buttonsLoaded);
                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region POS Buttons
        public void LoadButtons(int ButtonAmnt)
        {
            try
            {
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                SqlCommand command = new SqlCommand($"SELECT * FROM PRODUCT", Methods.SQLCon);
                SqlDataReader reader;
                reader = command.ExecuteReader();
                for (int i = 1; i <= ButtonAmnt; i++)
                {
                    reader.Read();
                    buttonsLoaded++;
                    posButtons[buttonsLoaded - 1] = new Button();
                    posButtons[buttonsLoaded - 1].Height = 100;
                    posButtons[buttonsLoaded - 1].Width = 150;
                    posButtons[buttonsLoaded - 1].ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
                    posButtons[buttonsLoaded - 1].Text = reader.GetValue(1).ToString() + "\nR" + Convert.ToDouble(reader.GetValue(2)).ToString();
                    posButtons[buttonsLoaded - 1].Parent = pnlForm;
                    pnlForm.Controls.Add(posButtons[buttonsLoaded - 1]);
                    posButtons[buttonsLoaded - 1].Name = reader.GetValue(0).ToString();
                    posButtons[buttonsLoaded - 1].Click += new EventHandler(OrderButton_Click);
                }
                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LocateButtons(int ButtonAmnt)
        {
            pnlForm.VerticalScroll.Value = 0;
            pnlForm.HorizontalScroll.Value = 0;
            int buttonsLocated = 0;
            double verticleLines = 1.00 * ButtonAmnt / (pnlForm.Size.Width / (150 + 6));
            double horisontalLines = 1.00 * pnlForm.Size.Width / (150 + 6);
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
            pnlForm.AutoScroll = true;
        }

        private void OrderButton_Click(object sender, EventArgs e)
        {
            FrmSalesQuantity frmSalesQuantity = new FrmSalesQuantity();
            frmSalesQuantity.LoadGUI();
            frmSalesQuantity.ShowDialog();
            int quantity = frmSalesQuantity.quantity;
            if (frmSalesQuantity.bOk)
            {
                int i;
                bool bExists = false;
                for (i = 0; i < buttonsToLoad; i++)
                {
                    if ((sender as Button).Name.Equals(arrOrder[i, 0]))
                    {
                        bExists = true;
                        break;
                    }
                }
                if (!bExists)
                {
                    try
                    {
                        Methods.SQLCon.Close();
                        Methods.SQLCon.Open();
                        SqlCommand command = new SqlCommand($"SELECT * FROM PRODUCT WHERE Product_ID = {(sender as Button).Name}", Methods.SQLCon);
                        SqlDataReader reader;
                        reader = command.ExecuteReader();
                        reader.Read();
                        arrOrder[orderItemCount, 0] = reader.GetValue(0).ToString();
                        arrOrder[orderItemCount, 1] = quantity.ToString();
                        arrOrder[orderItemCount, 2] = reader.GetValue(1).ToString();
                        arrOrder[orderItemCount, 3] = reader.GetValue(2).ToString();
                        orderItemCount++;
                        Methods.SQLCon.Close();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    arrOrder[i, 1] = (int.Parse(arrOrder[i, 1]) + quantity).ToString();
                }
                loadOrder();
            }
        }

        private void loadOrder()
        {
            lbxOrder.Items.Clear();
            orderTotal = 0;
            for (int y = 0; y < orderItemCount; y++)
            {
                string str = string.Format("{0} {1} {2} {3} {4}", arrOrder[y, 1], " * ", arrOrder[y, 2], " @ R ", Convert.ToDouble(Convert.ToDouble(arrOrder[y, 3]) * int.Parse(arrOrder[y, 1])));
                orderTotal += Convert.ToDouble(Convert.ToDouble(arrOrder[y, 3]) * int.Parse(arrOrder[y, 1]));
                lbxOrder.Items.Add(str);
            }
            lblTotalAmnt.Text = "R " + orderTotal.ToString();
        }
        #endregion

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            for (int i = lbxOrder.SelectedIndex; i < orderItemCount; i++)
            {
                arrOrder[i, 0] = arrOrder[i + 1, 0];
                arrOrder[i, 1] = arrOrder[i + 1, 1];
                arrOrder[i, 2] = arrOrder[i + 1, 2];
                arrOrder[i, 3] = arrOrder[i + 1, 3];
            }
            orderItemCount--;
            loadOrder();
        }

        private void FrmOrder_SizeChanged(object sender, EventArgs e)
        {

        }

        private void pnlForm_SizeChanged(object sender, EventArgs e)
        {
            if (!bFirstLoad)
            {
                LocateButtons(buttonsLoaded);
            }
            bFirstLoad = false;
        }
    }
}
