using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CollectionsAll
{
    internal class QueueDemo
    {
        static void Main(string[] args)
        {
            // ================= Queue ==================
            // 
            Queue q = new Queue(10);
            Console.WriteLine(q.Count);
            q.Enqueue(10);
            q.Enqueue(20);
            q.Enqueue(30);
            q.Enqueue(40);
            Console.WriteLine(q.Dequeue());
            Console.WriteLine(q.Count);
        }
    }
}
