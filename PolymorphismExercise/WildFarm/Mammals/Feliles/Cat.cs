using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animal.Mammals.Femiles;
using WildFarm.Foods;

namespace WildFarm.Animal.Mammals.Feliles
{
    public class Cat : Feline
    {

        private const double BaseWeightModifer = 0.30;

        private static HashSet<string> CatAllowedFood = new HashSet<string>()
        {
            nameof(Meat),
            nameof(Vegetable)
        };

        public Cat(string name, double weight, string livingRegion, string breed) 
            : base(name, weight, CatAllowedFood, BaseWeightModifer, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "Meow";
        }
    }
}
