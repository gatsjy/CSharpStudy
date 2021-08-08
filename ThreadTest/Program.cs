using System;
using System.Threading;

namespace ThreadTest
{
    class ThreadTest
    {
        bool _done;

        static void Main()
        {
            ThreadTest tt = new ThreadTest(); // 공통의 인스턴스를 생성한다.
            new Thread(tt.Go).Start();
            tt.Go();
        }

        void Go() // 이것이 인스턴스 메서드임을 주목할 것
        {
            if (!_done) { _done = true; Console.WriteLine("Done"); };
        }
    }
}
