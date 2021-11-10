using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public static class ExtensionDateTime
    {
        public static DateTime BeginOfDay(this DateTime dt)=> new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
        public static DateTime BeginOfWeek(this DateTime dt)
        {
            
            var week = (int)dt.DayOfWeek;
            return dt.AddDays(-week).BeginOfDay();
        }
        public static DateTime BeginOfWeek(this DateTime dt,Calendar calendar)
        {
            //calendar.

            var week = (int)calendar.GetDayOfWeek(dt);
            return dt.AddDays(-week).BeginOfDay();
        }

    }
}
