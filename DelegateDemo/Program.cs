using System;

namespace DelegateDemo
{
    class Program
    {
        delegate void Transformer(int x);

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t; // create the instance

            t = Square; // point to the function
             
            t += Cuber; // two methods till now

            t.Invoke(i); // invoking the delegate

            Console.ReadLine();
        }

        static void Square(int x)
        {
            Console.WriteLine(x * x);
        }

        static void Cuber(int x)
        {
            Console.WriteLine(x * x * x);
        }
    }
}
