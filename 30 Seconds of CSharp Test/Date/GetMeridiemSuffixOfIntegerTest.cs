using _30_Seconds_of_CSharp.Date;
using NUnit.Framework;

namespace _30_Seconds_of_CSharp_Test.Date
{
    [TestFixture]
    class GetMeridiemSuffixOfIntegerTest
    {
        [Test]
        public void GetMeridiemSuffixOfInteger_0To24()
        {
            Assert.AreEqual(DateUtils.GetMeridiemSuffixOfInteger(0), "12 am");
            Assert.AreEqual(DateUtils.GetMeridiemSuffixOfInteger(11), "11 am");
            Assert.AreEqual(DateUtils.GetMeridiemSuffixOfInteger(13), "1 pm");
        }

        [Test]
        public void GetMeridiemSuffixOfInteger_GreaterThan24()
        {
            Assert.AreEqual(DateUtils.GetMeridiemSuffixOfInteger(25), "1 pm");
        }
    }
}
