using System;
using System.IO;

namespace FileStreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // 현재 디렉터리에 test.txt라는 파일을 생성한다.
            using (Stream s = new FileStream("test.txt", FileMode.Create))
            {
                Console.WriteLine(s.CanRead); // True
                Console.WriteLine(s.CanWrite); // True
                Console.WriteLine(s.CanSeek); // True

                s.WriteByte(101);
                s.WriteByte(102);
                byte[] block = { 1, 2, 3, 4, 5 };
                s.Write(block, 0, block.Length); // 5바이트 블록을 기록한다.

                Console.WriteLine(s.Length); // 7
                Console.WriteLine(s.Position); //7
                s.Position = 0; // 시작위치로 돌아간다.

                Console.WriteLine(s.ReadByte()); // 101
                Console.WriteLine(s.ReadByte()); // 102

                // 스트림을 읽어서 block 배열을 다시 채운다.
                Console.WriteLine(s.Read(block, 0, block.Length)); //5

                // 위의 Read 호출이 5를 돌려주었다고 가정하면 현재 위치는
                // 파일의 끝이므로, 다음 Read는 0을 돌려준다.
                Console.WriteLine(s.Read(block, 0, block.Length)); //0
            }
        }
    }
}
