using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Coffee : HotBeverage
    {
        public Coffee(string name, double caffeine) : base(name, DeffaultCofeePrice, DeffaultCofeeMilliliters)
        {
            Caffeine = caffeine;
        }

        private const double DeffaultCofeeMilliliters = 50;

        private const decimal DeffaultCofeePrice = 3.50m;

        public double Caffeine { get; set; }

       
    }
}
