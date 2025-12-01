namespace CSharpConsole.Threading
{
    internal class ThreadingDemo1
    {
        static void Test1()
        {
            for (int i = 0; i < 100; i++)
            {
                if(i==50)
                {
                    Thread.Sleep(5000);
                }    
                Console.WriteLine("Test1 " + i);
            }
        }
        static void Test2()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test2 " + i);
            }
        }
        static void Test3()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Test3 " + i);
            }
        }
        static void Main(string[] args)
        {
            //Thread t = Thread.CurrentThread;
            //t.Name = "My Thread";
            //Console.WriteLine(Thread.CurrentThread.Name);

            Test1();
            Test2();
            Test3();
        }
    }
}
