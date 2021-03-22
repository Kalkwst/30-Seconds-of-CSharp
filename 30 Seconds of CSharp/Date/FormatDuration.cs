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
        /// Returns the human-readable format of the given number in milliseconds.
        /// </summary>
        /// <param name="ms">The duration in milliseconds</param>
        /// <returns>The duration formated in days, hours, minutes, seconds and milliseconds.</returns>
        public static string FormatDuration(long ms)
        {
            if (ms < 0)
            {
                ms = -ms;
            }

            Dictionary<string, long> time = new()
            {
                { "day", (long)Math.Floor(ms / 86400000d) },
                { "hour", (long)Math.Floor(ms / 3600000d) % 24 },
                { "minute", (long)Math.Floor(ms / 60000d) % 60 },
                { "second", (long)Math.Floor(ms / 1000d) % 60 },
                { "millisecond", (long)Math.Floor((double)ms % 1000) }
            };

            return string.Join(", ",
                                    time
                                    .Where(val => val.Value != 0)
                                    .Select(val => string.Format("{0} {1}{2}", val.Value, val.Key, (val.Value != 1 ? "s" : "")))
                                    .ToArray());


        }
    }
}
