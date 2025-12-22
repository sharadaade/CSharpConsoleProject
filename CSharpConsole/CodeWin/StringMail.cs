using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsProject
{
    internal class StringMail
    {
        static void Main(string[] args)
        {
            List<string> st = new List<string>();
            st.Add("ZZZZAade@gmail.com");
            st.Add("nnhhiuhhAade@gmail.com");
            st.Add("ghjgjhgjhAade@gmail.com");
            st.Add("Aade@gmail.com");
            st.Add("ghagdhjadAade@gmail.com");
            st.Add("jhkahkdaAade@gmail.com");
            st.Add("Aade@gmail.com");
            st.Add("Aade@gmail.com");
            st.Add("7218002575");
            st.Add("7218002599");
            st.Add("7218002595");
            st.Add("7218007533");

            ArrayList al = new ArrayList();

            foreach (string item in st)
            {
                if (item.Contains("@gmail.com"))
                {
                    int index = item.IndexOf("@");
                    string First2 = item.Substring(0, 2);
                    string hidden = new string('*', index - 2);
                    string domain = item.Substring(index - 2);
                    al.Add(First2 + hidden + domain);
                }
                else
                {
                    string endstring = item.Substring(6);
                    string hidden = "******";
                    al.Add(hidden + endstring);
                }
            }

            foreach (var item in al)
            {
                Console.WriteLine(item);
            }
        }
    }
}

