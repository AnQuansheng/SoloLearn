using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class RefOut
    {
        static void Method(out int i)
        {
            i = 44;
        }

        static void Main()
        {
            int value;
            Method(out value);
            // value is now 44
        }
        Console.ReadLine();
    }
}
