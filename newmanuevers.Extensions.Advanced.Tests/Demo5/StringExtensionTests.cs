using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using newmanuevers.Extensions.Advanced.Demo5;

namespace newmanuevers.Extensions.Advanced.Tests.Demo5
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void ToString()
        {
            var input = 10.51M;
            Assert.AreEqual("10.5", input.ToString());
        }

        [TestMethod]
        public void ToStringRounded()
        {
            var input = 10.51M;
            Assert.AreEqual("10.5", input.ToStringRounded());
        }

       
    }
}
