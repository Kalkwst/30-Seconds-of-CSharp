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
        /// Checks if a date is after another date.
        /// </summary>
        /// <param name="dateA">The first date</param>
        /// <param name="dateB">The second date</param>
        /// <returns><c>true</c> if the first date is after the second date</returns>
        public static bool IsAfterDate(DateTime dateA, DateTime dateB)
        {
            return dateA > dateB;
        }
    }
}
