using System;
namespace _30_Seconds_of_CSharp.Maths
{
    public static partial class MathUtils
    {
        public static long Factorial(int number)
        {
            return number < 0
                ? throw new ArgumentException("Negative numbers are not allowed")
                : number <= 1
                ? 1
                : number * Factorial(number - 1);
        }
    }
}