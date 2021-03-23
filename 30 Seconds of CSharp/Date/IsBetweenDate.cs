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
        /// Check if a date is between two other dates
        /// </summary>
        /// <param name="dateStart">The first date</param>
        /// <param name="dateEnd">The second date</param>
        /// <param name="date">The date to check</param>
        /// <returns><c>true</c> if <c>date</c> is between <c>dateStart</c> and <c>dateEnd</c></returns>
        public static bool IsBetweenDate(DateTime dateStart, DateTime dateEnd, DateTime date)
        {
            return date > dateStart && date < dateEnd;
        }
    }
}