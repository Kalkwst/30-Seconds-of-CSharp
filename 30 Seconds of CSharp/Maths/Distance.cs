using System;
using System.IO;
namespace _30_Seconds_of_CSharp.Maths
{
    public static partial class MathUtils 
    {
        /// <summary>
        /// Calculates the distance between two points in a 2D plane.
        /// </summary>
        /// <param name="x0">The first point's x coordinate</param>
        /// <param name="y0">The first point's y coordinate</param>
        /// <param name="x1">The second point's x coordinate</param>
        /// <param name="y1">The seocond point's y coordinate</param>
        /// <returns>the Euclidean distance between the two points</returns>
        public static double Distance(double x0, double y0, double x1, double y1)
        {
            return Math.Sqrt(Math.Pow((x0 - x1), 2) + Math.Pow((y0 - y1), 2));
        }
    }
}