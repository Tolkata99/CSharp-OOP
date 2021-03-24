using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern.Attributes
{
    public abstract class MyValidationAttribute : Attribute
    {
        public abstract bool IsValid(Object obj);
    }
}
