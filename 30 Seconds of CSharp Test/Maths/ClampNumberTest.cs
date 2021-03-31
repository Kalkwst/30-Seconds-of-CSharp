using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _30_Seconds_of_CSharp.Maths;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Maths
{
    [TestFixture]
    public class ClampNumberTest
    {
        [Test]
        public void ClampNumber_Integer_LowerBoundary()
        {
            Assert.AreEqual(1, MathUtils.ClampNumber(0, 1, 3));
            Assert.AreEqual(-1, MathUtils.ClampNumber(-9, -1, 1));
        }

        [Test]
        public void ClampNumber_Integer_UpperBoundary()
        {
            Assert.AreEqual(4, MathUtils.ClampNumber(8, 1, 4));
            Assert.AreEqual(-1, MathUtils.ClampNumber(1, -1, -5));
        }

        [Test]
        public void ClampNumber_Integer_Clamped()
        {
            Assert.AreEqual(4, MathUtils.ClampNumber(4, 1, 8));
            Assert.AreEqual(-1, MathUtils.ClampNumber(-1, 0, -5));
        }

        [Test]
        public void ClampNumber_Long_LowerBoundary()
        {
            Assert.AreEqual(1L, MathUtils.ClampNumber(0L, 1L, 3L));
            Assert.AreEqual(-1L, MathUtils.ClampNumber(-9L, -1L, 1L));
        }

        [Test]
        public void ClampNumber_Long_UpperBoundary()
        {
            Assert.AreEqual(4L, MathUtils.ClampNumber(8L, 1L, 4L));
            Assert.AreEqual(-1L, MathUtils.ClampNumber(1L, -1L, -5L));
        }

        [Test]
        public void ClampNumber_Long_Clamped()
        {
            Assert.AreEqual(4L, MathUtils.ClampNumber(4L, 1L, 8L));
            Assert.AreEqual(-1L, MathUtils.ClampNumber(-1L, 0L, -5L));
        }

        [Test]
        public void ClampNumber_Float_LowerBoundary()
        {
            Assert.AreEqual(1F, MathUtils.ClampNumber(0F, 1F, 3F));
            Assert.AreEqual(-1F, MathUtils.ClampNumber(-9F, -1F, 1F));
        }

        [Test]
        public void ClampNumber_Float_UpperBoundary()
        {
            Assert.AreEqual(4F, MathUtils.ClampNumber(8F, 1F, 4F));
            Assert.AreEqual(-1F, MathUtils.ClampNumber(1F, -1F, -5F));
        }

        [Test]
        public void ClampNumber_Float_Clamped()
        {
            Assert.AreEqual(4F, MathUtils.ClampNumber(4F, 1F, 8F));
            Assert.AreEqual(-1F, MathUtils.ClampNumber(-1F, 0F, -5F));
        }

        [Test]
        public void ClampNumber_Double_LowerBoundary()
        {
            Assert.AreEqual(1D, MathUtils.ClampNumber(0D, 1D, 3D));
            Assert.AreEqual(-1D, MathUtils.ClampNumber(-9D, -1D, 1D));
        }

        [Test]
        public void ClampNumber_Double_UpperBoundary()
        {
            Assert.AreEqual(4D, MathUtils.ClampNumber(8D, 1D, 4D));
            Assert.AreEqual(-1D, MathUtils.ClampNumber(1D, -1D, -5D));
        }

        [Test]
        public void ClampNumber_Double_Clamped()
        {
            Assert.AreEqual(4D, MathUtils.ClampNumber(4D, 1D, 8D));
            Assert.AreEqual(-1D, MathUtils.ClampNumber(-1D, 0D, -5D));
        }

        [Test]
        public void ClampNumber_Decimal_LowerBoundary()
        {
            Assert.AreEqual(1M, MathUtils.ClampNumber(0M, 1M, 3M));
            Assert.AreEqual(-1M, MathUtils.ClampNumber(-9M, -1M, 1M));
        }

        [Test]
        public void ClampNumber_Decimal_UpperBoundary()
        {
            Assert.AreEqual(4M, MathUtils.ClampNumber(8M, 1M, 4M));
            Assert.AreEqual(-1M, MathUtils.ClampNumber(1M, -1M, -5M));
        }

        [Test]
        public void ClampNumber_Decimal_Clamped()
        {
            Assert.AreEqual(4M, MathUtils.ClampNumber(4M, 1M, 8M));
            Assert.AreEqual(-1M, MathUtils.ClampNumber(-1M, 0M, -5M));
        }
    }
}
