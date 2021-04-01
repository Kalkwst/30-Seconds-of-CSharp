using System;

namespace _30_Seconds_of_CSharp.Maths
{
    public static partial class MathUtils
    {

        /// <summary>
        /// Converts an angle from degrees to radians.
        /// </summary>
        /// <param name="degrees">The angle in degrees</param>
        /// <returns>The angle in radians</returns>
        public static double DegreesToRads(double degrees)
        {
            return (degrees * Math.PI) / 180.0;
        }
    }
}