using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class FormateExcep
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the first number  : ");
                int n1 = int.Parse(Console.ReadLine());

                Console.Write("Enter the second number : ");
                int n2 = int.Parse(Console.ReadLine());

            }
            catch(FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Program end.");
            }
        }
    }
}
