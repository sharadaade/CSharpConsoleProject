using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
//    1)Write a C# Program to Find number of digits from a given number?
//      Create the following fields num, Count
//      Write the logic to find count of digits by using while loop
    internal class NoOfDigitInNumber
    {
        static int num;
        static void Main(string[] args)
        {
            int count = 0;
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            if(num == 0)
            {
                Console.WriteLine("Above number contains 1 digits");
                return;
            }

            while (num!=0)
            {
                count++;
                num = num / 10;
            }
            Console.WriteLine($"Above number contains {count} digits");
        }
    }
}
