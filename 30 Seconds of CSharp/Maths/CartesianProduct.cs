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
        /// Calculates the cartesian product of two arrays.
        /// </summary>
        /// <typeparam name="T">The type parameters of the arrays</typeparam>
        /// <param name="a">The first array</param>
        /// <param name="b">The second array</param>
        /// <returns>A list containing the cartesian product of the two arrays</returns>
        public static List<T[]> CartesianProduct<T>(T[] a, T[] b)
        {
            List<T[]> product = new();

            for(int i = 0; i < a.Length; i++)
            {
                for(int j = 0; j < b.Length; j++)
                {
                    T[] tmp = { a[i], b[j] };
                    product.Add(tmp);
                }
            }

            return product;
        }
    }
}
