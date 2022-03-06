﻿using System;
using System.Threading;

namespace makingThread
{
    public class ServerClass
    {
        // The method that will be called when the thread is started
        public void InstanceMethod()
        {
            Console.WriteLine("ServerClass.InstanceMethod 다른 쓰레드에서 실행 중");

            // Pause for a moment to provide a delay to make threads more apparent.
            Thread.Sleep(3000);
            Console.WriteLine("The instance method called by the worker 쓰레드 끝");
        }

        public static void StaticMethod()
        {
            Console.WriteLine("ServerClass.StaticMethod 다른 쓰레드에서 실행 중");

            // Pause for a moment to provide a delay to make threads more apparent
            Thread.Sleep(5000);
            Console.WriteLine(
            "The static method called by the worker thread 쓰레드 끝");
        }
    }

    public class Simple
    {
        public static void Main()
        {
            ServerClass serverObject = new ServerClass();

            // Create the thread object, passing in the
            // serverObject.InstanceMethod method using a
            // ThreadStart delegate.
            Thread InstanceCaller = new Thread(new ThreadStart(serverObject.InstanceMethod));

            // Start the Thread
            InstanceCaller.Start();

            Console.WriteLine("The Main() thread this after " + "starting the new InstanceCaller thread.");

            // Create the thread object, passing in the
            // serverObject.StaticMethod method using a
            // ThreadStart delegate.
            Thread StaticCaller = new Thread(
                new ThreadStart(ServerClass.StaticMethod));

            // Start the thread.
            StaticCaller.Start();

            Console.WriteLine("The Main() thread calls this after "
                + "starting the new StaticCaller thread.");
        }
    }
}
