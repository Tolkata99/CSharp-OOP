
using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface IRobots : IIdentifiable
    {
        string Model { get; }
    }
}
