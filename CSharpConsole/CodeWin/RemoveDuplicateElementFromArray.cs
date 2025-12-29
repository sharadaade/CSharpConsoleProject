using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CodeWin
{
    internal class RemoveDuplicateElementFromArray
    {
        static void Main(string[] args)
        {
            int[] ar = { 1, 2, 4, 2, 6, 5 };

            for(int i = 0; i < ar.Length; i++)
            {
                int count = 1;

                for(int j = i + 1; j < ar.Length; j++)
                {
                    if (ar[i] == ar[j])
                    {
                        count++;
                    }
                }
                
                if(count == 1)
                {
                    Console.Write($"{ar[i]} ");
                }
            }

        }
    }
}
