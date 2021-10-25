using System;

namespace P02.Graphic_Editor
{
    class Program
    {
        static void Main()
        {
            IShape circle = new Circle();

            Console.WriteLine(circle.Draw());
        }
    }
}
