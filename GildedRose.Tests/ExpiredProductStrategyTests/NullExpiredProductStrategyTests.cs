﻿using csharp;
using csharp.ExpiredProductStrategies;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GildedRose.Tests.ExpiredProductStrategyTests
{
    [TestClass]
    public class NullExpiredProductStrategyTests
    {
        [TestMethod, TestCategory("Unit")]
        public void GivenNullExpiredProductStrategyShouldReturnSameObject()
        {
            Item item = new Item { Name = "Foo", SellIn = 2, Quality = 50 };
            IProduct product = new Product(item);

            IExpiredProductStrategy nullExpiredProductStrategy = new NullExpiredProductStrategy();
            IProduct actual = nullExpiredProductStrategy.Expired(product);
            actual.Item().Should().Be(item);
        }
    }
}