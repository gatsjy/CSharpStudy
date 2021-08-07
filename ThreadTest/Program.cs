using System;
using System.Threading;

namespace ThreadTest
{
    class ThreadTest
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Start();

            // 그와 동시에, 주 스레드도 나름의 작업을 진행한다.
            for (int i = 0; i < 1000; i++) Console.Write("X");
        }
        static void WriteY()
        {
            for (int i = 0; i < 1000; i++) Console.Write("Y");
        }
    }
}
