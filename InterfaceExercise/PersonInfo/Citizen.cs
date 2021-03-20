using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : IPerson, IBirdThday, IIdentification
    {
        public Citizen(string name, int age, string id,string birdDay)
        {
            Name = name;
            Age = age;
            Food = 0;
            BirdDay = birdDay;
            Id = id;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public int Food { get; private set; }

        public string BirdDay { get; private set; }

        public string Id { get; private set; }

        public void BuyFood()
        {
            Food += 10;
        }
    }
}
