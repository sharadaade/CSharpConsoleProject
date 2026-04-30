using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    public delegate string WishDelegate(string name);
    internal class AnonymousMethod
    {
        static void Main(string[] args)
        {
            WishDelegate obj = delegate (string name)
            {
                return $"Hey {name}";
            };
            Console.WriteLine(obj("Sharad"));
        }
    }
}
