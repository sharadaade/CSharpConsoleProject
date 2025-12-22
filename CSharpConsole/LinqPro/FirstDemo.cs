using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.LinqPro
{
    internal class FirstDemo
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 66, 44, 55, 88, 11, 22, 33, 44, 65, 78, 43, 64, 88 };
            var greateThan40 = (from i in list where i > 40 orderby i select i);

            var greaterThan40Sum = (from obj in list where obj > 40 select obj).Sum();

            Console.Write("Greater than 40 : ");
            foreach (var i in greateThan40)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\nGreater than 40 Sum is " + greaterThan40Sum);

        }
    }
}
