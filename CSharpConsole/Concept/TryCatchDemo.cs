using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class TryCatchDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st Number : ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd Number : ");
                int y = int.Parse(Console.ReadLine());
            }
            catch(DivideByZeroException)
            {
                Console.WriteLine("Divisor value should not be zero");
            }
            catch(FormatException)
            {
                Console.WriteLine("Input value must be number");
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Ende of the Program");
        }
    }
}
