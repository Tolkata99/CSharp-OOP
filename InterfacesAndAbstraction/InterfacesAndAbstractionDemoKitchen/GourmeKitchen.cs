using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractionDemoKitchen
{
    class GourmeKitchen : ICostCalculate, IMachinery, IOrderMeal
    {
        public List<string> Machines { get; set; }

        public GourmeKitchen()
        {
            Machines = new List<string>() { "goutrme sdfs", "gourme kotlon" };
        }
        public void CalculateCost()
        {
            Console.WriteLine("gourme cost");
        }

        public void ListOfMachines()
        {
            foreach (var item in Machines)
            {
                Console.WriteLine($"gourme {item}");
            }
        }

        public void OrderMeal(string order)
        {
            Console.WriteLine("Order meal gourme '");
        }
    }
}
