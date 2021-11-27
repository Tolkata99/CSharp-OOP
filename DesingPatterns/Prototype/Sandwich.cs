using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Sandwich : SandwichPrototype
    {
        
        public Sandwich(string bread, string meat, string cheese, string veggies)
        {
            Bread = bread;
            Meat = meat;
            Cheese = cheese;
            Veggies = veggies;
        }

        public string Bread { get; set; }


        public string Meat { get; set; }


        public string Cheese { get; set; }


        public string Veggies { get; set; }

        public override SandwichPrototype Clone()
        {
            //violation single responsibility
            //Console.WriteLine(GetIngredientList());

            return MemberwiseClone() as SandwichPrototype;
        }

        private string GetIngredientList()
        {
            return $"{this.Bread} {this.Meat} {this.Cheese} { this.Veggies}";
        }
    }
}
