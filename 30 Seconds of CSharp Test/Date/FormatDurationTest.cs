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
    public class DateUtils_FormatDuration
    {
        [Test]
        public void FormatDuration_PositiveInput_1001_ReturnDuration()
        {
            var result = DateUtils.FormatDuration(1001);
            Assert.AreEqual(result, "1 second, 1 millisecond");
        }

        [Test]
        public void FormatDuration_PositiveInput_999_ReturnDuration()
        {
            var result = DateUtils.FormatDuration(999);
            Assert.AreEqual(result, "999 milliseconds");
        }

        [Test]
        public void FormatDuration_PositiveInput_34325055574_ReturnDuration()
        {
            var result = DateUtils.FormatDuration(34325055574);
            Assert.AreEqual(result, "397 days, 6 hours, 44 minutes, 15 seconds, 574 milliseconds");
        }

        public void FormatDuration_NegativeInput_1001_ReturnDuration()
        {
            var result = DateUtils.FormatDuration(-1001);
            Assert.AreEqual(result, "1 second, 1 millisecond");
        }

        [Test]
        public void FormatDuration_NegativeInput_999_ReturnDuration()
        {
            var result = DateUtils.FormatDuration(-999);
            Assert.AreEqual(result, "999 milliseconds");
        }

        [Test]
        public void FormatDuration__NegativeInput_34325055574_ReturnDuration()
        {
            var result = DateUtils.FormatDuration(-34325055574);
            Assert.AreEqual(result, "397 days, 6 hours, 44 minutes, 15 seconds, 574 milliseconds");
        }
    }
}
