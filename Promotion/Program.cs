using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;

namespace Promotion
{
   public class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
            .AddSingleton<IPromotionService, PromotionService>()
            .AddSingleton<IPromotioncal, Promotioncal>()
            .BuildServiceProvider();


            List<DTOProduct> products = new List<DTOProduct>();
            Console.WriteLine("Enter the total number of order you want to  buy ?");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                Console.WriteLine("Enter the type of product like :A, B, C or D");
                string type = Console.ReadLine();
                DTOProduct p = new DTOProduct(type);
                products.Add(p);
            }


            var promotionService = serviceProvider.GetService<IPromotionService>();
            int totalPrice = promotionService.GetTotalPriceService(products);


            //Promotioncal _promotion = new Promotioncal();
            //int totalPrice = _promotion.GetTotalPrice(products);
            Console.WriteLine("======================================");
            Console.WriteLine("Total of your order is : " + totalPrice);
            Console.WriteLine("======================================");
            Console.ReadLine();
        }
    }
}

