using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{

    public delegate void Greet(string str);

    internal class One
    {
        public void SayHello(string str)
        {
            Console.WriteLine($"Hello {str}");
        }
        public void SayNamaste(string str)
        {
            Console.WriteLine($"Namaste {str}");
        }
        public void SayHola(string str)
        {
            Console.WriteLine($"Hola {str}");
        }
    }
    internal class DelegateDemo
    {
        static void Main(string[] args)
        {
            //NOTE:- For Multicast Delegate return type must be ** void ** type of delegate and method
            One o = new One();
            Greet g = o.SayHello;
            g += o.SayNamaste;
            g += o.SayHola;

            //g -= o.SayHello;

            g("Sharad");
        }
    }
    
}
