using SOLID.Enum;
using SOLID.Layout;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Apender
{
    public class ConsoleAppender : Appender
    {
        public ConsoleAppender(ILayout layout) : base(layout)
        {
        }

        public override void Append(string data, ReportLevel reportLevel, string name)
        {
            if(reportLevel < this.ReportLevel)
            {
                return;
            }

            string content = string.Format(this.layout.template, data, reportLevel, name);
            Console.WriteLine(content);
        }
    }
}
