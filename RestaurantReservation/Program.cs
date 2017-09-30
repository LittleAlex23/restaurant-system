using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantReservation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Reservation frm = new Reservation();
            MySQLDataBaseConnection sql = MySQLDataBaseConnection.GetInstance();
            Controller c = new Controller(frm, sql);

            Application.Run(frm);
        }
    }
}
