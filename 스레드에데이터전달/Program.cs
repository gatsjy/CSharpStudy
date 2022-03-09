using System;
using System.Threading;

namespace 스레드에데이터전달
{
    // ThreadWithState 클래스는 다음 작업에 필요한 정보를 포함합니다.
    // 태스크 및 태스크 실행 방법.
    public class ThreadWithState
    {
        // 태스크에서 사용되는 상태 정보
        private string boilerplate;
        private int numberValue;

        // 생성자는 상태 정보를 포함합니다.
        public ThreadWithState(string text, int number)
        {
            boilerplate = text;
            numberValue = number;
        }

        // 스레드 프로시저는 포맷과 같은 작업을 수행합니다.
        // 문서 인쇄.
        public void ThreadProc()
        {
            Console.WriteLine(boilerplate, numberValue);
        }
    }

    // 예시 시작 지점
    public class Example
    {
        public static void Main()
        {
            // Supply the state information required by the task.
            ThreadWithState tws = new ThreadWithState("this report displays the number {0}.", 42);

            // Create a thread th execute the task, and then start thr thread.
            Thread t = new Thread(new ThreadStart(tws.ThreadProc));
            t.Start();
            // 시작하고 조인할때까지 작동하지 않다가 조인하는 순간 작동한다.
            Console.WriteLine("Main thread does some work, then waits.");
            t.Join();
            Console.WriteLine("Independent task has completed; main thread ends.");
        }
    }
}
