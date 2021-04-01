using System.Reflection;
using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class DigitizeTest
    {
        [Test]
        public void Digitize_PositiveChars()
        {
            Assert.AreEqual(new int[]{1, 2, 3}, MathUtils.Digitize(123));
            Assert.AreEqual(new int[]{1, 2, 3, 4, 5}, MathUtils.Digitize(12345));
        }

        [Test]
        public void Digitize_NegativeChars()
        {
            Assert.AreEqual(new int[]{1, 2, 3}, MathUtils.Digitize(-123));
            Assert.AreEqual(new int[]{1, 2, 3, 4, 5}, MathUtils.Digitize(-12345));
        }
    }
}