using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorTracker.Models;
using System;

namespace VendorTracker.Tests
{
    [TestClass]
    public class OrderTests
    {
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
        Order newOrder = new Order();
        Assert.AreEqual(typeof(Order), newOrder.GetType());
        }
    }
}