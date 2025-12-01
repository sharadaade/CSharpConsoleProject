using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    public class A
    {
        public void M1()
        {
            Console.WriteLine("Parent Method");
        }
    }

    public class B : A
    {
        public void M1()
        {
            Console.WriteLine("Child Method");
        }
    }
    internal class MethodHidding
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.M1();
        }
        
    }
}
