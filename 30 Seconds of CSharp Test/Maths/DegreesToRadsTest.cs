using System;
using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class DegreesToRadsTest
    {
        [Test]
        public void TestDegreesToRads()
        {
            Assert.AreEqual(0, MathUtils.DegreesToRads(0));
            Assert.AreEqual(0.523, MathUtils.DegreesToRads(30), 0.001);
            Assert.AreEqual(0.785, MathUtils.DegreesToRads(45), 0.001);
            Assert.AreEqual(1.047, MathUtils.DegreesToRads(60), 0.001);
            Assert.AreEqual(1.570, MathUtils.DegreesToRads(90), 0.001);
            Assert.AreEqual(3.141, MathUtils.DegreesToRads(180), 0.001);
            Assert.AreEqual(6.283, MathUtils.DegreesToRads(360), 0.001);
        }
    }
}