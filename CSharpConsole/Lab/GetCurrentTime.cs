using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
    internal class GetCurrentTime
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Get Current Date and Time");
            DateTime curretDataTime = DateTime.Now;
            Console.WriteLine(curretDataTime);
        }
    }
}
