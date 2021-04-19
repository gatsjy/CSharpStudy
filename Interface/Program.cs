using System;
using System.Runtime.CompilerServices;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //ClimateMonitor monitor = new ClimateMonitor(new FileLogger("MyLog.txt"));
            ClimateMonitor monitor = new ClimateMonitor(new ConsoleLogger());

            monitor.start();
        }
    }
}
