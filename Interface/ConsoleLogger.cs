using Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{ 
    class ConsoleLogger : ILogger
    {
        public void WriteLog(string message)
        {
            Console.WriteLine(
                "{0} {1}", DateTime.Now.ToLocalTime(), message);
        }
    }
}
