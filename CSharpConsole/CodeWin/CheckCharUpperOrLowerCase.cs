using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class CheckCharUpperOrLowerCase
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the character : ");
            char c = Convert.ToChar(Console.ReadLine());
            if (c >= 'A' && c <= 'Z')
            {
                Console.WriteLine("Uppercase");
            }
            else if(c >= 'a' && c <= 'z')
            {
                Console.WriteLine("Lowercase");
            }
            else
            {
                Console.WriteLine("Not a alphabate");
            }
        }
    }
}
