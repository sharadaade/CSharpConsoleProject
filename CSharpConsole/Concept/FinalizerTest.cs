namespace CSharpConsole.Concept
{
    internal class FinalizerTest
    {
        internal class Test
        {
            public Test()
            {
                Console.WriteLine("Constructor Called");
            }
            ~Test()
            {
                Console.WriteLine("Finalizer Called");
            }
        }
        static void Main(string[] args)
        {
            CreateObjects();
                
            GC.Collect();
            GC.WaitForPendingFinalizers();
            Console.ReadLine();
        }
        static void CreateObjects()
        {
            Test t = new Test();
            Test t1 = new Test();
            Test t2 = new Test();
        }
    }
}
