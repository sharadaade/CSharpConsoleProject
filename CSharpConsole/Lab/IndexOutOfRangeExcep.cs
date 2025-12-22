using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class IndexOutOfRangeExcep
    {
        static void Main(string[] args)
        {
            int[] ar =
            {
                11, 22, 33, 44, 55
            };

            try
            {
                Console.Write("Enter the index of arry to access element : ");
                int i = int.Parse(Console.ReadLine());
                Console.WriteLine(ar[i]);
            }
            catch(IndexOutOfRangeException e)
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
