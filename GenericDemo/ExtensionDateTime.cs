using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDemo
{
    public static class ExtensionDateTime
    {
        public static DateTime BeginOfDay(this DateTime dt)=> new DateTime(dt.Year, dt.Month, dt.Day, 0, 0, 0);
 
    }
}
