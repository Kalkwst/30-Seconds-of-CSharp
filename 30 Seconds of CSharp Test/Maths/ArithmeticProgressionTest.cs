using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class ArithmeticProgressionTest
    {
        [Test]
        public void ArithmeticProgression_Integer()
        {
            Assert.AreEqual(new int[] { 5, 10, 15, 20, 25 }, MathUtils.ArithmeticProgression(5, 25));
        }

        [Test]
        public void ArithmeticProgression_Long()
        {
            Assert.AreEqual(new long[] { 5, 10, 15, 20, 25 }, MathUtils.ArithmeticProgression(5l, 25l));
        }

        [Test]
        public void ArithmeticProgression_Decimal()
        {
            Assert.AreEqual(new decimal[] { 0.1M, 0.2M, 0.3M, 0.4M, 0.5M }, MathUtils.ArithmeticProgression(0.1M, 0.5M));
        }
    }
}
