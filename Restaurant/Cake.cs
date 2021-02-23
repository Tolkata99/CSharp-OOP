using System;
using System.Collections.Generic;
using System.Text;

namespace Restaurant
{
    public class Cake : Dessert
    {
        //        •	Grams = 250
        //•	Calories = 1000
        //•	CakePrice = 5

        private const double Gramss = 250;

        private const double Calories = 1000;

        private const decimal CakePrice = 5;

            
        public Cake(string name) : base(name, CakePrice, Gramss, Calories)
        {

        }

        
    }
}
