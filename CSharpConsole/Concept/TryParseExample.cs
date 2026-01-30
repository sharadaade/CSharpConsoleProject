using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class TryParseExample
    {
        static void Main(string[] args)
        {
            bool success = int.TryParse("123", out int result);
            Console.WriteLine(success);
            Console.WriteLine(result.GetType());

        }
    }
}
