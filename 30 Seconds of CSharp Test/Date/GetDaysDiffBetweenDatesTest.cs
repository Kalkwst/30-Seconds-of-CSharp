using System;
using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    class DateUtils_GetDaysDiffBetweenDatesTest
    {
        [Test]
        public void GetDaysDiffBetweenDates()
        {
            var result = DateUtils.GetDaysDiffBetweenDates(new DateTime(2017, 12, 13), new DateTime(2017, 12, 22));
            Assert.AreEqual(result, 9);
        }
    }
}
