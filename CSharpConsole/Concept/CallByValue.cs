namespace CSharpConsole.Concept
{
    internal class CallByValue
    {
        public static void CallByVal(int a)
        {
            a = a + 10;
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            int x = 5;
            CallByVal(x);
            Console.WriteLine(x);
        }
    }
}
