using System;
using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    class IsBetweenDatesTest
    {
        [Test]
        public void IsBetweenDates_True()
        {
            Assert.IsTrue(DateUtils.IsBetweenDate(
                new DateTime(2010, 11, 20),
                new DateTime(2010, 11, 30),
                new DateTime(2010, 11, 25)));
        }

        [Test]
        public void IsBetweenDates_False()
        {
            Assert.IsTrue(DateUtils.IsBetweenDate(
                new DateTime(2010, 11, 20),
                new DateTime(2010, 11, 30),
                new DateTime(2010, 11, 19)));
        }
    }
}
