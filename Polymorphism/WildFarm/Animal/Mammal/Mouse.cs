﻿using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animal.Mammal
{
    public class Mouse : Mammal
    {
        private const double BaseWeightModifier = 0.10;
        private const int foodEaten = 0;
        private static HashSet<string> allowedFoods = new HashSet<string>()
        {
            nameof(Vegetable),
            nameof(Fruit)
        };

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, allowedFoods, BaseWeightModifier, livingRegion)
        {
            
        }

       

        public override string ProduceSound()
        {
           return "Squeak";
        }
    }
}
