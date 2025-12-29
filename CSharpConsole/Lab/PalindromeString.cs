using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class PalindromeString
    {
        static void Main(string[] args)
        {
            bool isPalindrome = true;
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();

            str = str.ToLower();

            int left = 0;
            int right = str.Length - 1;

            while (str[left] != str[right])
            {
                isPalindrome = false;
                break;
            }

            if(isPalindrome)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is Not Palindrome");
            }
        }
    }
}
