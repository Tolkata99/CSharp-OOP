using System;
using System.Collections.Generic;
using System.Text;
using WildFarm.Foods;

namespace WildFarm.Animal.Birds
{
    public class Own : Bird
    {
        private static HashSet<string> allowedFoods = new HashSet<string>()
        {
            nameof(Meat)
        };
        private const double BaseWeightModifier = 0.25;
       

        public Own(string name,
            double weight,        
            double wingSize)
            : base(name, weight, allowedFoods, BaseWeightModifier, wingSize)
        {

        }

        public override string ProduceSound()
        {
            return "Hoot Hoot";
        }
    }
}
