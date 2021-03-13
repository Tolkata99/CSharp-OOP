using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal.Mammals.Femiles
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name, double weight, HashSet<string> allowedFood, double weidhtModifer, string livingRegion,string breed) 
            : base(name, weight, allowedFood, weidhtModifer, livingRegion)
        {
            Breed = breed;
        }

        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.Breed}, {this.Weight}, {this.LivingRegion}, {this.FoodEaten}]";
        }
    }
}
