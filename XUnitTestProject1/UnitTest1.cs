using Moq;
using Promotion;
using System;
using System.Collections.Generic;
using Xunit;

namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var Products = new DTOProduct("A") { Price = 20 };
            List<DTOProduct> listp = new List<DTOProduct>();
            listp.Add(Products);
            var mock = new Mock<IPromotionService>();
            var result = mock.Setup(x => x.GetTotalPriceService(listp));
            Assert.NotNull(result);
        }
    }
}
