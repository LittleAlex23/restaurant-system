using System;
using System.Data;
using System.Linq;

namespace RestaurantReservation
{
    class PriceCalculator
    {
        public string Calculate(DataTable dt) {

            return dt.AsEnumerable().Sum(x => (x.Field<Int32>("QUANTITY")) * x.Field<decimal>("PRICE")).ToString();
        }
    }
}
