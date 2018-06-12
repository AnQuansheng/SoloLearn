using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StuyGrammar
{
    class foreachLoop
    {
        int[] a = { 1, 3, 5, 7, 2, 4, 6, 8 };
        void returnValue()
        {
            //var自适应类型
            foreach (var k in a)
            {
                Console.WriteLine(k);
            }
        }
        
        static void Main(string[] args)
        {
            foreachLoop p = new foreachLoop();
            p.returnValue();
            Console.ReadLine();
        }
    }
}
