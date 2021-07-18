using System;
using System.Collections.Generic;

namespace GenericCollectionsEx2
{
    // Queue<T>
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> q = new Queue<int>();

            q.Enqueue(100);
            q.Enqueue(200);
            q.Enqueue(300);
            q.Enqueue(400);

            while(q.Count > 0)
            {
                Console.WriteLine(q.Peek());
                q.Dequeue();
            }
        }
    }
}
