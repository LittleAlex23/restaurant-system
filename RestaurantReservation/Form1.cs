using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace RestaurantReservation
{
    public partial class Form1 : Form
    {
        public Controller controller;
        // local server
        private const string SERVER = "127.0.0.1";
        private const string userID = "root";

        // Use your own password
        private const string pwd = "Theelitestar23";
   
        private const string dbName = "RESTAURANT";
        private DataTable waitingTable;
        private DataTable eatingTable;
        private DataTable orderTable;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            comboBox1.SelectedIndex = 0;
            dataGridView1.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
            tableGrid.DataError += new DataGridViewDataErrorEventHandler(dataGridView1_DataError);
        }

        // Connect to a database
        private void connect_Click(object sender, EventArgs e)
        {
            controller.connect(SERVER, userID, pwd, dbName);
            waitingTable = new DataTable();
            eatingTable = new DataTable();
            inputPanel.Enabled = true;
            connectButton.SendToBack();
            try
            {
                populate_gridview("SELECT * FROM WAITING_CUST", waitingTable, dataGridView1);
                messageLabel.Text = "hi";
                populate_gridview("SELECT * FROM CUST_TABLE", eatingTable, tableGrid);
                
                List<String> list = controller.getFoodList("SELECT NAME FROM FOOD");
                foreach (string item in list)
                    orderList.Items.Add(item);
                 orderList.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            messageLabel.Text = "Connected to database";
        }

        // populate datagridview with data
        private void populate_gridview(string queryString, DataTable table, DataGridView grid) {
            grid.DataSource = controller.fillTable(queryString, table);
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show(dataGridView1.SelectedCells[0].Value.ToString());
        }

        // Add a customer to the wait_list
        private void enterButton_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(partyTextField.Text) < 0)
            {
                MessageBox.Show("Positve integer only");
                return;
            }
            string partyName = nameTextField.Text.ToLower();
            int partySize = Convert.ToInt32(partyTextField.Text);
            int currentIndex = controller.addPartyToWaitinglist(partyName, partySize);
            waitingTable.Rows.Add(currentIndex, partyName, partySize);
            messageLabel.Text = "row added";
        }

        // Disconnect the application from database
        private void disconnectButton_Click(object sender, EventArgs e)
        {
            disconnectButton.SendToBack();
            orderList.Items.Clear();
            dataGridView1.DataSource = null;
            tableGrid.DataSource = null;
            foodGrid.DataSource = null;
            inputPanel.Enabled = false;
            clearButton.Enabled = false;
            assignButton.Enabled = false;
        }

        // Row from waiting table is selected
        private void waiting_list_row_selected(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (waitingTable.Rows.Count != 0)
            {
                nameTextField.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                partyTextField.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); ;
                deleteButton.Enabled = true;
            }
        }

        private void waiting_list_cell_clicked(object sender, DataGridViewCellEventArgs e)
        {
            deleteButton.Enabled = false;
        }

        // Row from customer table is selected
        private void tableGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (eatingTable.Rows.Count != 0)
            {
                if (Convert.ToInt32(tableGrid.SelectedRows[0].Cells["isAvailable"].Value) == 0)
                    orderButton.Enabled = clearButton.Enabled = true;
                else if (waitingTable.Rows.Count != 0)
                    assignButton.Enabled = true;
            }
        }

        private void tableGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            orderButton.Enabled = assignButton.Enabled = clearButton.Enabled = false;
            foodPanel.Enabled = false;
        }

        // Deselect the row from order table
        private void foodGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            idBox.Text = foodBox.Text = "N/A";
            quantity.ResetText();
            if (foodGrid.SelectedRows.Count == 1 && foodGrid.SelectedRows[0].Cells["Num"].Value.ToString() != "")
                foodPanel.Enabled = true;
            else
                foodPanel.Enabled = false;
        }

        // Select row from order table 
        private void foodGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (orderTable.Rows.Count > 0)
            {
                idBox.Text = foodGrid.SelectedRows[0].Cells["Num"].Value.ToString();
                foodBox.Text = foodGrid.SelectedRows[0].Cells["NAME"].Value.ToString();
                quantity.Text = foodGrid.SelectedRows[0].Cells["QUANTITY"].Value.ToString();
            }
        }

        // Remove a customer from the waiting list
        private void deleteButton_Click(object sender, EventArgs e)
        {
            controller.deletePartyFromWaitingList(nameTextField.Text.ToLower());

            nameTextField.Text = partyTextField.Text = "";
            waitingTable.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            messageLabel.Text = "row deleted";
            deleteButton.Enabled = false;
        }

        // Switch to another panel
        private void panel_change(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
                waitingPanel.BringToFront();
            else
                tablePanel.BringToFront();
        }

        // Seat a party
        private void seat_customer(object sender, EventArgs e)
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
                int custSize = Convert.ToInt32(dataGridView1.Rows[i].Cells["PARTY"].Value);
                if (custSize <= maxSeat) {
                    try
                    {
                        controller.seatCustomer(id, dataGridView1.Rows[i].Cells["FNAME"].Value.ToString(), custSize, dataGridView1.Rows[i].Cells["ID"].Value.ToString());
                        tableGrid.SelectedRows[0].Cells["FNAME"].Value = dataGridView1.Rows[i].Cells["FNAME"].Value;
                        tableGrid.SelectedRows[0].Cells["PARTY"].Value = dataGridView1.Rows[i].Cells["PARTY"].Value;
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
        private void clean_table(object sender, EventArgs e)
        {
            try
            {
                controller.cleanTable(Convert.ToInt32(tableGrid.SelectedRows[0].Cells["TID"].Value));
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
        private void orderButton_Click(object sender, EventArgs e)
        {
            tableNum.Text = tableGrid.SelectedRows[0].Cells["TID"].Value.ToString();
            orderTable = new DataTable();
            populate_gridview("SELECT orderID, C.FID as Num, NAME, QUANTITY FROM CUST_ORDER AS C JOIN FOOD AS F ON C.FID = F.FID WHERE ID = " + tableGrid.SelectedRows[0].Cells["TID"].Value.ToString(), orderTable, foodGrid);
            orderPanel.BringToFront();
        }

        // Return to the customer table panel
        private void backButton_Click(object sender, EventArgs e)
        {
            orderPanel.SendToBack();
        }

        // Add another order to a customer's list of orders
        private void addOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(textBox1.Text) < 0) { 
                    MessageBox.Show("Positve Integer only");
                    return;
                }
                orderTable.Rows.Add(controller.addOrder(tableNum.Text, orderList.SelectedIndex, textBox1.Text),
                orderList.SelectedIndex,
                    orderList.SelectedItem.ToString(),
                    textBox1.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            messageLabel.Text = "order added to list";
        }

        // Remove a customer's order
        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                controller.removeOrder(foodGrid.SelectedRows[0].Cells["orderID"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            idBox.Text = foodBox.Text = "N/A";
            quantity.Text = "";

            orderTable.Rows.RemoveAt(foodGrid.SelectedRows[0].Index);
            messageLabel.Text = "order deleted";
            deleteButton.Enabled = false;
        }

        // Change the customer's order
        private void changeOrder(object sender, EventArgs e)
        {
            try
            {if (Convert.ToInt32(quantity.Text) < 0) { 
                    MessageBox.Show("Positve Integer only");
                    return;
                }
                controller.changeOrder(quantity.Text, foodGrid.SelectedRows[0].Cells["orderID"].Value.ToString());
                foodGrid.SelectedRows[0].Cells["QUANTITY"].Value = quantity.Text;
                messageLabel.Text = "order changed";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
