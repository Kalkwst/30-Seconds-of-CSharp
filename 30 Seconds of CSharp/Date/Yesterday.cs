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
        /// Return a string representation of yesterday's date.
        /// </summary>
        /// <returns>The yesterday's date in <c>yyyy-MM-DD</c> format</returns>
        public static string Yesterday()
        {
            return DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd");
        }
    }
}
