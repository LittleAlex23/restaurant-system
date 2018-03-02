namespace RestaurantReservation
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.statusLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.dishPanel = new System.Windows.Forms.Panel();
            this.tableNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.changeOrderButton = new System.Windows.Forms.Button();
            this.dishBox = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.quantityText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderList = new System.Windows.Forms.ComboBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.orderGrid = new System.Windows.Forms.DataGridView();
            this.dishChangePanel = new System.Windows.Forms.Panel();
            this.FID_value = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.name_value = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.quantity_box = new System.Windows.Forms.TextBox();
            this.dishGrid = new System.Windows.Forms.DataGridView();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.waitingPage = new System.Windows.Forms.TabPage();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.enterButton = new System.Windows.Forms.Button();
            this.partyTextField = new System.Windows.Forms.TextBox();
            this.nameTextField = new System.Windows.Forms.TextBox();
            this.partyLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.waitingGrid = new System.Windows.Forms.DataGridView();
            this.tablePage = new System.Windows.Forms.TabPage();
            this.orderPage = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.stockPage = new System.Windows.Forms.TabPage();
            this.WaiterPage = new System.Windows.Forms.TabPage();
            this.waiterGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.dishPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).BeginInit();
            this.dishChangePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishGrid)).BeginInit();
            this.tabControl.SuspendLayout();
            this.waitingPage.SuspendLayout();
            this.inputPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingGrid)).BeginInit();
            this.tablePage.SuspendLayout();
            this.orderPage.SuspendLayout();
            this.panel1.SuspendLayout();
            this.stockPage.SuspendLayout();
            this.WaiterPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waiterGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(2, 293);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(40, 13);
            this.statusLabel.TabIndex = 7;
            this.statusLabel.Text = "Status:";
            // 
            // messageLabel
            // 
            this.messageLabel.AutoSize = true;
            this.messageLabel.Location = new System.Drawing.Point(42, 293);
            this.messageLabel.Name = "messageLabel";
            this.messageLabel.Size = new System.Drawing.Size(27, 13);
            this.messageLabel.TabIndex = 8;
            this.messageLabel.Text = "N/A";
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(5, 10);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 9;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.Connect_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(5, 10);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 10;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.DisconnectButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Location = new System.Drawing.Point(6, 58);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 16;
            this.orderButton.Text = "check order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.OrderButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(6, 32);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "clear table";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.Clean_table);
            // 
            // assignButton
            // 
            this.assignButton.Enabled = false;
            this.assignButton.Location = new System.Drawing.Point(6, 6);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(75, 23);
            this.assignButton.TabIndex = 14;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.Seat_customer);
            // 
            // tableGrid
            // 
            this.tableGrid.AllowUserToAddRows = false;
            this.tableGrid.AllowUserToDeleteRows = false;
            this.tableGrid.AllowUserToResizeColumns = false;
            this.tableGrid.AllowUserToResizeRows = false;
            this.tableGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGrid.Location = new System.Drawing.Point(82, 6);
            this.tableGrid.MultiSelect = false;
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.ReadOnly = true;
            this.tableGrid.Size = new System.Drawing.Size(547, 213);
            this.tableGrid.TabIndex = 13;
            this.tableGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableGrid_CellClick);
            this.tableGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.TableGrid_RowHeaderMouseClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(572, 200);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 33;
            this.label11.Text = "$";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(588, 200);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(27, 13);
            this.priceLabel.TabIndex = 33;
            this.priceLabel.Text = "N/A";
            // 
            // dishPanel
            // 
            this.dishPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dishPanel.Controls.Add(this.tableNum);
            this.dishPanel.Controls.Add(this.label4);
            this.dishPanel.Controls.Add(this.deleteOrderButton);
            this.dishPanel.Controls.Add(this.changeOrderButton);
            this.dishPanel.Controls.Add(this.dishBox);
            this.dishPanel.Controls.Add(this.idBox);
            this.dishPanel.Controls.Add(this.label2);
            this.dishPanel.Controls.Add(this.nameBox);
            this.dishPanel.Controls.Add(this.quantity);
            this.dishPanel.Controls.Add(this.idLabel);
            this.dishPanel.Enabled = false;
            this.dishPanel.Location = new System.Drawing.Point(6, 6);
            this.dishPanel.Name = "dishPanel";
            this.dishPanel.Size = new System.Drawing.Size(147, 105);
            this.dishPanel.TabIndex = 33;
            // 
            // tableNum
            // 
            this.tableNum.AutoSize = true;
            this.tableNum.Location = new System.Drawing.Point(52, 5);
            this.tableNum.Name = "tableNum";
            this.tableNum.Size = new System.Drawing.Size(27, 13);
            this.tableNum.TabIndex = 32;
            this.tableNum.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "table:";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(76, 73);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(66, 23);
            this.deleteOrderButton.TabIndex = 25;
            this.deleteOrderButton.Text = "delete";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // changeOrderButton
            // 
            this.changeOrderButton.Location = new System.Drawing.Point(6, 73);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(64, 23);
            this.changeOrderButton.TabIndex = 24;
            this.changeOrderButton.Text = "change";
            this.changeOrderButton.UseVisualStyleBackColor = true;
            this.changeOrderButton.Click += new System.EventHandler(this.ChangeOrder);
            // 
            // dishBox
            // 
            this.dishBox.AutoSize = true;
            this.dishBox.Location = new System.Drawing.Point(51, 31);
            this.dishBox.Name = "dishBox";
            this.dishBox.Size = new System.Drawing.Size(27, 13);
            this.dishBox.TabIndex = 23;
            this.dishBox.Text = "N/A";
            // 
            // idBox
            // 
            this.idBox.AutoSize = true;
            this.idBox.Location = new System.Drawing.Point(51, 18);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(27, 13);
            this.idBox.TabIndex = 22;
            this.idBox.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "quantity:";
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(17, 31);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(36, 13);
            this.nameBox.TabIndex = 20;
            this.nameBox.Text = "name:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(54, 47);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(25, 20);
            this.quantity.TabIndex = 19;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(9, 18);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(44, 13);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "order #:";
            // 
            // quantityText
            // 
            this.quantityText.Location = new System.Drawing.Point(45, 30);
            this.quantityText.Name = "quantityText";
            this.quantityText.Size = new System.Drawing.Size(97, 20);
            this.quantityText.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-1, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "name:";
            // 
            // orderList
            // 
            this.orderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(45, 3);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(97, 21);
            this.orderList.TabIndex = 27;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(80, 56);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(62, 23);
            this.addOrderButton.TabIndex = 26;
            this.addOrderButton.Text = "add";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // orderGrid
            // 
            this.orderGrid.AllowUserToAddRows = false;
            this.orderGrid.AllowUserToDeleteRows = false;
            this.orderGrid.AllowUserToResizeColumns = false;
            this.orderGrid.AllowUserToResizeRows = false;
            this.orderGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderGrid.Location = new System.Drawing.Point(159, 6);
            this.orderGrid.MultiSelect = false;
            this.orderGrid.Name = "orderGrid";
            this.orderGrid.ReadOnly = true;
            this.orderGrid.Size = new System.Drawing.Size(467, 191);
            this.orderGrid.TabIndex = 15;
            this.orderGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DishGrid_CellClick);
            this.orderGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.FoodGrid_RowHeaderMouseClick);
            // 
            // dishChangePanel
            // 
            this.dishChangePanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dishChangePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dishChangePanel.Controls.Add(this.FID_value);
            this.dishChangePanel.Controls.Add(this.label6);
            this.dishChangePanel.Controls.Add(this.button2);
            this.dishChangePanel.Controls.Add(this.name_value);
            this.dishChangePanel.Controls.Add(this.label9);
            this.dishChangePanel.Controls.Add(this.label10);
            this.dishChangePanel.Controls.Add(this.quantity_box);
            this.dishChangePanel.Enabled = false;
            this.dishChangePanel.Location = new System.Drawing.Point(6, 6);
            this.dishChangePanel.Name = "dishChangePanel";
            this.dishChangePanel.Size = new System.Drawing.Size(121, 99);
            this.dishChangePanel.TabIndex = 39;
            // 
            // FID_value
            // 
            this.FID_value.AutoSize = true;
            this.FID_value.Location = new System.Drawing.Point(52, 10);
            this.FID_value.Name = "FID_value";
            this.FID_value.Size = new System.Drawing.Size(27, 13);
            this.FID_value.TabIndex = 32;
            this.FID_value.Text = "N/A";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "FID:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4, 67);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 24;
            this.button2.Text = "update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Update_Stock_Click);
            // 
            // name_value
            // 
            this.name_value.AutoSize = true;
            this.name_value.Location = new System.Drawing.Point(52, 26);
            this.name_value.Name = "name_value";
            this.name_value.Size = new System.Drawing.Size(27, 13);
            this.name_value.TabIndex = 23;
            this.name_value.Text = "N/A";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "quantity:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "name:";
            // 
            // quantity_box
            // 
            this.quantity_box.Location = new System.Drawing.Point(51, 41);
            this.quantity_box.Name = "quantity_box";
            this.quantity_box.Size = new System.Drawing.Size(59, 20);
            this.quantity_box.TabIndex = 19;
            // 
            // dishGrid
            // 
            this.dishGrid.AllowUserToAddRows = false;
            this.dishGrid.AllowUserToDeleteRows = false;
            this.dishGrid.AllowUserToResizeColumns = false;
            this.dishGrid.AllowUserToResizeRows = false;
            this.dishGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dishGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dishGrid.Location = new System.Drawing.Point(130, 6);
            this.dishGrid.Margin = new System.Windows.Forms.Padding(0);
            this.dishGrid.MultiSelect = false;
            this.dishGrid.Name = "dishGrid";
            this.dishGrid.ReadOnly = true;
            this.dishGrid.Size = new System.Drawing.Size(499, 216);
            this.dishGrid.TabIndex = 13;
            this.dishGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dishGrid_CellClick);
            this.dishGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DishGrid_RowHeaderMouseClick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.waitingPage);
            this.tabControl.Controls.Add(this.tablePage);
            this.tabControl.Controls.Add(this.orderPage);
            this.tabControl.Controls.Add(this.stockPage);
            this.tabControl.Controls.Add(this.WaiterPage);
            this.tabControl.Enabled = false;
            this.tabControl.Location = new System.Drawing.Point(5, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(640, 251);
            this.tabControl.TabIndex = 18;
            // 
            // waitingPage
            // 
            this.waitingPage.Controls.Add(this.inputPanel);
            this.waitingPage.Controls.Add(this.deleteButton);
            this.waitingPage.Controls.Add(this.waitingGrid);
            this.waitingPage.Location = new System.Drawing.Point(4, 22);
            this.waitingPage.Name = "waitingPage";
            this.waitingPage.Padding = new System.Windows.Forms.Padding(3);
            this.waitingPage.Size = new System.Drawing.Size(632, 225);
            this.waitingPage.TabIndex = 0;
            this.waitingPage.Text = "Waiting";
            this.waitingPage.UseVisualStyleBackColor = true;
            // 
            // inputPanel
            // 
            this.inputPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.inputPanel.Controls.Add(this.enterButton);
            this.inputPanel.Controls.Add(this.partyTextField);
            this.inputPanel.Controls.Add(this.nameTextField);
            this.inputPanel.Controls.Add(this.partyLabel);
            this.inputPanel.Controls.Add(this.nameLabel);
            this.inputPanel.Enabled = false;
            this.inputPanel.Location = new System.Drawing.Point(6, 3);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(151, 91);
            this.inputPanel.TabIndex = 11;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(73, 62);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.EnterButton_Click);
            // 
            // partyTextField
            // 
            this.partyTextField.Location = new System.Drawing.Point(41, 36);
            this.partyTextField.Name = "partyTextField";
            this.partyTextField.Size = new System.Drawing.Size(105, 20);
            this.partyTextField.TabIndex = 5;
            // 
            // nameTextField
            // 
            this.nameTextField.Location = new System.Drawing.Point(41, 10);
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.Size = new System.Drawing.Size(105, 20);
            this.nameTextField.TabIndex = 4;
            // 
            // partyLabel
            // 
            this.partyLabel.AutoSize = true;
            this.partyLabel.Location = new System.Drawing.Point(4, 39);
            this.partyLabel.Name = "partyLabel";
            this.partyLabel.Size = new System.Drawing.Size(34, 13);
            this.partyLabel.TabIndex = 3;
            this.partyLabel.Text = "Party:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(0, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(38, 13);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.Text = "Name:";
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(82, 100);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // waitingGrid
            // 
            this.waitingGrid.AllowUserToAddRows = false;
            this.waitingGrid.AllowUserToDeleteRows = false;
            this.waitingGrid.AllowUserToResizeColumns = false;
            this.waitingGrid.AllowUserToResizeRows = false;
            this.waitingGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.waitingGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waitingGrid.Location = new System.Drawing.Point(160, 6);
            this.waitingGrid.MultiSelect = false;
            this.waitingGrid.Name = "waitingGrid";
            this.waitingGrid.ReadOnly = true;
            this.waitingGrid.Size = new System.Drawing.Size(452, 213);
            this.waitingGrid.TabIndex = 1;
            this.waitingGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Waiting_list_cell_clicked);
            this.waitingGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.Waiting_list_row_selected);
            // 
            // tablePage
            // 
            this.tablePage.Controls.Add(this.orderButton);
            this.tablePage.Controls.Add(this.assignButton);
            this.tablePage.Controls.Add(this.clearButton);
            this.tablePage.Controls.Add(this.tableGrid);
            this.tablePage.Location = new System.Drawing.Point(4, 22);
            this.tablePage.Name = "tablePage";
            this.tablePage.Padding = new System.Windows.Forms.Padding(3);
            this.tablePage.Size = new System.Drawing.Size(632, 225);
            this.tablePage.TabIndex = 1;
            this.tablePage.Text = "Table";
            this.tablePage.UseVisualStyleBackColor = true;
            // 
            // orderPage
            // 
            this.orderPage.Controls.Add(this.panel1);
            this.orderPage.Controls.Add(this.label11);
            this.orderPage.Controls.Add(this.dishPanel);
            this.orderPage.Controls.Add(this.priceLabel);
            this.orderPage.Controls.Add(this.orderGrid);
            this.orderPage.Location = new System.Drawing.Point(4, 22);
            this.orderPage.Name = "orderPage";
            this.orderPage.Padding = new System.Windows.Forms.Padding(3);
            this.orderPage.Size = new System.Drawing.Size(632, 225);
            this.orderPage.TabIndex = 2;
            this.orderPage.Text = "Order";
            this.orderPage.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.orderList);
            this.panel1.Controls.Add(this.addOrderButton);
            this.panel1.Controls.Add(this.quantityText);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(6, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(147, 89);
            this.panel1.TabIndex = 34;
            // 
            // stockPage
            // 
            this.stockPage.Controls.Add(this.dishChangePanel);
            this.stockPage.Controls.Add(this.dishGrid);
            this.stockPage.Location = new System.Drawing.Point(4, 22);
            this.stockPage.Name = "stockPage";
            this.stockPage.Padding = new System.Windows.Forms.Padding(3);
            this.stockPage.Size = new System.Drawing.Size(632, 225);
            this.stockPage.TabIndex = 3;
            this.stockPage.Text = "Stock";
            this.stockPage.UseVisualStyleBackColor = true;
            // 
            // WaiterPage
            // 
            this.WaiterPage.Controls.Add(this.waiterGrid);
            this.WaiterPage.Location = new System.Drawing.Point(4, 22);
            this.WaiterPage.Name = "WaiterPage";
            this.WaiterPage.Padding = new System.Windows.Forms.Padding(3);
            this.WaiterPage.Size = new System.Drawing.Size(632, 225);
            this.WaiterPage.TabIndex = 4;
            this.WaiterPage.Text = "Waiters";
            this.WaiterPage.UseVisualStyleBackColor = true;
            // 
            // waiterGrid
            // 
            this.waiterGrid.AllowUserToAddRows = false;
            this.waiterGrid.AllowUserToDeleteRows = false;
            this.waiterGrid.AllowUserToResizeColumns = false;
            this.waiterGrid.AllowUserToResizeRows = false;
            this.waiterGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.waiterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.waiterGrid.Location = new System.Drawing.Point(3, 3);
            this.waiterGrid.Margin = new System.Windows.Forms.Padding(0);
            this.waiterGrid.MultiSelect = false;
            this.waiterGrid.Name = "waiterGrid";
            this.waiterGrid.ReadOnly = true;
            this.waiterGrid.Size = new System.Drawing.Size(631, 216);
            this.waiterGrid.TabIndex = 29;
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(652, 311);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.disconnectButton);
            this.Name = "Reservation";
            this.Text = "Reservation";
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.dishPanel.ResumeLayout(false);
            this.dishPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderGrid)).EndInit();
            this.dishChangePanel.ResumeLayout(false);
            this.dishChangePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dishGrid)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.waitingPage.ResumeLayout(false);
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.waitingGrid)).EndInit();
            this.tablePage.ResumeLayout(false);
            this.orderPage.ResumeLayout(false);
            this.orderPage.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.stockPage.ResumeLayout(false);
            this.WaiterPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.waiterGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.DataGridView tableGrid;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.DataGridView orderGrid;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label dishBox;
        private System.Windows.Forms.Label idBox;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button changeOrderButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TextBox quantityText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orderList;
        private System.Windows.Forms.Label tableNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel dishPanel;
        private System.Windows.Forms.DataGridView dishGrid;
        private System.Windows.Forms.Panel dishChangePanel;
        private System.Windows.Forms.Label FID_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label name_value;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox quantity_box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage waitingPage;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox partyTextField;
        private System.Windows.Forms.TextBox nameTextField;
        private System.Windows.Forms.Label partyLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.DataGridView waitingGrid;
        private System.Windows.Forms.TabPage tablePage;
        private System.Windows.Forms.TabPage orderPage;
        private System.Windows.Forms.TabPage stockPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabPage WaiterPage;
        private System.Windows.Forms.DataGridView waiterGrid;
    }
}

