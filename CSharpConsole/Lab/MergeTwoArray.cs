using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class MergeTwoArray
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first array size : ");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[] ar1 = new int[size1];

            Console.Write("Enter the element in array1 ");
            for(int i = 0; i < size1; i++)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                ar1[i] = temp;
            }

            Console.Write("Enter the first array size : ");
            int size2 = Convert.ToInt32(Console.ReadLine());
            int[] ar2 = new int[size2];

            Console.Write("Enter the element in array2 ");
            for (int i = 0; i < size2; i++)
            {
                int temp = Convert.ToInt32(Console.ReadLine());
                ar2[i] = temp;
            }

            int[] ar3 = new int[size1 + size2];

            for(int i = 0; i < ar1.Length; i++)
            {
                ar3[i] = ar1[i];
            }
            for(int i = 0; i < ar2.Length; i++)
            {
                ar3[size1 + i] = ar2[i];
            }

            Console.WriteLine("First array elements: ");
            foreach(int i in ar1)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("Second array elements: ");
            foreach (int i in ar2)
            {
                Console.WriteLine(i + " ");
            }

            Console.WriteLine("Third array elements: ");
            foreach (int i in ar3)
            {
                Console.WriteLine(i + " ");
            }

        }
    }
}
