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
        /// Calculates the difference (in days) between two dates
        /// </summary>
        /// <param name="dateInitial">The initial date</param>
        /// <param name="dateFinal">The final date</param>
        /// <returns>The difference between the two dates in days</returns>
        public static int GetDaysDiffBetweenDates(DateTime dateInitial, DateTime dateFinal)
        {
            return (int)((long)(dateFinal - dateInitial).TotalMilliseconds / (1000 * 3600 * 24)); 
        }
    }
}
