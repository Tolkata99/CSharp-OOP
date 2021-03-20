using SOLID.Enum;
using SOLID.Layout;
using SOLID.Logger;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace SOLID.Apender
{
    public class FileAppender : Appender
    {
        private ILogFile LogFile;

        public FileAppender(ILayout layout, ILogFile logFile) 
            : base(layout)
        {
            this.LogFile = logFile;
        }

        public override void Append(string data, ReportLevel reportLevel, string name)
        {
            string content = string.Format(this.layout.template,data, reportLevel, name) + Environment.NewLine;

            this.LogFile.Write(content);

        }
    }
}
