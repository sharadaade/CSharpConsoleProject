using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.InterviewQ
{
    internal class CountWordAndCharacterInString
    {
        static void Main(string[] args)
        {
            int count = 0;
            string s = "Welcome to Hyderabad";
            char[] ca = s.ToCharArray();
            string[] ar = s.Split(" ");
            Console.WriteLine($"Word in string {ar.Length}");

            foreach(char i in ca)
            {
                if (i != ' ')
                {
                    count++;
                }
            }
            Console.WriteLine($"Character count without space in string {count}");
        }
    }
}
