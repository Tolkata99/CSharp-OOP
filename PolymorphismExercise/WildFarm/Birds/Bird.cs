using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public abstract class Bird : Animal
    {
        public Bird(string name,
            double weight,
            HashSet<string> allowedFood,           
            double weidhtModifer,
            double wingSize)
            : base(name, weight, allowedFood, weidhtModifer)
        {
            WingSizes = wingSize;
        }

        public double WingSizes { get; private set; }

        public override string ToString()
        {
            return $"{this.GetType().Name} [{this.Name}, {this.WingSizes}, {this.Weight}, {this.FoodEaten}]";
        }
    }
}
