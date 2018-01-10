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

        // Retrieve all the rows from the name column of FOOD table
        public List<String> GetFoodList(string queryString) {
            MySqlCommand query = new MySqlCommand(queryString, conn);
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
        public DataTable PopulateCustomerOrderTable(string id, DataTable table)
        {
            MySqlCommand command = new MySqlCommand("SELECT orderID, C.FID as Num, NAME, QUANTITY, PRICE FROM CUST_ORDER AS C JOIN FOOD AS F ON C.FID = F.FID WHERE ID = ?", conn);
            command.Parameters.Add("1", MySqlDbType.VarChar).Value = id;
            MySqlDataAdapter adapter = new MySqlDataAdapter()
            {
                SelectCommand = command
            };

            adapter.Fill(table);
            return table;
        }

        // Insert a new row to WAITING_CUST table
        public Int32 AddPartyToWaitingList(string name, Int32 size) {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO WAITING_CUST(Fname,Party) VALUES(?,?)", conn);
            cmd.Parameters.Add("Fname", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("Party", MySqlDbType.Int32).Value = size;
            cmd.ExecuteNonQuery();

            return Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID()", conn).ExecuteScalar());
        }

        // Delete a row from WAITING_CUST table
        public void DeleteParty(string name) {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM WAITING_CUST WHERE Fname = ?", conn);
            cmd.Parameters.Add("Fname", MySqlDbType.VarChar).Value = name;
            cmd.ExecuteNonQuery();
        }

        // Update a row from CUST_TABLE table
        public void CleanTable(Int32 id) {
            String queryString = "UPDATE CUST_TABLE SET FNAME = NULL, PARTY = 0, isAvailable = 1 WHERE TID = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("TID", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }

        // Insert a new row to CUST_ORDER table
        public decimal[] AddOrder(string tableID, int foodID, string quantity) {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO CUST_ORDER(ID,FID,QUANTITY) VALUES(?,?,?)", conn);
            cmd.Parameters.Add("ID", MySqlDbType.Int32).Value = tableID;
            cmd.Parameters.Add("FID", MySqlDbType.Int32).Value = foodID;
            cmd.Parameters.Add("QUANTITY", MySqlDbType.Int32).Value = quantity;
            cmd.ExecuteNonQuery();

            decimal[] values = new decimal[2];
            cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", conn);
            values[0] = Convert.ToInt32(cmd.ExecuteScalar());

            cmd = new MySqlCommand("SELECT PRICE FROM FOOD WHERE FID = ?", conn);
            cmd.Parameters.Add("FID", MySqlDbType.Int32).Value = foodID;
            values[1] = Convert.ToDecimal(cmd.ExecuteScalar());
            return values;
        }

        // Remove a row from CUST_ORDER table
        public void RemoveOrder(string ID) {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM CUST_ORDER WHERE orderID = ?", conn);
            cmd.Parameters.Add("orderID", MySqlDbType.Int32).Value = ID;
            cmd.ExecuteNonQuery();
        }

        // Update a row from CUST_ORDER table with different quantity
        public void ChangeOrder(string quantity, string orderID) {
            String queryString = "UPDATE CUST_ORDER SET QUANTITY = ? WHERE orderID = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("QUANTITY", MySqlDbType.Int32).Value = quantity;
            cmd.Parameters.Add("orderID", MySqlDbType.Int32).Value = orderID;
            cmd.ExecuteNonQuery();
        }

        // Insert new a row to CUST_TABLE table
        // Then delete a row from WAITING_CUST table
        public void TransferCustomerToTable(string tid, string name, Int32 partySize, string partyID)
        {
            String queryString = "UPDATE CUST_TABLE SET FNAME = ?, PARTY = ?, isAvailable =? WHERE TID = " + tid;
            MySqlCommand cmd = new MySqlCommand(queryString, conn);

            cmd.Parameters.Add("FNAME", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("PARTY", MySqlDbType.Int32).Value = partySize;
            cmd.Parameters.Add("isAvailable", MySqlDbType.Bit).Value = 0;
            cmd.ExecuteNonQuery();

            queryString = "DELETE FROM WAITING_CUST WHERE ID = ?";
            cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("ID", MySqlDbType.Int32).Value = partyID;
            cmd.ExecuteNonQuery();
        }

        // Insert a new row to FOOD table
        public void AddItem(Int32 fid, string name, string stock)
        {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO FOOD VALUES(?,?,?)", conn);
            cmd.Parameters.Add("FID", MySqlDbType.Int32).Value = fid;
            cmd.Parameters.Add("NAME", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("STOCK", MySqlDbType.Int32).Value = stock;
            cmd.ExecuteNonQuery();
        }

        // Update a row from FOOD table
        public void ChangeStockCount(string stock, string fid)
        {
            String queryString = "UPDATE FOOD SET STOCK = ? WHERE FID = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, conn);
            cmd.Parameters.Add("STOCK", MySqlDbType.Int32).Value = stock;
            cmd.Parameters.Add("FID", MySqlDbType.Int32).Value = fid;
            cmd.ExecuteNonQuery();
        }

    }
}
