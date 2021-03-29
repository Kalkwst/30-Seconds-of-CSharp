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
        /// Calculates the average of two or more numbers.
        /// </summary>
        /// <param name="array">The numbers to calculate the average of</param>
        /// <returns>The average of the provided numbers</returns>
        public static double Average(params int[] array)
        {
            double avg = 0;

            for(int i = 0; i < array.Length; i++)
            {
                avg += (double)array[i] / array.Length;
            }

            return avg;
        }

        /// <summary>
        /// Calculates the average of two or more numbers.
        /// </summary>
        /// <param name="array">The numbers to calculate the average of</param>
        /// <returns>The average of the provided numbers</returns>
        public static double Average(params long[] array)
        {
            double avg = 0;

            for(int i = 0; i < array.Length; i++)
            {
                avg += (double)array[i] / array.Length;
            }

            return avg; 
        }

        /// <summary>
        /// Calculates the average of two or more numbers.
        /// </summary>
        /// <param name="array">The numbers to calculate the average of</param>
        /// <returns>The average of the provided numbers</returns>
        public static decimal Average(params decimal[] array)
        {
            decimal avg = 0;

            for (int i = 0; i < array.Length; i++)
            {
                avg += array[i] / array.Length;
            }

            return avg;
        }

        /// <summary>
        /// Calculates the average of two or more numbers.
        /// </summary>
        /// <param name="array">The numbers to calculate the average of</param>
        /// <returns>The average of the provided numbers</returns>
        public static double Average(params double[] array)
        {
            double avg = 0;

            for(int i = 0; i < array.Length; i++)
            {
                avg += array[i] / array.Length;
            }

            return avg;
        }
    }
}
