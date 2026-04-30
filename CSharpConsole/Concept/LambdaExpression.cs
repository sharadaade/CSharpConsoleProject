using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    public delegate string WishDele(string name);
    public delegate int AddDelegate(int a, int b);
    internal class LambdaExpression
    {
        static void Main(string[] args)
        {
            WishDele obj = name =>
            {
                return $"OMG {name}";
            };

            Console.WriteLine(obj("Sharad"));

            AddDelegate add = (a, b) =>
            {
                return a + b;
            };

            Console.WriteLine(add(5, 3));

            Console.ReadLine(); 
        }
    }
}
