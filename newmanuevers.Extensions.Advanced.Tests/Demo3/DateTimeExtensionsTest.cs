using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using newmanuevers.Extensions.Advanced.Demo3;

namespace newmanuevers.Extensions.Advanced.Tests.Demo3
{
    [TestClass]
    public class DateTimeExtensionsTest
    {
        [TestMethod]
        public void ToXmlDateTime()
        {
            string xmlDateTime2 = DateTimeExtensions.ToXmlDateTime(new DateTime(2013, 10, 24));
            Assert.AreEqual("2013-10-24T00:00:00Z", xmlDateTime2);

            string xmlDateTime = new DateTime(2013, 10, 24).ToXmlDateTime();
            Assert.AreEqual("2013-10-24T00:00:00Z", xmlDateTime2, xmlDateTime);

        }
    }
}
