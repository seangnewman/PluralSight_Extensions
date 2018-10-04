﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;
using newmanuevers.Extensions.Advanced.Demo1;


namespace newmanuevers.Extensions.Advanced.Tests
{
    [TestClass]
    public class InstrumentationTests
    {
        [TestMethod]
        public void GetTotalSeconds()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            Assert.AreEqual(1, instrumentation.GetElapsedTime());

        }

        [TestMethod]
        public void GetPreciseElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.Start();
            Thread.Sleep(750);
            var elapsed = instrumentation.GetPreciseElapsedTime();
            Assert.IsTrue(elapsed >= 0.75 && elapsed < 0.78);

        }

        [TestMethod]
        public void GetReallyPrecisedElapsedTime()
        {
            var instrumentation = new Instrumentation();
            instrumentation.StartWithPrecision();
            Thread.Sleep(750);
            Assert.AreEqual(750, instrumentation.GetReallyPreciseElapsedTime());

        }
    }
}
