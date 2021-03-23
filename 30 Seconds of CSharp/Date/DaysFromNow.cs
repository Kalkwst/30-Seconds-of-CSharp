using System;

namespace _30_Seconds_of_CSharp.Date
{
    public static partial class DateUtils
    {
        /// <summary>
        /// Calculates the date of <c>n</c> from the provided day as a string representation.
        /// </summary>
        /// <param name="current">The date to start calculating</param>
        /// <param name="count">The number of days in the future</param>
        /// <returns>The future date</returns>
        public static DateTime DaysFromNow(DateTime current, int count)
        {
            int days = Math.Abs(count);

            for (int i = 0; i < days; i++)
            {
                current = current.AddDays(1);
            }

            return current;
        }
    }
}