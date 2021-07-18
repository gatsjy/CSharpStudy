using System;
using System.Collections;
using System.Collections.Generic;

namespace GenericCollectionsEx3
{
    // Stack<T>
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            stack.Push(11);
            stack.Push(22);
            stack.Push(33);
            stack.Push(44);
            stack.Push(55);

            while(stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
        }
    }
}
