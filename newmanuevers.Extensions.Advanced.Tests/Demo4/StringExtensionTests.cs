﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace newmanuevers.Extensions.Advanced.Tests.Demo4
{
    [TestClass]
    public class StringExtensionTests
    {
        [TestMethod]
        public void FormatWith()
        {
            Assert.AreEqual("Demo 4", "Demo {0}".FormatWith(4));
        }
    }
}
