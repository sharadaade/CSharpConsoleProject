using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.InterviewQ
{
    internal class MultiplicationWithoutStar
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number : ");
            int num1 = Convert.ToInt32(Console.ReadLine()); // 2

            Console.Write("Enter second number : ");
            int num2 = Convert.ToInt32(Console.ReadLine()); // 3 6
            int mul = 0;
            for(int i = 0; i < num1; i++)
            {
                mul = mul + num2; // 3, 
            }
        }
    }
}
