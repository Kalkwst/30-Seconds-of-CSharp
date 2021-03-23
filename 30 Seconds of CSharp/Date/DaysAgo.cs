using System;

namespace _30_Seconds_of_CSharp.Date
{
    public static partial class DateUtils
    {
        /// <summary>
        /// Calculates the date of <c>n</c> days ago from the given day as a string representation.
        /// </summary>
        /// <param name="current">The date to start</param>
        /// <param name="count">The number of days in the past</param>
        /// <returns>The date <c>n</c> days before the provided date</returns>
        public static DateTime DaysAgo(DateTime current, int count)
        {
            int days = Math.Abs(count);

            for(int i = 0; i < days; i++)
            {
                current = current.AddDays(-1);
            }

            return current;
        }
    }
}
