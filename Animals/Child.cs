using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Child : Person
    {
        public Child(string name, int age) : base(name, age) 
        {
            
        }

        public override int Age
        {
            get
            {
                return base.Age;
            }
            set
            {
                if (value > 15)
                {
                    throw new Exception("this is big person");
                }

                base.Age = value;
            }


        }
    }
}
