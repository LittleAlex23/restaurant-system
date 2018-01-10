using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace RestaurantReservation
{
    public partial class Reservation : Form
    {
        public Controller controller;
        // local server
        private const string SERVER = "127.0.0.1";
        private const string userID = "root";

        // Use your own password
        private const string pwd = "";
   
        private const string dbName = "RESTAURANT";
        private DataTable waitingTable;
        private DataTable eatingTable;
        private DataTable orderTable;
        private DataTable stockTable;
        public Reservation()
        {
            InitializeComponent();
            waitingGrid.DataError += new DataGridViewDataErrorEventHandler(DataGridView1_DataError);
            tableGrid.DataError += new DataGridViewDataErrorEventHandler(DataGridView1_DataError);
        }
        public void SetController(Controller controller) {
            this.controller = controller;
        }
        // Connect to a database
        private void Connect_Click(object sender, EventArgs e)
        {
            waitingTable = new DataTable();
            eatingTable = new DataTable();
            stockTable = new DataTable();
            inputPanel.Enabled = true;
            connectButton.SendToBack();
            try
            {
                controller.Connect(SERVER, userID, pwd, dbName);
                waitingGrid.DataSource = controller.FillTable("WAITING_CUST", waitingTable);
                tableGrid.DataSource = controller.FillTable("CUST_TABLE", eatingTable);
                stockGrid.DataSource = controller.FillTable("FOOD", stockTable);
                InitializeMenu();
                tabControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            messageLabel.Text = "Connected to database";
        }
        private void InitializeMenu() {
            List<String> list = controller.GetFoodList("SELECT NAME FROM FOOD");
            foreach (string item in list)
                orderList.Items.Add(item);
            orderList.SelectedIndex = 0;
        }
        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(waitingGrid.SelectedCells[0].Value.ToString());
        }

        // Add a new party to the waiting list
        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (!Validation.IsNameValid(nameTextField.Text))
                return;
            if (!Validation.IsNumberPositive(partyTextField.Text))
                return;
            string partyName = nameTextField.Text.ToLower();
            int partySize = Convert.ToInt32(partyTextField.Text);
            int currentIndex = controller.AddPartyToWaitinglist(partyName, partySize);
            waitingTable.Rows.Add(currentIndex, partyName, partySize);
            messageLabel.Text = "row added";
        }

        // Disconnect the application from database and clear the data
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            disconnectButton.SendToBack();
            orderList.Items.Clear();
            waitingTable.Clear();
            eatingTable.Clear();
            if(orderTable != null)
                orderTable.Clear();
            stockTable.Clear();

            inputPanel.Enabled = false;
            clearButton.Enabled = false;
            assignButton.Enabled = false;
            tabControl.Enabled = false;
            messageLabel.Text = "database connection closed";
        }

        // Row from waiting table is selected
        private void Waiting_list_row_selected(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (waitingTable.Rows.Count != 0)
            {
                nameTextField.Text = waitingGrid.SelectedRows[0].Cells[1].Value.ToString();
                partyTextField.Text = waitingGrid.SelectedRows[0].Cells[2].Value.ToString(); ;
                deleteButton.Enabled = true;
            }
        }

        private void Waiting_list_cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            deleteButton.Enabled = false;
        }

        // Row from customer table is selected
        private void TableGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (eatingTable.Rows.Count != 0)
            {
                if (Convert.ToInt32(tableGrid.SelectedRows[0].Cells["isAvailable"].Value) == 0)
                    orderButton.Enabled = clearButton.Enabled = true;
                else if (waitingTable.Rows.Count != 0)
                    assignButton.Enabled = true;
            }
        }

        private void TableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderButton.Enabled = assignButton.Enabled = clearButton.Enabled = false;
            foodPanel.Enabled = false;
        }

        // Deselect the row from order table
        private void FoodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idBox.Text = foodBox.Text = "N/A";
            quantity.ResetText();
            if (foodGrid.SelectedRows.Count == 1 && foodGrid.SelectedRows[0].Cells["Num"].Value.ToString() != "")
                foodPanel.Enabled = true;
            else
                foodPanel.Enabled = false;
        }

        // Select row from order table 
        private void FoodGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (orderTable.Rows.Count > 0)
            {
                idBox.Text = foodGrid.SelectedRows[0].Cells["Num"].Value.ToString();
                foodBox.Text = foodGrid.SelectedRows[0].Cells["NAME"].Value.ToString();
                quantity.Text = foodGrid.SelectedRows[0].Cells["QUANTITY"].Value.ToString();
            }
        }

        // Deselect row from food table
        private void StockGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Text = label7.Text = "N/A";
            textBox2.ResetText();
            stockChangePanel.Enabled = (stockGrid.SelectedRows.Count == 1);
        }

        // Select row from food table
        private void StockGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (stockTable.Rows.Count > 0)
            {
                label5.Text = stockGrid.SelectedRows[0].Cells["FID"].Value.ToString();
                label7.Text = stockGrid.SelectedRows[0].Cells["NAME"].Value.ToString();
                textBox2.Text = stockGrid.SelectedRows[0].Cells["STOCK"].Value.ToString();
            }
        }

        // Remove a customer from the waiting list
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            controller.DeletePartyFromWaitingList(nameTextField.Text.ToLower());

            nameTextField.Text = partyTextField.Text = "";
            waitingTable.Rows.RemoveAt(waitingGrid.SelectedRows[0].Index);
            messageLabel.Text = "row deleted";
            deleteButton.Enabled = false;
        }

        // Seat a party
        private void Seat_customer(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tableGrid.SelectedRows[0].Cells["isAvailable"].Value) == 0)
            {
                messageLabel.Text = "That table is not available";
                return;
            }
            String id = tableGrid.SelectedRows[0].Cells["TID"].Value.ToString();
            int maxSeat = Convert.ToInt32(tableGrid.SelectedRows[0].Cells["MAX_SEAT"].Value);
            for (int i = 0; i < waitingTable.Rows.Count; i++)
            {
                int custSize = Convert.ToInt32(waitingGrid.Rows[i].Cells["PARTY"].Value);
                if (custSize <= maxSeat) {
                    try
                    {
                        controller.SeatCustomer(id, waitingGrid.Rows[i].Cells["FNAME"].Value.ToString(), custSize, waitingGrid.Rows[i].Cells["ID"].Value.ToString());
                        tableGrid.SelectedRows[0].Cells["FNAME"].Value = waitingGrid.Rows[i].Cells["FNAME"].Value;
                        tableGrid.SelectedRows[0].Cells["PARTY"].Value = waitingGrid.Rows[i].Cells["PARTY"].Value;
                        tableGrid.SelectedRows[0].Cells["isAvailable"].Value = 0;

                        waitingTable.Rows.RemoveAt(i);
                        nameTextField.Text = partyTextField.Text = "";
                        messageLabel.Text = "Customer assigned to table";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                }
                else
                    messageLabel.Text = "Not enough seats";
            }

        }

        // Make a table available for the next party
        private void Clean_table(object sender, EventArgs e)
        {
            try
            {
                controller.CleanTable(Convert.ToInt32(tableGrid.SelectedRows[0].Cells["TID"].Value));
                tableGrid.SelectedRows[0].Cells["FNAME"].Value = "";
                tableGrid.SelectedRows[0].Cells["PARTY"].Value = 0;
                tableGrid.SelectedRows[0].Cells["isAvailable"].Value = 1;
                messageLabel.Text = "table cleared";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Populate the customer's order table
        private void OrderButton_Click(object sender, EventArgs e)
        {
            tableNum.Text = tableGrid.SelectedRows[0].Cells["TID"].Value.ToString();
            orderTable = new DataTable();
            foodGrid.DataSource = controller.FillCustomerOrderTable(tableGrid.SelectedRows[0].Cells["TID"].Value.ToString(), orderTable);
            tabControl.SelectedTab = orderPage;
            CalculateTotalPrice();
        }

        // Add another order to a customer's list of orders
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsNumberPositive(textBox1.Text))
                    return;
                decimal[] d = controller.AddOrder(tableNum.Text, orderList.SelectedIndex, textBox1.Text);
                orderTable.Rows.Add(d[0], orderList.SelectedIndex, orderList.SelectedItem.ToString(),
                    textBox1.Text, d[1]);
                CalculateTotalPrice();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            messageLabel.Text = "order added to list";
        }

        // Remove a customer's order
        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                controller.RemoveOrder(foodGrid.SelectedRows[0].Cells["orderID"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            idBox.Text = foodBox.Text = "N/A";
            quantity.Text = "";

            orderTable.Rows.RemoveAt(foodGrid.SelectedRows[0].Index);
            messageLabel.Text = "order deleted";
            CalculateTotalPrice();
            foodPanel.Enabled = false;
        }

        // Change the customer's order
        private void ChangeOrder(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsNumberPositive(quantity.Text))
                    return;
                controller.ChangeOrder(quantity.Text, foodGrid.SelectedRows[0].Cells["orderID"].Value.ToString());
                foodGrid.SelectedRows[0].Cells["QUANTITY"].Value = quantity.Text;
                CalculateTotalPrice();
                messageLabel.Text = "order changed";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Add a new item to the stock list
        private void Add_New_Item_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Validation.IsNumberPositive(textBox3.Text))
                    return;
                int count = stockTable.Rows.Count;
                string name = textBox4.Text.ToString();
                string stock = textBox3.Text.ToString();
                controller.AddItem(count, name, stock);
                stockTable.Rows.Add(count, name, stock);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Update an item in the stock list
        private void Update_Stock_Click(object sender, EventArgs e)
        {
            try
            {
                if(!Validation.IsNumberPositive(textBox2.Text))
                    return;

                controller.ChangeStock(textBox2.Text, label5.Text);
                stockGrid.SelectedRows[0].Cells["STOCK"].Value = textBox2.Text;
                messageLabel.Text = "stock changed";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Calculate the total price for a customer
        private void CalculateTotalPrice() {
            priceLabel.Text = orderTable.AsEnumerable().Sum(x => (x.Field<Int32>("QUANTITY")) * x.Field<decimal>("PRICE")).ToString();
        }
    }
}
