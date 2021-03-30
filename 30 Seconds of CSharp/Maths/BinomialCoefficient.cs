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
        /// Calculates the binomial coefficient between two numbers.
        /// </summary>
        /// <param name="n">The first factor</param>
        /// <param name="k">The second factor</param>
        /// <returns>The binomial coefficient</returns>
        public static int BinomialCoefficient(int n, int k)
        {
            if (k < 0 || k > n)
                return 0;

            if (k == 0 || k == n)
                return 1;

            if (k == 1 || k == n - 1)
                return n;

            if (n - k < k)
                k = n - k;

            double res = (double)n;

            for (int i = 2; i <= k; i++)
                res *= (double)(n - i + 1) / i;

            return (int)Math.Round(res);
        }
    }
}
