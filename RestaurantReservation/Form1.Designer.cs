﻿namespace RestaurantReservation
{
    partial class Form1
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nameLabel = new System.Windows.Forms.Label();
            this.partyLabel = new System.Windows.Forms.Label();
            this.nameTextField = new System.Windows.Forms.TextBox();
            this.partyTextField = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.messageLabel = new System.Windows.Forms.Label();
            this.connectButton = new System.Windows.Forms.Button();
            this.disconnectButton = new System.Windows.Forms.Button();
            this.inputPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.waitingPanel = new System.Windows.Forms.Panel();
            this.tablePanel = new System.Windows.Forms.Panel();
            this.orderButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.assignButton = new System.Windows.Forms.Button();
            this.tableGrid = new System.Windows.Forms.DataGridView();
            this.orderPanel = new System.Windows.Forms.Panel();
            this.foodPanel = new System.Windows.Forms.Panel();
            this.tableNum = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.changeOrderButton = new System.Windows.Forms.Button();
            this.foodBox = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.orderList = new System.Windows.Forms.ComboBox();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.foodGrid = new System.Windows.Forms.DataGridView();
            this.backButton = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.inputPanel.SuspendLayout();
            this.waitingPanel.SuspendLayout();
            this.tablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).BeginInit();
            this.orderPanel.SuspendLayout();
            this.foodPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(155, 6);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(488, 232);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.waiting_list_cell_clicked);
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.waiting_list_row_selected);
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
            // partyLabel
            // 
            this.partyLabel.AutoSize = true;
            this.partyLabel.Location = new System.Drawing.Point(4, 39);
            this.partyLabel.Name = "partyLabel";
            this.partyLabel.Size = new System.Drawing.Size(34, 13);
            this.partyLabel.TabIndex = 3;
            this.partyLabel.Text = "Party:";
            // 
            // nameTextField
            // 
            this.nameTextField.Location = new System.Drawing.Point(41, 10);
            this.nameTextField.Name = "nameTextField";
            this.nameTextField.Size = new System.Drawing.Size(107, 20);
            this.nameTextField.TabIndex = 4;
            // 
            // partyTextField
            // 
            this.partyTextField.Location = new System.Drawing.Point(41, 36);
            this.partyTextField.Name = "partyTextField";
            this.partyTextField.Size = new System.Drawing.Size(107, 20);
            this.partyTextField.TabIndex = 5;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(73, 62);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
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
            this.connectButton.Click += new System.EventHandler(this.connect_Click);
            // 
            // disconnectButton
            // 
            this.disconnectButton.Location = new System.Drawing.Point(5, 10);
            this.disconnectButton.Name = "disconnectButton";
            this.disconnectButton.Size = new System.Drawing.Size(75, 23);
            this.disconnectButton.TabIndex = 10;
            this.disconnectButton.Text = "Disconnect";
            this.disconnectButton.UseVisualStyleBackColor = true;
            this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
            // 
            // inputPanel
            // 
            this.inputPanel.Controls.Add(this.enterButton);
            this.inputPanel.Controls.Add(this.partyTextField);
            this.inputPanel.Controls.Add(this.nameTextField);
            this.inputPanel.Controls.Add(this.partyLabel);
            this.inputPanel.Controls.Add(this.nameLabel);
            this.inputPanel.Enabled = false;
            this.inputPanel.Location = new System.Drawing.Point(3, 3);
            this.inputPanel.Name = "inputPanel";
            this.inputPanel.Size = new System.Drawing.Size(151, 93);
            this.inputPanel.TabIndex = 11;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(74, 102);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 12;
            this.deleteButton.Text = "delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // waitingPanel
            // 
            this.waitingPanel.Controls.Add(this.deleteButton);
            this.waitingPanel.Controls.Add(this.inputPanel);
            this.waitingPanel.Controls.Add(this.dataGridView1);
            this.waitingPanel.Location = new System.Drawing.Point(2, 39);
            this.waitingPanel.Name = "waitingPanel";
            this.waitingPanel.Size = new System.Drawing.Size(647, 251);
            this.waitingPanel.TabIndex = 13;
            // 
            // tablePanel
            // 
            this.tablePanel.Controls.Add(this.orderButton);
            this.tablePanel.Controls.Add(this.clearButton);
            this.tablePanel.Controls.Add(this.assignButton);
            this.tablePanel.Controls.Add(this.tableGrid);
            this.tablePanel.Location = new System.Drawing.Point(2, 39);
            this.tablePanel.Name = "tablePanel";
            this.tablePanel.Size = new System.Drawing.Size(647, 251);
            this.tablePanel.TabIndex = 14;
            // 
            // orderButton
            // 
            this.orderButton.Enabled = false;
            this.orderButton.Location = new System.Drawing.Point(3, 58);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 16;
            this.orderButton.Text = "check order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(3, 32);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "clear table";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clean_table);
            // 
            // assignButton
            // 
            this.assignButton.Enabled = false;
            this.assignButton.Location = new System.Drawing.Point(3, 6);
            this.assignButton.Name = "assignButton";
            this.assignButton.Size = new System.Drawing.Size(75, 23);
            this.assignButton.TabIndex = 14;
            this.assignButton.Text = "Assign";
            this.assignButton.UseVisualStyleBackColor = true;
            this.assignButton.Click += new System.EventHandler(this.seat_customer);
            // 
            // tableGrid
            // 
            this.tableGrid.AllowUserToResizeColumns = false;
            this.tableGrid.AllowUserToResizeRows = false;
            this.tableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableGrid.Location = new System.Drawing.Point(79, 6);
            this.tableGrid.MultiSelect = false;
            this.tableGrid.Name = "tableGrid";
            this.tableGrid.ReadOnly = true;
            this.tableGrid.Size = new System.Drawing.Size(564, 232);
            this.tableGrid.TabIndex = 13;
            this.tableGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableGrid_CellClick);
            this.tableGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.tableGrid_RowHeaderMouseClick);
            // 
            // orderPanel
            // 
            this.orderPanel.Controls.Add(this.foodPanel);
            this.orderPanel.Controls.Add(this.textBox1);
            this.orderPanel.Controls.Add(this.label1);
            this.orderPanel.Controls.Add(this.label3);
            this.orderPanel.Controls.Add(this.orderList);
            this.orderPanel.Controls.Add(this.addOrderButton);
            this.orderPanel.Controls.Add(this.foodGrid);
            this.orderPanel.Controls.Add(this.backButton);
            this.orderPanel.Location = new System.Drawing.Point(2, 39);
            this.orderPanel.Name = "orderPanel";
            this.orderPanel.Size = new System.Drawing.Size(647, 251);
            this.orderPanel.TabIndex = 17;
            // 
            // foodPanel
            // 
            this.foodPanel.Controls.Add(this.tableNum);
            this.foodPanel.Controls.Add(this.label4);
            this.foodPanel.Controls.Add(this.deleteOrderButton);
            this.foodPanel.Controls.Add(this.changeOrderButton);
            this.foodPanel.Controls.Add(this.foodBox);
            this.foodPanel.Controls.Add(this.idBox);
            this.foodPanel.Controls.Add(this.label2);
            this.foodPanel.Controls.Add(this.nameBox);
            this.foodPanel.Controls.Add(this.quantity);
            this.foodPanel.Controls.Add(this.idLabel);
            this.foodPanel.Location = new System.Drawing.Point(0, 28);
            this.foodPanel.Name = "foodPanel";
            this.foodPanel.Size = new System.Drawing.Size(189, 122);
            this.foodPanel.TabIndex = 33;
            // 
            // tableNum
            // 
            this.tableNum.AutoSize = true;
            this.tableNum.Location = new System.Drawing.Point(52, 10);
            this.tableNum.Name = "tableNum";
            this.tableNum.Size = new System.Drawing.Size(27, 13);
            this.tableNum.TabIndex = 32;
            this.tableNum.Text = "N/A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 31;
            this.label4.Text = "table:";
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(101, 92);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(85, 23);
            this.deleteOrderButton.TabIndex = 25;
            this.deleteOrderButton.Text = "delete";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // changeOrderButton
            // 
            this.changeOrderButton.Location = new System.Drawing.Point(4, 92);
            this.changeOrderButton.Name = "changeOrderButton";
            this.changeOrderButton.Size = new System.Drawing.Size(91, 23);
            this.changeOrderButton.TabIndex = 24;
            this.changeOrderButton.Text = "change";
            this.changeOrderButton.UseVisualStyleBackColor = true;
            this.changeOrderButton.Click += new System.EventHandler(this.changeOrder);
            // 
            // foodBox
            // 
            this.foodBox.AutoSize = true;
            this.foodBox.Location = new System.Drawing.Point(52, 49);
            this.foodBox.Name = "foodBox";
            this.foodBox.Size = new System.Drawing.Size(27, 13);
            this.foodBox.TabIndex = 23;
            this.foodBox.Text = "N/A";
            // 
            // idBox
            // 
            this.idBox.AutoSize = true;
            this.idBox.Location = new System.Drawing.Point(51, 30);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(27, 13);
            this.idBox.TabIndex = 22;
            this.idBox.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "quantity:";
            // 
            // nameBox
            // 
            this.nameBox.AutoSize = true;
            this.nameBox.Location = new System.Drawing.Point(17, 48);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(36, 13);
            this.nameBox.TabIndex = 20;
            this.nameBox.Text = "name:";
            // 
            // quantity
            // 
            this.quantity.Location = new System.Drawing.Point(54, 66);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(41, 20);
            this.quantity.TabIndex = 19;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(10, 30);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(44, 13);
            this.idLabel.TabIndex = 16;
            this.idLabel.Text = "order #:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(73, 186);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(41, 20);
            this.textBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "name:";
            // 
            // orderList
            // 
            this.orderList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.orderList.FormattingEnabled = true;
            this.orderList.Location = new System.Drawing.Point(73, 160);
            this.orderList.Name = "orderList";
            this.orderList.Size = new System.Drawing.Size(113, 21);
            this.orderList.TabIndex = 27;
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(73, 212);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(62, 23);
            this.addOrderButton.TabIndex = 26;
            this.addOrderButton.Text = "add";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.addOrderButton_Click);
            // 
            // foodGrid
            // 
            this.foodGrid.AllowUserToResizeColumns = false;
            this.foodGrid.AllowUserToResizeRows = false;
            this.foodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.foodGrid.Location = new System.Drawing.Point(195, 6);
            this.foodGrid.MultiSelect = false;
            this.foodGrid.Name = "foodGrid";
            this.foodGrid.ReadOnly = true;
            this.foodGrid.Size = new System.Drawing.Size(448, 232);
            this.foodGrid.TabIndex = 15;
            this.foodGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.foodGrid_CellClick);
            this.foodGrid.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.foodGrid_RowHeaderMouseClick);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(124, 6);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(65, 23);
            this.backButton.TabIndex = 14;
            this.backButton.Text = "<< back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Waiting list",
            "Table list"});
            this.comboBox1.Location = new System.Drawing.Point(510, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(135, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.panel_change);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(652, 311);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.messageLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.disconnectButton);
            this.Controls.Add(this.orderPanel);
            this.Controls.Add(this.tablePanel);
            this.Controls.Add(this.waitingPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.inputPanel.ResumeLayout(false);
            this.inputPanel.PerformLayout();
            this.waitingPanel.ResumeLayout(false);
            this.tablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableGrid)).EndInit();
            this.orderPanel.ResumeLayout(false);
            this.orderPanel.PerformLayout();
            this.foodPanel.ResumeLayout(false);
            this.foodPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foodGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label partyLabel;
        private System.Windows.Forms.TextBox nameTextField;
        private System.Windows.Forms.TextBox partyTextField;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label messageLabel;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button disconnectButton;
        private System.Windows.Forms.Panel inputPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Panel waitingPanel;
        private System.Windows.Forms.Panel tablePanel;
        private System.Windows.Forms.DataGridView tableGrid;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button assignButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.Panel orderPanel;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.DataGridView foodGrid;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label nameBox;
        private System.Windows.Forms.TextBox quantity;
        private System.Windows.Forms.Label foodBox;
        private System.Windows.Forms.Label idBox;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.Button changeOrderButton;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox orderList;
        private System.Windows.Forms.Label tableNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel foodPanel;
    }
}

