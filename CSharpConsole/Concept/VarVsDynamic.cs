using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConsole.Concept
{
    internal class VarVsDynamic
    {
        static void Main(string[] args)
        {
            // Datatype is know during the compiled time
            // We can not change the type of var later on string to int
            // It checks the literal type and make the variable that type
            // It is statically type
            var Name = "Sharad";
            //Name = 23; // Invalid

            // Dynamic determines type during the runtime
            // It is dynamically typed
            // We can change type in dynamic string to int
            dynamic NickName = "Fall";
            Console.WriteLine(NickName.GetType());
            NickName = 24;
            Console.WriteLine(NickName.GetType());

        }
    }
}
