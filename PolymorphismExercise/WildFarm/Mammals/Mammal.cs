using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal.Mammals
{
    public abstract class Mammal : Animal
    {
        protected Mammal(string name, 
            double weight, 
            HashSet<string> allowedFood,
            double weidhtModifer,
            string livingRegion) 
            : base(name, weight, allowedFood, weidhtModifer)
        {
            LivingRegion = livingRegion;
        }

        public string LivingRegion { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
