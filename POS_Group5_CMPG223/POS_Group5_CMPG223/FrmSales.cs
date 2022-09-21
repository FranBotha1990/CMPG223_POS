using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace POS_Group5_CMPG223
{
    //Test
    public partial class FrmSales : Form
    {
        #region Variables
        private int buttonsToLoad = 0;
        private int buttonsLoaded = 0;
        private Button[] posButtons;
        private String[,] arrBill;
        private Boolean bFirstLoad = true;
        private int billItemCount = 0;
        private double billTotal = 0;
        SqlDataAdapter adapter;
        DataSet dataset;
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
            //POS Buttons
            try
            {
                SqlCommand command = new SqlCommand($"SELECT COUNT(*) FROM PRODUCT", Methods.SQLCon);
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                buttonsToLoad = (int)command.ExecuteScalar();
                posButtons = new Button[buttonsToLoad];
                arrBill = new string[buttonsToLoad, 4];
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
                    posButtons[buttonsLoaded - 1].Parent = pnlButtons;
                    pnlButtons.Controls.Add(posButtons[buttonsLoaded - 1]);
                    posButtons[buttonsLoaded - 1].Name = reader.GetValue(0).ToString();
                    posButtons[buttonsLoaded - 1].Click += new EventHandler(POSButton_Click);
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

        private void POSButton_Click(object sender, EventArgs e)
        {
            FrmSalesQuantity frmSalesQuantity = new FrmSalesQuantity();
            frmSalesQuantity.LoadGUI();
            frmSalesQuantity.ShowDialog();
            int quantity = frmSalesQuantity.quantity;
            //Check Stock
            if (frmSalesQuantity.bOk)
            {
                bool bEnoughStock = false;
                int stock = 0;
                try
                {
                    Methods.SQLCon.Close();
                    Methods.SQLCon.Open();
                    SqlCommand command = new SqlCommand($"SELECT * FROM PRODUCT WHERE Product_ID = {(sender as Button).Name}", Methods.SQLCon);
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    reader.Read();
                    stock = int.Parse(reader.GetValue(3).ToString());
                    if (quantity <= stock)
                    {
                        bEnoughStock = true;
                    }
                    Methods.SQLCon.Close();
                }
                catch
                {
                    MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                //Button Event
                if (bEnoughStock)
                {
                    int i;
                    bool bExists = false;
                    for (i = 0; i < buttonsToLoad; i++)
                    {
                        if ((sender as Button).Name.Equals(arrBill[i, 0]))
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
                            SqlCommand command2 = new SqlCommand($"SELECT * FROM PRODUCT WHERE Product_ID = {(sender as Button).Name}", Methods.SQLCon);
                            SqlDataReader reader2;
                            reader2 = command2.ExecuteReader();
                            reader2.Read();
                            arrBill[billItemCount, 0] = reader2.GetValue(0).ToString();
                            arrBill[billItemCount, 1] = quantity.ToString();
                            arrBill[billItemCount, 2] = reader2.GetValue(1).ToString();
                            arrBill[billItemCount, 3] = reader2.GetValue(2).ToString();
                            billItemCount++;
                            Methods.SQLCon.Close();
                        }
                        catch (SqlException)
                        {
                            MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (int.Parse(arrBill[i, 1]) + quantity <= stock)
                        {
                            arrBill[i, 1] = (int.Parse(arrBill[i, 1]) + quantity).ToString();
                        }
                        else
                        {
                            bEnoughStock = false;
                        }
                    }
                    LoadBill();
                }
                if (!bEnoughStock)
                    MessageBox.Show("Not enough stock (In Stock: " + stock.ToString() + ")", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        #endregion
        #region Bill Buttons
        private void btnConfirmBill_Click(object sender, EventArgs e)
        {
            int orderID = 0;
            //Create Sales Order Record
            try
            {
                Methods.SQLCon.Open();

                SqlCommand commandInsert = new SqlCommand($"INSERT INTO SALES_ORDER(Sales_date) VALUES('{DateTime.Now.Date}')", Methods.SQLCon);

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
            try
            {
                SqlCommand command = new SqlCommand($"SELECT * FROM SALES_ORDER ORDER BY Sales_ID DESC", Methods.SQLCon);
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();
                orderID = (int)command.ExecuteScalar();
                Methods.SQLCon.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Create Sales Order Items
            try
            {
                Methods.SQLCon.Close();
                Methods.SQLCon.Open();

                for (int i = 0; i < billItemCount; i++)
                {
                    SqlCommand commandInsert = new SqlCommand($"INSERT INTO SALES_ORDER_ITEM(Sales_ID,Product_ID,Quantity_sold) VALUES('{orderID}','{arrBill[i,0]}','{arrBill[i, 1]}')", Methods.SQLCon);

                    adapter = new SqlDataAdapter();
                    dataset = new DataSet();

                    adapter.InsertCommand = commandInsert;
                    adapter.InsertCommand.ExecuteNonQuery();

                    //Load Quantity
                    SqlCommand commandSelect = new SqlCommand($"SELECT Quantity_in_stock FROM PRODUCT WHERE Product_ID = {arrBill[i, 0]}", Methods.SQLCon);
                    int inStock = (int)commandSelect.ExecuteScalar();
                    //Update Quantity
                    SqlCommand commandUpdate = new SqlCommand($"UPDATE PRODUCT SET Quantity_in_stock = '{(inStock - int.Parse(arrBill[i, 1])).ToString()}' WHERE Product_ID = {arrBill[i, 0]}", Methods.SQLCon);
                    
                    adapter.UpdateCommand = commandUpdate;
                    adapter.UpdateCommand.ExecuteNonQuery();
                }

                Methods.SQLCon.Close();
            }
            catch (SqlException)
            {
                //Error message
                MessageBox.Show("Could not load the database", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Reset billItemCount
            billItemCount = 0;
            lbxBill.Items.Clear();
            lblTotalAmnt.Text = "R 0";

    }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            //Verify selection
            if (lbxBill.SelectedItem == null)
            {
                MessageBox.Show("Please select an item from the items list.");
            }
            else
            {
                //Delete tiem from list
                for (int i = lbxBill.SelectedIndex; i < billItemCount; i++)
                {
                    arrBill[i, 0] = arrBill[i + 1, 0];
                    arrBill[i, 1] = arrBill[i + 1, 1];
                    arrBill[i, 2] = arrBill[i + 1, 2];
                    arrBill[i, 3] = arrBill[i + 1, 3];
                }
                billItemCount--;
                LoadBill();
            }
        }

        private void LoadBill()
        {
            lbxBill.Items.Clear();
            billTotal = 0;
            for (int y = 0; y < billItemCount; y++)
            {
                string str = string.Format("{0} {1} {2} {3} {4}", arrBill[y, 1], " x ", arrBill[y, 2], " @ R ", Convert.ToDouble(arrBill[y, 3]));
                billTotal += Convert.ToDouble(Convert.ToDouble(arrBill[y, 3]) * int.Parse(arrBill[y, 1]));
                lbxBill.Items.Add(str);
            }
            lblTotalAmnt.Text = "R " + billTotal.ToString();
        }
        #endregion
    }
}
