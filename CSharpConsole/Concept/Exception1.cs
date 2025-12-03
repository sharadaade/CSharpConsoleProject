namespace CSharpConsole.Concept
{
    internal class Exception1 : Exception
    {
        
        static void Main(string[] args)
        {
            Console.Write("Enter the Number: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Age is {Age}");
        }
    }
}
