using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class ConstVsReadOnly
    {
        // ====================== Const =====================
        // Const is compiled time constant 
        // Declaration and initialization at the same time
        // Can not be changed
        public  const int cmToMeter = 100;


        // ====================== Readonnly ====================
        // Readonly is runtime constant
        // Decalaration and initialization not mandatory in same time we can intialise later on
        // We can change the value

        //public static readonly double PI = 3.1;
        public static readonly double PI;

        static ConstVsReadOnly()
        {
            PI = 3.14;
        }
        static void Main(string[] args)
        {
            //cmToMeter = 101; // Invalid
            //PI = 3.14 // Invalid
        }
    }
}
