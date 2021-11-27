using System;
using System.Collections.Generic;
using System.Text;

namespace Component
{
    public class SingleGift : GiftBase
    {
        public SingleGift(string name,int price)
            :base(name,price)
        {

        }

        public override int CalculateTOtalPrice()
        {
            return price;
        }
    }
}
