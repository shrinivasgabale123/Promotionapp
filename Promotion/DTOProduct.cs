﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Promotion
{
   public class DTOProduct
    {
        public string Id { get; set; }
        public decimal Price { get; set; }


        public DTOProduct(string id)
        {
            this.Id = id;
            switch (id)
            {
                case "A":
                    this.Price = 50m;

                    break;
                case "B":
                    this.Price = 30m;

                    break;
                case "C":
                    this.Price = 20m;

                    break;
                case "D":
                    this.Price = 2015m;
                    break;
            }
        }
    }
}
