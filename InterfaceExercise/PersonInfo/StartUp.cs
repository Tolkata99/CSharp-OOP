using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {
            List<IPerson> result = new List<IPerson>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] parts = Console.ReadLine().Split();

                if(parts.Length == 3)
                {
                    IPerson rebel = new Rebel(parts[0], int.Parse(parts[1]), parts[2]);
                    result.Add(rebel);
                }
                else if(parts.Length == 4)
                {
                    IPerson citizen = new Citizen(parts[0], int.Parse(parts[1]), parts[2], parts[3]);
                    result.Add(citizen);
                }
            }

            while (true)
            {
                string name = Console.ReadLine();
                if(name == "End")
                {
                    break;
                }

                foreach (var names in result)
                {
                    if(names.Name == name)
                    {
                        names.BuyFood();
                    }
                }

            }
            int food = 0;
            foreach (var item in result)
            {
                food += item.Food;
            }
            Console.WriteLine(food);
        }

    }
}
