using System;

namespace GenericsEx
{
    // Generics : int, float, double 과 같은 데이터 타입을 확정하지 않고 이 데이터 타입 자체를 
    //타입 파라미터(Type Parameter) 받아들이도록 하는 기능
    // 실수형으로 계산을 하게 될 때?
    // 데이터 타입만 다르고 내부적으로 같은 로직일 뿐인데?? 이러한 불합리함을 제거하기 위해 제네릭스가 만들어졌다.
    // C++의 템플릿 기능과 비슷한 개념이다!
    // ** 성공하려면.. 남들 유투브 넷플릭스 보는 시간에 C# C++ C 를 공부해야 합니다!!
    // 현대오토에버 가자!!
    /*
        일반화 메서드 선언 방식

        접근제한자 반환형식 메소드이름<형식 매개 변수>(매개변수)
        {
        }

        <예>
        void CopyData(int a, int b)
        {
            b = a; // b에 a를 복사
        }

        void CopyData(string a, string b)
        {
            b = a; // b에 a를 복사... 문자열 a를 b에 복사
        }

        -> 이거 너무 비효율적인거 아닌가????
        위의 방식은 데이터 형식에 따라서 여러개의 메소드가 필요하게된다.

        void CopyData<T> (T a, T b) // 여기서 T는 Type을 뜻함
        {
            b = a;
        }

    */
    class Program
    {
        static void CopyData<T> (T[] a, T[] b)
        {
            for (int i = 0; i < a.Length; i++)
            {
                b[i] = a[i];
            }
        }
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44, 55, };
            int[] b = new int[a.Length];

            CopyData<int>(a, b);
            
            foreach(int item in b)
            {
                Console.WriteLine(item);
            }

            string[] aa = { "사과", "배", "딸기", "포도", "수박" };
            string[] bb = new string[aa.Length];

            CopyData<string>(aa, bb);

            foreach(string item in aa)
            {
                Console.WriteLine(item);
            }
        }
    }
}
