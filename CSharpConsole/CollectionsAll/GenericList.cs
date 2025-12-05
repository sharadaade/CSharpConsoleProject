using System.Collections.Generic;
namespace CSharpConsole.CollectionsAll
{
    public class Person
    {
        public int id { get; set; }
        public string Name { set; get; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    internal class GenericList
    {
        static void Main(string[] args)
        {
            // ===================== List ==========================
            // List is generic collection which is used to store similar type of data
            // List are present in System.Collections.Generic
            // 
            List<int> l = new List<int>();

            List<string> s = new List<string>();

            List<Person> p = new List<Person>();

            l.Add(1);
            l.Add(22);
            l.Add(43);
            l.Add(4);
            //l.Add(52);
            l.Remove(11);
            l.Sort();
            var newArr = l.ToArray();
            Array.Sort(newArr);
            foreach(var i in newArr)
            {
                Console.Write($"{i} ");
            }

            //Console.WriteLine(l.Sum());
            //foreach(int item in l)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.Write(l.Capacity);

            s.Add("Mango");
            s.Add("Banana");
            s.Add("Pineapple");
            //Console.WriteLine(s.Capacity);
        }
    }
}
