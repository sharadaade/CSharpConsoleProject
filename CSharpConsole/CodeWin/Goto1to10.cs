using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class Goto1to10
    {
        static void Main(string[] args)
        {
            int i = 1;
        Label:
            Console.WriteLine(i);
            i++;
            if(i <= 10)
            {
                goto Label;
            }
        }
    }
}
