using System;
using System.Collections.Generic;
using System.Data;
namespace RestaurantReservation
{
    // this controller class only communicates with MySQL database
    public class Controller
    {
        private MySQLDataBaseConnection sql;
        private Reservation f;
        public Controller() {}
        public Controller(Reservation f, MySQLDataBaseConnection sql)
        {
            this.f = f;
            this.sql = sql;
            f.SetController(this);
        }
        public void Connect(string server, string userId, string pwd, string dbName) {
            sql.Connect(new string[4] {server, userId, pwd, dbName});
        }
        public void Disconnect() {
            sql.Disconnect();
        }
        public DataTable FillTable(string tableName, DataTable dt)
        {
            sql.PopulateTable(tableName, dt);
            return dt;
        }
        public DataTable FillCustomerOrderTable(string tableName, DataTable dt)
        {
            sql.PopulateCustomerOrderTable(tableName, dt);
            return dt;
        }
        public Int32 AddPartyToWaitinglist(string name, Int32 size) {
            return sql.AddPartyToWaitingList(name, size);
        }
        public void DeletePartyFromWaitingList(string name) {
            sql.DeleteParty(name);
        }
        public void CleanTable(Int32 id) {
            sql.CleanTable(id);
        }
        public decimal[] AddOrder(string tableID, int foodID, string quantity) {
            return(sql.AddOrder(tableID, foodID, quantity));
        }
        public List<String> GetFoodList(string query) {
            return sql.GetFoodList(query);
        }

        public void SeatCustomer(string TID, string name, Int32 partySize, string partyID) {
            sql.TransferCustomerToTable(TID, name, partySize, partyID);
        }
        public void RemoveOrder(string ID) {
            sql.RemoveOrder(ID);
        }
        public void ChangeOrder(string quanity, string orderID)
        {
            sql.ChangeOrder(quanity, orderID);
        }
        public void ChangeStock(string stock, string fid) {
            sql.ChangeStockCount(stock, fid);
        }
    }
}
