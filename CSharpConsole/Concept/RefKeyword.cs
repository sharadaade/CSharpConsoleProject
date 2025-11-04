using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class RefKeyword
    {
        //With ref
        static void Increase(ref int number)
        {
            number = number + 10;
        }

        // Without ref
        static void Increase(int num)
        {
            num = num + 10;
        }
        static void Main()
        {
            //With ref call 
            int value = 5;
            Increase(ref value);
            Console.WriteLine(value);


            // Without ref call
            int val = 5;
            Increase(value);
            Console.WriteLine(value); // Output: 5
        }

        

        
    }
}
