using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal
{
    public abstract class Animal
    {
        protected Animal(string name,
            double weight
            ,HashSet<string> allowedFood,
            double weidhtModifer)
        {
            Name = name;
            Weight = weight; 
            AllowedFood = allowedFood;
            WeidhtModifer = weidhtModifer;
        }

        private HashSet<string> AllowedFood;

        private double WeidhtModifer { get; set; }

        // \•	Animal – string Name, double Weight, int FoodEaten;

        public string Name { get; private set; }

        public double Weight { get; private set; }

        public int FoodEaten { get; private set; }

        public abstract string ProduceSound();

        public void Eat(Food food)
        {
            string foodType = food.GetType().Name;
            //1-Validate the Food
            if(!AllowedFood.Contains(foodType))
            {
                throw new InvalidOperationException($"{this.GetType().Name} does not eat {foodType}!");
            }
            //2-Food Eaten
            this.FoodEaten += food.Quantity;
            //3-Weight
            this.WeidhtModifer += this.WeidhtModifer * food.Quantity;
        }

    }
}
