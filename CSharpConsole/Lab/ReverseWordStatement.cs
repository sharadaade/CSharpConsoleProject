namespace CSharpConsole.Lab
{
    internal class ReverseWordStatement
    {
        static void Main(string[] args)
        {
            string input = "Hello World from C#";
            string result = "";
            string currentWord = "";

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch != ' ')
                {
                    // Reverse by prepending
                    currentWord = ch + currentWord;
                }
                else
                {
                    // Add reversed word to result
                    result += currentWord + " ";
                    currentWord = "";
                }
            }

            // Add last reversed word
            result += currentWord;

        }
    }
}
