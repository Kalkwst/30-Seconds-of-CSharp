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
    public class BinomialCoefficientTest
    {
        [Test]
        public void BinomialCoefficient_KgtN()
        {
            Assert.AreEqual(0, MathUtils.BinomialCoefficient(2, 3));
        }

        [Test]
        public void BinomialCoefficient_Klt0()
        {
            Assert.AreEqual(0, MathUtils.BinomialCoefficient(2, -3));
        }

        [Test]
        public void BinomialCoefficient_Keq0()
        {
            Assert.AreEqual(1, MathUtils.BinomialCoefficient(2, 0));
        }

        [Test]
        public void BinomialCoefficient_KeqN()
        {
            Assert.AreEqual(1, MathUtils.BinomialCoefficient(2, 2));
        }

        [Test]
        public void BinomialCoefficient_Keq1()
        {
            Assert.AreEqual(3, MathUtils.BinomialCoefficient(3, 1));
        }

        [Test]
        public void BinomialCoefficient_KeqNmin1()
        {
            Assert.AreEqual(6, MathUtils.BinomialCoefficient(6, 5));
        }

        [Test]
        public void BinomialCoefficientGenericTest()
        {
            Assert.AreEqual(10, MathUtils.BinomialCoefficient(5, 2));
            Assert.AreEqual(28, MathUtils.BinomialCoefficient(8, 2));
            Assert.AreEqual(3365856, MathUtils.BinomialCoefficient(32, 7));
        }
    }
}
