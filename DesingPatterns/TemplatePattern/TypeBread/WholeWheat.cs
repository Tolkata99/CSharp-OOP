using System;
using System.Collections.Generic;
using System.Text;

namespace TemplatePattern
{
    public class WholeWheat : Bread
    {
        public override string Bake()
        {
            return $"Baking the Whole Wheat Bread ((15 minutes))";

        }

        public override string MixIngredients()
        {
            return $"Gathering Ingredient for Whole Wheat Bread";
        }
    }
}
