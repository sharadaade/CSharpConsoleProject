using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CollectionsAll
{
    internal class StackDemo
    {
        static void Main(string[] args)
        {
            // =========== Stack ============
            // Stack works
            // FILO => First In Last Out
            // LIFI => Last In First Out
            // Initial capacity of Stack is 10
            // It grows double 10, 20, 40,..
            // We can also specify initial capacity
            // There is no method to check capacity

            //============================================
            // Common methods => .Push(), .Pop(), .Peek()
            // Common property => .Count
            //============================================
            Stack st = new Stack(6);
            //Console.WriteLine(st.Count);

            // Push() => It Add the object at the top in stack
            
            st.Push(100);
            st.Push(200);
            st.Push(300);
            st.Push(400);
            st.Push(500);
            st.Push(600);
            st.Push(700);

            // Count => property
            // Count property gets the number of elemetn contains in stack
            //Console.WriteLine(st.Count);

            // Pop() method removes the top most object from stack
            //st.Pop();

            foreach (object i in st)
            {
                Console.Write($"{i} ");
            }

            // Peek() => It return Top most object from stack without removing
            //Console.WriteLine(st.Peek());


            Console.WriteLine();
            Stack sss = new Stack();
            st.Push(10);

            
        }
    }
}
