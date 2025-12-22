using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class NullReferenceExcep
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter the name : ");
                string name = Console.ReadLine();
                Console.WriteLine("Your name is " + name);
                Console.WriteLine("Length of " + name + " " + name.Length);
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
