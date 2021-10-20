using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animal.Birds
{
    public class Hen : Bird
    {

        private const double BaseWeightModifier = 0.35;

        private static HashSet<string> allowedFoods = new HashSet<string>()
        {
            nameof(Meat),
            nameof(Seeds),
            nameof(Vegetable),
            nameof(Fruit)
        };

        public Hen(string name, double weight, double wingSize) 
            : base(name, weight, allowedFoods, BaseWeightModifier, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
