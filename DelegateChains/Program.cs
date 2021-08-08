using System;

namespace DelegateChains
{
    delegate void Notify(string message);

    // Notify 델리게이트의 인스턴스 EventOccured를 가지는 클래스
    class Notifier
    {
        public Notify EventOccured;
    }

    class EventListener
    {
        private string name;
        public EventListener(string name)
        {
            this.name = name;
        }

        public void SomethingHappend(string message)
        {
            Console.WriteLine("{0}.SomethingHappend : {1}", name, message);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Notifier notifier = new Notifier();
            EventListener listener1 = new EventListener("Listenter1");
            EventListener listener2 = new EventListener("Listenter2");
            EventListener listener3 = new EventListener("Listenter3");

            // += 연산자로 체인 만들기
            notifier.EventOccured += listener1.SomethingHappend;
            notifier.EventOccured += listener2.SomethingHappend;
            notifier.EventOccured += listener3.SomethingHappend;
            notifier.EventOccured("You've got mail");

            Console.WriteLine();

            // -= 연산자로 체인 끊기
            notifier.EventOccured -= listener2.SomethingHappend;
            notifier.EventOccured("Download complete.");

            Console.WriteLine();

            // + 연산자로 체인 만들기
            notifier.EventOccured = new Notify(listener2.SomethingHappend) + new Notify(listener3.SomethingHappend);
            notifier.EventOccured("Nuclear launch detected.");
        }
    }
}
