using System;

namespace DelegateDemo
{
    // event는 delegate와 써야한다.
    delegate void Transformer(int x);

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int i = int.Parse(Console.ReadLine());

            Transformer t; // create the instance

            t = Square; // point to the function
             
            t += Cuber; // two methods till now

            t.Invoke(i); // invoking the delegate

            NotifivationfMethods obj = new NotifivationfMethods();

            obj.transformerEvent += User1.Xhandler;
            obj.transformerEvent += User2.Yhandler;

            obj.NotifyOnCell(i);

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

    class NotifivationfMethods
    {
        public event Transformer transformerEvent;

        public void NotifyOnCell(int x)
        {
            if (transformerEvent != null)
            {
                transformerEvent(x);
            }
        }
    }

    class User1
    {
        public static void Xhandler(int x)
        {
            Console.WriteLine("Event received by User1 object");
        }
    }
    class User2
    {
        public static void Yhandler(int x)
        {
            Console.WriteLine("Event received by User2 object");
        }
    }
}
