using System;

namespace UsingParams
{
    class Program
    {
        static int Sum(params int[] args)
        {
            Console.WriteLine("Summing...");

            int sum = 0;
            for (int i = 0; i <args.Length; i++)
            {
                if (i > 0)
                    Console.WriteLine(", ");

                Console.WriteLine(args[i]);

                sum += args[i];
            }
            Console.WriteLine();

            return sum;
        }

        static void Main(string[] args)
        {
            int sum = Sum(3, 4, 5, 6, 7, 8, 35, 35, 64, 7);
            Console.WriteLine(sum);
        }
    }
}
