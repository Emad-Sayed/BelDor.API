using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public static class DateTimeServer
    {
        public static int Difference = 9;
        public static DateTime AddServerTimeHours(this DateTime date)
        {
            //return date.AddHours(0);
            return date.AddHours(Difference);
        }
    }
}