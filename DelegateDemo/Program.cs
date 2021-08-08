using System;

namespace DelegateDemo
{
    // 참고 : https://qzqz.tistory.com/226
    // 델리게이트는 callback을 구현하기 위해 사용됩니다.
    // callback은 어떤 작업을 해줄 코드를 두고 프로그램 실행 시점에 부여하는 것을 말합니다.
    // 델리게이트는 메서드에 대한 참조입니다.
    class Program
    {
        delegate int MyDelegate(int a, int b);

        static int Plus(int a, int b)
        {
            return a + b;
        }

        static int Minus(int a, int b)
        {
            return a - b;
        }
        static void Main(string[] args)
        {
            MyDelegate Callback;

            Callback = new MyDelegate(Plus);
            Console.WriteLine(Callback(3, 4)); // 7

            Callback = new MyDelegate(Minus);
            Console.WriteLine(Callback(7, 3));
        }
    }
}