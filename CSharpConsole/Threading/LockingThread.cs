using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CSharpConsole.Threading
{
    internal class LockingThread
    {
        public void Display()
        {
            // lock is allow only one thread can access code at a time
            // Other thread will wait untile execution completion
            lock(this)
            {
                Console.Write("C# is an - ");
                Thread.Sleep(5000);
                Console.WriteLine("Object oriented programming language.");
            }

        }
        static void Main(string[] args)
        {
            LockingThread obj = new LockingThread();

            Thread t1 = new Thread(obj.Display);
            Thread t2 = new Thread(obj.Display);
            Thread t3 = new Thread(obj.Display);

            t1.Start();
            t2.Start();
            t3.Start();
        }
    }
}
