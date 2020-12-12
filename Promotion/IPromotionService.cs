using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
   public interface IPromotionService
    {
        int GetTotalPriceService(List<DTOProduct> products);
    }
}
