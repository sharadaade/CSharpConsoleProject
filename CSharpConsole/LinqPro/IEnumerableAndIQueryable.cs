using System.Collections;

namespace CSharpConsole.LinqPro
{
    //IEnumerable<Student> MaleStudent = from obj in StudentList where obj.Gender == "Male" select obj;
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
    internal class IEnumerableAndIQueryable
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


            IEnumerable<Student> FemaleStudent = from obj in StudentList
                                                 where obj.Gender == "Female"
                                                 select obj;

            foreach(var stu in FemaleStudent)
            {
                Console.WriteLine($"Id: {stu.Id} Name: {stu.Name} Gender: {stu.Gender}");
            }

            //foreach(var stu in MaleStudent)
            //{
            //    Console.WriteLine($"Id: {stu.Id} Name: {stu.Name} Gender: {stu.Gender}");
            //}
        }
    }
}
