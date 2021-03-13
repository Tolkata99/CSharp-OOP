using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animal.Mammals;
using WildFarm.Foods;

namespace WildFarm.Mammals
{
    public class Dog : Mammal
    {
        private const double BaseWeightModifer = 0.40;

        private static HashSet<string> MouseAllowedFood = new HashSet<string>()
        {
            nameof(Meat),          
        };

        public Dog(string name, double weight,string livingRegion)
            : base(name, weight, MouseAllowedFood, BaseWeightModifer, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Woof!";
        }
    }
}
