using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class JaggedInputOutput
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the row number : ");
            int r = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[r][];

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                Console.Write("Entere the col size : ");
                int c = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[c];

                for (int j = 0; j < c; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
