using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
   public interface IPromotioncal
    {
        int GetTotalPrice(List<DTOProduct> products);
    }
}
