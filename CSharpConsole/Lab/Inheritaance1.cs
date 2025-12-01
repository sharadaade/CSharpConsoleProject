namespace CSharpConsole.Lab
{
    public class Person
    {
        public string Name;
        public int Age;

        public Person(string _Name, int _Age)
        {
            this.Name = _Name;
            this.Age = _Age;
        }

        public override string ToString()
        {
            return $"\nName: {this.Name} \nAge: {this.Age}";
        }
    }
    public class Employee : Person
    {
        public int EmpId;
        public string Department;

        public Employee(int _EmpId, string _Department, string Name, int Age)
                        : base(Name, Age)
        {
            this.EmpId = _EmpId;
            this.Department = _Department;
        }

        public override string ToString()
        {
            return $"EmpId: {this.EmpId} \nDepartment: {this.Department} " + base.ToString();
        }
    }

    public class Salary : Employee
    {
        public double BasicSalary;
        public double Bonus;

        public Salary(double _BasicSalary, double _Bonus, int EmpId, string Department, string Name, int Age)
                        : base(EmpId, Department, Name, Age)
        {
            this.BasicSalary = _BasicSalary;
            this.Bonus = _Bonus;
        }

        public override string ToString()
        {
            return base.ToString() + $"\nBasicSalary: {this.BasicSalary} \nBonus: {this.Bonus}";
        }
    }

    internal class Inheritaance1
    {
        static void Main(string[] args)
        {
            Salary s = new Salary(30000, 3000, 101, "IT", "Fall", 25);
            Console.WriteLine(s.ToString());
        }
    }
}
