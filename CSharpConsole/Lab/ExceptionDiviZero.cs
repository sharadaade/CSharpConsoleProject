using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class ExceptionDiviZero
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the numerator : ");
                int numerator = int.Parse(Console.ReadLine());

                Console.Write("Enter the denominator : ");
                int denoninator = int.Parse(Console.ReadLine());

                int result = numerator / denoninator;

                Console.WriteLine("Result is : " + result);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program execution end.");
            }
            
        }
    }
}
