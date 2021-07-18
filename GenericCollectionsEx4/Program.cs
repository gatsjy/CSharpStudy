using System;
using System.Collections.Generic;

namespace GenericCollectionsEx4
{
    // Dictionary<Tkey, TValue>
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dic = new Dictionary<string, string>();

            dic["apple"] = "사과";
            dic["orange"] = "오렌지";
            dic["banana"] = "바나나";

            Console.WriteLine(dic["apple"]);
            Console.WriteLine(dic["orange"]);
        }
    }
}
