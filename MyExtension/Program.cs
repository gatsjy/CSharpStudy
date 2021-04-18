using MyExtension;
using System;

namespace MyExtension
{
    public static class IntegerExtension
    {
        public static int Square(this int myInt)
        {
            return myInt * myInt;
        }

        public static int Power(this int MyInt, int exponent)
        {
            int result = MyInt;
            for (int i = 1; i < exponent; i++)
            {
                result = result * MyInt;
            }
            return result;
        }
    }
}

namespace ExtensionMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"3^2 : {3.Square()}");
            Console.WriteLine($"3^2 : {3.Power(4)}");
            Console.WriteLine($"3^2 : {2.Power(10)}");
        }
    }
}
