using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class CountWordInSentance
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the sentance : ");
            string sentance = Console.ReadLine();

            string[] words =  sentance.Split(" ");

            int wordCount = words.Length;
            Console.WriteLine("Word count in sentance " + wordCount);
         
        }
    }
}
