using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndAbstractionDemoKitchen
{
    public class Kitchen : IOrderMeal, IMachinery, ICostCalculate
    {
        public Kitchen()
        {
            Machines = new List<string>() { "kotlon", "pechka", "freeze" };
        }

        public List<string> Machines { get; set; }

        public void OrderMeal(string order)
        {
            Console.WriteLine($"Oreded meal {order}");
        }

        public void AddProduct(string product)
        {
            Console.WriteLine($"Product Added {product}");
        }

        public void CalculateCost()
        {
            Console.WriteLine("curent cost");
        }

        public void ListOfMachines()
        {
            foreach (var item in Machines)
            {
                Console.WriteLine(item);
            }
        }

       
    }


}
