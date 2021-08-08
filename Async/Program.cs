using System;
using System.Threading.Tasks;

namespace Async
{
    class Program
    {
        async static private void MyMethodAsync(int count)
        {
            Console.WriteLine("C");
            Console.WriteLine("D");

            await Task.Run(async () =>
            {
                for (int i = 0; i <= count; i++)
                {
                    Console.WriteLine("{0}/{1} ...", i, count);
                    await Task.Delay(100); // Thread.Sleep() 의 비동기 버전
                }
            });

            Console.WriteLine("G");
            Console.WriteLine("H");
        }

        static void Caller()
        {
            Console.WriteLine("A");
            Console.WriteLine("B");

            MyMethodAsync(3);

            Console.WriteLine("E");
            Console.WriteLine("F");
        }
        static void Main(string[] args)
        {
            Caller();

            Console.ReadLine();
        }
    }
}
