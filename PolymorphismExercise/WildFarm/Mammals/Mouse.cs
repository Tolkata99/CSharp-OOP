using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animal.Mammals;
using WildFarm.Foods;

namespace WildFarm.Animals.Mammals
{
    public class Mouse : Mammal
    {
        private const double BaseWeightModifer = 0.1;

        private static HashSet<string> MouseAllowedFood = new HashSet<string>()
        {
            nameof(Fruit),         
            nameof(Vegetable)
        };

        public Mouse(string name, double weight,  string livingRegion) 
            : base(name, weight, MouseAllowedFood, BaseWeightModifer, livingRegion)
        {
        }

        public override string ProduceSound()
        {
            return "Squeak";
        }
    }
}
