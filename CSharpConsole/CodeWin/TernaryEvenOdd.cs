using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class TernaryEvenOdd
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());

            string result = (n % 2 == 0) ? "Even" : "Odd";
            Console.WriteLine($"Number is {result}");
        }
    }
}
