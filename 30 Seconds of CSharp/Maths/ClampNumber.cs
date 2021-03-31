using System;

namespace _30_Seconds_of_CSharp.Maths
{
    public static partial class MathUtils
    {
        /// <summary>
        /// Clamps <c>num</c> within the inclusive range specified by the boundary values <c>lower</c> and <c>upper</c>.
        /// </summary>
        /// <param name="num">The number to clamp</param>
        /// <param name="lower">The lower boundary</param>
        /// <param name="upper">The upper boubdary</param>
        /// <returns>The number if it is between the boundaries, the closest boundary otherwise.</returns>
        public static int ClampNumber(int num, int lower, int upper)
        {
            return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
        }

        /// <summary>
        /// Clamps <c>num</c> within the inclusive range specified by the boundary values <c>lower</c> and <c>upper</c>.
        /// </summary>
        /// <param name="num">The number to clamp</param>
        /// <param name="lower">The lower boundary</param>
        /// <param name="upper">The upper boubdary</param>
        /// <returns>The number if it is between the boundaries, the closest boundary otherwise.</returns>
        public static long ClampNumber(long num, long lower, long upper)
        {
            return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
        }

        /// <summary>
        /// Clamps <c>num</c> within the inclusive range specified by the boundary values <c>lower</c> and <c>upper</c>.
        /// </summary>
        /// <param name="num">The number to clamp</param>
        /// <param name="lower">The lower boundary</param>
        /// <param name="upper">The upper boubdary</param>
        /// <returns>The number if it is between the boundaries, the closest boundary otherwise.</returns>
        public static float ClampNumber(float num, float lower, float upper)
        {
            return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
        }

        /// <summary>
        /// Clamps <c>num</c> within the inclusive range specified by the boundary values <c>lower</c> and <c>upper</c>.
        /// </summary>
        /// <param name="num">The number to clamp</param>
        /// <param name="lower">The lower boundary</param>
        /// <param name="upper">The upper boubdary</param>
        /// <returns>The number if it is between the boundaries, the closest boundary otherwise.</returns>
        public static decimal ClampNumber(decimal num, decimal lower, decimal upper)
        {
            return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
        }

        /// <summary>
        /// Clamps <c>num</c> within the inclusive range specified by the boundary values <c>lower</c> and <c>upper</c>.
        /// </summary>
        /// <param name="num">The number to clamp</param>
        /// <param name="lower">The lower boundary</param>
        /// <param name="upper">The upper boubdary</param>
        /// <returns>The number if it is between the boundaries, the closest boundary otherwise.</returns>
        public static double ClampNumber(double num, double lower, double upper)
        {
            return Math.Max(Math.Min(num, Math.Max(lower, upper)), Math.Min(lower, upper));
        }
    }
}
