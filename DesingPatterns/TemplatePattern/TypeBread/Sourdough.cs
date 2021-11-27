using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class Sourdough : Bread
    {
        public override string Bake()
        {
            return $"Baking the Sourdough Bread ((20 minutes))";

        }

        public override string MixIngredients()
        {
            return $"Gathering Ingredient for Sourdough Bread";
        }
    }
}
