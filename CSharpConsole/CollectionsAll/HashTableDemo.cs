using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.CollectionsAll
{
    internal class HashTableDemo
    {
        static void Main(string[] args)
        {
            // Before going to Hashtable disscuss the problem with Array and ArrayList
            // Array and ArrayList have predefinde key measns index(0, 1, 2, 3, 4, ....)
            // We can't change 
            // But storing the User details is ok but accessing the details is very problematic
            // We need to remember 0 for Id, 1 for Name, 2 for Address, 3 for Job and so on...

            // This problem is solved by Hashtable
            // Array and ArrayList is we can use for other purpose 

            // Let's go => Hashtable

            Hashtable ht = new Hashtable();
            ht.Add("Id", 1001);
            ht.Add("Name", "Sharad");
            ht.Add("Job", ".NET Developer");
            ht.Add("Salary", 250000);
            ht.Add("Phone", 7218002500);
            ht.Add("Email", "aadesharad@gmail.com");
            ht.Add("Location", "MH");

            //Console.WriteLine(ht["Name"]);
            //Console.WriteLine(ht["Job"]);
            //Console.WriteLine(ht["Email"]);

            // Get all the keys    ****
            foreach(object x in ht.Keys)
            {
                Console.WriteLine(x);
            }

            // Note => It not shows in sequential order as we store
            // Because internal Hashtable create hashcode(int) for every key's based on that it shows
            // Hastable contains three things => 1.Key 2.Value 3.Hashcode


            Console.WriteLine();
            


            // Sample to check the hashcode
            //Console.WriteLine("Hello".GetHashCode());

        }
    }
}
