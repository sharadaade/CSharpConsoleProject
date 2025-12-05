using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CollectionsAll
{
    internal class GenericMethod
    {
        public bool Compare<T>(T a, T b)
        {
            if (a.Equals(b))
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            GenericMethod d = new GenericMethod();
            bool result = d.Compare<double>(21, 22);
            Console.WriteLine(result);

            bool reString = d.Compare<string>("Sharad", "Sharad");
            Console.WriteLine(reString);
        }
    }
}
