using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    public  class ClassCheck
    {
        public static void Method1()
        {
            Console.WriteLine("From Static class");
        }
    }
    internal class StaticBlock
    {
        static void Main(string[] args)
        {
            Console.WriteLine("From mian method");
            ClassCheck.Method1();
        }
    }
}
