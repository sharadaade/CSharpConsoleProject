using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class TupleConcept
    {
        static void Main(string[] args)
        {
            // In C#, a tuple is a data structure that allows you to store multiple values
            // of different types in a single object — without having to create a separate
            // class or struct.

            //var details = ("Sharad", 21, "CS", "Partner");
            //Console.WriteLine(details.Item1);
            //Console.WriteLine(details.Item2);
            //Console.WriteLine(details.Item3);
            //Console.WriteLine(details.Item4);

            var data = ("One", "Two", 99, true);
            Console.WriteLine(data.Item1);
            Console.WriteLine(data.Item4);
        }
    }
}
