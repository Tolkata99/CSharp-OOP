using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonInfo
{
    public class StartUp
    {
        public static void Main()
        {
            List<IBirdThday> identification = new List<IBirdThday>();

            while (true)
            {
                string partsLoop = Console.ReadLine();

                if (partsLoop == "End")
                {
                    break;
                }

                string[] parts = partsLoop.Split();

                if (parts.Length == 5)
                {
                    string name = parts[1];
                    int age = int.Parse(parts[2]);
                    string id = parts[3];
                    string birdDay = parts[4];

                    identification.Add(new Citizen(name, age, id, birdDay));
                }
                else if(parts.Length == 3)
                {
                    string name = parts[1];
                    string data = parts[2];

                    IBirdThday pet = new Pet(data, name);

                    identification.Add(pet);
                }

            }

            string year = Console.ReadLine();

            var birdDayDateValid = identification
                .Where(i => i.BirdDay
                .EndsWith(year))
                .ToList();

            foreach (var item in birdDayDateValid)
            {
                Console.WriteLine(item.BirdDay);
                
                
            }

            if(birdDayDateValid.Count < 1)
            {
                string empty = string.Empty;
                
            }
        }

    }
}
