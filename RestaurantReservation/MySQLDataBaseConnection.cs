using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace RestaurantReservation
{
    class MySQLDataBaseConnection
    {
        public static MySQLDataBaseConnection sql;
        private MySqlDataAdapter myDataAdapter;
        private MySqlConnection myConn;

        private  MySQLDataBaseConnection(){
            myDataAdapter = new MySqlDataAdapter();
        }

        // Singleton design pattern
        public static MySQLDataBaseConnection getInstance()
        {
            if (sql == null)
                sql = new MySQLDataBaseConnection();
            return sql;
        }

        // Connect to the database
        public void connect(string[] str) {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = str[0];
            builder.UserID = str[1];
            builder.Password = str[2];
            builder.Database = str[3];

            // Connect to MySQL server
            myConn = new MySqlConnection(builder.ToString());
            myConn.Open();
        }

        // Disconnect from the database
        public void disconnect() {
            myConn.Close();
        }

        // Retrieve all the rows from the name column of FOOD table
        public List<String> getFoodList(string queryString) {
            MySqlCommand query = new MySqlCommand(queryString, myConn);
            MySqlDataReader myReader = query.ExecuteReader();
            List<String> list = new List<String>();
            while (myReader.Read())
                list.Add(myReader.GetString(0));
            myReader.Close();
            return list;
        }

        // Populate table with data from database
        public MySqlDataAdapter populateTable(string queryString) {
            return new MySqlDataAdapter(queryString, myConn);
        }

        // Insert a new row to WAITING_CUST table
        public Int32 addPartyToWaitingList(string name, Int32 size) {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO WAITING_CUST(Fname,Party) VALUES(?,?)", myConn);
            cmd.Parameters.Add("Fname", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("Party", MySqlDbType.Int32).Value = size;
            cmd.ExecuteNonQuery();

            return Convert.ToInt32(new MySqlCommand("SELECT LAST_INSERT_ID()", myConn).ExecuteScalar());
        }

        // Delete a row from WAITING_CUST table
        public void deleteParty(string name) {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM WAITING_CUST WHERE Fname = ?", myConn);
            cmd.Parameters.Add("Fname", MySqlDbType.VarChar).Value = name;
            cmd.ExecuteNonQuery();
        }

        // Update a row from CUST_TABLE table
        public void cleanTable(Int32 id) {
            String queryString = "UPDATE CUST_TABLE SET FNAME = NULL, PARTY = 0, isAvailable = 1 WHERE TID = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, myConn);
            cmd.Parameters.Add("TID", MySqlDbType.Int32).Value = id;
            cmd.ExecuteNonQuery();
        }

        // Insert a new row to CUST_ORDER table
        public int addOrder(string tableID, int foodID, string quantity) {
            MySqlCommand cmd = new MySqlCommand("INSERT INTO CUST_ORDER(ID,FID,QUANTITY) VALUES(?,?,?)", myConn);
            cmd.Parameters.Add("ID", MySqlDbType.Int32).Value = tableID;
            cmd.Parameters.Add("FID", MySqlDbType.Int32).Value = foodID;
            cmd.Parameters.Add("QUANTITY", MySqlDbType.Int32).Value = quantity;
            cmd.ExecuteNonQuery();
            cmd = new MySqlCommand("SELECT LAST_INSERT_ID()", myConn);
            return Convert.ToInt32(cmd.ExecuteScalar());
        }

        // Remove a row from CUST_ORDER table
        public void removeOrder(string ID) {
            MySqlCommand cmd = new MySqlCommand("DELETE FROM CUST_ORDER WHERE orderID = ?", myConn);
            cmd.Parameters.Add("orderID", MySqlDbType.Int32).Value = ID;
            cmd.ExecuteNonQuery();
        }

        // Update a row from CUST_ORDER table with different quantity
        public void changeOrder(string quantity, string orderID) {
            String queryString = "UPDATE CUST_ORDER SET QUANTITY = ? WHERE orderID = ?";
            MySqlCommand cmd = new MySqlCommand(queryString, myConn);
            cmd.Parameters.Add("QUANTITY", MySqlDbType.Int32).Value = quantity;
            cmd.Parameters.Add("orderID", MySqlDbType.Int32).Value = orderID;
            cmd.ExecuteNonQuery();
        }

        // Insert new a row to CUST_TABLE table
        // Then delete a row from WAITING_CUST table
        public void transferCustomerToTable(string tid, string name, Int32 partySize, string partyID)
        {
            String queryString = "UPDATE CUST_TABLE SET FNAME = ?, PARTY = ?, isAvailable =? WHERE TID = " + tid;
            MySqlCommand cmd = new MySqlCommand(queryString, myConn);

            cmd.Parameters.Add("FNAME", MySqlDbType.VarChar).Value = name;
            cmd.Parameters.Add("PARTY", MySqlDbType.Int32).Value = partySize;
            cmd.Parameters.Add("isAvailable", MySqlDbType.Bit).Value = 0;
            cmd.ExecuteNonQuery();

            queryString = "DELETE FROM WAITING_CUST WHERE ID = ?";
            cmd = new MySqlCommand(queryString, myConn);
            cmd.Parameters.Add("ID", MySqlDbType.Int32).Value = partyID;
            cmd.ExecuteNonQuery();
        }
    }
}
