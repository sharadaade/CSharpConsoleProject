using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class Pattern5
    {
        static void Main(string[] args)
        {
            //for(int i = 1; i <= 5; i++)
            //{
            //    int n = 1;
            //    for(int j = 5; j >= i; j--)
            //    {
            //        Console.Write($"{n} ");
            //        n++;
            //    }
            //    Console.WriteLine();
            //}

            int n = 5;
            for(int i = n; i >= 1; i--)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
