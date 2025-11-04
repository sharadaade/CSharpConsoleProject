using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class Pattern5Hollow
    {
        static void Main(string[] args)
        {
            int r = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= r; i++)
            {
                for(int j = 1; j <= c; j++)
                {
                    if (i == 1 || i == r || j == 1 || j == c)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
