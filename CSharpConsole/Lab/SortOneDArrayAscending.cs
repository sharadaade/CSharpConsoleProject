using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class SortOneDArrayAscending
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of array : ");
            int size = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            int[] ar = new int[size];

            for(int i = 0; i < size; i++)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                ar[i] = temp;
            }


            // Selection Sort–like algorithm
            for (int i = 0; i < ar.Length; i++)
            {
                for(int j = i + 1; j < ar.Length; j++)
                {
                    count = count + 1;
                    if (ar[i] > ar[j])
                    {
                        int temp = ar[i];
                        ar[i] = ar[j];
                        ar[j] = temp;
                    }
                }
            }

            Console.WriteLine("After sorting array : ");
            foreach (int i in ar)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
            Console.WriteLine("The Loop iterates :" + count);
        }
    }
}
