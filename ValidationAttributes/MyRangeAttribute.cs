using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationAttributes
{
    public class MyRangeAttribute : MyValidationAttribute
    {
        private int _minValue;
        private int _maxValue;

        public MyRangeAttribute(int minValue, int maxValue)
        {
            this._minValue = minValue;
            this._maxValue = maxValue;
        }
         
        public override bool IsValid(object obj)
        {
            if(obj is int) 
            {
                int currNum = ((int)obj);
                return (this._minValue <= currNum && currNum <= this._maxValue);
            }
            return false;
        }
    }
}
