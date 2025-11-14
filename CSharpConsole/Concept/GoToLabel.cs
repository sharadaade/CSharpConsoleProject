using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class GoToLabel
    {
        static void Main(string[] args)
        {
            Console.WriteLine("First statement");

            goto Label;

            Console.WriteLine("Second statement");

        Label:
            Console.WriteLine("Labeled statement");
        }
    }
}
