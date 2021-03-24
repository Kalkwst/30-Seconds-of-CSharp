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
    public class DateUtils_DaysFromNowTest
    {
        [Test]
        public void DaysFromNow_PositiveCount()
        {
            var result = DateUtils.DaysFromNow(new DateTime(2020, 03, 15), 5);
            Assert.AreEqual(result, new DateTime(2020, 03, 20));
        }

        [Test]
        public void DaysFromNow_NegativeCount()
        {
            var result = DateUtils.DaysFromNow(new DateTime(2020, 03, 15), -5);
            Assert.AreEqual(result, new DateTime(2020, 03, 20));
        }
    }
}
