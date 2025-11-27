using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.OOPS
{
    public abstract class EmpPerson
    {
        public string conmpanyName;
        public string employeeName;
        public double salary;

        public EmpPerson(string _conmapanyName, string _employeeName, double _salary)
        {
            this.conmpanyName = _conmapanyName;
            this.employeeName = _employeeName;
            this.salary = _salary;
        }
        public abstract String Details();
        public abstract double CalculateBonus();

    }
    public class Manager : EmpPerson
    {
      //  public double sal;
        public double bon;

        public Manager(string _conmapanyName, string _employeeName, double _salary) : 
            base(_conmapanyName, _employeeName, _salary)
        {

        }
       
        public override double CalculateBonus()
        {
            bon = salary*0.10;
            return bon;
        }

        public override string Details()
        {
            return $"Comany Name = {conmpanyName} \nEmployee Name = {employeeName} \nBonus = {bon}\nSalary {base.salary}$";
        }
    }

    public class Developer : EmpPerson
    {
        //public double sal;
        public double bon;

        public int WorkExperience;
        public Developer(int WorkExperience, string _conmapanyName, string _employeeName, double _salary) :
            base(_conmapanyName, _employeeName, _salary)
        {
            this.WorkExperience = WorkExperience;
        }

        public override double CalculateBonus()
        {
            bon=salary * 0.15;
            //bon = sal;
            return bon;
        }

        public override String Details()
        {
            return $"Comany Name = {conmpanyName} \nEmployee Name = {employeeName} \nBonus = {bon}\nSalary {base.salary}$ \nWork Experience = {WorkExperience}";
        }
    }

    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Manager ===");
            Manager m = new Manager("IBM", "Sharad", 30000);
            m.CalculateBonus();
            Console.WriteLine(m.Details());

            Console.WriteLine();

            Console.WriteLine("=== Develooper ===");
            Developer d = new Developer(6, "Apple", "FallStyle", 50000);
            d.CalculateBonus();
            Console.WriteLine(d.Details());



        }
    }
}
