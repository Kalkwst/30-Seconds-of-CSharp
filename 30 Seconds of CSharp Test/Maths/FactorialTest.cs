using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class FactorialTest
    {
        [Test]
        public void TestFactorial()
        {
            Assert.AreEqual(1, MathUtils.Factorial(0));
            Assert.AreEqual(1, MathUtils.Factorial(1));

            Assert.AreEqual(120, MathUtils.Factorial(5));

            Assert.AreEqual(40320, MathUtils.Factorial(8));

            Assert.AreEqual(3628800, MathUtils.Factorial(10));
        }
    }
}