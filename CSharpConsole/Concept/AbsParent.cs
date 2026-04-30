using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal abstract class AbsParent
    {
        public void Add(int x, int y)
        {
            Console.WriteLine(x + y);
        }
        public void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }
        public abstract void Mul(int a, int b);
        public abstract void Div(int a, int b);
    }
    internal class AbsChild : AbsParent
    {
        public override void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        public override void Mul(int a, int b)
        {
            Console.WriteLine(a + b);
        }

        public static void Main()
        {
            AbsChild ob = new AbsChild();
            ob.Add(1, 2);
            ob.Sub(5, 2);
            ob.Mul(3, 4);
            ob.Div(10, 2);
        }
    }
}
