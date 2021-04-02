using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class DivModTest
    {
        [Test]
        public void DivModTestMethod(){
            int[] result = MathUtils.DivMod(4, 2);
            Assert.AreEqual(2, result[0]);
            Assert.AreEqual(0, result[1]);

            result = MathUtils.DivMod(12, 8);
            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(4, result[1]);
        }
    }
}