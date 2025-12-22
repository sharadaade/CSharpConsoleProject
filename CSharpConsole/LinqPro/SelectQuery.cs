using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.LinqPro
{
    internal class SelectQuery
    {
        static void Main(string[] args)
        {
            List<Student> StudentList = new List<Student>()
            {
                new Student {Id = 111, Name = "Sharad", Gender = "Male"},
                new Student {Id = 222, Name = "Sahana", Gender = "Female"},
                new Student {Id = 333, Name = "Jack", Gender = "Male"},
                new Student {Id = 444, Name = "Rock", Gender = "Male"},
                new Student {Id = 555, Name = "Sonal", Gender = "Female"}
            };
        }
    }
}
