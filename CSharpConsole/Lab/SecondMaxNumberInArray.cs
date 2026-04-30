using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class SecondMaxNumberInArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 25, 8, 40, 15 };

            int max = int.MinValue;
            int secondMax = int.MinValue;
            foreach (int num in arr)
            {
                if (num > max)
                {
                    secondMax = max;
                    max = num;
                }
                else if (num > secondMax && num != max)
                {
                    secondMax = num;
                }
            }
            Console.WriteLine("Second Maximum: " + secondMax);
        }
    }
}
