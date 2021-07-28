using System;

namespace AnonymousMethodsandLambdaExpression
{
    class Program
    {
        delegate void Transformer(int x);
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t; // create the instance;

            //t = delegate (int x)
            //{
            //    Console.WriteLine(x * x);
            //};

            t = (int x) => { Console.WriteLine(x * x); };

            t.Invoke(i);

            Console.ReadLine();
        }
    }
}
