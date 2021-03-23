using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    public class DateUtils_DaysAgoTest
    {
        [Test]
        public void DaysAgo_PositiveCount()
        {
            var result = DateUtils.DaysAgo(new DateTime(2020, 03, 15), 5);
            Assert.AreEqual(result, new DateTime(2020, 03, 10));
        }

        [Test]
        public void DaysAgo_NegativeCount()
        {
            var result = DateUtils.DaysAgo(new DateTime(2020, 03, 15), -5);
            Assert.AreEqual(result, new DateTime(2020, 03, 10));
        }
    }
}
