using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using newmanuevers.Extensions.Samples_v2.Demo3;
using newmanuevers.Extensions.Samples_v2.Demo3.Impl;

namespace newmanuevers.Extensions.Tests.Demo3
{
    [TestClass]
    public class ReferenceDataSourceTests
    {
        [TestMethod]
        public void GetItems()
        {
            IReferenceDataSource source;

            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());

            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());

            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItems().Count());
        }

        [TestMethod]
        public void GetItemsByCode()
        {
            IReferenceDataSource source;

            source = new SqlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());

             
        }


        [TestMethod]
        public void GetItemsByCode_Xml()
        {
            IReferenceDataSource source;

            source = new XmlReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());


        }


        [TestMethod]
        public void GetItemsByCode_Api()
        {
            IReferenceDataSource source;

            source = new ApiReferenceDataSource();
            Assert.AreEqual(2, source.GetItemsByCode("xyz").Count());


        }
    }
}
