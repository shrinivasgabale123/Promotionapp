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
            List<DTOProduct> dTOProducts = new List<DTOProduct>();
            DTOProduct dTOProduct = new DTOProduct("A");
            dTOProducts.Add(dTOProduct);
            Promotioncal promotioncal = new Promotioncal();
            Assert.Equal(50, promotioncal.GetTotalPrice(dTOProducts));
        }
    }
}
