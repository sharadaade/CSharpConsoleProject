namespace CSharpConsole.Concept
{
    public class MyClass
    {
        public void Method()
        {
            Console.WriteLine("My Method");
        }
    }
    public class Child : MyClass
    {
        public void Method()
        {
            Console.WriteLine("Child Method");
        }
    }
    internal class SealedMethod
    {
        static void Main(string[] args)
        {
            
        }
    }
}
