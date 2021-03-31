using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class CopySignTest
    {

        [Test]
        public void CopySign_Integer()
        {
            Assert.AreEqual(2, MathUtils.CopySign(2, 3));
            Assert.AreEqual(-2, MathUtils.CopySign(2, -3));

            Assert.AreEqual(2, MathUtils.CopySign(-2, 3));
            Assert.AreEqual(-2, MathUtils.CopySign(-2, -3));
        }

        [Test]
        public void CopySign_Long()
        {
            Assert.AreEqual(2L, MathUtils.CopySign(2L, 3L));
            Assert.AreEqual(-2L, MathUtils.CopySign(2L, -3L));

            Assert.AreEqual(2L, MathUtils.CopySign(-2L, 3L));
            Assert.AreEqual(-2L, MathUtils.CopySign(-2L, -3L));
        }

        [Test]
        public void CopySign_Float()
        {
            Assert.AreEqual(2F, MathUtils.CopySign(2F, 3F));
            Assert.AreEqual(-2F, MathUtils.CopySign(2F, -3F));

            Assert.AreEqual(2F, MathUtils.CopySign(-2F, 3F));
            Assert.AreEqual(-2F, MathUtils.CopySign(-2F, -3F));
        }

        [Test]
        public void CopySign_Double()
        {
            Assert.AreEqual(2D, MathUtils.CopySign(2D, 3D));
            Assert.AreEqual(-2D, MathUtils.CopySign(2D, -3D));

            Assert.AreEqual(2D, MathUtils.CopySign(-2D, 3D));
            Assert.AreEqual(-2D, MathUtils.CopySign(-2D, -3D));
        }

        [Test]
        public void CopySign_Decimal()
        {
            Assert.AreEqual(2M, MathUtils.CopySign(2M, 3M));
            Assert.AreEqual(-2M, MathUtils.CopySign(2M, -3M));

            Assert.AreEqual(2M, MathUtils.CopySign(-2M, 3M));
            Assert.AreEqual(-2M, MathUtils.CopySign(-2M, -3M));
        }
    }
}