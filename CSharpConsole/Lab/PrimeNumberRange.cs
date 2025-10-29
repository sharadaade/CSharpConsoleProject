using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
 //   4)Write a C# Program to print the Range of PrimNumbers?
 //     Create the following fields num
 //     write a logic inside the loop to check the number is prime or not 
 //     if the number is prime print the number
    internal class PrimeNumberRange
    {
        static void Main(string[] args)
        {
            int n;
            
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int count = 0;

                for (int j = 1; j <= i; j++)
                {
                    if(i%j==0)
                    {
                        count++;
                    }
                }
                if (count == 2)
                {
                    Console.Write($"{i} ");
                }
            }


            //for (int i = 1; i <= n; i++)
            //{

            //    for (int j = 2; j <= (i / 2); i++)
            //    {

            //    }
            //}
        }
    }
}
