using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class CallByRef
    {
        public static void CallbyReference(ref int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int x = 5;
            CallbyReference(ref x);
            Console.WriteLine(x);
        }
    }
}
