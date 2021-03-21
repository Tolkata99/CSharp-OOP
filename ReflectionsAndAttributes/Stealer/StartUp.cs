using System;

namespace Stealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Spy spy = new Spy();
           
            
            object result = spy.AnalyzeAccessModifiers("Hacked");
            Console.WriteLine(result);
        }
    }
}
