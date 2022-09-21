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
        private Button[] orderButtons;
        private String[,] arrOrder;
        private Boolean bFirstLoad = true;
        private int orderItemCount = 0;
        private double orderTotal = 0;
        SqlDataAdapter adapter;
        DataSet dataset;
        #endregion
        #region Constructor
        public FrmOrder()
        {
            InitializeComponent();
        }
        #endregion
        #region LoadGUI
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
                orderButtons = new Button[buttonsToLoad];
                arrOrder = new string[buttonsToLoad, 4];
                LoadButtons(buttonsToLoad);
                LocateButtons(buttonsLoaded);
                Methods.SQLCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        #region Panel Size Change
        private void pnlForm_SizeChanged(object sender, EventArgs e)
        {
            if (!bFirstLoad)
            {
                LocateButtons(buttonsLoaded);
            }
            bFirstLoad = false;
        }
        #endregion

        #region Order Buttons
        public void LoadButtons(int ButtonAmnt)
        {
            //Load Buttons
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
                    orderButtons[buttonsLoaded - 1] = new Button();
                    orderButtons[buttonsLoaded - 1].Height = 100;
                    orderButtons[buttonsLoaded - 1].Width = 150;
                    orderButtons[buttonsLoaded - 1].ForeColor = Methods.DetermineFrontColor(Methods.clrMenu);
                    orderButtons[buttonsLoaded - 1].Text = reader.GetValue(1).ToString()+"\nStock: "+reader.GetValue(3).ToString();
                    orderButtons[buttonsLoaded - 1].Parent = pnlForm;
                    pnlForm.Controls.Add(orderButtons[buttonsLoaded - 1]);
                    orderButtons[buttonsLoaded - 1].Name = reader.GetValue(0).ToString();
                    orderButtons[buttonsLoaded - 1].Click += new EventHandler(OrderButton_Click);
                }
                Methods.SQLCon.Close();
            }
            catch (SqlException)
            {
                MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LocateButtons(int ButtonAmnt)
        {
            //Locate Buttons
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
                        orderButtons[buttonsLocated - 1].Location = new Point((((x - 1) * 150) + (x) * 6), (((y - 1) * 100) + (y) * 6));
                    }
                    else
                    {
                        break;
                    }
                }
            }
            pnlForm.AutoScroll = true;
        }
        //Order Button
        private void OrderButton_Click(object sender, EventArgs e)
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
            FrmOrderQuantity frmOrderQuantity = new FrmOrderQuantity(bExists);
            frmOrderQuantity.LoadGUI();
            frmOrderQuantity.ShowDialog();
            int quantity = frmOrderQuantity.quantity;
            double price = frmOrderQuantity.price;
            if (frmOrderQuantity.bOk)
            {
                if (!bExists)
                {
                    try
                    {
                        //Assign to Array
                        Methods.SQLCon.Close();
                        Methods.SQLCon.Open();
                        SqlCommand command = new SqlCommand($"SELECT * FROM PRODUCT WHERE Product_ID = {(sender as Button).Name}", Methods.SQLCon);
                        SqlDataReader reader;
                        reader = command.ExecuteReader();
                        reader.Read();
                        arrOrder[orderItemCount, 0] = reader.GetValue(0).ToString();    //ID
                        arrOrder[orderItemCount, 1] = quantity.ToString();              //Quantity
                        arrOrder[orderItemCount, 2] = reader.GetValue(1).ToString();    //Desc
                        arrOrder[orderItemCount, 3] = price.ToString();                 //Price
                        orderItemCount++;
                        Methods.SQLCon.Close();
                    }
                    catch (SqlException)
                    {
                        MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Increase Quantity
                    arrOrder[i, 1] = (int.Parse(arrOrder[i, 1]) + quantity).ToString();
                }
                loadOrder();
            }
        }

        private void loadOrder()
        {
            //Print Array onto ListBox
            lbxOrder.Items.Clear();
            orderTotal = 0;
            for (int y = 0; y < orderItemCount; y++)
            {
                string str = string.Format("{0} {1} {2} {3} {4}", arrOrder[y, 1], " x ", arrOrder[y, 2], " @ R ", Convert.ToDouble(arrOrder[y, 3]));
                orderTotal += Convert.ToDouble(Convert.ToDouble(arrOrder[y, 3]) * int.Parse(arrOrder[y, 1]));
                lbxOrder.Items.Add(str);
            }
            lblTotalAmnt.Text = "R " + orderTotal.ToString();
        }
        #endregion
        #region Delete Item
        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Verify selection
            if (lbxOrder.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the items list.");
            }
            else
            {
                //Delete Item from list
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
        }
        #endregion
        #region Place Order
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            FrmOrderSupplier frmOrderSupplier = new FrmOrderSupplier();
            frmOrderSupplier.LoadGUI();
            frmOrderSupplier.ShowDialog();
            if (frmOrderSupplier.bOk)
            {
                int supplerID = frmOrderSupplier.supplierID;
                //Create Sales Order Record
                try
                {
                    Methods.SQLCon.Open();

                    SqlCommand commandInsert = new SqlCommand($"INSERT INTO PURCHASE_ORDER(Supplier_ID,Purchase_date) VALUES('{supplerID}','{DateTime.Now.Date}')", Methods.SQLCon);

                    adapter = new SqlDataAdapter();
                    dataset = new DataSet();

                    adapter.InsertCommand = commandInsert;
                    adapter.InsertCommand.ExecuteNonQuery();

                    Methods.SQLCon.Close();
                }
                catch (SqlException)
                {
                    //Error message
                    MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Get Sales Order Record ID
                int orderID = 0;
                try
                {
                    SqlCommand command = new SqlCommand($"SELECT * FROM PURCHASE_ORDER ORDER BY Purchase_ID DESC", Methods.SQLCon);
                    Methods.SQLCon.Close();
                    Methods.SQLCon.Open();
                    orderID = (int)command.ExecuteScalar();
                    Methods.SQLCon.Close();
                }
                catch (SqlException)
                {
                    MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Create Sales Order Items
                try
                {
                    Methods.SQLCon.Close();
                    Methods.SQLCon.Open();

                    for (int i = 0; i < orderItemCount; i++)
                    {
                        SqlCommand commandInsert = new SqlCommand($"INSERT INTO PURCHASE_ORDER_ITEM(Purchase_ID,Product_ID,Quantity_purchased,Cost_price) VALUES('{orderID}','{arrOrder[i, 0]}','{arrOrder[i, 1]}','{arrOrder[i, 3]}')", Methods.SQLCon);

                        adapter = new SqlDataAdapter();
                        dataset = new DataSet();

                        adapter.InsertCommand = commandInsert;
                        adapter.InsertCommand.ExecuteNonQuery();
                    }

                    Methods.SQLCon.Close();
                }
                catch (SqlException)
                {
                    //Error message
                    MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //Reset billItemCount
                orderItemCount = 0;
                lbxOrder.Items.Clear();
                lblTotalAmnt.Text = "R 0";
            }
        }
        #endregion
    }
}
