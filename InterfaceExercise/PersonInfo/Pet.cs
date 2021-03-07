using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Pet : IBirdThday
    {
        public Pet(string birdDay, string name)
        {
            BirdDay = birdDay;
            Name = name;
        }

        public string BirdDay { get; private set;}

        public string Name { get; set; }
    }
}
