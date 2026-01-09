using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class Leet1
    {
        static void Main(string[] args)
        {

            
            int s = 1;

            Console.Write("Enter the num : ");
            int n = Convert.ToInt32(Console.ReadLine());

            if(n < 9)
            {
                Console.Write(n);
                return;
            }
        top:
            int sum = 0;
            while (n != 0)
            {
                int rem = n % 10;
                s = rem * rem;
                sum = sum + s;
                n = n / 10;
            }

            Console.Write(sum + " ");

            n = sum;

            if(sum < 10)
            {
                return;
            }
            goto top;

        }
    }
}
