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
    public class DateUtils_IsBusinessDayTest
    {
        [Test]
        public void IsBusinessDay_WeekDay()
        {
            Assert.IsTrue(DateUtils.IsBusinessDay(new DateTime(2019, 07, 19)));
        }

        [Test]
        public void IsBusinessDay_WeekendDay()
        {
            Assert.IsFalse(DateUtils.IsBusinessDay(new DateTime(2021, 03, 06)));
        }
    }
}
