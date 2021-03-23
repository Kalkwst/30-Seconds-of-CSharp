using System;
using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    public class TomorrowTest
    {
        [Test]
        public void TestTommorow()
        {
            DateTime t1 = DateTime.Now.AddDays(1);
            DateTime t2 = DateTime.Parse(DateUtils.Tommorow());

            Assert.AreEqual(t1.Year, t2.Year);
            Assert.AreEqual(t1.Month, t2.Month);
            Assert.AreEqual(t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"));
        }
    }
}
