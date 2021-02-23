using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Dessert : Food
    {
        public double Calorries { get; set; }

        public Dessert(string name, decimal price, double grams,double calorries) : base(name, price, grams)
        {
            Calorries = calorries;
        }
    }
}
