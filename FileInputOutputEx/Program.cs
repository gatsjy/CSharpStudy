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

            // 이런 클래스도 존재한다!
            DriveInfo c = new DriveInfo("C"); // C: 드라이브를 질의한다.

            long totalSize = c.TotalSize; // 크키 (바이트 단위)
            long freeByte = c.TotalFreeSpace; // 디스크 할당량(쿼터)은 무시한 가용 용량
            long freeToMe = c.AvailableFreeSpace; // 디스크 할당량도 포함한 가용 용량

            foreach(DriveInfo d in DriveInfo.GetDrives()) // 정의된 모든 드라이브를 나열
            {
                Console.WriteLine(d.Name); // C:\
                Console.WriteLine(d.DriveType); // Fixed
                Console.WriteLine(d.RootDirectory); // C:\

                if(d.IsReady) // 드라이브가 준비되지 않은 상태이면
                              // 다른 속성들이 예외를 던진다.
                {
                    Console.WriteLine(d.VolumeLabel); // The Sea Drive
                    Console.WriteLine(d.DriveFormat); // NTFS
                }
            }
        }
    }
}
