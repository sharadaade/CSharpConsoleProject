using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class TryParsing
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("Enter the number : ");
            if(int.TryParse(Console.ReadLine(),out num))
            {
                Console.WriteLine($"Your number is {num}");
            }
            else
            {
                Console.WriteLine("Enter the valid number");
            }
        }
    }
}
