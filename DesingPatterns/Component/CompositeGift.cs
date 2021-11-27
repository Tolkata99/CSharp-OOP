using Component.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Component
{
    public class CompositeGift : GiftBase,IGiftOperations
    {
        private List<GiftBase> gifts;

        public CompositeGift(string name,int price)
            :base (name,price)
        {
            gifts = new List<GiftBase>();
        }

        public void Add(GiftBase gift)
        {
            gifts.Add(gift);
        }

    
        public void Remove(GiftBase gift)
        {
            gifts.Remove(gift);
        }


        public override int CalculateTOtalPrice()
        {
            int totalPrice = 0;

            foreach (var gift in gifts)
            {
                totalPrice += gift.CalculateTOtalPrice();

            }

            return totalPrice;
        }

    }
}
