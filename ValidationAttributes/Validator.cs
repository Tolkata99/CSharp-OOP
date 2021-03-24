using CommandPattern.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace CommandPattern
{
    public static class Validator
    {
        public static bool IsValid(object obj)
        {
            var properties = obj.GetType().GetProperties();

            foreach (var prop in properties)
            {
                var arttributes = prop.GetCustomAttributes().Cast<MyValidationAttribute>().ToArray();

                var value = prop.GetValue(obj);

                foreach (var atribute in arttributes)
                {
                   bool isValid = atribute.IsValid(value);

                    if(!isValid)
                    {
                        return false;
                    }
                }

            }

            

            return true;
        }
    }
}
