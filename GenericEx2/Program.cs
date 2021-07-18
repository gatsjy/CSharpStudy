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

    class DemoList<T>
    {
        private T[] array;
        public T GetItem(int idx) { return array[idx]; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            DemoList<int> demoList1 = new DemoList<int>();
            DemoList<Double> demoList2 = new DemoList<double>();

            Console.WriteLine("Hello World!");
        }
    }
}
