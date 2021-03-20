using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Logger
{
    public interface ILogFile
    {
        int Size { get; }


        void Write(string content);
    }
}
