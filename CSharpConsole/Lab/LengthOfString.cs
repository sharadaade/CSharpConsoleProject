using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class LengthOfString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string to calculate length : ");
            string str = Console.ReadLine();

            if(str.Length > 0)
            {
                Console.WriteLine(str.Length);
                // Length counting start from 1 ....
                // Index counting start from 0 ...
            }
            else
            {
                Console.WriteLine("Please enter the string");
            }
        }
    }
}
