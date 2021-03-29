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
        /// <para>
        /// Creates an array of numbers in the arithmetic progression, starting with the 
        /// given positive integer, and up to the specified limit.
        /// </para>
        /// </summary>
        /// <param name="n">The starting number</param>
        /// <param name="lim">The limit</param>
        /// <returns>An array containing the arithmetic progression between <c>n</c> and <c>lim</c></returns>
        public static int[] ArithmeticProgression(int n, int lim)
        {
            int[] array = new int[(int)Math.Ceiling((double)lim / n)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * n;
            }

            return array;
        }

        /// <summary>
        /// <para>
        /// Creates an array of numbers in the arithmetic progression, starting with the 
        /// given positive long, and up to the specified limit.
        /// </para>
        /// </summary>
        /// <param name="n">The starting number</param>
        /// <param name="lim">The limit</param>
        /// <returns>An array containing the arithmetic progression between <c>n</c> and <c>lim</c></returns>
        public static long[] ArithmeticProgression(long n, long lim)
        {
            long[] array = new long[(long)Math.Ceiling((double)lim / n)];

            for (long i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * n;
            }

            return array;
        }

        /// <summary>
        /// <para>
        /// Creates an array of numbers in the arithmetic progression, starting with the 
        /// given positive decimal, and up to the specified limit.
        /// </para>
        /// </summary>
        /// <param name="n">The starting number</param>
        /// <param name="lim">The limit</param>
        /// <returns>An array containing the arithmetic progression between <c>n</c> and <c>lim</c></returns>
        public static decimal[] ArithmeticProgression(decimal n, decimal lim)
        {
            decimal[] array = new decimal[(int)Math.Ceiling(lim / n)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * n;
            }

            return array;
        }

        /// <summary>
        /// <para>
        /// Creates an array of numbers in the arithmetic progression, starting with the 
        /// given positive double, and up to the specified limit.
        /// </para>
        /// </summary>
        /// <param name="n">The starting number</param>
        /// <param name="lim">The limit</param>
        /// <returns>An array containing the arithmetic progression between <c>n</c> and <c>lim</c></returns>
        public static double[] ArithmeticProgression(double n, double lim)
        {
            double[] array = new double[(int)Math.Ceiling(lim / n)];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = (i + 1) * n;
            }

            return array;
        }
    }
}
