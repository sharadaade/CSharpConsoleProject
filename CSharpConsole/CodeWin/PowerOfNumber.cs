using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class PowerOfNumber
    {
        static void Main(string[] args)
        {
            int result = 1;
            Console.Write("Enter number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter power : ");
            int p = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= p; i++)
            {
                result = result * n;
            }

            Console.WriteLine("Result is : " + result);

        }
    }
}
