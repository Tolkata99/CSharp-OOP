using System;
using System.Collections.Generic;
using System.Text;

namespace PersonInfo
{
    public interface ICitizen : IIdentifiable,IBirdThday
    {
        string Name { get; }

        int Age { get; }
    }
}
