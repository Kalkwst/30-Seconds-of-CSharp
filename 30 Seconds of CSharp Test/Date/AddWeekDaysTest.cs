using System;
using System.Collections.Generic;
using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    public class DateUtils_AddWeekDaysTest
    {
        [Test]
        public void AddWeekDays_NoWeekends()
        {
            var result = DateUtils.AddWeekDays(new DateTime(2021, 03, 01), 4);
            Assert.AreEqual(result, new DateTime(2021, 03, 05));
        }

        [Test]
        public void AddWeekDays_IncludingWeekends()
        {
            var result = DateUtils.AddWeekDays(new DateTime(2021, 03, 01), 5);
            Assert.AreEqual(result, new DateTime(2021, 03, 08));
        }

        [Test]
        public void AddWeekDays_IncludingWeekends_Holidays()
        {
            var result = DateUtils.AddWeekDays(new DateTime(2021, 03, 01), 18, new List<DateTime>() { new DateTime(2021, 03, 25) });
            Assert.AreEqual(result, new DateTime(2021, 03, 26));
        }
    }
}
