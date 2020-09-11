using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public static class DateTimeServer
    {
        public static DateTime AddServerTimeHours(this DateTime date)
        {
            return date.AddHours(2); // GMT From Egyption Time
        }
        public static DateTime GetServerDateTimeNow(this DateTime date)
        {
            return date.AddHours(2).Date; // GMT From Egyption Time
        }
    }
}