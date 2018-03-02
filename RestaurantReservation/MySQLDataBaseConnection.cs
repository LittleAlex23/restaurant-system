using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace RestaurantReservation
{
    public class MySQLDataBaseConnection
    {
        private static MySQLDataBaseConnection sql;
        private MySqlDataAdapter myDataAdapter;
        private MySqlConnection conn;

        private MySQLDataBaseConnection(){
            myDataAdapter = new MySqlDataAdapter();
        }

        // Singleton design pattern
        public static MySQLDataBaseConnection GetInstance()
        {
            if (sql == null)
                sql = new MySQLDataBaseConnection();
            return sql;
        }

        // Connect to the database
        public void Connect(string[] str) {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder
            {
                Server = str[0],
                UserID = str[1],
                Password = str[2],
                Database = str[3]
            };

            // Connect to MySQL server
            conn = new MySqlConnection(builder.ToString());

            conn.Open();
        }

        // Disconnect from the database
        public void Disconnect() {
            conn.Close();
        }

        // Retrieve all the rows from the name column of STOCK table
        public List<String> GetStockList() {
            MySqlCommand query = new MySqlCommand("SELECT DNAME FROM DISH", conn);
            MySqlDataReader myReader = query.ExecuteReader();
            List<String> list = new List<String>();
            while (myReader.Read())
                list.Add(myReader.GetString(0));
            myReader.Close();
            return list;
        }
        // Populate table with data from database
        public DataTable PopulateTable(string tableName, DataTable table) {
            MySqlCommand command = new MySqlCommand("SELECT * FROM " + tableName, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter() 
            {
                SelectCommand = command
            };
            adapter.Fill(table);
            return table;
        }

        // Show the list of orders from the selected party
        public DataTable PopulateCustomerOrderTable(string id, DataTable table)
        {
            string queryString = "SELECT ORDER_ID, C.CID as Dish_ID, DNAME, QUANTITY, PRICE FROM CUST_ORDER AS C JOIN DISH AS D ON C.DID = D.ID WHERE C.CID = ?";
            MySqlCommand command = new MySqlCommand(queryString, conn);
            command.Parameters.Add("1", MySqlDbType.VarChar).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter()
            {
                SelectCommand = command
            };

            adapter.Fill(table);
            return table;
        }

        // Check if a name is taken
        public Boolean CheckIfNameAvailable(string name) {
            MySqlCommand cmd = new MySqlCommand("SELECT PNAME FROM waiting_cust WHERE PNAME = ?", conn);
            cmd.Parameters.Add("PNAME", MySqlDbType.VarChar).Value = name;
            return cmd.ExecuteScalar() == null;
        }

        // Insert a new row to WAITING_CUST table
        public Int32 AddPartyToWaitingList(string name, Int32 size) {
            Int32 id = -1;
            if (CheckIfNameAvailable(name)) {
                MySqlCommand cmd = new MySqlCommand("INSERT INTO WAITING_CUST(pname,size) VALUES(?,?)", conn);
                cmd.Parameters.Add("pname", MySqlDbType.VarChar).Value = name;
                cmd.Parameters.Add("size", MySqlDbType.Int32).Value = size;
                cmd.ExecuteNonQuery();
                id = Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar());
            }
            return id;
        }

        // Delete a row from WAITING_CUST table
        public void DeleteParty(string name) {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM WAITING_CUST WHERE pname = ?", conn);
            cmd.Parameters.Add("pname", MySqlDbType.VarChar).Value = name;
            cmd.ExecuteNonQuery();
        }

        // Update a row from CUST_TABLE table
        public void CleanTable(Int32 id) {
            String queryString = "UPDATE CUST_TABLE SET PNAME = NULL, SIZE = 0, isAvailable = 1 WHERE CID = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("CID", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }

        // Insert a new row to CUST_ORDER table
        public decimal[] AddOrder(string tableID, int dishID, string quantity) {
            string queryString = "INSERT INTO CUST_ORDER(DID,CID,QUANTITY) VALUES(?,?,?)";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("DID", MySqlDbType.Int32).Value = dishID;
            cmd.Parameters.Add("CID", MySqlDbType.Int32).Value = tableID;
            cmd.Parameters.Add("QUANTITY", MySqlDbType.Int32).Value = quantity;
            cmd.ExecuteNonQuery();

            decimal[] values = new decimal[2];
            cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
            values[0] = Convert.ToInt32(cmd.ExecuteScalar());

            cmd = new MySqlCommand("SELECT PRICE FROM DISH WHERE ID = ?", conn);
            cmd.Parameters.Add("ID", MySqlDbType.Int32).Value = dishID;
            values[1] = Convert.ToDecimal(cmd.ExecuteScalar());
            return values;
        }

        // Remove a row from CUST_ORDER table
        public void RemoveOrder(string ID) {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM CUST_ORDER WHERE order_id = ?", conn);
            cmd.Parameters.Add("order_id", MySqlDbType.Int32).Value = ID;
            cmd.ExecuteNonQuery();
        }

        // Update a row from CUST_ORDER table with different quantity
        public void ChangeOrder(string quantity, string orderID) {
            String queryString = "UPDATE CUST_ORDER SET QUANTITY = ? WHERE order_id = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("QUANTITY", MySqlDbType.Int32).Value = quantity;
            cmd.Parameters.Add("order_id", MySqlDbType.Int32).Value = orderID;
            cmd.ExecuteNonQuery();
        }

        // Insert new a row to CUST_TABLE table
        // Then delete a row from WAITING_CUST table with the same id
        public void TransferCustomerToTable(string tid, string name, Int32 partySize, string partyID)
        {
            String queryString = "UPDATE CUST_TABLE SET PNAME = ?, SIZE = ?, isAvailable = ? WHERE CID = " + tid;
            MySqlCommand cmd = new MySqlCommand(queryString, conn);

            cmd.Parameters.Add("PNAME", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("SIZE", MySqlDbType.Int32).Value = partySize;
            cmd.Parameters.Add("isAvailable", MySqlDbType.Bit).Value = 0;
            cmd.ExecuteNonQuery();

            queryString = "DELETE FROM WAITING_CUST WHERE WID = ?";
            cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("WID", MySqlDbType.Int32).Value = partyID;
            cmd.ExecuteNonQuery();
        }

        // Update a row from DISH table
        public void ChangeStockCount(string stock, string fid)
        {
            String queryString = "UPDATE DISH SET STOCK = ? WHERE ID = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("STOCK", MySqlDbType.Int32).Value = stock;
            cmd.Parameters.Add("ID", MySqlDbType.Int32).Value = fid;
            cmd.ExecuteNonQuery();
        }

    }
}
