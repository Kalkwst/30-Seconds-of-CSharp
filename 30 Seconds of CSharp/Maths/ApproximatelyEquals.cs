using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30_Seconds_of_CSharp.Maths
{
    public static partial class MathUtils
    {
        /// <summary>
        /// Checks if two numbers are approximately equal to each other.
        /// </summary>
        /// <param name="num1">The first number</param>
        /// <param name="num2">The second number</param>
        /// <param name="epsilon">The maximum possible difference between the two numbers</param>
        /// <returns><c>true</c> if the two numbers are appropriately equal</returns>
        public static bool ApproximatelyEqual(double num1, double num2, double epsilon = 0.001)
        {
            return Math.Abs(num1 - num2) < epsilon;
        }
    }
}
