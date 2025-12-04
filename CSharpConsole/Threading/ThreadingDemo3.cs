using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CSharpConsole.Threading
{
    internal class ThreadingDemo3
    {
        //static void Test()
        //{
        //    for(int i = 0; i < 100; i++)
        //    {
        //        Console.WriteLine("Test " + i);
        //    }
        //}

        static void Test(object max)
        {
            int num = Convert.ToInt32(max);
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Test " + i);
            }
        }
        static void Main(string[] args)
        {
            //ThreadStart ts = new ThreadStart(Test);
            //Thread th = new Thread(Test);
            //th.Start();

            //ThreadStart obj = () => Test();
            //Thread t = new Thread(obj);
            //t.Start();

            ParameterizedThreadStart tsObj = new ParameterizedThreadStart(Test);
            Thread t = new Thread(tsObj);
            t.Start("Hello");

        }
    }
}
