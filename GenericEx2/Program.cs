using System;

namespace GenericEx2
{
    // 일반화 클래스 선언 방식
    // 일반화 클래스는 똑같은 기능을 하지만 내부적으로 사용하는 데이터 형식이 다를 경우에 사용하면 편리합니다.
        /*
           class 클래스명 <T>
           {
                
           }

           <예>
           class DemoList
           {
                private int[] array;
                
                public int GetItem(int idx){ return array[idx] }
           }

           class DemoList2
           {
                private double[] array;

                public int GetItem(double idx){ return array[idx] }
           }

           분리 된 두개의 클래스를... 내용은 같은데 자료형만 다르다??
         */
    class Program
    {
        class MyList<T>
        {
            private T[] array;

            public MyList()
            {
                array = new T[4];
            }

            public T this[int idx]
            {
                get
                {
                    return array[idx];
                }

                set
                {
                    if(idx >= array.Length)
                    {
                        Array.Resize<T>(ref array, idx+1);
                        Console.WriteLine($"배열 사이즈조정 : {array.Length}");
                    }

                    array[idx] = value;
                }
            }

            public int Length
            {
                get { return array.Length; }
            }
        }

        static void Main(string[] args)
        {
            MyList<string> myList1 = new MyList<string>();
            myList1[0] = "A";
            myList1[1] = "B";
            myList1[2] = "C";
            myList1[3] = "D";
            myList1[4] = "E";
            myList1[5] = "F";

            for (int i = 0; i < myList1.Length; i++)
            {
                Console.WriteLine(myList1[i]);
            }
        }
    }
}
