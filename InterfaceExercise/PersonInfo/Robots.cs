using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public class Robots : IRobots
    {
        public Robots(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; private set; }

        public string Id { get; private set; }
    }
}
