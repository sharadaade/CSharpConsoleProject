using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class FindDuplicateCharacterInString
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string : ");
            string str = Console.ReadLine();

            for(int i = 0; i < str.Length; i++)
            {
                int count = 1;
                for(int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        count++;
                    }
                }

            }
        }
    }
}
