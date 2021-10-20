using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm.Animal.Mammal.Feline
{
    public abstract class Feline : Mammal
    {
        protected Feline(string name,
            double weight,
            HashSet<string> allowedFoods,
            double weightModifier,
            string livingRegion,
            string breed)
            : base(name, weight, allowedFoods, weightModifier, livingRegion)
        {
            Breed = breed;
        }


        public string Breed { get; set; }

        public override string ToString()
        {
            return $"{GetType().Name} {Name} {Weight} {LivingRegion} {Breed}";
        }
    }
}
