using SOLID.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Apender
{
    public interface IAppender
    {
        ReportLevel ReportLevel { get; set; }

        void Append(string data, ReportLevel reportLevel, string name);
    }
}
