using NUnit.Framework;

namespace TddBuddy.DateTime.Extensions.Tests
{
    [TestFixture]
    public class DateTimeExtensionsTests
    {
        [Test]
        public void ConvertTo24HourFormatWithSeconds_WhenDateTimePmValue_ShouldReturnStringWithSeconds()
        {
            //---------------Arrange-------------------
            var dateTime = new System.DateTime(2017,2,1,22,00,01);
            //---------------Act----------------------
            var result = dateTime.ConvertTo24HourFormatWithSeconds();
            //---------------Assert-----------------------
            Assert.AreEqual("2017-02-01 22:00:01",result);
        }

        [Test]
        public void ConvertTo24HourFormatWithSeconds_WhenDateTimeAmValue_ShouldReturnStringWithSeconds()
        {
            //---------------Arrange-------------------
            var dateTime = new System.DateTime(2017, 2, 1, 10, 05, 09);
            //---------------Act----------------------
            var result = dateTime.ConvertTo24HourFormatWithSeconds();
            //---------------Assert-----------------------
            Assert.AreEqual("2017-02-01 10:05:09", result);
        }
    }
}
