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
    public class DateUtils_IsBeforeDate
    {
        [Test]
        public void IsBeforeDate_Truthy()
        {
            Assert.IsTrue(DateUtils.IsBeforeDate(new DateTime(2010, 10, 20), new DateTime(2010, 10, 21)));
        }

        [Test]
        public void IsBeforeDate_Falsy()
        {
            Assert.IsFalse(DateUtils.IsBeforeDate(new DateTime(2010, 10, 21), new DateTime(2010, 10, 20)));
        }

        [Test]
        public void IsBeforeDate_Falsy_SameDate()
        {
            Assert.IsFalse(DateUtils.IsBeforeDate(new DateTime(2010, 10, 21), new DateTime(2010, 10, 21)));
        }
    }
}
