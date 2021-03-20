using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SOLID.Logger
{
    class LogFile : ILogFile
    {
        protected const string FilePath = "../../../log.txt";

        public int Size => File.ReadAllText(FilePath)
            .Where(d => char.IsDigit(d))
            .Sum(s => s);



        public void Write(string content)
        {
            File.AppendAllText(FilePath, content);
        }
    }
}
