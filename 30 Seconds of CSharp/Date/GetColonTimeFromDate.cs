using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Seconds_of_CSharp.Date
{
    public static partial class DateUtils
    {
        /// <summary>
        /// Returns a string of the form <c>HH:mm:ss</c>, from a <c>DateTime</c> object.
        /// </summary>
        /// <param name="time">the DateTime object to get the time component</param>
        /// <returns>The time component in the form of <c>HH:mm:ss</c></returns>
        public static string GetColonTimeFromDate(DateTime time)
        {
            return time.ToString("HH:mm:ss");
        }
    }
}