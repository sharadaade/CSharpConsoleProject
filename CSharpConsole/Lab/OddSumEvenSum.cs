using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
 //   2)Write a C# Program to print EvenSum and OddSum of numbers from 1 to n?
 //     Create the following fields n, EvenSum, OddSum
 //     Write the logic to Print EvenSum and OddSum by using Iterations(Loops)
    internal class OddSumEvenSum
    {
        static void Main(string[] args)
        {
            int EvenSum = 0;
            int OddSum = 0;
            Console.Write("Enter the number : ");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                if (i % 2 == 0)
                    EvenSum = EvenSum + i;
                else
                    OddSum = OddSum + i;
            }

            Console.WriteLine($"Odd Sum is {EvenSum}");
            Console.WriteLine($"Odd Sum is {OddSum}");
        }
    }
}
