using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class TemperatureConversion
    {
        static void Main(string[] args)
        {
            double f;
            double c;
            string? ch = null;
            int sch;
            do
            {

                Console.WriteLine("1.Convert Farenhite to Celsius \n2.Celsious to Convert");
                Console.Write("Select the choice : ");
                if (!int.TryParse(Console.ReadLine(), out sch))
                {
                    Console.WriteLine("Invalid input! Please enter 1 or 2.");
                    continue;
                }

                switch (sch)
                {
                    case 1:
                        Console.Write("Enter the fahrenheit : ");
                        f = Convert.ToDouble(Console.ReadLine());
                        c = (f-32)*(5.0/9.0);
                        Console.WriteLine($"{c}");
                        break;

                    case 2:
                        Console.Write("Enter the celcsious : ");
                        c = Convert.ToDouble(Console.ReadLine());
                        f = c*(9/5)+32;
                        Console.WriteLine($"{f}");
                        break;

                    default:
                        Console.WriteLine("Enter valid input!");
                        break;
                }
                
                Console.Write("Do you want continue (y/N) : ");
                ch = Console.ReadLine();

            } while (ch == "y" || ch == "Y");
        }
    }
}
