using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class DistanceTest
    {
        [Test]
        public void TestDistance()
        {
           Assert.AreEqual(2.828, MathUtils.Distance(1,2,3,4), 0.001);
           Assert.AreEqual(21.8689, MathUtils.Distance(7, 12, 3, -9.5), 0.001);
           Assert.AreEqual(2.2361, MathUtils.Distance(1, 1, 2, 3), 0.001);
        }
    }

}