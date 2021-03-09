using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Animal
    {

        public string Name { get; private set; }

        public string FavouriteFood { get; private set; }


        protected Animal(string name, string favoriteFood)
        {
            this.Name = name;
            this.FavouriteFood = favoriteFood;
        }

        public virtual string ExplainSelf()
        {
            return $"I am {this.Name} and my fovourite food is {this.FavouriteFood}";
        }
    }
}
