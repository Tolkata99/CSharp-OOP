using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animal;
using WildFarm.Foods;

namespace WildFarm.Birds
{
    public class Hen : Bird
    {
        private const double BaseWeightModifer = 0.35;

        private static HashSet<string> HenAllowedFood = new HashSet<string>()
        {
            nameof(Meat),
            nameof(Fruit),
            nameof(Seeds),
            nameof(Vegetable)
        };

        public Hen(string name, double weight, double wingSize)
            : base(name, weight, HenAllowedFood, BaseWeightModifer, wingSize)
        {
        }

        public override string ProduceSound()
        {
            return "Cluck";
        }
    }
}
