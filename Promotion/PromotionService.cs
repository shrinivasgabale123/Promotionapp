using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
   public class PromotionService : IPromotionService
    {
        private readonly IPromotioncal _Promotioncal;

        public PromotionService(IPromotioncal Promotioncal)
        {
            _Promotioncal = Promotioncal;
        }
        public int GetTotalPriceService(List<DTOProduct> products)
        {
            return _Promotioncal.GetTotalPrice(products);
        }
    }
}
