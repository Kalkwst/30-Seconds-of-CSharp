using System;
using System.Linq;

namespace _30_Seconds_of_CSharp.Maths
{
    public static partial class MathUtils
    {
        /// <summary>
        /// Converts  number to an array of digits, removing its sign if necessary.
        /// </summary>
        /// <param name="number">The number to digitize</param>
        /// <returns>An array containing all the number's digits</returns>
        public static int[] Digitize(int number)
        {
           string[] digits = Math.Abs(number).ToString().ToCharArray().Select(c => c.ToString()).ToArray();
           int[] result = new int[digits.Length];

           for(int i = 0; i < digits.Length; i++)
           {
               result[i] = Int32.Parse(digits[i]);
           }

           return result;
        }
    }
}