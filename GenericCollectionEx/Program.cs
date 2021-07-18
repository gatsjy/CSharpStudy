using System;
using System.Collections.Generic;

namespace GenericCollectionEx
{
    // Generic Collection : object 형식에 기반한 컬렉션의 문제들을 해결하는 방법으로 사용되고 있다.
    // Generic(일반화) 기반으로 만들어져 있기 때문에 컴파일할 때 사용할 형식이 정해지므로 형변환 발생이 줄어든다.
    // 컬렉션이 가지고 있는 성능상의 문제를 해결할 수 있다.

    // ArrayList, Queue, Stack, Hashtable
    // --> List<T>, Queue<T>, Stack<T>, Dictionary<Tkey, TValue>

    // List<T>클래스는 ArrayList의 일반(Generic) 버전
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
                list.Add(i);

            foreach (int item in list)
                Console.Write($"{item} ");
            Console.WriteLine();

            list.RemoveAt(2);

            foreach (int item in list)
                Console.Write($"{item} ");
            Console.WriteLine();

            list.Insert(2, 2);
            foreach (int item in list)
                Console.Write($"{item} ");
            Console.WriteLine();

        }
    }
}
