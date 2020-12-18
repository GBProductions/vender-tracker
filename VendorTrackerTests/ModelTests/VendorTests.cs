using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class VendorTests
    {
        [TestMethod]
        public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
        {
            Vendor newVendor = new Vendor("Test", "test1");
            Assert.AreEqual(typeof(Vendor), newVendor.GetType());
        }

        [TestMethod]
        public void GetBusiness_ReturnsBusiness_String()
        {
            //Arrange
            string business = "The Cake House.";

            //Act
            Vendor newVendor = new Vendor(business, "test");
            string result = newVendor.Business;

            //Assert
            Assert.AreEqual(business, result);

        }


    }
}