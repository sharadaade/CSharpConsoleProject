using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class OutKeyword
    {
        static void Divide(int dividend, int divisor, out int quotient, out int remainder)
        {
            quotient = dividend / divisor;
            remainder = dividend % divisor;
        }
        static void Main(string[] args)
        {
            int q, r;
            Divide(10, 3, out q, out r);

            //Console.WriteLine($"Quotient: {q}, Remainder: {r}");


            //Another example of out keyword
            /*
            
            if (int.TryParse("123", out int number))
            {
                Console.WriteLine($"Parsed successfully: {number}");
            }
            else
            {
                Console.WriteLine("Parsing failed.");
            }

            */


            var result = int.TryParse("HQ", out int num);
            Console.WriteLine(result);
            Console.WriteLine(num);

            // If TryParse method converets into int then it return True and that value is in num
            // If TryParse method does't converets into int then it return False and inside the mun is 0(zero)

        }
    }
}
