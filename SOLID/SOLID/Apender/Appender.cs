using SOLID.Enum;
using SOLID.Layout;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Apender
{
    public abstract class Appender : IAppender
    {
        protected ILayout layout;

        public Appender(ILayout layout)
        {
            this.layout = layout;
        }

        public ReportLevel ReportLevel { get; set; }

        public abstract void Append(string data,ReportLevel reportLevel, string name);

        
       
        
    }
}
