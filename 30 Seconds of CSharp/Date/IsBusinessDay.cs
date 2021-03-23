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
        /// Checks if the given date is a bussiness day.
        /// </summary>
        /// <param name="targetDate">The date to check</param>
        /// <param name="holidays">An optional list of holidays to consider</param>
        /// <returns><c>true</c> if the date is a business day</returns>
        public static bool IsBusinessDay(DateTime targetDate, IEnumerable<DateTime> holidays = null)
        {
            return !(
                         targetDate.DayOfWeek == DayOfWeek.Saturday
                      || targetDate.DayOfWeek == DayOfWeek.Sunday
                      || holidays != null && holidays.Contains(targetDate.Date));
        }
    }
}
