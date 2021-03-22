using System;
using System.Collections.Generic;
using System.Linq;

namespace _30_Seconds_of_CSharp.Date
{
    public static partial class DateUtils
    {
        /// <summary>
        /// Adds the given number of week days to the given DateTime.
        /// </summary>
        /// <param name="startingDate">The date to be changed.</param>
        /// <param name="count">The number of weekdays to add</param>
        /// <param name="holidays">An optional list of holidays to consider</param>
        /// <returns>A DateTime increased by the given number of week days, considering holidays</returns>
        public static DateTime AddWeekDays(DateTime startingDate, int count, IEnumerable<DateTime> holidays = null)
        {
            var days = Math.Abs(count);

            for (int i = 0; i < days; i++)
            {
                do
                {
                    startingDate = startingDate.AddDays(1);
                } while (
                    startingDate.DayOfWeek == DayOfWeek.Saturday
                 || startingDate.DayOfWeek == DayOfWeek.Sunday
                 || holidays != null && holidays.Contains(startingDate.Date));
            }

            return startingDate;
        }
    }
}
