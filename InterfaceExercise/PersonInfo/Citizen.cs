using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Citizen : ICitizen
    {
        public Citizen(string name, int age ,string id,string birdDay)
        {
            Name = name;
            Age = age;        
            Id = id;
            BirdDay = birdDay;
        }

        public string Name { get; private set; }

        public int Age { get; private set; }

        public string Id { get; private set; }

        public string BirdDay { get; private set; }
    }
}
