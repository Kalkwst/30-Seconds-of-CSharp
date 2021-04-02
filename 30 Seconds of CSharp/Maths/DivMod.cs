using System;
namespace _30_Seconds_of_CSharp.Maths
{
    public static partial class MathUtils
    {
        /// <summary>
        /// Returns an array consisting of the quontient and the remainder of the given
        /// numbers.
        /// </summary>
        /// <param name="x">the numerator</param>
        /// <param name="y">the denominator</param>
        /// <returns>an array containing the quontient, and the remainder of the division</returns>
        public static int[] DivMod(int x, int y)
        {
            return new int[] { (int)Math.Floor((double)x / (double)y), x % y };
        }
    }
}