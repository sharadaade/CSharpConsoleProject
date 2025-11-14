using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    public abstract class TypeCasting
    {
        public abstract void Sum(int a, int b);

        public void sub(int c, int d)
        {
            int a = c - d;
            Console.WriteLine("Sub is: " + a);
        }
    }


    public class Casting : TypeCasting
    {
        public override void Sum(int a, int b)
        {
            int c = a + b;
            Console.WriteLine("Sum is: " + c);
        }

        static void Main()
        {
            Casting ca = new Casting();
            ca.Sum(2, 3);

            Console.ReadLine();
        }

        
    }
}
