using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Animal.Mammals.Femiles;
using WildFarm.Foods;

namespace WildFarm.Mammals.Feliles
{
    public class Tiger : Feline
    {
        private const double BaseWeightModifer = 1;

        private static HashSet<string> TigerAllowedFood = new HashSet<string>()
        {
            nameof(Meat),

        };

        public Tiger(string name, double weight , string livingRegion, string breed) 
            : base(name, weight, TigerAllowedFood, BaseWeightModifer, livingRegion, breed)
        {
        }

        public override string ProduceSound()
        {
            return "ROAR!!!";
        }
    }
}
