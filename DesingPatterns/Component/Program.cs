using System;

namespace Component
{
    class Program
    {
        static void Main(string[] args)
        {
            var phone = new SingleGift("phone", 256);
            var n = phone.CalculateTOtalPrice();
            Console.WriteLine(n);

            var rootBox = new CompositeGift("RootBox", 0);
            var truckToy = new SingleGift("truckToy", 700);
            rootBox.Add(truckToy);

            Console.WriteLine($"Total price is this composite present is {rootBox.CalculateTOtalPrice()}");

        }
    }
}
