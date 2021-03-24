using System;
using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    class GetColonTimeFromDateTest
    {
        [Test]
        public void GetColonTimeFromDateTest_FixedDate()
        {
            var result = DateUtils.GetColonTimeFromDate(new DateTime(2020, 03, 15, 16, 32, 0));
            Assert.AreEqual(result, "16:32:00");
        }

        [Test]
        public void GetColonTimeFromDate_CurrentDateTime()
        {
            var current = DateTime.Now;
            var result = DateUtils.GetColonTimeFromDate(current);
            Assert.AreEqual(result, current.ToString("HH:mm:ss"));
        }
    }
}
