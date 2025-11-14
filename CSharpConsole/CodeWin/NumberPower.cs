using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class NumberPower
    {
        static void Main(string[] args)
        {
            int result = 1;

            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the power : ");
            int pow = Convert.ToInt32(Console.ReadLine());

            int i = 1;

            while(i <= pow)
            {
                result = result * num;
                i++;
            }
            Console.WriteLine($"Powewr is {result}");
        }
    }
}
