using System;

namespace UsingCallback
{
    //delegate int Compare(int a, int b);
    // 제네릭 버전
    delegate int Compare<T>(T a, T b);

    class Program
    {
        //static int AscendCompare<T>(int a, int b)
        //{
        //    if (a > b)
        //        return 1;
        //    else if (a == b)
        //        return 0;
        //    else
        //        return -1;
        //}
        static int AscendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b);
        }

        //static int DescendCompare<T>(int a, int b)
        //{
        //    if (a < b)
        //        return 1;
        //    else if (a == b)
        //        return 0;
        //    else
        //        return -1;
        //}
        static int DescendCompare<T>(T a, T b) where T : IComparable<T>
        {
            return a.CompareTo(b) * -1;
        }

        static void BubbleSort<T>(T[] DataSet, Compare<T> Comparer)
        {
            int i = 0;
            int j = 0;
            T temp;

            for (i = 0; i < DataSet.Length - 1; i++)
            {
                for (j = 0; j < DataSet.Length - (i + 1); j++)
                {
                    if (Comparer(DataSet[j], DataSet[j + 1]) > 0)
                    {
                        temp = DataSet[j + 1];
                        DataSet[j + 1] = DataSet[j];
                        DataSet[j] = temp;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int[] array = { 3, 7, 5, 2, 10 };
            Console.WriteLine("Sorting ascending");
            BubbleSort(array, new Compare<int>(AscendCompare));

            for(int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }

            int[] array2 = { 7, 2, 8, 10, 11 };
            Console.WriteLine("\nSorting descending");
            BubbleSort(array2, new Compare<int>(DescendCompare));

            for (int i = 0; i < array2.Length; i++)
                Console.Write("{0} ", array2[i]);

            string[] array3 = { "abc", "def", "ghi", "jkl", "mno" };
            Console.WriteLine("\nSorting descending");
            BubbleSort(array3, new Compare<string>(DescendCompare));

            for (int i = 0; i < array3.Length; i++)
                Console.Write("{0} ", array3[i]);
        }
    }
}
