namespace CSharpConsole.CodeWin
{
    internal class EvenGoto
    {
        static void Main(string[] args)
        {
            int n = 20;
            int i = 1;
        start:
            if(i%2==0)
            {
                Console.WriteLine(i);
            }
            i++;

            if (i <= n)
            {
                goto start;
            }
        }
    }
}
