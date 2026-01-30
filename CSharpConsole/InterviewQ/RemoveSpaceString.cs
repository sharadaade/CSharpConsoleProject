using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.InterviewQ
{
    internal class RemoveSpaceString
    {
        static void Main(string[] args)
        {
            string str = "Naresh It Technology";
            StringBuilder st = new StringBuilder();

            // Way - 1
            //string[] ar = str.Split(" ");
            //for (int i = 0; i < ar.Length; i++)
            //{
            //    st.Append(ar[i]);
            //}

            //Console.WriteLine(st);

            // =========================
            // Way - 2

            foreach(char c in str)
            {
                if(c == ' ')
                {
                    continue;
                }
                st.Append(c);
            }
            Console.WriteLine(st);
        }
    }
}
