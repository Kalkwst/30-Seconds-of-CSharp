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
    class MathUtils_ApproximatelyEqualTest
    {
        [Test]
        public void ApproximatelyEqual_PI()
        {
            Assert.IsTrue(MathUtils.ApproximatelyEqual(Math.PI / 2.0, 1.5708));
        }

        [Test]
        public void ApproximatelyEquals_03()
        {
            Assert.IsTrue(MathUtils.ApproximatelyEqual(0.1 + 0.2, 0.3));
        }

        [Test]
        public void ApproximatelyEquals_EqualValues()
        {
            Assert.IsTrue(MathUtils.ApproximatelyEqual(0.5, 0.5));
        }

        public void ApproximatelyEquals_CustomEp
    }
}
