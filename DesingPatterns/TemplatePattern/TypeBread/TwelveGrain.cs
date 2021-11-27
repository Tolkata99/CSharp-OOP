using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class TwelveGrain : Bread
    {
        public override string Bake()
        {
            return $"Baking the 12-Grain Bread ((25 minutes))";

        }

        public override string MixIngredients()
        {
            return $"Gathering Ingredient for 12-Grain Bread";
        }
    }
}
