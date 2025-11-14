using CSharpConsole.Lab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class DayConversion
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Eneter the total days : ");
            int total = Convert.ToInt32(Console.ReadLine());

            int y = total / 365;
            int m = (total % 365) / 30;
            int w = ((total % 365) % 30 ) / 7;
            int d = ((total % 365) % 30) % 7;

            Console.WriteLine("Year " + y);
            Console.WriteLine("Months " + m);
            Console.WriteLine("Week days "+ w);
            Console.WriteLine("Days "+ d);

        }
    }
}
