using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    public class Person
    {
        public int Id;
        public string Name;
        public int Age;

        public Person()
        {
            this.Id = 0;
            this.Name = "Unknown";
            this.Age = 0;
            Console.WriteLine($"ID : {this.Id} \nName : {this.Name} \nAge : {this.Age}");
        }

    }
    internal class DefaultConstructor
    {
        static void Main(string[] args)
        {
            Person p = new Person();
        }
    }
}
