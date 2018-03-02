using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantReservation
{
    class Validation
    {
        public static bool IsNameValid(string str) {
            if (str.Length < 3)
                return false;
            foreach (char c in str)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }
        public static bool IsNumberPositive(string str) {
            if (str.Length == 0)
                return false;
            foreach (char c in str)
            {
                if (!Char.IsNumber(c))
                    return false;
            }
            return true;
        } 
    }
}
