using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CollectionsAll
{
    internal class CollectionsOne
    {
        static void Main(string[] args)
        {
            char c = 'M';
            Console.WriteLine(sizeof(char));
            // ==== Static size ==============
            int[] ar = new int[10];
            //Console.WriteLine(ar.Length);

            // Old item is cpoied from old array and new array is created
            // Later on old array is destroyed by GC(Garbage collector)
            Array.Resize(ref ar, 20);
            //Console.WriteLine(ar.Length);

            // ============ Variable length ==============
            // Auto Resize => 0, 4, 8, 16, 32, 64, 128, ...
            ArrayList al = new ArrayList();
            Console.WriteLine(al.Capacity);
            al.Add(100);
            al.Add(200);
            al.Add(300);
            al.Add(400);
            al.Add(150);
            al.Add(500);
            al.Add(600);

            Console.WriteLine(al.Capacity);

            foreach (object item in al)
            {
                // String Interpolation
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            // Insert item at specific index
            al.Insert(1, 150);

            // NOTE => Remove the first occurence of element from ArrayList
            // Rmove element which you want pass as parameter
            al.Remove(150);
            
            // Remove element from specific index
            //al.RemoveAt(6);
            foreach(object item in al)
            {
                // String Interpolation
                Console.Write($"{item} ");
            }
        }
    }
}
