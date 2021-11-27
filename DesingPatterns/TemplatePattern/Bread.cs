using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public abstract class Bread
    {
        public abstract string MixIngredients();

        public abstract string Bake();

        public virtual string Slice()
        {
            return $"Slicing the" + this.GetType().Name + "bread!!!!!!!!!";
        }


        //Template method
        public string Make()
        {
            return $"{MixIngredients()} \n {Bake()}, \n {Slice()}\n";
          
        }
    }
}
