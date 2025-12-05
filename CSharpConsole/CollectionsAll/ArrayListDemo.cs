using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CollectionsAll
{
    internal class ArrayListDemo
    {
        static void Main(string[] args)
        {
            // ===========  ArrayList =============
            // 
            ArrayList a = new ArrayList(20);
            a.Add(100);
            a.Add(200);
            a.Add(300);
            a.Add(400);
            a.Add(500);
            a.Add(100);
            a.Add(200);
            a.Add(300);
            a.Add(400);
            a.Add(500);
            a.Add(100);
            a.Add(200);
            a.Add(300);
            a.Add(400);
            a.Add(500);
            a.Add(100);
            a.Add(200);
            a.Add(300);
            a.Add(400);
            a.Add(500);
            a.Add(900);
            Console.WriteLine(a.Capacity);
        }
    }
}
