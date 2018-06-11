using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class recursion
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Fun(6));
        }

        static int Fun(int num)
        {
            if(num == 1)
            {
                return 1;
            }
            return num * Fun(num - 1);
        }
    }
}
