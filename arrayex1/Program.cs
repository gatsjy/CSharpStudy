using System;

namespace arrayex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] a = {{0,0,4,1,0},{0,2,0,0,0},{5,0,0,0,0},{0,0,2,0,3},{4,0,0,0,0}};

            // 1. 행 우선 방식으로 할당
            int[,] b = new int[5, 5];
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    b[i,j] = a[i,j];
                }
            }
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.Write(b[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("B[2][4] : {0}", b[2,4]);

            // 1. 열 우선 방식으로 할당
            int[,] c = new int[5, 5];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    c[i, j] = a[j, i];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("C[2][4] : {0}", c[2, 4]);
        }
    }
}
