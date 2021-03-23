namespace _30_Seconds_of_CSharp.Date
{
    public static partial class DateUtils
    {
        /// <summary>
        /// Converts an integer to a suffixed string, adding <c>am</c> or <c>pm</c> based on its value.
        /// </summary>
        /// <param name="num">The integer to convert</param>
        /// <returns>The converted suffixed string</returns>
        public static string GetMeridiemSuffixOfInteger(int num)
        {
            return num == 0 || num == 24
                 ? 12 + " am"
                 : num == 12
                 ? 12 + " pm"
                 : num < 12
                 ? (num % 12) + " am"
                 : (num % 12) + " pm";
        }
    }
}
