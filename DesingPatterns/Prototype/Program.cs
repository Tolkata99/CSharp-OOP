using System;

namespace Prototype
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Sandwich sandwich = new Sandwich("","","","");
            Console.WriteLine(sandwich.Clone());
        }
    }
}
