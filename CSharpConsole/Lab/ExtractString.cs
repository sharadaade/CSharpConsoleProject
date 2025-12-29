using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class ExtractString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string ");
            string str = Console.ReadLine();

            Console.WriteLine(str.Substring(0, 3));
            // NOTE => 3 the the excluded means it is not shown in the output
        }
    }
}
