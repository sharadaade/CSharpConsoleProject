using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Lab
{
  //  3)Write a c# program create a class student containing [sid,sname,marks] take input from the user
  //    and print the values and also 
  //    ask the user to write "y/N" to enter the input again and build the logic to take input values again?
  //    Create the following fields Sid, Sname, Marks, choice
  //    write the logic to take multiple requests from User by using do-while?

    class Student 
    {
        public int sid { get; set; }
        public string sname { get; set; }
        public int? marks { get; set; }
    }
    internal class InputAgain
    {
        static void Main(string[] args)
        {
            char choice;
            Student st = new Student();
           
            do
            {
                Console.Write("Enter the student ID : ");
                st.sid = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the student name : ");
                st.sname = Console.ReadLine();

                Console.Write("Enter the student marks : ");
                st.marks = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("==== Student Detais =====");
                Console.WriteLine($"Student ID {st.sid}");
                Console.WriteLine($"Student name {st.sname}");
                Console.WriteLine($"Student marks {st.marks}");

                Console.Write("Do you want to continue(y/N) : ");
                choice = Convert.ToChar(Console.ReadLine());

            }
            while(choice == 'y' || choice == 'Y');
            Console.WriteLine("Student enrollment is completed!!");
        }
    }
}
