using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class SearchString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();

            Console.Write("Enter the search string : ");
            string strSearch = Console.ReadLine();

            if(str.Contains(strSearch))
            {
                Console.WriteLine($"{strSearch} is found");
            }
            else
            {
                Console.WriteLine("String is not found");
            }
        }
    }
}
