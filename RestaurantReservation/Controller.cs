using System;
using System.Collections.Generic;
using System.Data;
namespace RestaurantReservation
{
    // this controller class only communicates with MySQL database
    public class Controller
    {
        private MySQLDataBaseConnection sql;
        public Controller() {
            sql = MySQLDataBaseConnection.getInstance();
        }
        public void connect(string server, string userId, string pwd, string dbName) {
            sql.connect(new string[4] {server, userId, pwd, dbName});
        }
        public void disconnect() {
            sql.disconnect();
        }
        public DataTable fillTable(string queryString, DataTable table)
        {
            sql.populateTable(queryString).Fill(table);
            return table;
        }
        public Int32 addPartyToWaitinglist(string name, Int32 size) {
            return sql.addPartyToWaitingList(name, size);
        }
        public void deletePartyFromWaitingList(string name) {
            sql.deleteParty(name);
        }
        public void cleanTable(Int32 id) {
            sql.cleanTable(id);
        }
        public decimal[] addOrder(string tableID, int foodID, string quantity) {
            return(sql.addOrder(tableID, foodID, quantity));
        }
        public List<String> getFoodList(string query) {
            return sql.getFoodList(query);
        }

        public void seatCustomer(string TID, string name, Int32 partySize, string partyID) {
            sql.transferCustomerToTable(TID, name, partySize, partyID);
        }
        public void removeOrder(string ID) {
            sql.removeOrder(ID);
        }
        public void changeOrder(string quanity, string orderID)
        {
            sql.changeOrder(quanity, orderID);
        }

        public void addItem(Int32 fid, string name, string stock)
        {
            sql.addItem(fid, name, stock);
        }
        public void changeStock(string stock, string fid) {
            sql.changeStockCount(stock, fid);
        }
    }
}
