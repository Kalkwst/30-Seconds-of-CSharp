using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class AverageTest
    {
        [Test]
        public static void AverageTest_Integers_SingleNumber()
        {
            Assert.AreEqual(0, MathUtils.Average(0));
            Assert.AreEqual(1, MathUtils.Average(1));
        }

        [Test]
        public static void AverageTest_Integers_PositiveNumbers()
        {
            Assert.AreEqual(2.0, MathUtils.Average(1, 2, 3));
            Assert.AreEqual(3.0, MathUtils.Average(1, 2, 3, 4, 5));
        }

        [Test]
        public static void AverageTest_Integers_NegativeNumbers()
        {
            Assert.AreEqual(-2.0, MathUtils.Average(-1, -2, -3));
            Assert.AreEqual(-3.0, MathUtils.Average(-1, -2, -3, -4, -5));
        }

        [Test]
        public static void AverageTest_Longs_SingleNumber()
        {
            Assert.AreEqual(0, MathUtils.Average(0L));
            Assert.AreEqual(1, MathUtils.Average(1L));
        }
         
        [Test]
        public static void AverageTest_Longs_PositiveNumbers()
        {
            Assert.AreEqual(2.0, MathUtils.Average(1L, 2L, 3L));
            Assert.AreEqual(3.0, MathUtils.Average(1L, 2L, 3L, 4L, 5L));
        }

        [Test]
        public static void AverageTest_Longs_NegativeNumbers()
        {
            Assert.AreEqual(-2.0, MathUtils.Average(-1L, -2L, -3L));
            Assert.AreEqual(-3.0, MathUtils.Average(-1L, -2L, -3L, -4L, -5L));
        }

        [Test]
        public static void AverageTest_Decimals_SingleNumber()
        {
            Assert.AreEqual(0, MathUtils.Average(0M));
            Assert.AreEqual(1, MathUtils.Average(1M));
        }

        [Test]
        public static void AverageTest_Decimals_PositiveNumbers()
        {
            Assert.AreEqual(2.0, MathUtils.Average(1M, 2M, 3M));
            Assert.AreEqual(3.0, MathUtils.Average(1M, 2M, 3M, 4M, 5M));
        }

        [Test]
        public static void AverageTest_Decimal_NegativeNumbers()
        {
            Assert.AreEqual(-2.0, MathUtils.Average(-1M, -2M, -3M));
            Assert.AreEqual(-3.0, MathUtils.Average(-1M, -2M, -3M, -4M, -5M));
        }

        [Test]
        public static void AverageTest_Doubles_SingleNumber()
        {
            Assert.AreEqual(0, MathUtils.Average(0D));
            Assert.AreEqual(1, MathUtils.Average(1D));
        }

        [Test]
        public static void AverageTest_Doubles_PositiveNumbers()
        {
            Assert.AreEqual(2.0, MathUtils.Average(1D, 2D, 3D));
            Assert.AreEqual(3.0, MathUtils.Average(1D, 2D, 3D, 4D, 5D));
        }

        [Test]
        public static void AverageTest_Double_NegativeNumbers()
        {
            Assert.AreEqual(-2.0, MathUtils.Average(-1D, -2D, -3D));
            Assert.AreEqual(-3.0, MathUtils.Average(-1D, -2D, -3D, -4D, -5D));
        }
    }
}
