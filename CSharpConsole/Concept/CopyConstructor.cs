namespace CSharpConsole.Concept
{

    // Copy Constructor
    public class Employee
    {
        public int Id;
        public string Name;
        public string Address;

        public Employee(int Id, string Name, string Address)
        {
            this.Id = Id;
            this.Name = Name;
            this.Address = Address;
        }

        public override string ToString()
        {
            return $"Id: {Id} \nName: {Name} \nAddress: {Address}";
        }

        public Employee(Employee e)
        {
            Id = e.Id;
            Name = e.Name;
            Address = e.Address;
        }
    }
    internal class CopyConstructor
    {
        static void Main(string[] args)
        {
            Employee e = new Employee(111, "Fall", "White City");
            Console.WriteLine(e.ToString());

            Console.WriteLine();

            Employee cp = new Employee(e);
            cp.Name = "Style";
            Console.WriteLine(cp.ToString());
        }
    }
}
