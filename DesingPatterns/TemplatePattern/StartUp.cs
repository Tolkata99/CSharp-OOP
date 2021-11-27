using System;

namespace TemplatePattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Sourdough sourdough = new Sourdough();
            Console.WriteLine(sourdough.Make());

            TwelveGrain twelveGrain = new TwelveGrain();
            Console.WriteLine(twelveGrain.Make());

            WholeWheat wholeWheat = new WholeWheat();
            Console.WriteLine(wholeWheat.Make());


        }
    }
}
