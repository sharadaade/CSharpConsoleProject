using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CSharpConsole.CodeWin
{
    internal class ReverseEachWord
    {
        static void Main(string[] args)
        {


            //Algorithm Steps:

            //Start

            //Input the sentence(a string).

            //Split the sentence into a list/ array of words using space (' ') as a separator.

            //Initialize an empty string result.

            //Repeat for each word in the list:

            //Initialize an empty string reversedWord.

            //Loop from the last character of the word to the first:

            //Add each character to reversedWord.

            //Add reversedWord and a space to result.

            //Trim any extra space at the end of result.

            //Output the result string.

            //End

            string sentence = "I love coding";
            string[] words = sentence.Split(' ');
            string result = "";

            foreach (string word in words)
            {
                string reversedWord = "";
                for (int i = word.Length - 1; i >= 0; i--)
                {
                    reversedWord += word[i];
                }
                result += reversedWord + " ";
            }

            Console.WriteLine(result.Trim()); // Output: I evol gnidoc
        }
    }
}
