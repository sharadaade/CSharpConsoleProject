using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.InterviewQ
{
    internal class RemoveDuplicateArray
    {
        static void Main(string[] args)
        {
            int[] ar = { 10, 10, 20, 30 };
            HashSet<int> h = new HashSet<int>();

            for(int i = 0; i < ar.Length; i++)
            {
                h.Add(ar[i]);
            }

            foreach(int i in h)
            {
                Console.Write(i + " ");
            }
        }
    }
}
