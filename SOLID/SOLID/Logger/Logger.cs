using SOLID.Apender;
using SOLID.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.Logger
{
    public class Loggerr : ILogger
    {
        private readonly IAppender[] appenders;


        public Loggerr(params IAppender[] apenders)
        {
            this.appenders = apenders;
        }



        public void Error(string date, string message)
        {
            foreach (var apender in this.appenders)
            {
                apender.Append(date, ReportLevel.Error, message);
            }
        }

        public void Info(string date, string message)
        {
            foreach (var apender in this.appenders)
            {
                apender.Append(date, ReportLevel.Info, message);
            }
        }

        public void Warning(string date, string message)
        {
            foreach (var apender in this.appenders)
            {
                apender.Append(date, ReportLevel.Warning, message);
            }
        }

        public void Critical(string date, string message)
        {
            foreach (var apender in this.appenders)
            {
                apender.Append(date, ReportLevel.Critical, message);
            }

        }

        public void Fatal(string date, string message)
        {
            foreach (var apender in this.appenders)
            {
                apender.Append(date, ReportLevel.Fatal, message);
            }
        }

        
    }
}
