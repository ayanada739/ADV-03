using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_03
{
    internal class CompareFunctions
    {
        public static bool ComapreGrt(int X, int Y)
        {
            return X > Y;
        }



        public static bool ComapreLess(int X, int Y)
        {
            return X < Y;
        }


        public static bool SortAscending(string X , string Y)
        {
            return X?.Length > Y?.Length;

        }



        public static bool SortDescending(string X, string Y)
        {
            return X?.Length < Y?.Length;

        }

    }
}
