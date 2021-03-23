using System;
using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    public class YesterdayTest
    {
        [Test]
        public void TestYesterday()
        {
            DateTime t1 = DateTime.Now.AddDays(-1);
            DateTime t2 = DateTime.Parse(DateUtils.Yesterday());

            Assert.AreEqual(t1.Year, t2.Year);
            Assert.AreEqual(t1.Month, t2.Month);
            Assert.AreEqual(t1.ToString("yyyy-MM-dd"), t2.ToString("yyyy-MM-dd"));
        }
    }
}
