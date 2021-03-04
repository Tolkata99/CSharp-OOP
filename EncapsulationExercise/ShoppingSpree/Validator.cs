using System;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public static class Validator
    {
        public static void ThrowIfNameEmpty(string str ,string exception)
        {
            if(string.IsNullOrWhiteSpace(str))
            {
                throw new ArgumentException(exception);
            }
        }

        public static void ThrowIfCostEmpty(decimal cost,string exception)
        {
            if(cost < 0)
            {
                throw new ArgumentException(exception);
            }
        }

    }
}
