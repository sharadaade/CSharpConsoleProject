using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class SampleInput
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"This is your number {num}");
        }
    }
}
