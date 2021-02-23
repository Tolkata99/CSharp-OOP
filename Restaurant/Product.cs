using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Product
    {
        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        //        •	A constructor with the following parameters: string name, decimal price
        //•	Name – string
        //•	Price – decimal

        public string Name { get; set; }

        public decimal Price { get; set; }

    }
}
