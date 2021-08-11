using System;
using System.IO;

namespace FileInputOutputEx
{
    class Program
    {
        static void Main(string[] args)
        {
            // StreamWriter
            StreamWriter sw = new StreamWriter("a.txt");
            sw.Write("안녕!");
            sw.Write("바보!");
            sw.WriteLine("멍충이");
            sw.WriteLine("천치");
            sw.WriteLine("천치");
            sw.WriteLine("천치");

            // sw.Close() 를 해야지 모든 쓰기가 커밋된다.
            sw.Close();

            // StreamReader
            StreamReader sr = new StreamReader("a.txt");

            int count = 1;
            // 한줄읽고 쓰고 한줄읽고 쓰고
            while(sr.Peek() >= 0)
            {
                Console.WriteLine(sr.ReadLine());
                Console.WriteLine(count++);
            }
            sr.Close();
        }
    }
}
