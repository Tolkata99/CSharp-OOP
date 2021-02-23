using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Beverage : Product
    {
        public double Mililitres { get; set; }

        public Beverage(string name, decimal price, double milliliters) : base(name, price)
        {
            Mililitres = milliliters;
        }
    }
}
