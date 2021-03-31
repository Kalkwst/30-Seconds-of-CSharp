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
        /// Returns the absolute value of the first number, but the sign of the second.
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>the absolute value of the first number, but the sign of the second</returns>
        public static int CopySign(int x, int y)
        {
            return Math.Sign(x) == Math.Sign(y) ? x : -x;
        }

        /// <summary>
        /// Returns the absolute value of the first number, but the sign of the second.
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>the absolute value of the first number, but the sign of the second</returns>
        public static long CopySign(long x, long y)
        {
            return Math.Sign(x) == Math.Sign(y) ? x : -x;
        }

        /// <summary>
        /// Returns the absolute value of the first number, but the sign of the second.
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>the absolute value of the first number, but the sign of the second</returns>
        public static float CopySign(float x, float y)
        {
            return Math.Sign(x) == Math.Sign(y) ? x : -x;
        }

        /// <summary>
        /// Returns the absolute value of the first number, but the sign of the second.
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>the absolute value of the first number, but the sign of the second</returns>
        public static double CopySign(double x, double y)
        {
            return Math.Sign(x) == Math.Sign(y) ? x : -x;
        }

        /// <summary>
        /// Returns the absolute value of the first number, but the sign of the second.
        /// </summary>
        /// <param name="x">The first number</param>
        /// <param name="y">The second number</param>
        /// <returns>the absolute value of the first number, but the sign of the second</returns>
        public static decimal CopySign(decimal x, decimal y)
        {
            return Math.Sign(x) == Math.Sign(y) ? x : -x;
        }
    }
}
