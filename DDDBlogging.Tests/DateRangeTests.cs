using DDDBlogging.Shared;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DDDBlogging.Tests
{
    [TestClass]
    public class DateRangeTests
    {
        [TestMethod]
        public void TestEmpty()
        {
            var range = DateRange.Empty;

            Assert.AreEqual(DateTime.MinValue, range.Start);
            Assert.AreEqual(DateTime.MinValue, range.End);
        }

        [TestMethod]
        public void TestEndGreaterThanStart()
        {
            Assert.ThrowsException<ArgumentException>(() => new DateRange(DateTime.Now, DateTime.Now.AddHours(-1)));

            Assert.IsNotNull(new DateRange(DateTime.Now, DateTime.Now.AddHours(1)));
        }

        [TestMethod]
        public void TestEquals()
        {
            var start = DateTime.Now;
            var end = DateTime.Now.AddDays(1);

            var firstRange = new DateRange(start, end);
            var secondRange = new DateRange(start, end);

            Assert.AreEqual(firstRange, secondRange);
        }
    }
}
