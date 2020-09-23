﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Helpers
{
    public static class DateTimeServer
    {
        public static DateTime AddServerTimeHours(this DateTime date)
        {
            return date.AddHours(9); // GMT From Egyption Time
        }
    }
}