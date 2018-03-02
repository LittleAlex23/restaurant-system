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
        private DataTable dishTable;
        private DataTable waiterTable;

        private PriceCalculator calculator;
        public Reservation()
        {
            InitializeComponent();
            calculator = new PriceCalculator();
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
            orderTable = new DataTable();
            dishTable = new DataTable();
            waiterTable = new DataTable();

            inputPanel.Enabled = true;
            connectButton.SendToBack();
            try
            {
                controller.Connect(SERVER, userID, pwd, dbName);
                waitingGrid.DataSource = controller.FillTable("WAITING_CUST", waitingTable);
                tableGrid.DataSource = controller.FillTable("CUST_TABLE", eatingTable);
                dishGrid.DataSource = controller.FillTable("DISH", dishTable);
                waiterGrid.DataSource = controller.FillTable("WAITER", waiterTable);

                InitializeMenu();
                tabControl.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            messageLabel.Text = "Connected to database";
        }

        // Initialize the combo box with dish;
        private void InitializeMenu() {
            List<String> list = controller.GetDishList();
            list.ForEach((item) => orderList.Items.Add(item));
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
            {
                MessageBox.Show("Name is invalid");
                return;
            }
            if (!Validation.IsNumberPositive(partyTextField.Text))
            {
                MessageBox.Show("Number must be positive");
                return;
            }
            string partyName = nameTextField.Text.ToLower();
            int partySize = Convert.ToInt32(partyTextField.Text);
            int currentIndex = controller.AddPartyToWaitinglist(partyName, partySize);
            if (currentIndex != -1)
            {
                waitingTable.Rows.Add(currentIndex, partyName, partySize, DateTime.Now.ToString("HH:mm:ss"));
                messageLabel.Text = "row added";
            }
            else
                MessageBox.Show("Name already taken");
        }

        // Disconnect the application from database and clear the contents from every DataTable
        private void DisconnectButton_Click(object sender, EventArgs e)
        {
            disconnectButton.SendToBack();
            orderList.Items.Clear();
            waitingTable.Clear();
            eatingTable.Clear();
            if(orderTable != null)
                orderTable.Clear();
            dishTable.Clear();

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

        // Deselect the row from waiting table
        private void Waiting_list_cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            deleteButton.Enabled = false;
        }

        // A row from customer table is selected
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
        // Deselect the row from seating table
        private void TableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderButton.Enabled = assignButton.Enabled = clearButton.Enabled = false;
            dishPanel.Enabled = false;
        }

        // Deselect the row from order table
        private void DishGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idBox.Text = dishBox.Text = "N/A";
            quantity.ResetText();
            dishPanel.Enabled = false;
        }

        // Select row from order table 
        private void FoodGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow r = orderGrid.SelectedRows[0];
            if (orderTable.Rows.Count > 0)
            {
                idBox.Text = r.Cells["Num"].Value.ToString();
                dishBox.Text = r.Cells["DNAME"].Value.ToString();
                quantity.Text = r.Cells["QUANTITY"].Value.ToString();
                if (!dishPanel.Enabled)
                    dishPanel.Enabled = true;
            }
        }

        // Deselect row from dish table
        private void dishGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            quantity_box.Enabled = false;
            FID_value.Text = name_value.Text = "N/A";
            quantity_box.ResetText();
            dishChangePanel.Enabled = (dishGrid.SelectedRows.Count == 1);
        }

        // Select row from dish table
        private void DishGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dishTable.Rows.Count > 0 )
            {
                if (!quantity_box.Enabled)
                    quantity_box.Enabled = true;
                DataGridViewRow r = dishGrid.SelectedRows[0];
                FID_value.Text = r.Cells["ID"].Value.ToString();
                name_value.Text = r.Cells["DNAME"].Value.ToString();
                quantity_box.Text = r.Cells["STOCK"].Value.ToString();
            }
        }

        // Remove the party from the waiting list
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            controller.DeletePartyFromWaitingList(nameTextField.Text.ToLower());
            nameTextField.ResetText();
            partyTextField.ResetText();
            waitingTable.Rows.RemoveAt(waitingGrid.SelectedRows[0].Index);
            messageLabel.Text = "row deleted";
            deleteButton.Enabled = false;
        }

        // Assign the available table to any party, if possible
        private void Seat_customer(object sender, EventArgs e)
        {
            DataGridViewRow r = tableGrid.SelectedRows[0];
            if (Convert.ToInt32(r.Cells["isAvailable"].Value) == 0)
            {
                messageLabel.Text = "That table is not available";
                return;
            }
            String id = r.Cells["CID"].Value.ToString();
            int maxSeat = Convert.ToInt32(r.Cells["MAX_SEAT"].Value);

            // Assign the first party whose number is less than the number of seats 
            for (int i = 0; i < waitingTable.Rows.Count; i++)
            {
                DataGridViewRow w = waitingGrid.Rows[i];
                int custSize = Convert.ToInt32(w.Cells["SIZE"].Value);
                if (custSize <= maxSeat)
                {
                    controller.SeatCustomer(id, w.Cells["PNAME"].Value.ToString(), custSize, waitingGrid.Rows[i].Cells["WID"].Value.ToString());
                    r = tableGrid.SelectedRows[0];
                    r.Cells["PNAME"].Value = w.Cells["PNAME"].Value;
                    r.Cells["SIZE"].Value = w.Cells["SIZE"].Value;
                    r.Cells["isAvailable"].Value = 0;

                    waitingTable.Rows.RemoveAt(i);
                    nameTextField.ResetText();
                    partyTextField.ResetText();
                    messageLabel.Text = "Customer assigned to table";
                    break;
                }
            }
        }

        // Make the seating table available
        private void Clean_table(object sender, EventArgs e)
        {
            controller.CleanTable(Convert.ToInt32(tableGrid.SelectedRows[0].Cells["CID"].Value));
            DataGridViewRow r = tableGrid.SelectedRows[0];
            r.Cells["PNAME"].Value = "";
            r.Cells["SIZE"].Value = 0;
            r.Cells["isAvailable"].Value = 1;
            if(orderTable != null)
                orderTable.Clear();
            quantityText.ResetText();
            messageLabel.Text = "table cleared";
        }

        // Populate the party's order table
        private void OrderButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = tableGrid.SelectedRows[0];
            tableNum.Text = r.Cells["CID"].Value.ToString();
            orderTable.Clear();
            orderGrid.DataSource = controller.FillCustomerOrderTable(r.Cells["CID"].Value.ToString(), orderTable);
            tabControl.SelectedTab = orderPage;
            panel1.Enabled = true;
            CalculateTotalPrice();
        }

        // Add another order to the party's order list 
        private void AddOrderButton_Click(object sender, EventArgs e)
        {
            if (!Validation.IsNumberPositive(quantityText.Text))
                return;
            decimal[] d = controller.AddOrder(tableNum.Text, orderList.SelectedIndex+1, quantityText.Text);
            orderTable.Rows.Add(d[0], orderList.SelectedIndex, orderList.SelectedItem.ToString(), quantityText.Text, d[1]);
            CalculateTotalPrice();
            messageLabel.Text = "order added to list";
        }

        // Remove the party's order
        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = orderGrid.SelectedRows[0];
            controller.RemoveOrder(r.Cells["order_ID"].Value.ToString());
            idBox.Text = dishBox.Text = "N/A";
            quantity.ResetText();
            orderTable.Rows.RemoveAt(r.Index);
            messageLabel.Text = "order deleted";
            CalculateTotalPrice();
            dishPanel.Enabled = false;
        }

        // Change the party's order
        private void ChangeOrder(object sender, EventArgs e)
        {
            if (!Validation.IsNumberPositive(quantity.Text))
                return;
            controller.ChangeOrder(quantity.Text, orderGrid.SelectedRows[0].Cells["orderID"].Value.ToString());
            orderGrid.SelectedRows[0].Cells["QUANTITY"].Value = quantity.Text;
            CalculateTotalPrice();
            messageLabel.Text = "order changed";
        }
        
        // Update an item in the dish list
        private void Update_Stock_Click(object sender, EventArgs e)
        {
            if(!Validation.IsNumberPositive(quantity_box.Text))
                return;

            controller.ChangeStock(quantity_box.Text, FID_value.Text);
            dishGrid.SelectedRows[0].Cells["STOCK"].Value = quantity_box.Text;
            messageLabel.Text = "stock changed";
        }

        // Calculate the total price for the party
        private void CalculateTotalPrice() {
            priceLabel.Text = calculator.Calculate(orderTable);
        }
    }
}
