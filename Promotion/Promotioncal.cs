using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
    public class Promotioncal : IPromotioncal
    {
        public Promotioncal()
        {
            //here we can take the DB object but here its not needed
        }

        public int GetTotalPrice(List<DTOProduct> products)
        {
            int counterofA = 0;
            int priceofA = 50;
            int counterofB = 0;
            int priceofB = 30;
            int CounterofC = 0;
            int priceofC = 20;
            int CounterofD = 0;
            int priceofD = 15;
            foreach (DTOProduct pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }
            int totalPriceofA = (counterofA / 3) * 130 + (counterofA % 3 * priceofA);
            int totalPriceofB = (counterofB / 2) * 45 + (counterofB % 2 * priceofB);
            int totalPriceofC = (CounterofC * priceofC);
            int totalPriceofD = (CounterofD * priceofD);
            return totalPriceofA + totalPriceofB + totalPriceofC + totalPriceofD;

        }
    }
}
